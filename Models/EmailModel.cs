using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maqs.Models
{
    public class EmailModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Comments { get; set; }
        public string EmailSubject { get; set; }


        public string MaqsEmail { get; set; } = "anna.nader33@ethereal.email";
    }


}
