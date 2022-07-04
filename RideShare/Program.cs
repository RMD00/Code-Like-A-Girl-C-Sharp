using RideShare.Models;

namespace RideShare
{
    class Program
    {
        static void Main()
        {
			// Create cars, motorbikes and luxury cars in the user's vicinity
			var car1 = new Car ();
			car1.DistanceAwayInKm = 4.5;
			car1.ReportDistance();
			vehicle.AddVehicle(car1);

			var car2 = new Car (); 
			car2.DistanceAwayInKm = 1.2;
			car2.ReportDistance();
			vehicle.AddVehicle(car2);

			var luxuryCar1 = new LuxuryCar ();
			luxuryCar1.DistanceAwayInKm = 0.6;
			luxuryCar1.ReportDistance();
			vehicle.AddVehicle(luxuryCar1);
			
			var extraLargeCar1 = new ExtraLargeCar ();
			extraLargeCar1.DistanceAwayInKm = 3.0;
			extraLargeCar1.ReportDistance();
			vehicle.AddVehicle(extraLargeCar1);

			// Create a list that can hold the above cars, extra large cars and luxury cars
			// Check for nearby cars, extra large cars and luxury cars by creating a foreach loop that 
			// goes through each of the cars, motorbikes and luxury cars created and calls their ReportDistance method
			var availableVehicles = new List<availableVehicle> 
			{
				foreach (vehicle in Vehicle)
				{
					vehicle.ReportDistance();
				}
			};

        }

    }
}
