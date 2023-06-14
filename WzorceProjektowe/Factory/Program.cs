using System.Threading.Channels;

List<Factory.Factory> factories = new List<Factory.Factory>()
{
    new Factory.ProductCreator(),
    new Factory.ProductCreator()
};

factories.ForEach(factory => Console.WriteLine("{0} produkt został stworzony przez {1}", factory.CreateProduct().GetType(), factory.GetType()));

//Kontrola tworzonych obiektów
//Tworzenie jednostek w grze