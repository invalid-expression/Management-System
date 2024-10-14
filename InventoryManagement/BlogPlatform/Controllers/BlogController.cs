using Application.Entity.Common;
using Application.Entity.Model;
using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BlogPlatform.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogController : ControllerBase
	{
		private readonly IPosts _posts;
		public BlogController(IPosts posts)
		{
			_posts = posts;
		}

		[HttpPost]
		public async Task<ActionResult<Response>> Post(Posts posts)
		{
			var Post = await _posts.Post(posts);
			return Ok(Post);
		}

		[HttpPost("{Id}")]
        public async Task<ActionResult<Response>> Comment(Comment comment)
		{
			var Comment = await _posts.Comment(comment);
			return Ok(Comment);
		}



    }
}
