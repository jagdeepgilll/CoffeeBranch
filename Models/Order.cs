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
        public int BranchId { get; set; } // Registration ID coming from class registration
        public int MenuId { get; set; }// Add Booking ID

        public string CustomerName { get; set; }//Add Score

        public Branch Branch { get; set; } //Linking to registration class
        public Menu Menu { get; set; }
    }
}
