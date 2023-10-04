#r "Newtonsoft.Json"
#r "SendGrid"

using System;
using SendGrid;
using SendGrid.Helpers.Mail;

public static SendGridMessage Run(TimerInfo myTimer, ILogger log)
{
    Guid Id = Guid.NewGuid();
    log.LogInformation($" Email generated via azure functions met Id: {Id}");
    SendGridMessage message = new SendGridMessage();
    message.AddContent("text/plain", $"Test");
    return message;
}

// option 2
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
    Guid Id = Guid.NewGuid();
    log.LogInformation($" Email generated via azure functions met Id: {Id}");
    SendGridMessage message = new SendGridMessage(){
        Subject = $" Weather email with Id {Id}"
    };

    string url = "https://dogapi.dog/api/facts?name=5";
    var client = new HttpClient();
    var response = client.GetAsync(url).Result;

    var json = response.Content.ReadAsStringAsync().Result;
    dynamic responseData = JsonConvert.DeserializeObject(json);

    message.AddContent("text/plain", $"{responseData}");
    return message;
}
