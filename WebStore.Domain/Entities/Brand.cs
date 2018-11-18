using System;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Сущность бренд
    /// </summary>
    public class Brand: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}