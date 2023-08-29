using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts.Base
{
    /// <summary>
    /// базовый контракт
    /// </summary>
    public class BaseDto
    {
        /// <summary>
        /// Индетификатор сущности
        /// </summary>
        public Guid Id { get; set; }
    }
}
