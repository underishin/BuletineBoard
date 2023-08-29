using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Domain.Base
{
    /// <summary>
    /// базовый сущность
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Индетификатор сущности
        /// </summary>
        public Guid Id { get; set; }
    }
}
