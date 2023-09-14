using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Application.AppServices.Contexts.Post.Services
{
    public class PostService : iPostService
    {
        private readonly iPostRepository _postRepository;
        /// <summary>
        /// Инициализирует экземпляр <see cref="PostService"/>
        /// </summary>
        /// <param name="postRepository">Репозиторий для работы с объявлениями</param>
        public PostService(iPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        ///<inheritdoc/>
        public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _postRepository.GetByIdAsync(id, cancellationToken);
        }
    }
}
