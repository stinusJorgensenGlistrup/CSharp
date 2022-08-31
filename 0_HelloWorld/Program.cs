//DRY: Don't Repeat Yourself. To make thi text-based adventure a lot of the code will be similar. This could be made into a function, however it will nto seeing as it would reduce nothing replacing a line to save another one or maybe two.
/*
To this end i made a function which print dialoge with a specific bacground color, however it was not implemented:
/*
static void respondToDialog(string textForResponse, ConsoleColor colorOfAmongus)
{
    //i wish to make it so that the console color is selected by the input of the 2nd parameter:
    Console.BackgroundColor = colorOfAmongus;
    Console.WriteLine(textForResponse);
}
*/
static void respondToDialog(string textForResponse, ConsoleColor colorOfAmongus)
{
    //i wish to make it so that the console color is selected by the input of the 2nd parameter:
    Console.BackgroundColor = colorOfAmongus;
    Console.WriteLine(textForResponse);
}

//to further simplify this code it would be possible to create a class for each amongus, with a nested function. This would mean that we would be able to call on that funtion eithin an instance of that class.
//A good use for this might be  if we had more variation in the foreground color. due to the shortnes and the above mentioned, this will not be done.
/*
class Person
{
    ConsoleColor foregroundColor;
    ConsoleColor backgroundColor;

    Person(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        this.foregroundColor = foregroundColor;
        this.backgroundColor = backgroundColor;
    }

    void say(string whatToSay)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;
        Console.WriteLine(whatToSay);
    }

    static void Main(string[] args)
    {
        Person person1 = new Person(ConsoleColor.White, ConsoleColor.Gray);
        Person person2 = new Person(ConsoleColor.Green, ConsoleColor.Gray);
        person2.say("i am person 2");
        person1.say("bhhbhb");
    }
}

*/
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("EMERGENCY MEETING");
Console.ForegroundColor = ConsoleColor.White;
respondToDialog("Why did you press the button?", ConsoleColor.Green);
Console.BackgroundColor = ConsoleColor.DarkBlue;
string answerSus = "hello world";
answerSus = Console.ReadLine();
respondToDialog(
    "'" + answerSus + "'" + " is not a good excuse kind of sus, you might be the mongster!",
    ConsoleColor.Green
);
respondToDialog("Are you?", ConsoleColor.Green);
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
        respondToDialog("Kinda sus, ngl", ConsoleColor.Green);
    }).Start();
    new Thread(async () =>
    {
        timeForResponse = random.Next(250, 1000);
        Thread.CurrentThread.IsBackground = true;
        await Task.Delay(timeForResponse);
        respondToDialog("He is amongus", ConsoleColor.Cyan);
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
//This could also be done without any mention of new threads by using a butt-load(sus) of if-loops controlling the order of de- and incrementing a random number within the limits of how many responenses are needed(there are 4 sentences meaning that there are 4*3*2*1 = 24 differing combinations).
else
{
    new Thread(async () =>
    {
        timeForResponse = random.Next(250, 1000);
        Thread.CurrentThread.IsBackground = true;
        await Task.Delay(timeForResponse);
        respondToDialog("That is what you would say as the mongster!", ConsoleColor.Green);
    }).Start();
    new Thread(async () =>
    {
        timeForResponse = random.Next(250, 1000);
        Thread.CurrentThread.IsBackground = true;
        await Task.Delay(timeForResponse);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Cyan;
        respondToDialog("He is amongus", ConsoleColor.Cyan);
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
//test af andet, ikke vigtigt herd
