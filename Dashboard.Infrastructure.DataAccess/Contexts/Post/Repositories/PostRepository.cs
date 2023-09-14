using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Post;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories
{
    public class PostRepository: iPostRepository
    {
        ///<inheritdoc/>
        public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {

                return Task.Run(() => new PostDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Заголовок",
                    Description = "Описание.",
                    CategoryNames = "tt",
                    TagNames = new[] { "тег1", "тег2" },
                    Price = 500.43M

                }, cancellationToken);
            
        }
    }
}
