// See https://aka.ms/new-console-template for more information
using Cafetera_TDD.Classes;

CupSizes cupSizes = new CupSizes();
Cups LargeCups = new Cups(cupSizes.Large, 10);
Cups MediumCups = new Cups(cupSizes.Medium, 10);
Cups SmallCups = new Cups(cupSizes.Small, 10);
Coffe Coffe = new Coffe(15);
Sugar Sugar = new Sugar(50);

Machine Machine = new Machine(cupSizes, LargeCups, MediumCups, SmallCups, Coffe, Sugar);
Machine.Start();