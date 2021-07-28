using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBranch.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        //Name of the Branch
        public string Branch_Name { get; set; }
        //Address of the Branch
        public string Branch_Address { get; set; }
        public ICollection<Menu> Menus { get; set; } // 1 to many relation
        public ICollection<Order> Orders { get; set; } // 1 person have many orders
    }
}
