using RPG.src.Entities;

Knight arus = new Knight("Arus", 12);
WhiteWizard jenica = new WhiteWizard("Jenica", 23);

Console.WriteLine(jenica.Attack());
Console.WriteLine(arus.Attack());

Console.WriteLine(jenica.Attack(100));
Console.WriteLine(jenica.Attack(1));