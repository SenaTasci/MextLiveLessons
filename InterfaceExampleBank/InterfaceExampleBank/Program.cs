



using InterfaceExampleBank.Concrete;

Akbank akbank = new Akbank();

decimal interestAkbank = akbank.GetCredit(6,10000);

Console.WriteLine($" Akbank : {interestAkbank}");

Vakıfbank vakıfbank = new Vakıfbank();

decimal interestVakif = vakıfbank.GetCredit(6, 10000);

Console.WriteLine($" Vakıfbank : {interestVakif}");

