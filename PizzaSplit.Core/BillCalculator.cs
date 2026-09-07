namespace PizzaSplit.Core
{
    public class BillCalculator
    {
        public static int Bill(int total, int people, bool isChecked)
        {
           
            if (isChecked)
            {
                total += (int)(total * 0.1); 
            }
            return total / people;
        }
    }
}
