﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greg.RestLearning.ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClientWrapper client = new HttpClientWrapper();

            //client.ReadText();

            client.ReadUser();
        }
    }
}
