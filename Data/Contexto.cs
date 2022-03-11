using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EtecTube.Models;

namespace EtecTube.Data
{
    public class Contexto : IdentityDbContext<User>
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }

        public DbSet<Channel> Channels { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Renomeia a tabela de usuários
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name:"User")
            });
            //Renomeia a tabela de perfis
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name:"Role")
            });
            //Renomeia a tabela de perfis do usuário
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name:"UserRoles")
            });
            //Renomeia a tabela de regras do usuários
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name:"UserClaims")
            });
            //Renomeia a tabela de logins do usuário
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name:"UserLogins")
            });
            //Renomeia a tabela de tokens do usuário
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name:"UserTokens")
            });
            //Renomeia a tabela de regras do perfil
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name:"RoleClaims")
            });
        }
    }
}