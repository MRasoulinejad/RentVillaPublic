﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVilla.Application.Services.Interface
{
    public  interface ISmtpEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
