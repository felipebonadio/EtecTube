using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecTube.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public String UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }
        
        [Required]
        public Guid VideoId { get; set; }
        [ForeignKey("VideoId")]

        public Video Video { get; set; }

        [StringLength(1000)]
        public String CommentText { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.Now;

    }
}