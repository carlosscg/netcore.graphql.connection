using GraphQL;
using GraphQL.Types;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AppSyncConnect
{
   class Program
   {
      static void Main(string[] args)
      {

         //var xclient = new HttpClientHandler();
         //xclient.Properties.Add("x-api-key", "da2-bm2qqpx5ljhyhdqhv6nzsps7eu");

         //xclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("x-api-key", "da2-bm2qqpx5ljhyhdqhv6nzsps7eu");


         var client = new GraphQL.Client.GraphQLClient(new GraphQL.Client.GraphQLClientOptions()
         {
            EndPoint = new Uri("https://fo77ruxnqrh5tkml5oivdm4tvm.appsync-api.us-east-1.amazonaws.com/graphql"),
         });

         client.DefaultRequestHeaders.Add("x-api-key", "da2-bm2qqpx5ljhyhdqhv6nzsps7eu");

         var response = client.GetQueryAsync("{\"query\" : \" { allCruisesQuote { provider} }\"}").Result;
         Console.WriteLine(response);


      }
   }
}
