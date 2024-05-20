using Newtonsoft.Json;
using OdiAdmin.Extensions;
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Pages.UygulamaAyarlari.Diller;
using OdiAdmin.Tools;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OdiAdmin.Services.UygulamaAyarlari
{
    public class DilService : IDilService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DilService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
        }

       
        public async Task<ApiResponse<List<Dil>>> DilListesiAsyc()
        {
            return await _client.GetFromJsonAsync<ApiResponse<List<Dil>>>(Endpoints.UygulamaBilgileri.Dil.DilListesi);
        }

        public async Task<List<Dil>> SessionDilListesiAsyc()
        {
            List<Dil> languageList = new List<Dil>();

            try
            {
                var languageListJson = _httpContextAccessor.HttpContext.Session.GetString("LanguageList");
                if (!string.IsNullOrEmpty(languageListJson))
                {
                    try
                    {
                        languageList = JsonConvert.DeserializeObject<List<Dil>>(languageListJson);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
                else
                {
                    ApiResponse<List<Dil>> resp = await _client.GetFromJsonAsync<ApiResponse<List<Dil>>>(Endpoints.UygulamaBilgileri.Dil.DilListesi);

                    _httpContextAccessor.HttpContext.Session.SetObject("LanguageList",resp.Data);
                    if (resp.IsSuccessful)
                    {
                        languageList = resp.Data;
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return languageList;
            
        }

        public bool CheckSessionDilListesi()
        {
            var languageListJson = _httpContextAccessor.HttpContext.Session.GetString("LanguageList");
            return string.IsNullOrEmpty(languageListJson) ? true : false;
        }
    }
}
