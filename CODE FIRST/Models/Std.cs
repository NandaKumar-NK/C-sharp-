using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FIRST.Models
{
    internal class Std
    {
        [Key]
        public int stdRoll { get; set; }
        public string stdName { get; set; } 
        public string stddept { get; set; }
    }
}
