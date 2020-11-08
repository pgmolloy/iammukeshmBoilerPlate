﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreHero.Application.DTOs.Mail
{
    public class MailRequest
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
    }
}
