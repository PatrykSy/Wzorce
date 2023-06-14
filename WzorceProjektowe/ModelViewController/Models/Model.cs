using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController.Models
{
    class Model : IModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Model(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Model() { }
    }
}
