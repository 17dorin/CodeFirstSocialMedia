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

        public AspNetUser AspNetUser { get; set; }
    }
}
