namespace Set1Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti 2 numere: ");
            string[] numere = Console.ReadLine().Split(' ');
            int a = int.Parse(numere[0]);
            int b = int.Parse(numere[1]);
            int aOriginal = a;//salvam valorile initiale ale lui a si b
            int bOriginal = b;

            //cel mai mare div comun
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            int cmmdc = a;//sau b, ca sunt egale
            Console.WriteLine($"Cel mai mare divizor comun al numerelor {aOriginal} si {bOriginal} este {cmmdc}");

            int m = aOriginal; 
                int n = bOriginal;
                while (m != n)
                {
                    if (m < n)
                    {
                        m = m + aOriginal;
                    }
                    else
                    {
                        n = n + bOriginal;
                    }
                }
                Console.WriteLine($"Cel mai mic multiplu comun dintre {aOriginal} si {bOriginal} este {m}");
            
        }
    }
}
