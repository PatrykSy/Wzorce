using ChainOfResponsibilities;

List<int> requests = new List<int> { 0, 10, 42, 500, 400,2,41,10004 };
var handler1 = new RequestHandler1();
var handler2 = new RequestHandler2();
var handler3 = new RequestHandler3();
handler1.SetSuccessor(handler2);
handler2.SetSuccessor(handler3);

requests.ForEach(request => handler1.HandleRequest(request));

//Wielopoziomowa autoryzacja
//Pozwala na przekazanie odpowiedzialności za dane zadanie innemu obiektowi