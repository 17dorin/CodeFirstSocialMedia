using CodeFirstSocialMediaDb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodeFirstSocialMediaDb.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly CodeFirstSocialMediaContext _context;

        public PostController(CodeFirstSocialMediaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Post> userPosts = _context.Posts.Where(p => p.AspNetUser.Id == userId).ToList();

            return View(userPosts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string Content)
        {
            AspNetUser currentUser = (AspNetUser)_context.AspNetUsers.FirstOrDefault(u => u.Id == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            Post p = new Post(Content);
            p.AspNetUser = currentUser;

            _context.Posts.Add(p);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Post p = (Post)_context.Posts.FirstOrDefault(d => d.Id == id);

            return View(p);
        }

        public async Task<IActionResult> ConfirmDelete(int id)
        {
            Post postToDelete = (Post)_context.Posts.FirstOrDefault(p => p.Id == id);
            _context.Remove(postToDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> LikePost(int id)
        {
            LikedPost lp = new LikedPost();
            lp.PostId = id;
            lp.LikingUser = User.FindFirst(ClaimTypes.NameIdentifier).Value;


            Post postToLike = (Post)_context.Posts.FirstOrDefault(p => p.Id == id);

            if(_context.LikedPosts.Contains(lp))
            {
                _context.LikedPosts.Remove(lp);
                postToLike.Likes--;
            }
            else
            {
                _context.LikedPosts.Add(lp);
                postToLike.Likes++;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
