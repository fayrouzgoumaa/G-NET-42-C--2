namespace G_NET_42_C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //double d = 9.99;
            //int x1 = (int)d;
            //Console.WriteLine(x1);
            //Explicit casting from double to int.
            //9.99 becomes 9 because the fractional part is discarded.
            #endregion

            #region Q2

            //int n = 5;
            //double d2 = n / 2.0;   
            //Console.WriteLine(d2);
            //n / 2 performs integer division first(5 / 2 = 2), then converts to double → 2.0
            #endregion
            #region Q3
            //Console.Write("Enter age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            #endregion
            #region Q4
            // Q4: What happens and why?
            //string s = "12a";
            //int x2 = int.Parse(s);   // Runtime exception
            //Console.WriteLine(x2);

            //int.Parse() requires a purely numeric string.
            // "12a" contains a non - numeric character.
            #endregion
            #region Q5

            //string s2 = "12a";

            //if (int.TryParse(s2, out int result))
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Invalid");
            #endregion
        }
    }
}
