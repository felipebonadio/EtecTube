using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EtecTube.Models;

namespace EtecTube.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Channel canal1 = new Channel(){
                Id = new Guid(),
                Name = "Ds Mucho Loko",
                ChannelPicture = "~/img/avatar.png"
            };            
            Video video1 = new Video(){
                Id = new Guid(),
                Channel = canal1,
                Name = "Carnaval na Etec",
                Description = "Estamos todos querendo ir embora, estou com fome",
                PublishedDate = DateTime.Parse("25/02/2021"),
                Thumbnail = "~/img/video.jpg"
            };
            return View(video1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
