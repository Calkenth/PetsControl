using System;
using System.Collections.Generic;
using System.Text;

namespace PetsControl.Data.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
