using System;

namespace VSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            string digitadoString = Console.ReadLine();
            double digitado = Convert.ToDouble(digitadoString);
            double resultado = digitado * 30;
            Console.WriteLine(string.Format("{0} meses tem {1} dias", digitado, resultado));
        }
    }
}
