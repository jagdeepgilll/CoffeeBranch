using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBranch.Models
{
    public class Order
    {
        [Key]//Add primary key
        public int ID { get; set; }// ID is primary key 
        public int BranchId { get; set; } // Branch ID 
        public int MenuId { get; set; }// Add Menu ID

        public string CustomerName { get; set; }//Add Customer name

        public Branch Branch { get; set; } //Linking to branch class
        public Menu Menu { get; set; }
    }
}
