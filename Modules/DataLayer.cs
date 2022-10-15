using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maqs.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;
using MailKit.Net.Smtp;
using MudBlazor;


namespace Maqs.Modules
{
    public class DataLayer
    {



     

        public void SendContactEmail(EmailModel item)
        {
            try
            {

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(item.MaqsEmail));
                email.To.Add(MailboxAddress.Parse(item.MaqsEmail));
                email.Subject = "MAD Nature Request";
                email.Body = new TextPart(TextFormat.Html) { Text = item.Comments + $"\n\nUsers Email: {item.EmailAddress}"};

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.mail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate(item.MaqsEmail, "qGhS382tBqGmgrJaGD");
                smtp.Send(email);
                smtp.Disconnect(true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void SendCustomOrderEmail(CustomOrderModel item)
        {
            try
            {
                EmailModel emailModel = new();
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(emailModel.MaqsEmail));
                email.To.Add(MailboxAddress.Parse(emailModel.MaqsEmail));
                email.Subject = "MAD Nature Request";
                email.Body = new TextPart(TextFormat.Html) { Text = $"\n\nFirst name: {item.FirstName}\nLast name: {item.LastName}\nPhone Number: {item.PhoneNumber}\nAddress: {item.Address}\nCity: {item.City}\nState: {item.State}\nCountry: {item.Country}\nZip: {item.Zip}\nEmail: {item.EmailAddress}\nJewelry: {item.JewelryType}\nOrder Request: {item.OrderRequest}" };
                 

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.mail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate(emailModel.MaqsEmail, "qGhS382tBqGmgrJaGD");
                smtp.Send(email);
                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //public static string GetRecipients(string emailAddress, MailAddressCollection mailAddress)
        //{
        //mailAddress.Add(new MailAddress(emailAddress));
        //return emailAddress;
        //}




    }
}
