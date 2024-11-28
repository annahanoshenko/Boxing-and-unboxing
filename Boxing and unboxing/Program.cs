

namespace Boxing_and_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            a.GetType(); //boxing
            
            //object b = a;
            //int c = (int)b; //unboxing

           // decimal d = (decimal)b; InvslidCastException  
        }
    }
}
