using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if(a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsInconsisted(double a, double b)
        {
            if(a==0 && b==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDegree2(double x)
        {
            if (x>1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Delta(double a, double b, double c)
        {
            double delta = (b * b) + (-4 * a * c);
            return delta;
        }
        public static string Soluzioni(double a, double b, double c)
        {
            double delta = Delta(a, b, c);
            if (delta < 0)
            {
                return "impossibile";
            }
            
            double x1, x2;
            x1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            x2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
            return $"x1 = {x1}, x2 = {x2}";
        }
        public static string EquationDegree1(double a, double b)
        {
            if(a==0 && b==0)
            {
                return "indeterminato";
            }
            if(a!=0 && b==0)
            {
                return "impossibile";
            }
            double x = b / a;
            return $"x = {x}";
        }
    }
}
