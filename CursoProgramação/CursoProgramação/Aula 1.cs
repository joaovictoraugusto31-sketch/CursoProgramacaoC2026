
namespace CursoProgramação
{
    public class Aula_1
    {
        //Método Somar
        public void Soma()
        {
            int valor1;
            int valor2;


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor2)");
            valor2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Total: {valor2 + valor2}");


        }

        public void Multiplicar()
        {

            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 * valor2}");

        }

        //Subtrair
        public void Subtrair()
        {

            int valor1;
            int valor2;


            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 - valor2}");



        }

        //Divisão
        public void Dividir()
        {

            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 / valor2}");
        }

    }
}


