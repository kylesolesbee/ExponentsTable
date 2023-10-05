using Exponents_Table.Calculation;

namespace Exponents_Table.Output
{
    public class OutputTable
    {
        Calculations calculations = new Calculations();
        public void Output(int number)
        {
            Calculations calculations = new Calculations();
            Console.WriteLine(String.Format("{0, -10} {1, -20} {2, -30}", "Number", "Squared", "Cubed"));
            Console.WriteLine(String.Format("{0, -10} {1, -20} {2, -30}", "==========", "====================", "=============================="));

            for (int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine(String.Format("{0, 10} {1, 20} {2, 30}", counter, calculations.SquaredFormula(counter), calculations.CubedFormula(counter)));
            }
        }
    }
}
