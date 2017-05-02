using Amazon;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingAMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AmazonLambdaClient client = new AmazonLambdaClient("key", "key", RegionEndpoint.USWest1);          

            InvokeRequest ir = new InvokeRequest
            {
                FunctionName = "MyHelloWorld",
                InvocationType = InvocationType.RequestResponse,
                Payload = "\"Ramesh\""
            };

            InvokeResponse response = client.Invoke(ir);

            var sr = new StreamReader(response.Payload);
            JsonReader reader = new JsonTextReader(sr);

            var serilizer = new JsonSerializer();
            var op = serilizer.Deserialize(reader);

            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}
