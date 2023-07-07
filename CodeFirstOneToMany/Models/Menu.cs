using System.ComponentModel.DataAnnotations;

namespace CodeFirstOneToMany.Models
{
    public class Menu
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        //Navigation
        public Type ItemType { get; set; }
    }
}
