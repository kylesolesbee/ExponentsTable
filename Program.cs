// Kyle Solesbee 10/2/23
// Exponents Table 

using Exponents_Table.Output;

int number = 0;
bool goodNum;
OutputTable outputTable = new OutputTable();

do
{
    Console.WriteLine("Please enter a number between 1 and 1290: ");
    goodNum = int.TryParse(Console.ReadLine(), out number) && 
             number > 0 && number <= 1290;

    if(goodNum == false)
    {
        Console.WriteLine("Error! Try a valid number: ");
    }

} while (goodNum == false);

outputTable.Output(number);