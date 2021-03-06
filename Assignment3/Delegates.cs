using System;

namespace BDSA2020.Assignment3
{
    public class Delegates
    {
        //part 1
        public delegate string ReverseOrder(string input);
        public static ReverseOrder GetReverseOrder()
        {
            var reverser = new ReverseOrder(
                delegate (string input)
                {
                    var chars = input.ToCharArray();
                    var output = "";
                    for(var i = chars.Length - 1; i >= 0; i--)
                    {
                        output += chars[i];
                    }
                    return output;
                }
            );

            return reverser;
        }



        //part 2
        public static Func<double, double, double> producter = (a, b) => a*b;



        //part 3
        public delegate bool MultiargumentPredigate<T1, T2>(T1 arg1, T2 arg2);
        public static MultiargumentPredigate<int, string> numberValidator = (int i, string s) => Int32.TryParse(s, out _) ? Int32.Parse(s) == i : false;
        //original code
        /*public static void InitiateNumberValidator() {
            numberValidator = new MultiargumentPredigate<int, string>(
                delegate (int i, string s)
                    {
                        if (! Int32.TryParse(s, out _)) {
                            return false;
                        }
                        return Int32.Parse(s) == i;
                    }
                );
        }*/
    }
}
