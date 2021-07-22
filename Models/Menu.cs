using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBranch.Models
{
    public enum FlavourType
    {
        HotChoclate, FrenchVanilla, CaramelMacchiato, PumpkinSpice, Hazelnut, Mocha
    }
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        
        //Price of the coffee
        public int Price { get; set; }
        public FlavourType? FlavourType { get; set; }//TestType
        public int BranchId { get; set; }
        public Branch Branch { get; set; } //Linking
    }
}
