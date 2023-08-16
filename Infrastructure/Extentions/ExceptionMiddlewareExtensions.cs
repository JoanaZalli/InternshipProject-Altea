using Application.Contracts;
using Application.Exceptions;
using Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Domain.Entities;
using Application.Exceptions;
using Microsoft.Extensions.Localization;
using Domain;
using Application.Resources;
using Application.Models;

namespace Infrastructure.Extentions {
    public class ExceptionMiddlewareExtensions
    {
        private readonly RequestDelegate _next;
        private readonly IStringLocalizer<LocalizationResource> _localizer;

        public ExceptionMiddlewareExtensions(RequestDelegate next, IStringLocalizer<LocalizationResource> localizer)
        {
            _next = next;
            _localizer = localizer;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, _localizer);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, IStringLocalizer localizer)
        {

            HttpStatusCode statusCode;
            List<LocalizedString> errorMessages = new List<LocalizedString>();

           if (exception is FluentValidationException fluentValidationException)
            {
                statusCode = HttpStatusCode.BadRequest;
                foreach (var errorMessage in fluentValidationException.ErrorMessages)
                {
                    errorMessages.Add(localizer[errorMessage]);
                }
            }
            else if (exception is EmailInUseException emailInUseException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.Unique_Email, emailInUseException.Email]);
            }
            else if (exception is UserNameInUseException userNameInUseException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.Unique_Username, userNameInUseException.UserName]);
            }else if (exception is UserNotFoundException userNotFoundException)
            {
                statusCode= HttpStatusCode.NotFound;
                errorMessages.Add(localizer[ValidationResource.UserNotFound]);
            } else if (exception is TokenExpiredException tokenExpiredException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.TokenExpired]);
            } 
            else if (exception is EmailAlreadyConfirmedExcepion emailAlreadyConfirmedExcepion)
            {
                statusCode=HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.EmailConfirmed]);
            }
            else if (exception is EmailNotConfirmedException emailNotConfirmedException)
            {
                statusCode=HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.EmailNotConfirmed]);
            } else if (exception is AuthenticationFailedException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.AuthenticationFailed]);
            } else if(exception is PasswordsDoNotMatchException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.PasswordsDoNotMatch]);
            }else if (exception is AccountBlockedException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.AccountBlocked]);
            } else if(exception is RoleExistsException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.RoleExists]);
            } else if(exception is RoleWasNotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                errorMessages.Add(localizer[ValidationResource.RoleWasNotFound]);
            }
            else if (exception is PermissionToRoleAssignedException) {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.RolePermission]);
            }
            else if (exception is DuplicateFiscalCodeException)
            {
                statusCode= HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.FiscalCodeUnique]);
            }else if (exception is BorrowerNotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                errorMessages.Add(localizer[ValidationResource.BorrowerNotFound]);
            } else if(exception is ApplicationNotCreatedException )
            {

                statusCode = HttpStatusCode.NotFound;
                errorMessages.Add(localizer[ValidationResource.ApplicationCanNotBeCreated]);
            }
           else if(exception is ApplicationNotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                errorMessages.Add(localizer[ValidationResource.ApplicationNotFound]);
            }
           else if(exception is ProductCanNotBeChangedException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.ProductNotChanged]);
            }
            else if (exception is CombinationExistsException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.CombinationExists]);
            }
            else if (exception is NoEligibleLenderException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[ValidationResource.NoLender]);
            }else if (exception is LoanNotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                errorMessages.Add(localizer[ValidationResource.LoanNotFound]);
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
                errorMessages.Add(localizer["An error occurred while processing your request."]);
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var errorDetails = new ErrorDetails
            {
                StatusCode = (int)statusCode,
                Message = errorMessages
            };



            string errorJson = JsonSerializer.Serialize(errorDetails);
            return context.Response.WriteAsync(errorJson);
        }
    }
}
