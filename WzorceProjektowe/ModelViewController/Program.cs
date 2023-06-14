using ModelViewController.Controllers;
using ModelViewController.Models;

var controller = new Controller();
Console.WriteLine(controller.CreateView().Render());

//Łatwość zmiany danych
//Generowanie stron internetowych ASP.NET