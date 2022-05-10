Console.Title = "Revision";

//Method for title of this revision
Revision1();
//using a method to get our row variable
int row = getRow(0);
//showing that input
Console.WriteLine($"\nYour target row is: {row}");
//using a method to get our column variable
int column = getColumn(0);
//showing that input
Console.WriteLine($"\nYour target column is: {column}");
//using a method on text to make text red
Red();
Console.WriteLine($"\nComputing......");
//making console make a noise while it computes
Console.Beep();
//giving back the attack targets
Console.WriteLine($"\nYou will deploy your attack too row:{row} column:{column}");
//changing the text back to white for the next revision
White();

PressToContinue();
Clear();

//Reivison 2 intro
Revision2();

//gets user inputs
int x = GetUserInt("Please enter a x value: ");
int y = GetUserInt("Please enter a y value: ");

//if statement that gives us our location of enemy
Blue();
if (x < 0 && y > 0)
{
     Console.WriteLine("\nThe enemy is NW!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("\nThe enemy is N!");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("\nThe enemy is NE!");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("\nThe enemy is W!");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("\nThe enemy is near!");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("\nThe enemy is E!");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("\nThe enemy is SW!");
}
else if (x == 0 && x > 0)
{
    Console.WriteLine("\nThe enemy is S!");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("\nThe enemy is SE!");
}
else
{
    Console.WriteLine("\nError");
}
White();

PressToContinue();
Clear();









//Text colour methods
void Red() { Console.ForegroundColor = ConsoleColor.Red; }
void White() { Console.ForegroundColor = ConsoleColor.White; }
void Blue() { Console.ForegroundColor = ConsoleColor.Blue; }

//Methods for the intro of the levels I am revising
void Revision1()
{
    Red();
    string level = "Level 8";
    Console.WriteLine($"{level, 23}");
    Console.WriteLine("The Defense of Consolas");
    Console.WriteLine("------------------------\n");
    White();
}

//Method used to get row variable in first revision
int getRow(int row)
{
    while (true)
    {
        Console.Write("\nPlease enter an integer for row, 1 - 8: ");
        row = Convert.ToInt32(Console.ReadLine());
        if (row <= 0 && row >= 9) Console.WriteLine("This is not a correct integer try again, 1 - 8 ");
        if (row >= 1 && row <= 8) return row;
    }
}

//Method press any key to continue so console just doesn't skip to the next chapter without letting the user see what they just entered
void PressToContinue()
{
    Console.Write("\nPress any key to continue....");
    Console.ReadKey(false);
}

//Method will clear console
void Clear()
{
    Console.Clear();
}

//Method to get user int, can add string to the method
int GetUserInt(string text)
{
    Console.Write($"\n{text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
    
}

//method just goes to next line
void jumpLine()
{
    Console.WriteLine("\n");
}

//Method used to get column variable in first revision
int getColumn(int column)
{
    while (true)
    {
        Console.Write("\nPlease enter an integer for column, 1 - 8: ");
        column = Convert.ToInt32(Console.ReadLine());
        if (column <= 0 && column >= 9) Console.WriteLine("This integer is not in range please enter between 1 - 8");
        if (column >= 1 && column <= 8) return column;
    }
}

//Title for level 9 revision
void Revision2()
{
    string level = "Level 9";
    Console.WriteLine($"{level,10}");
    Console.WriteLine("Watchtower");
    Console.WriteLine("-----------");
}
