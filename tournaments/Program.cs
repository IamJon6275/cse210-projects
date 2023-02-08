// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Team firebirds = new Team("Firebirds");

Player john = new Player("John Henderson", 12);
//john.Display();
Player tim = new Player("Tim Nunn", 1);

firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);
firebirds.DisplayRoster();

Team blackSharks = new Team("Black Sharks");

Player jon = new Player("Jonathan Wells", 1);
Player jonas = new Player("Jonas Smith", 28);
blackSharks.AddPlayer(jon);
blackSharks.AddPlayer(jonas);

Match match1 = new Match(firebirds, blackSharks);
match1.DecideWin();

blackSharks.DisplayRoster();
firebirds.DisplayRoster();