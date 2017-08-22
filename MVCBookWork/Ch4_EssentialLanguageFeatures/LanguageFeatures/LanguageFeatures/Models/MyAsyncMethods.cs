using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpTask = client.GetAsync("http://apress.com");

            // other things could be done here while waiting for the HTTP request to complete

            return httpTask.ContinueWith((Task<HttpResponseMessage> antecdent) =>
            {
                return antecdent.Result.Content.Headers.ContentLength;
            });
        }

        public async static Task<long?> GetPageLengthTwo()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://apress.com");

            return httpMessage.Content.Headers.ContentLength;
        }

            /* .NET Represents work that will be done asynchronously as a "Task" 
             * 
             * 
             * 
             * 
             * 
             * 
             */
        


    }
}