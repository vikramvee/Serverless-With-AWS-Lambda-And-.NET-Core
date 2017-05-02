using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace HelloLambda
{
    public class Function
    {  
        public string HelloWorld(string input, ILambdaContext context)
        {
            context.Logger.Log("Execution Start");
            return string.Format("Hello {0} to Lambda World", input);          
        }
    }
}
