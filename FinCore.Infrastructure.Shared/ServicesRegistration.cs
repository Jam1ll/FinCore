﻿using FinCore.Infrastructure.Shared.Services;
using FinCore.Core.Application.Interfaces;
using FinCore.Core.Domain.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinCore.Infrastructure.Shared
{
    public static class ServicesRegistration
    {
        //Extension method - Decorator pattern
        public static void AddSharedLayerIoc(this IServiceCollection services, IConfiguration config)
        {
            #region Configurations
            services.Configure<MailSettings>(config.GetSection("MailSettings"));
            #endregion

            #region Services IOC
            services.AddScoped<IEmailService, EmailService>();
            #endregion
        }
    }
}