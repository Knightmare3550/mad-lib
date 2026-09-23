Console.WriteLine("Hello, World!");
Console.WriteLine("=== THE LEGEND OF HAMSTERVILLE ===");
Console.WriteLine();
// 10 Mad Lib inputs
Console.Write("Enter a city: ");
string city = Console.ReadLine();
Console.Write("Enter a hero name: ");
string hero = Console.ReadLine();
Console.Write("Enter a creature: ");
string creature = Console.ReadLine();
Console.Write("Enter a food: ");
string food = Console.ReadLine();
Console.Write("Enter an adjective: ");
string adjective = Console.ReadLine();
Console.Write("Enter an action: ");
string action = Console.ReadLine();
Console.Write("Enter a magical object: ");
string weapon = Console.ReadLine();
Console.Write("Enter a superpower: ");
string power = Console.ReadLine();
Console.Write("Enter a villain name: ");
string villain = Console.ReadLine();
Console.Write("Choose your fate! Enter a number from 1-100: ");
int fate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("========== YOUR STORY ==========");
Console.WriteLine();
Console.WriteLine($"Long ago, {hero} protected the kingdom of {city}.");
Console.WriteLine($"One day, a {adjective} {creature} appeared.");
Console.WriteLine($"It warned {hero} that the evil {villain} was coming!");
Console.WriteLine();
Console.WriteLine($"{hero} ate some {food}, grabbed the {weapon},");
Console.WriteLine($"and unlocked the power of {power}.");
Console.WriteLine();
Console.WriteLine($"{hero} prepared to {action}!");
Console.WriteLine();
 
// Ending system
if (fate >= 1 && fate <= 10)
{
Console.WriteLine("ENDING 1: TOTAL DEFEAT");
Console.WriteLine($"{villain} was too powerful!");
Console.WriteLine($"{hero} was defeated and {city} fell into darkness.");
}
else if (fate <= 20)
{
Console.WriteLine("ENDING 2: THE BETRAYAL");
Console.WriteLine($"The {creature} suddenly switched sides and joined {villain}!");
Console.WriteLine($"{hero} barely escaped.");
}
else if (fate <= 30)
{
Console.WriteLine("ENDING 3: THE LOST WEAPON");
Console.WriteLine($"{hero} dropped the {weapon} during battle.");
Console.WriteLine($"{villain} grabbed it and became even stronger!");
}
else if (fate <= 40)
{
Console.WriteLine("ENDING 4: CHEESY VICTORY");
Console.WriteLine($"The smell of {food} stopped the entire battle.");
Console.WriteLine($"Everyone decided eating was better than fighting.");
}
else if (fate <= 50)
{
Console.WriteLine("ENDING 5: DESTRUCTION");
Console.WriteLine($"The battle between {hero} and {villain} became so powerful");
Console.WriteLine($"that they accidentally destroyed half of {city}!");
}
else if (fate <= 60)
{
Console.WriteLine("ENDING 6: REDEMPTION");
Console.WriteLine($"{hero} convinced {villain} to give up being evil.");
Console.WriteLine($"Together they helped rebuild {city}.");
}
else if (fate <= 70)
{
Console.WriteLine("ENDING 7: POWER UNLEASHED");
Console.WriteLine($"{hero} unleashed {power}!");
Console.WriteLine($"{villain} didn't stand a chance.");
}
else if (fate <= 80)
{
Console.WriteLine("ENDING 8: NEW ALLY");
Console.WriteLine($"The {creature} joined {hero} in battle!");
Console.WriteLine($"Together they defeated {villain}.");
}
else if (fate <= 90)
{
Console.WriteLine("ENDING 9: THE LEGEND");
Console.WriteLine($"{hero} defeated {villain} with the {weapon}!");
Console.WriteLine($"{hero} became the legendary protector of {city}.");
}
else if (fate <= 99)
{
Console.WriteLine("ENDING 10: SECRET ENDING");
Console.WriteLine($"{villain} vanished before the final attack.");
Console.WriteLine($"A mysterious voice whispered: \"This isn't over...\"");
}
else if (fate == 100)
{
Console.WriteLine("ULTIMATE ENDING!");
Console.WriteLine($"{hero} unleashed the full power of {power}!");
Console.WriteLine($"{villain} was defeated!");
Console.WriteLine($"The {creature} bowed before {hero}.");
Console.WriteLine($"{city} was saved!");
Console.WriteLine();
Console.WriteLine($"{hero} became the greatest ruler in history!");
}
else
{
Console.WriteLine("Your fate number must be between 1 and 100!");
}