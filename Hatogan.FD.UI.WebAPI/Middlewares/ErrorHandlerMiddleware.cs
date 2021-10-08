using FluentValidation;
using Hatogan.AB.UseCases.Common.Exceptions;
using Hatogan.EB.Domain.Exceptions;
using Hatogan.EB.Domain.Wrappers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hatogan.FD.UI.WebAPI.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                if(error.InnerException != null)
                {
                    throw new GeneralException(error.Message, error.InnerException);
                }

                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new Response<string> { Successful = false, Message = error.Message };

                switch (error)
                {
                    case GeneralException:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    case ApiValidationException e:
                        response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                        responseModel.Errors = e.Errors;
                        break;
                    case KeyNotFoundException:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var result = JsonSerializer.Serialize(responseModel);

                await response.WriteAsync(result);
            }
        }
    }
}
