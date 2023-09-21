using System;
class program
{
    static void Main(string[] args)
    {
        
        
            Console.WriteLine("ingrese el numero limite :");
            string limitetxt=Console.ReadLine();
            int limite = int.Parse(limitetxt);
            Console.WriteLine("Escoja una opcion:");
            Console.WriteLine("1:Numeros pares");
            Console.WriteLine("2:Numeros impares");
            Console.WriteLine("3:Factorial");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    for (int i = 2; i <= limite; i += 2)
                    {
                        Console.Write(i + ",");
                    }
                    break;
                case 2:
                    for (int i = 1; i <= limite; i += 2)
                    {
                        Console.Write(i + ",");
                    }
                    break;
            case 3:
                long factorial = 1;
                for (int i = 2; i <= limite; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("El factorial es : " + factorial);
                break;
            default:
                Console.WriteLine("Opción no válida. ");
                break;
        }
        Console.ReadKey();
    }
}