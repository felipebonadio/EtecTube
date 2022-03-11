using System;
using Microsoft.EntityFrameworkCore;
using EtecTube.Models;

namespace EtecTube.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }

        public DbSet<Channel> Channels { get; set; }
        public DbSet<Video> Videos { get; set; }

    }
}