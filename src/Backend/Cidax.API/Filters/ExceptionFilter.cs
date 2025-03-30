using Microsoft.AspNetCore.Mvc.Filters;
using Cidax.Exceptions.ExceptionsBase;
using System.Net;
using Cidax.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using Cidax.Exceptions;

namespace Cidax.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is CidaxException)
                HandleProjectException(context);
            else 
            {
                ThrowUnksnowException(context);
            }
        }
        private void HandleProjectException(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException)
            {
                var exception = context.Exception as ErrorOnValidationException;
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new BadRequestObjectResult(new ResponseErrorJson(exception.ErrorsMessages));
            }
        }
        private void ThrowUnksnowException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorJson(ResourceMessagesException.UNKNOWN_ERROR));
        }
    }
}
