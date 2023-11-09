using System;
using DesafioDIO.Models;
// Coloca o encoding para UTF8 para exibir acentuação
// Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace DesafioDIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal prize=0;
            decimal prize_hour =0;

            System.Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial:"); 
            prize = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            prize_hour = Convert.ToDecimal(Console.ReadLine());

            Parking pp = new Parking(prize, prize_hour);

            int op=0;
            bool showMenu=true;

            while(showMenu)
            {
                // Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Add a new Car");
                Console.WriteLine("2 - Remove vehicle");
                Console.WriteLine("3 - List all vehicle");
                Console.WriteLine("4 - Leave");

                op = Convert.ToInt16(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        pp.AddCars();
                    break;

                    case 2:
                        pp.DeleteCar();
                    break;

                    case 3:
                        pp.ListAllVehicle();
                    break;

                    case 4:
                        showMenu = false;
                    break;

                    default:
                        System.Console.WriteLine("Invalid option");
                    break;
                }

                // Console.WriteLine("Pressione uma tecla para continuar");
                // Console.ReadLine();
            }
            System.Console.WriteLine("Program is done");
        }
    }
}