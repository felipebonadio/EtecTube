using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models
{
    [Table("Subscript")]
    public class Subscript
    {
        [Key, Column(Order = 1)]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Key, Column(Order = 2)]
        public Guid ChannelId { get; set; }
        [ForeignKey("ChannelId")]
        public Channel Channel { get; set; }
    }
}