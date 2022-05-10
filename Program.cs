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