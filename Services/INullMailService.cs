﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllInOne.Services
{
    public interface INullMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}
