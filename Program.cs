//Initiates variables to hold the Live Scores for both the Hero and the Monster
int heroLiveScore = 10;
int monsterLiveScore = 10;

Random live = new Random(); //Initialize a new Random integer generator

do
{  

    int subLive = live.Next(1,11); //Generates random live score subtractor for Monsters attacks
    monsterLiveScore -= subLive;
    Console.WriteLine($"Monster was damaged and lost {subLive} and now has {monsterLiveScore} health");

if (monsterLiveScore <= 0) continue; //The continue keyword tells the compiler to jump to the last line of code block and evaluate the WHILE boolean, if its still TRUE then it continues the line 16

subLive = live.Next(1, 11); //Generates random live score subtractor for Monsters attacks
heroLiveScore -= subLive;
    Console.WriteLine($"Hero was damaged and lost {subLive} and now has {heroLiveScore} health");

} while (monsterLiveScore > 0 && heroLiveScore > 0);

Console.WriteLine(monsterLiveScore > heroLiveScore ? "Monster wins" : "Hero wins"); //Tenary conditions to print winner

