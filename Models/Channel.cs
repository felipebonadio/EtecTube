using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models
{
    [Table("Channel")]
    public class Channel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        
        [StringLength(200)]
        [Display(Name = "Foto do Canal")]
        public string ChannelPicture { get; set; }

        [StringLength(200)]
        [Display(Name = "Banner")]
        public string Banner { get; set; }

        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public ICollection<Video> Videos { get; set; }
        public ICollection<Subscript> Subscriptions { get; set; }
    }
}