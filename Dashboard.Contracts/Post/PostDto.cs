using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Contracts.Base;

namespace Dashboard.Contracts.Post
{
    /// <summary>
    ///     Объявление
    /// </summary>
    public class PostDto : BaseDto
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
        public string CategoryNames{ get; set; }
        ///<summary>
        ///Имена тегов товаров
        /// </summary>
        public string[] TagNames { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

    }
}
