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
