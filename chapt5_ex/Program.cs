using static System.Console;

namespace chapt5_ex
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 1, b = 2, c = 5, d = 4, e = 6, f = 7;
            int j = 2, k= 5, m = 6, n=9;
        //Letter B
        //    while(d<f){
        //        d = d + 1;
        //        e = e - 1;
        //    }
        //    WriteLine("The value for d is: " + d + " The value for e is : " +e + " The value for f is: " + f);

        //Letter E
        while(j < k){  //2 < 5
            while(m < n){ //6 < 9
                WriteLine("Hello");
                m = m+1;
            }
            j = j+1;
        }
           
        }//end of main
    }
}
