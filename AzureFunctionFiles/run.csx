#r "Newtonsoft.Json"
#r "SendGrid"
#r "System.Net.Http" 

using System;
using SendGrid;
using SendGrid.Helpers.Mail;
using Newtonsoft.Json;
using System.Text;

public static SendGridMessage Run(TimerInfo myTimer, ILogger log)
{
    log.LogInformation($" Email generated via azure functions");

    // Creating new email message
    SendGridMessage message = new SendGridMessage();

    // getting the weather for today in Utrecht
    string url = "https://goweather.herokuapp.com/weather/Utrecht";
    var client = new HttpClient();
    var response = client.GetAsync(url).Result;

    // formatting of the response
    var json = response.Content.ReadAsStringAsync().Result;
    dynamic responseData = JsonConvert.DeserializeObject(json);

    // Adding the weather to the email message
    message.AddContent("text/plain", $"{responseData}");
    return message;
}
