using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace exercise.main
{
    class TwilioText
    {

        private string accountSid = "";
        private string authToken = "";
        private string twilioNumber = "+18159494221";
        private string myNumber = "+1234567890";

        public async Task SendOrder()
        {
            var messageContent = "Yello";

            TwilioClient.Init(accountSid, authToken);

           var message = await MessageResource.CreateAsync(
               body: messageContent,
               from: new Twilio.Types.PhoneNumber(twilioNumber),
               to: new Twilio.Types.PhoneNumber(myNumber));

            Console.WriteLine(message.Body);
        }
    }
}
