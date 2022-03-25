using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GalloTube.Models;
using GalloTube.Data;
using Microsoft.EntityFrameworkCore;

namespace GalloTube.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto _contexto;

        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var videos = _contexto.Videos.Include(v => v.Channel).ToList();
            return View(videos);
        }

        public IActionResult Watch(Guid Id)
        {
            var video = _contexto.Videos.Where(v => v.Id == Id).Include(v => v.Channel).Include(v => v.VideoComments).ThenInclude(u => u.User).SingleOrDefault();
            return View(video);
        }

        public IActionResult Channel(Guid Id)
        {
            var channel = _contexto.Channels.Where(c => c.Id == Id).Include(c => c.User).Include(c => c.Videos).SingleOrDefault();
            return View(channel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
