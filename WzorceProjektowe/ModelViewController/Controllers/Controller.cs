using ModelViewController.Models;
using ModelViewController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController.Controllers
{
    internal class Controller : IController
    {
        public IView CreateView(IModel model)
        {
            if (model.GetType() == typeof(Models.Model))
            {
                return new ViewExample(model as Model);
            }
            else throw new Exception(string.Format("Wrong model type: {0}. Model1 required.", model.GetType()));
        }

        public IView CreateView()
        {
            var model = new Models.Model()
            {
                Name = "Name",
                Description = "Description"
            };
            return new ViewExample(model);
        }
    }
}
