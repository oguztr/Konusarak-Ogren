using CsvHelper;
using HtmlAgilityPack;
using KonusarakOgren.Application.Interfaces;
using KonusarakOgren.Application.Models.Responses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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


        public async Task<List<Article>> GetWiredArticles()
        {
            List<Article> articles = new List<Article>();
            var url = "https://www.wired.com";
            string recents = url + "/most-recent";

            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(recents);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//ul[@class='archive-list-component__items']//li");

            for (int i = 0; i < 5; i++)
            {
                var node = nodes[i];
                var title = htmlDoc.DocumentNode.SelectNodes("//h2[@class='archive-item-component__title']")[i].InnerText;

                var link = node.SelectSingleNode("a").Attributes["href"].Value;

                string articleLink = url + link;
                string content = GetArticle(articleLink);

                articles.Add(new Article { Content = content, Title = title });
            }
            return articles;
        }

        public static string GetArticle(string url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='body__inner-container']");
            var article = nodes[0].InnerHtml;
            return article;
        }
    }
}
