using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC2.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public  string Description { get; set; }
        public int CheeseId { get; set; }
        private static int nextId = 1;

        //This is being done in the controller under NewCheese
        //public Cheese(string name, string description)
        //{
        //    Name = name;
        //    Description = description;
        //}

        public Cheese() {
            CheeseId = nextId;
            nextId++;
        }
    }
}
