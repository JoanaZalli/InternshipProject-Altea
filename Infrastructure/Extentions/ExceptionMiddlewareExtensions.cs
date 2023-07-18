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

public class ExceptionMiddlewareExtensions
{
    private readonly RequestDelegate _next;

    public ExceptionMiddlewareExtensions(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        HttpStatusCode statusCode;
        List<string> errorMessages = new List<string>();

        if (exception is CustomException customException)
        {
            statusCode = customException.StatusCode;
            errorMessages = customException.ErrorMessages ?? errorMessages;
            //mos harro te shtosh kontrollin per fluent validation
        }
        else if (exception is UserRegisterFluentValidationException fluentValidationException)
        {
            statusCode = HttpStatusCode.BadRequest;
            errorMessages.Add(fluentValidationException.Message);
        }

        else
        {
            statusCode = HttpStatusCode.InternalServerError;
            errorMessages.Add("An error occurred while processing your request.");
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
