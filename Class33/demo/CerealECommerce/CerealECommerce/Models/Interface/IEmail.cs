using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Models.Interface
{
    interface IEmail
    {
        // SMTP
        // Simple Mail Transfer Protocol

        Task SendEmail(string email, string subject);
    }
}
