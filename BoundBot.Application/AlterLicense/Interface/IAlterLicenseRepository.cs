﻿using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundBot.Application.AlterLicense.Interface
{
    public interface IAlterLicenseRepository
    {
        Task AlterLicense(SocketSlashCommand command, HttpClient client);
    }
}
