//DRY: Don't Repeat Yourself. To make thi text-based adventure a lot of the code will be similar. This could be made into a function, however it will nto seeing as it would reduce nothing replacing a line to save another one or maybe two.
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("EMERGENCY MEETING");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Why did you press the button?");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkBlue;
string answerSus = "hello world";
answerSus = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine( "'"+answerSus +"'" + " is not a good excuse kind of sus, you might be the mongster!");
Console.WriteLine("Are you?");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkBlue;
answerSus = Console.ReadLine();
Random random = new Random();
int timeForResponse = random.Next(250, 1000);
if (answerSus == "yes")
{
new Thread(async () => 
{
    timeForResponse = random.Next(250, 1000);
    Thread.CurrentThread.IsBackground = true; 
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Kinda sus, ngl"); 
}).Start();
new Thread(async () => 
{
    timeForResponse = random.Next(250, 1000);
    Thread.CurrentThread.IsBackground = true; 
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine("He is amongus"); 
    
}).Start();
    await Task.Delay(2000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine("VOTED"); 
    timeForResponse = random.Next(250, 1000);
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("VOTED"); 
    timeForResponse = random.Next(250, 1000);
    await Task.Delay(2000);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("YOU were ejected");

}
//seeing as there can only be three answers: "yes", "no" and something else,  "no" and something else will be lumped in together.
//Seeing as this is based on the hit-game, known as amongus, we sant to emulate the differing wait time and order of the responses.
//To do that a pseudorandom number withing the timeframe for a response i generated for each repsonse, which is each contained in its own async thread(Borrowed from the internet). To use await the new thread needs to be async.
//This could also be done without any mention of new threads by using a butt-load(sus) of if-loops controlling the order of de- and incrementing a random number within the limits of how many responenses are needed.
else {
new Thread(async () => 
{
    timeForResponse = random.Next(250, 1000);
    Thread.CurrentThread.IsBackground = true; 
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("That is what you would say as the mongster!"); 
}).Start();
new Thread(async () => 
{
    timeForResponse = random.Next(250, 1000);
    Thread.CurrentThread.IsBackground = true; 
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine("He is amongus"); 
    
}).Start();
    await Task.Delay(2000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine("VOTED"); 
    timeForResponse = random.Next(250, 1000);
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("VOTED"); 
    timeForResponse = random.Next(250, 1000);
    await Task.Delay(timeForResponse);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("YOU were ejected");
}
Console.ReadLine();
