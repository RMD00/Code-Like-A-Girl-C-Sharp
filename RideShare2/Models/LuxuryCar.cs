namespace RideShare2.Models
{
	public class LuxuryCar : Vehicle
	{
		public LuxuryCar(){} // Empty constructor
		public override void ReportDistance()
		{
			Console.WriteLine($"You're in for a smooth ride! There is a luxury vehicle {DistanceAwayInKm}km away.");
		}
	}
}