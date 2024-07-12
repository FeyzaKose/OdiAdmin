﻿using Microsoft.AspNetCore.Identity;
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Services.CVAyarlari.FizikselOzellikler;
using OdiAdmin.Services.Identity;
using OdiAdmin.Services.KullaniciServices;
using OdiAdmin.Services.OdiUsers;
using OdiAdmin.Services.UygulamaAyarlari;

namespace OdiAdmin.Services
{
    public static class OdiServices
	{
		public static void AddOdiServices(this IServiceCollection services, IConfiguration Configuration)
		{
			var serviceApiSettings = Configuration.GetSection("ServiceApiSettings").Get<ServiceApiSettings>();
			//services.AddHttpClient<IClientCredentialTokenService, ClientCredentialTokenService>();

			services.AddHttpClient<IIdentityService, IdentityService>();
           
			services.AddHttpClient<IOdiUserService, OdiUserService>(opt =>
			{
				opt.BaseAddress = new Uri(serviceApiSettings.GatewayBaseUri);
			}).AddHttpMessageHandler<ResourceOwnerPasswordTokenHandler>();

            services.AddHttpClient<IKullaniciService, KullaniciService>(opt =>
            {
                opt.BaseAddress = new Uri(serviceApiSettings.GatewayBaseUri);
            }).AddHttpMessageHandler<ResourceOwnerPasswordTokenHandler>();

            services.AddHttpClient<IFizikselOzellikService, FizikselOzellikService>(opt =>
            {
                opt.BaseAddress = new Uri(serviceApiSettings.GatewayBaseUri);
            }).AddHttpMessageHandler<ResourceOwnerPasswordTokenHandler>();

            services.AddHttpClient<IDilService, DilService>(opt =>
			{
				opt.BaseAddress = new Uri(serviceApiSettings.GatewayBaseUri);
			}).AddHttpMessageHandler<ResourceOwnerPasswordTokenHandler>();
		}
	}
}
