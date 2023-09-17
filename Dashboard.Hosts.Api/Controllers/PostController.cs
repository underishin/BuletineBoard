using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Dashboard.Contracts.Post;
using Microsoft.AspNetCore.Mvc;
using Dashboard.Application.AppServices.Contexts.Post;
using Dashboard.Application.AppServices.Contexts.Post.Services;

namespace Dashboard.Hosts.Api.Controllers
{

    ///<summary>    
    ///Контроллер для работы с объявлениями
    /// </summary>
    [ApiController]
    [Route("post")]
    public class PostController : ControllerBase
    { 
        private readonly iPostService _postService;

        /// <summary>
        /// Инициализирует экзепляр <see cref="PostController"/>
        /// </summary>
        /// <param name="postService">Сервис работы с объявлениями.</param>
        public PostController(iPostService postService)
        {
            _postService = postService;
        }

        /// <summary>
        /// Возвращает объявление по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления <see cref="PostDto"/></returns>
        [HttpGet("get-by-id")]
        [ProducesResponseType(typeof(PostDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _postService.GetByIdAsync(id, cancellationToken);
            return Ok(result);
        }
        /// <summary>
        /// Возращает постраничные объявления
        /// </summary>
        /// <param name="cancellationToken">Отмена операции</param>
        /// <param name="pageSize">Размер страницы</param>
        /// <param name="pageIndex">Номер страницы</param>
        /// <returns>Коллекция объявлений<see cref="PostDto"/></returns>
        [HttpGet("get-all-paged")]
        public async Task<IActionResult> GetAllAsync( CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
        {
            return Ok();
        }
        /// <summary>
        /// Создает объявление
        /// </summary>
        /// <param name="cancellationToken">Отмена операции</param>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(PostDto dto,CancellationToken cancellationToken)
        {
            return Created(uri:string.Empty,value:null);
        }
        /// <summary>
        /// Редактирует объявление
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(PostDto dto, CancellationToken cancellationToken)
        {
            return Ok();
        }
        /// <summary>
        /// Удаляет объявление по индетификатору
        /// </summary>
        /// <param name="id">Индетификатор объявления</param>
        /// <param name="cancellationToken">Отмена операции</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
