using Dashboard.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Domain.Posts
{
    /// <summary>
    /// Сущность объявления
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        ///<summary>
        ///Имена категории товаров
        /// </summary>
        public Guid CategoryId { get; set; }
        ///<summary>
        ///Имена тегов товаров
        /// </summary>
        public string TagNames { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}
