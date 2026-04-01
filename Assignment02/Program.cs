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

            #region Question02
            /* Fields or attributes are variables to store data inside classes */
            /* properties are a controlled way to get or set fields to encounter and violate 
             * encapsulation */
            //read only property that return a calculated value 
            /* public int Balance => balance > 0 ; */
            #endregion


            #region Question04
            /* static keyword has made TotalOrders to be a class member not an instance(object) member */
            //No — static methods belong to the class, not an object. There's no instance to read the field from. You'd get a compile error.
            #endregion
        }
    }
}
