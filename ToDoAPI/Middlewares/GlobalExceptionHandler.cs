﻿using Core.Responses;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;
using Core.Exceptions;


namespace ToDoAPI.Middlewares
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            ReturnModel<List<string>> Errors = new();

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = 500;

            if (exception.GetType() == typeof(NotFoundExceptions))
            {
                httpContext.Response.StatusCode = 404;
                Errors.Success = false;
                Errors.Message = exception.Message;
                Errors.StatusCode = 404;
                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(Errors));

                return true;
            }

            if (exception.GetType() == typeof(BusinessExceptions))
            {
                httpContext.Response.StatusCode = 400;
                Errors.Success = false;
                Errors.Message = exception.Message;
                Errors.StatusCode = 400;
                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(Errors));

                return true;
            }

            Errors.StatusCode = 500;
            Errors.Message = exception.Message;
            Errors.Success = false;
            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(Errors));
            return true;
        }
    }
}
