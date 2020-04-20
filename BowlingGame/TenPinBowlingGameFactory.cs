namespace BowlingGame
{
	public class TenPinBowlingGameFactory : SimpleBowlingGameFactory
	{
		/// <summary>Creates a simple bowling gmae.</summary>
		/// <returns>A simple bowling game.</returns>
		public override ISimpleBowlingGame Create()
		{
			return new TenPinBowlingGame();
		}
	}
}