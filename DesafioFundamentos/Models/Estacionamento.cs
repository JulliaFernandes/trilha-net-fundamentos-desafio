namespace DesafioDIO.Models
{
    public class Parking
    {
        private decimal prize=0;
        private decimal prize_hour=0; 
        private List<string> licence_plate = new List<string>();


        public Parking (decimal _prize, decimal _prize_hour)
        {
            this.prize = _prize;
            this.prize_hour = _prize_hour;
        }

        public void AddCars()
        {
            System.Console.WriteLine("What is the license plate: ");
            string _licence_plate = Convert.ToString(Console.ReadLine()) ?? string.Empty;
            _licence_plate = _licence_plate.ToUpper();
            System.Console.WriteLine(_licence_plate);
            this.licence_plate.Add(_licence_plate);
        }

        public void DeleteCar()
        {
            System.Console.WriteLine("What is the license plate to delete:");
            string _licence_plate = Convert.ToString(Console.ReadLine()) ?? string.Empty;

            if(licence_plate.Any(x =>x.ToUpper() == _licence_plate.ToUpper()))
            {
                System.Console.WriteLine("How many hours you were parked?");
                int hours = Convert.ToInt32(Console.ReadLine());

                decimal total = 0;

                total = (hours * prize_hour) + prize;

                licence_plate.Remove(_licence_plate);

                System.Console.WriteLine($"Vehicle {_licence_plate.ToUpper()} was removed and the total are: ${total}");
            }
            else
            {
                System.Console.WriteLine("This licence plate wasn't in this parking");
            }


        }

        public void ListAllVehicle()
        {   
            //Olha se ha veiculos no estacionamento
            if(licence_plate.Any())
            {
                foreach(string car in licence_plate){
                    System.Console.WriteLine($">CAR: {car}");
                }
            }
            else
            {
                System.Console.WriteLine("The Parking is empty");
            }
        }



    }
}