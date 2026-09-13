namespace PizzaSplit.Core
{
    public class BillCalculator
    {
        public static double Bill(double total, int people, bool isChecked)
        {
           
            if (isChecked)
            {
                total += total / 10; 
            }
            return Math.Round(total / (double)people, 2);
        }
    }
}
