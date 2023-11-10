using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
//using NewsAPI.Models.Requests;

namespace ENTJAVA_Week3.Services
{
    public class NewsService
    {
        private readonly NewsApiClient newsApiClient;

        public NewsService(string apiKey)
        {
            newsApiClient = new NewsApiClient(apiKey);
        }

        public async Task<List<Article>> GetLatestNewsAsync()
        {
            var articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
            {
                Q = "",
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                From = new DateTime(2023, 11, 1)
            });

            return articlesResponse.Status == Statuses.Ok ? articlesResponse.Articles : new List<Article>();
        }
    }
}
