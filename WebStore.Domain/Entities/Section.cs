using System;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Сущность секция
    /// </summary>
    public class Section : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        /// <value>The parent identifier.</value>
        public int? ParentId { get; set; }
        public int Order { get; set; }
    }
}
