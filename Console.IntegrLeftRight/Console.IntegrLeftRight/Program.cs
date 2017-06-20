using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console.IntegrLeftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, x, s1, s2,eps;
            int a, b, n;
            double[] f = new double[1000];
            s1 = 0.0; s2 = 0.0;
            x = 0.0;
            a = 1;
            b = 3;
            n = 2;
            eps = 0.1;
            h = (b-a)/(double)n;
            for (int i = 1; i < n; i++) //Right h*(f[1]+f[2]..+f[n])
            {
                x = a + (i * h);
                f[i] = Math.Tan(0.1) * (x * x + Math.Sqrt((1 + 0.2 * x)));
                s1 = s1 + f[i];
            }
            s1 = s1 * h;
            s2 = s1;
            do
            {
                s1 = s2; s2 = 0.0;
                n = n * 2;
                h = (b - a) / (double)n;
                for (int j = 1; j < n; j++)
                {
                    x = a + (j * h);
                    f[j] = Math.Tan(0.1) * (x * x + Math.Sqrt((1 + 0.2 * x)));
                    s2 = s2 + f[j];
                }
                s2 = s2 * h;
            }
            while (((s1 - s2) < eps) || (n>256)); //НЕПОНЯТНО. РАЗОБРАТЬСЯ!!!
            System.Console.WriteLine(s1+"  "+s2+"  "+n+"\n"+s2);
            System.Console.ReadKey();

        }
    }
}
