using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController.Controllers
{
    internal interface IController
    {
        Views.IView CreateView();
        Views.IView CreateView(Models.IModel model);
    }
}
