using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Сущность секция
    /// </summary>
    [Table("Sections")]
    public class Section : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        /// <value>The parent identifier.</value>
        public int? ParentId { get; set; }
        [ForeignKey("Parentd")]
        public virtual Section ParentSection {get; set; }
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}