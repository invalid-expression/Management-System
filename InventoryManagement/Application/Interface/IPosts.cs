using Application.Entity.Common;
using Application.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
	public interface IPosts
	{
		Task<Response> Post(Posts posts);
		Task<Response> Comment(Comment comment);

	}
}
