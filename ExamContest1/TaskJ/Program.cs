using System;
using System.Linq.Expressions;
using System.Text;

partial class Program
{
    static string expr = "";
    static int Babah(ref int pos)
    {
        if (expr[pos] == '(')
        {
            ++pos;
            int leftop = Babah(ref pos);
            if (pos >= expr.Length)
            {
                return leftop;
            }
            if (expr[pos] == '*')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop * rightop;
            }
            else if (expr[pos] == '/')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop / rightop;
            }
            else if (expr[pos] == '+')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop + rightop;
            }
            else if (expr[pos] == '-')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop - rightop;
            }
            else if (expr[pos] == ')')
            {
                ++pos;
                return leftop;
            }
        }
        else
        {
            int leftop;
            StringBuilder str = new StringBuilder("0");
            while (pos < expr.Length && char.IsDigit(expr[pos]))
            {
                str.Append(expr[pos++]);
            }
            leftop = int.Parse(str.ToString());
            if (pos >= expr.Length)
            {
                return leftop;
            }
            if (expr[pos] == '*')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop * rightop;
            }
            else if (expr[pos] == '/')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop / rightop;
            }
            else if (expr[pos] == '+')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop + rightop;
            }
            else if (expr[pos] == '-')
            {
                ++pos;
                int rightop = Babah(ref pos);
                return leftop - rightop;
            }
            else if (expr[pos] == ')')
            {
                ++pos;
                return leftop;
            }
        }
        return 0;
    }
    public static void Main(string[] args)
    {
        expr = Console.ReadLine();
        int pos = 0;
        int result = Babah(ref pos);
        Console.WriteLine(result);
    }
}