namespace RideShare.Models
{
	public class LuxuryCar : Vehicle
	{
		public override void ReportDistance()
		{
			Console.WriteLine($"You're in for a smooth ride! There is a luxury vehicle {DistanceAwayInKm}km away.");
		}
	}
}
