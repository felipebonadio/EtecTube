using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models
{
[Table("Video")]
    public class Video
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid ChannelId { get; set; }
        public Channel Channel { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [StringLength(8000)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data de Publicação")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [StringLength(200)]
        [Display(Name = "Foto de Apresentação")]
        public string Thumbnail { get; set; }

        [Display(Name = "Gostei")]
        public uint Likes { get; set; }

        [Display(Name = "Não Gostei")]
        public uint Dislikes { get; set; }
        
        [Display(Name = "Visualizações")]
        public uint Visualizations { get; set; }

        [NotMapped]
        public string PassedTime { get => PassedTimeCalculated(); }

        [NotMapped]
        public string TextVisualizations { get => StringVisualizations(); }

        public ICollection<Comment> VideoComments { get; set; }

        // Método Construtor
        public Video()
        {
            PublishedDate = DateTime.Now;
            Likes = 0;
            Dislikes = 0;
            Visualizations = 0;
        }

        // Método privado para converter a data em periodo de tempo
        private string PassedTimeCalculated(){
            TimeSpan diff = DateTime.Now.Subtract(PublishedDate);
            if (diff.Days >= 365)
                return $"há { diff.Days / 365 } "
                    + ((diff.Days/365) > 1 ? "anos" : "ano");
            else if (diff.Days >= 30)
                return $"há { diff.Days / 30 } "
                    + ((diff.Days/30) > 1 ? "meses" : "mês");
            return $"há { diff.Days } "
                    + ((diff.Days) > 1 ? "dias" : "dia");
        }

        // Método privado para converter a quantidade de visualizações
        private string StringVisualizations(){
            if (Visualizations >= 1000000)
                return $"{ (Visualizations / 1000000.0).ToString("N1") } mi de visualizações";
            else if (Visualizations >= 100000)
                return $"{ (Visualizations / 100000) } mil de visualizações";
            else if (Visualizations >= 1000)
                return $"{ (Visualizations / 1000.0).ToString("N1") } mil de visualizações";
            else
                return $"{ Visualizations } visualizações";
        }
    }
}