namespace RideShare.Models
{
	public abstract class Vehicle
	{
		public Vehicle(){} // Empty constructor
		public double DistanceAwayInKm { get; set; }
		public virtual void ReportDistance()
		{
			Console.WriteLine($"There is a vehicle {DistanceAwayInKm}km away.");
		}

		public List<Vehicle> vehicles = new List<Vehicle>{};
    
        public void ListOfVehicles()
        {
            foreach (var Vehicle in vehicles)
            {
            Vehicle.ReportDistance();
            }
        }
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);    	
        }
	}
}