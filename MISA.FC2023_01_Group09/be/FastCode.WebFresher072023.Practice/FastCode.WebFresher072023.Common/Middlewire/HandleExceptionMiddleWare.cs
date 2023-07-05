using FastCode.WebFresher072023.Common.MISAException;
using FastCode.WebFresher072023.Common.Resources;
using Microsoft.AspNetCore.Http;
using MISA.QLTS.DEMO.Web04.PXTRUONG.Comon.MISAException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.Common.Middlewire
{
    public class HandleExceptionMiddleWare
    {
        private readonly RequestDelegate _next;




        public HandleExceptionMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {

            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await this.HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            if (exception is NotFoundException)
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync(
                    text: new BaseException()
                    {
                        ErroCode = ((NotFoundException)exception).ErrorCode,
                        UserMessage = "Không tìm thấy",
                        DevMessage = exception.Message,
                        TraceId = context.TraceIdentifier,
                        MoreInfo = exception.HelpLink

                    }.ToString() ?? ""

                 );
            }
            else if (exception is DuplicateException)
            {
                context.Response.StatusCode = StatusCodes.Status409Conflict;
                await context.Response.WriteAsync(
                    text: new BaseException()
                    {
                        ErroCode = ((DuplicateException)exception).ErrorCode,
                        UserMessage = ((DuplicateException)exception).DataInValue,
                        DevMessage = exception.Message,
                        TraceId = context.TraceIdentifier,
                        MoreInfo = exception.HelpLink

                    }.ToString() ?? ""

                 );
            }
            else if (exception is ValidateException)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync(
                    text: new BaseException()
                    {
                        ErroCode = ((ValidateException)exception).ErrorCode,
                        UserMessage = ((ValidateException)exception).DataInValue,
                        DevMessage = exception.Message,
                        TraceId = context.TraceIdentifier,
                        MoreInfo = exception.HelpLink

                    }.ToString() ?? ""

                 );
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync(
                    text: new BaseException()
                    {
                        ErroCode = context.Response.StatusCode,
                        UserMessage = "Lỗi hệ thống",
                        DevMessage = exception.Message,
                        TraceId = context.TraceIdentifier,
                        MoreInfo = exception.HelpLink

                    }.ToString() ?? ""

                 );
            }

        }

    }

}
