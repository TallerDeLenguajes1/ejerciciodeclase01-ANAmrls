using System;

namespace adivinar_el_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num_usuario, num_rand;
            string num;

            num_rand = random.Next(0, 101);

            try
            {
                do
                {
                    Console.WriteLine("Adivine el numero entre 0 y 100\n");
                    num = Console.ReadLine();

                } while (!int.TryParse(num, out num_usuario) || num_usuario < 0 || num_usuario > 100);

                while (num_rand != num_usuario)
                {
                    if (num_usuario < num_rand)
                    {
                        Console.WriteLine("El numero es mas grande\n");
                    }
                    else
                    {
                        Console.WriteLine("El numero es mas chico\n");
                    }

                    num = Console.ReadLine();

                    if (!int.TryParse(num, out num_usuario) || num_usuario < 0 || num_usuario > 100)
                    {
                        do
                        {
                            Console.WriteLine("Debe ingresar un NUMERO entre 0 y 100\n");
                            num = Console.ReadLine();
                        } while (!int.TryParse(num, out num_usuario) || num_usuario < 0 || num_usuario > 100);

                    }
                }

                Console.WriteLine("Felicidades adivinaste el numero\n");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Valor fuera de los rangos esperados\n");
            }
            
        }
    }
}
