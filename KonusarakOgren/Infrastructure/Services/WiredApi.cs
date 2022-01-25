﻿using KonusarakOgren.Application.Interfaces;
using KonusarakOgren.Application.Models.Responses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Proxies
{
    public class WiredApi : IWiredApiProxy
    {
        public readonly HttpClient _httpClient;
        public readonly IConfiguration _configuration;

        public WiredApi(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<WiredApiResponse> GetWiredArticles()
        {
            var newsApiKey = _configuration["NewsApiKey"];
            var uri = $"/v2/top-headlines?sources=wired&apiKey={newsApiKey}";
            var restResponse = await _httpClient.GetAsync(uri);

            if(restResponse.StatusCode == HttpStatusCode.OK)
            {
                var content = await restResponse.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<WiredApiResponse>(content);

                return response;
            }

            var errorMessage = $"{nameof(WiredApi)} {nameof(GetWiredArticles)} throws exception status code: {restResponse.StatusCode} error: {restResponse.Content}";
            throw new Exception(errorMessage);
        }
    }
}