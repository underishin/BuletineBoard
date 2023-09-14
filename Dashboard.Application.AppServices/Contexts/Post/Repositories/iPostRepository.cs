﻿using Dashboard.Contracts.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Application.AppServices.Contexts.Post.Repositories
{
    /// <summary>
    /// Репозиторий для работы с объявлениями
    /// </summary>
   public interface iPostRepository
    {
        /// <summary>
        /// Возвращает объявление по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления <see cref="PostDto"/></returns>
        Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
