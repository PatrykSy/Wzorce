using ModelViewController.Models;



namespace ModelViewController.Views
{
    abstract class View : IView
    {
        public Models.IModel model { get; private set; }
        public View(Models.IModel model)
        {
            this.model = model;
        }

        public abstract string Render();
    }
}
