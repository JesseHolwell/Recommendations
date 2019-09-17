using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendations
{
    //GET /api/models HTTP/1.1
    //Host: rcorleoboinwe2ows.azurewebsites.net
    //x-api-key: MnZmdTd1azNqeWEyNg==
    //Cache-Control: no-cache
    //Postman-Token: 2651736b-97bf-4757-92bb-eab8137655b4
       
    //POST /api/models HTTP/1.1
    //Host: rcorleoboinwe2ows.azurewebsites.net
    //x-api-key: MnZmdTd1azNqeWEyNg==
    //Content-Type: application/x-www-form-urlencoded
    //Cache-Control: no-cache
    //Postman-Token: b060c52e-ed05-5359-1b25-aac62c35685d

    //GET /api/models/13b73042-0df3-48fe-8d93-032ada44de80 HTTP/1.1
    //Host: rcorleoboinwe2ows.azurewebsites.net
    //Cache-Control: no-cache
    //Postman-Token: e345d0fc-5d36-ce0c-a3e2-c40b2be46ef2

    //GET /api/models/13b73042-0df3-48fe-8d93-032ada44de80/recommend? itemId = 2005018 HTTP/1.1
    //Host: rcorleoboinwe2ows.azurewebsites.net
    //x-api-key: MnZmdTd1azNqeWEyNg==
    //itemId: 85526
    //Cache-Control: no-cache
    //Postman-Token: ec8175ff-9732-ee66-bfb7-60162926b092


    //Headers:

    public class Recommendations
    {
        private static string ApiKey = "MnZmdTd1azNqeWEyNg==";
        private static string ApiHeader { get { return $"\"key\":\"x-api-key\",\"value\":{ApiKey}\""; } }

        private string ApiHeader2 = $"\"key\":\"x-api-key\",\"value\":{ApiKey}\"";
        private static string OtherHeader = "{\"key\":\"Content-Type\",\"value\":\"application/json\",\"description\":\"}";

        private string EndPoint = "https://rcorleoboinwe2ows.azurewebsites.net/api/models";



        public void AddToCatalog()
        { }

        public void AddToUsage()
        {

        }

        public void GetCatalog()
        {

        }

        public void GetUsage()
        {

        }

        public void InputData()
        {

        }

        public void GetModels()
        {
            //HttpRequest request = new HttpRequest();
            //request.Host = 

        }

        public void TrainModel()
        {

        }

        public Recommendation GetRecommendation(string userId)
        {

        }
    }
}

public class Catalog
{
    public string UserId;
    public string ItemId;
    public string Time;
    public string EventType;
    public string CustomEventWeight;
}

public class Usage
{
    public string Id;
    public string stringName;
    public string Category;
    public string Description;
    public List<string> FeaturesList = new List<string>();
}

public class Recommendation
{
    public Recommendation()
    {



    }

    private static string ModelId { get; set; } //"13b73042-0df3-48fe-8d93-032ada44de80/";

    public static int UserId { get; set; } //2005018

    private string EndPoint = $"https://rcorleoboinwe2ows.azurewebsites.net/api/models/{ModelId}recommend?itemId={UserId}";

    public class Response
    {
        public string RecommendedItemId { get; set; }

        public float Score { get; set; }
    }
}


//https://rcorleoboinwe2ows.azurewebsites.net/api/models
class Response
{
    public Response()
    {

    }

    public string Id { get; set; }
    public string Description { get; set; }
    public string CreationTime { get; set; }
    public string ModelStatus { get; set; }

    //parameters
    public string BlobContainerName { get; set; }
    public string CatalogFileRelativePath { get; set; }
    public string UsageRelativePath { get; set; }
    public string EvaluationUsageRelativePath { get; set; }

    public int SupportThreshold { get; set; }
    public string CooccurrenceUnit { get; set; }
    public string SimilarityFunction { get; set; }
    public bool EnableColdItemPlacement { get; set; }
    public bool EnableColdToColdRecommendations { get; set; }
    public bool EnableUserAffinity { get; set; }
    public bool EnableUserToItemRecommendations { get; set; }
    public bool AllowSeedItemsInRecommendations { get; set; }
    public bool EnableBackfilling { get; set; }
    public int DecayPeriodInDays { get; set; }

}