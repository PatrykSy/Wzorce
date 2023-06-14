using Adapter;

List<Target> targets = new List<Target>()
{
    new Target(),
    new Adapter.Adapter(new Adaptee())
};
targets.ForEach(target => target.Action());

//Dołączanie danych z zewnętrznej bazy
//Rozszarzenie funkcjonalności