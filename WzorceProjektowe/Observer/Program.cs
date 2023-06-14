using Observer;

var subject = new ConcreteSubject();
subject.Attach(new ConcreteObserver());
subject.Attach(new ConcreteObserver());
subject.Attach(new ConcreteObserver());

subject.Name = "Test";

//Informowanie o zmianach
//Repozytoria