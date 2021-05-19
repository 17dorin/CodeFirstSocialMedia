using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSocialMediaDb.Models
{
    public class FollowedUser
    {
        [Required]
        [ForeignKey("AspNetUser")]
        public string FollowingUser { get; set; }
        [Required]
        [ForeignKey("AspNetUser")]
        public string UserTofollow { get; set; }
    }
}
