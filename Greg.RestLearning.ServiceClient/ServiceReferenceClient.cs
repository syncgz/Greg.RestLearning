using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net.Http;


namespace Greg.RestLearning.ServiceClient
{
    public class ServiceReferenceClient
    {
        public void Foo()
        {
            HttpClientHandler handler = new HttpClientHandler();


            HttpClient client = new HttpClient();

            var task = client.GetAsync("http://localhost/Greg.RestLearning.Service/RestFeedService1.svc/aaa/test").Result.Content;

            int a = 100;

            /*Debug.Assert(task != null, "task != null");

            task.ContinueWith(task1 =>
                {
                    // Get HTTP response from completed task.
                    HttpResponseMessage response = task1.Result;

                    var content = response.Content.ReadAsStringAsync();

                    Console.WriteLine(content.Result);
                });

            Console.WriteLine("Hit ENTER to exit...");

            Console.Read();*/

        }
    }
}
