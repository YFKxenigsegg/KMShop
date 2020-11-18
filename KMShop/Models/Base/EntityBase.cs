using System.ComponentModel.DataAnnotations;

namespace KMShop.Models.Base
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
