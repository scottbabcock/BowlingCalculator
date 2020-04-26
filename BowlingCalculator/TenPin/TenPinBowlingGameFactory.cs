namespace BowlingCalculator.TenPin
{
	public class TenPinBowlingGameFactory : SimpleBowlingGameFactory
	{
		/// <summary>Creates a simple bowling gmae.</summary>
		/// <returns>A simple bowling game.</returns>
		public override ISimpleBowlingGame Create() => new TenPinBowlingGame();
	}
}