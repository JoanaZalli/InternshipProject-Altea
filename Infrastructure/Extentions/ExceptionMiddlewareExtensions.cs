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

            if (exception is CustomException customException)
            {
                statusCode = customException.StatusCode;
                errorMessages = customException.ErrorMessages ?? errorMessages;
            }
            else if (exception is UserRegisterFluentValidationException fluentValidationException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorMessages.Add(localizer[fluentValidationException.Message]);
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
