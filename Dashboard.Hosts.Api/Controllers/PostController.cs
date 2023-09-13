using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Dashboard.Contracts.Post;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers
{
    int a;
    //gg
    ///<summary>    
    ///Контроллер для работы с обЪявлениями
    /// </summary>
    public class PostController : ControllerBase
    {
        /// <summary>
        /// Возращает объявление по индетификатору
        /// </summary>
        /// <param name="id"> Индетификатор объявления</param>
        /// <param name="cancellationToken">Отмена операции</param>
        /// <returns>Модель объявления<see cref="PostDto"></returns>
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
        /// <summary>
        /// Возращает постраничные объявления
        /// </summary>
        /// <param name="cancellationTokenint">Отмена операции</param>
        /// <param name="pageSize">Размер страницы</param>
        /// <param name="pageIndex">Номер страницы</param>
        /// <returns>Колекция объявлений<see cref="PostDto"></returns>
        [HttpGet("get-all-paged")]
        public async Task<IActionResult> GetAllAsync( CancellationToken cancellationTokenint, int pageSize = 10, int pageIndex = 0)
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
        /// Удалаяет объявление по индетификатору
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
