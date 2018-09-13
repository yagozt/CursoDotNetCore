using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MiddlewareArticle.MiddleWare
{
    public class ResponseTime
    {
        RequestDelegate _next;

        public ResponseTime(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var sw = new Stopwatch();
            sw.Start();
            
            await _next(context);

            var isHtml = context.Response.ContentType?.ToLower().Contains("text/html");

            if(context.Response.StatusCode == 200 && isHtml.GetValueOrDefault())
            {
                var body = context.Response.Body;

                using (var streamWriter = new StreamWriter(body))
                {
                    var textHtml = string.Format(
                    "<footer><div id='process'>Response Time {0} milliseconds.</div>",
                    sw.ElapsedMilliseconds
                    );
                    streamWriter.Write(textHtml);
                }
            }
        }
    }
}