using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;
using Newtonsoft.Json;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovies=new List<ApiMovieViewModel>();    
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                   { "X-RapidAPI-Key", "85ac5bf4b0msh66d6d2cda60cd98p155845jsn5c2ced510ca5" },
                   { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovies=JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);   
                return View(apiMovies);

            }
        }
    }
}
