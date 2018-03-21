using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace WebServiceSample
{
   public enum TemperatureType
   {
      Fahrenheit,
      Celsius
   }

   public enum TemparatureCondition
   {
      Rainy,
      Sunny,
      Cloudy,
      Thunderstorm
   }

   public class GetWeatherRequest
   {
      public string City;
      public TemperatureType TemperatureType;
   }

   public class GetWeatherResponse
   {
      public TemparatureCondition Condition;
      public int Temperature;
   }


   /// <summary>
   /// Summary description for Service1
   /// </summary>
   [WebService(Namespace = "http://www.wrox.com/webservices")]
   [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
   [ToolboxItem(false)]
   // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
   // [System.Web.Script.Services.ScriptService]
   public class Service1 : System.Web.Services.WebService
   {
      [WebMethod]
      public string ReverseString(string message)
      {
         char[] arr = message.ToCharArray();
         Array.Reverse(arr);
         message = new string(arr);

         return message;
      }


      [WebMethod]
      public GetWeatherResponse GetWeather(GetWeatherRequest req)
      {
         GetWeatherResponse resp = new GetWeatherResponse();
         Random r = new Random();
         int celsius = r.Next(-20, 50);

         if (req.TemperatureType == TemperatureType.Celsius)
            resp.Temperature = celsius;
         else
            resp.Temperature = (212 - 32) / 100 * celsius + 32;

         if (req.City == "Redmond")
            resp.Condition = TemparatureCondition.Rainy;
         else
            resp.Condition = (TemparatureCondition)r.Next(0, 3);

         return resp;
      }

   }


}
