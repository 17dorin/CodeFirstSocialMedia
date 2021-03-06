using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSocialMediaDb.Models
{
    public class Post
    {
        public Post(string Content)
        {
            this.Content = Content;
            PostDate = DateTime.Now;
            Likes = 1;
        }

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(280)]
        public string Content { get; set; }
        [Required]
        public int Likes { get; set; }
        [Required]
        public DateTime PostDate { get; set; }
        [ForeignKey("AspNetUser")]
        public string AspNetUserId { get; set; }

        public AspNetUser AspNetUser { get; set; }
        public ICollection<LikedPost> LikingUsers { get; set; }
    }
}
