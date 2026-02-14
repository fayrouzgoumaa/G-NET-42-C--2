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
            #region Q6
            // Q6: What will this print?
            //object o1 = 10;
            //int a = (int)o1;
            //Console.WriteLine(a + 1);
            //print=11 10 is boxed into object Explicit cast(int)o performs unboxing
            //10 + 1 = 11
            #endregion
            #region Q7
            // Q7: What happens here?
            //object o2 = 10;
            //long x3 = (long)o2;   // InvalidCastException
            //Console.WriteLine(x3);

            // Result:InvalidCastException
            // 10 is boxed as int
            //Correct way:

            //long x = (int)o;
            #endregion
            #region Q8
            // Q8: Avoid exceptions and print -1 if not possible
            // object o3 = 10;

            // long x4 = o3 is long l ? l :
            //           o3 is int i ? i :
            //           -1;

            // Console.WriteLine(x4);
            // Safe fix:

            //long x = o is long l ? l :
            //          o is int i ? i :
            //           -1;

            #endregion
            #region Q9
            // Q9: What will this print?
            //string? name = null;
            //Console.WriteLine(name?.Length);

            //output = (blank line)
            // ?. is the null - conditional operator
            //If name is null, expression returns null
            //Console.WriteLine(null) prints nothing
            #endregion
            #region Q10
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);

            //output is 0

            //name2 is null
            //name2?.Length returns null
            //?? 0(null - coalescing operator) replaces null with 0
            //So length = 0.
            #endregion
            #region Q11
            // string? s = null;
            // int x = int.Parse(s ?? "0");
            // Console.WriteLine(x);

            //It does NOT protect against invalid numeric input

            //Safe Solution
            //string? s = null;

            //int x;
            //if (!int.TryParse(s, out x))
            //    x = 0;

            //Console.WriteLine(x);     
            #endregion
            #region Q12
            // string? s = null;
            // Console.WriteLine(s!.Length);
            //! is the null - forgiving operator.
            //It tells the compiler:
            //“Trust me, this is not null.”
            //But at runtime:
            //s is actually null
            //safe
            //    string? s = null;
            //Console.WriteLine(s?.Length ?? 0);

            #endregion


        }
    }
}
