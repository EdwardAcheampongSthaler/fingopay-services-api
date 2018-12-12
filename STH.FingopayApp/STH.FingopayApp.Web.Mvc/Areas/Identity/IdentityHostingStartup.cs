﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using STH.FingopayApp.Web.Mvc.Data;

[assembly: HostingStartup(typeof(STH.FingopayApp.Web.Mvc.Areas.Identity.IdentityHostingStartup))]
namespace STH.FingopayApp.Web.Mvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}