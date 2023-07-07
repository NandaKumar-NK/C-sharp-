using System.ComponentModel.DataAnnotations;

namespace CodeFirstOneToMany.Models
{
    public class Typecs
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        //Navigation
        public IEnumerable<Menu> menus { get; set; }
    }
}
