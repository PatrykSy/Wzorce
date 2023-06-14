using Decorator.Components;

List<IComponent> components = new List<IComponent>()
{
    new Component(),
    new Decorator.Decorators.DecoratorExample(new Component())
};
components.ForEach(component => { component.Action(); Console.WriteLine(); });

//Rozszerzanie funkcjonalności
//Dodanie śledzenia połączenia z serwerem