namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /* a) First problem : public fields so anyone from outside can access and change it directly */
            /* second problem: no validation inside the methods on these fields */
            // b) 
             /* making private fields and use setters and getters with validation or use properties */
             //example 
            // internal class BankAccount
            //    {

            //private string owner;
            //private double _balance;
            //public double GetBalance()
            //{
            //    return _balance;
            //}
            //public void SetBalance (double amount)
            //{
            //    if(amount < 0)
            //    {
            //        Console.WriteLine("Balance can not be negative");
            //        return;
            //    }
            //    _balance = amount;
            //}
            //// Using properties 
            //    public double Balance
            //       {
            //          get;
            //             set;
            //       }
            // C) because missuse is expected from user and unlogical use as well without validation of encapsulation



                //}
            #endregion
        }
    }
}
