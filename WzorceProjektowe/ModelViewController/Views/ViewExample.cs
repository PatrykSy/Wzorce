using ModelViewController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController.Views
{
    internal class ViewExample : View
    {
        private readonly Model _model;
        public ViewExample(Model model) : base(model)
        {
            if(model != null) 
            {
                _model = model;
            }
            else throw new Exception("WHERE MODEL?");
        }

        public override string Render()
        {
            return string.Format("{0} {1}", _model.Name, _model.Description);
        }
    }
}
