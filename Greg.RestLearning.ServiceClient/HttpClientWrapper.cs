using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net.Http;

using System.Net.Http.Formatting;
using System.Xml.Serialization;
using Greg.RestLearning.Common;


namespace Greg.RestLearning.ServiceClient
{
    public class HttpClientWrapper
    {
        public void ReadText()
        {
            HttpClientHandler handler = new HttpClientHandler();


            HttpClient client = new HttpClient();

            var respContent = client.GetAsync("http://localhost/Greg.RestLearning.Service/RestFeedService1.svc/aaa/text").Result.Content;

            var task = client.GetAsync("http://localhost/Greg.RestLearning.Service/RestFeedService1.svc/aaa/text");

            // Asynchroniczne otrzymanie responsa
            task.ContinueWith(task1 =>
                {
                    
                    HttpResponseMessage response = task1.Result;

                    //sprawdzenie statusu zwrotnego otrzymanego w responsie...
                    response.EnsureSuccessStatusCode();


                    //odczytanie zawartosci odpowiedzi synchronicznie
                    var syncContent = response.Content.ReadAsStringAsync().Result;

                    var asyncContent = response.Content.ReadAsStringAsync();

                    Console.WriteLine(asyncContent.Result);
                });

            Console.WriteLine("Hit ENTER to exit...");

            Console.Read();

        }

        public void ReadUser()
        {
            HttpClientHandler handler = new HttpClientHandler();


            HttpClient client = new HttpClient();

            var task = client.GetAsync("http://localhost/Greg.RestLearning.Service/RestFeedService1.svc/aaa/user");

            // Asynchroniczne otrzymanie responsa
            task.ContinueWith(task1 =>
            {

                HttpResponseMessage response = task1.Result;

                //sprawdzenie statusu zwrotnego otrzymanego w responsie...
                response.EnsureSuccessStatusCode();


                //odczytanie zawartosci odpowiedzi synchronicznie
                try
                {

                    var stream = response.Content.ReadAsStreamAsync().Result;

                    XmlSerializer abc = new XmlSerializer(typeof(User));

                    var obj = abc.Deserialize(stream);

                    var user = obj as User;

                    var uuu = response.Content.ReadAsAsync<User>();
;

                    var syncContent = response.Content.ReadAsAsync<User>().ContinueWith(task2 =>
                        {
                            var xxx = task2.Result;
                        });
                    Console.WriteLine(syncContent);
                }
                catch (Exception exception)
                {
                    int a = 100;
                }
                

                
            });

            Console.WriteLine("Hit ENTER to exit...");

            Console.Read();
        }
    }
}
