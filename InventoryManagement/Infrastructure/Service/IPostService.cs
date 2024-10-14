using Application.Entity.Common;
using Application.Entity.Model;
using Application.Interface;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
	public class IPostService : IPosts
	{
		private readonly ApplicationContext _applicationContext;
        public IPostService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<Response> Comment(Comment comment)
        {
			var Comment = await _applicationContext.Comment.AddAsync(comment);
						  await _applicationContext.SaveChangesAsync();
			return new Response
			{
				StatusCode = 200,
				Message = "Comment Added",
				Result = true
			};
		}

        public async Task<Response> Post(Posts posts)
		{
			var Post = await _applicationContext.Posts.AddAsync(posts);
					   await _applicationContext.SaveChangesAsync();
			
			return new Response
			{
				StatusCode = 200,
				Message="Post Posted",
				Result=true
			};
		}
	}
}
