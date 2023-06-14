using Composite;

var root = new Composite.Composite("root");

var level1Composite1 = new Composite.Composite("Level 1 composite 1");
var level1Composite2 = new Composite.Composite("Level 1 composite 2");

root.Add(level1Composite1);
root.Add(level1Composite2);

var level2Composite1 = new Composite.Composite("Level 2 composite 1");
var level2Composite2 = new Composite.Composite("Level 2 composite 2");

level1Composite1.Add(level2Composite1);
level1Composite2.Add(level2Composite2);

var level3Leaf1 = new Leaf("Level 3 leaf 1");
var level3Leaf2 = new Leaf("Level 3 leaf 2");
var level3Leaf3 = new Leaf("Level 3 leaf 3");

level2Composite1.Add(level3Leaf1);
level2Composite1.Add(level3Leaf2);
level2Composite1.Add(level3Leaf3);

root.Print(0);

//Umożliwia przechowywanie obiektów w innych obiektach tworząc katalogi
//Tworzenie ekwipunku
