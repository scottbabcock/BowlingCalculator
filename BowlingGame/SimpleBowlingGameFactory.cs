namespace BowlingGame
{
	public abstract class SimpleBowlingGameFactory
	{
		/// <summary>Creates a simple bowling gmae.</summary>
		/// <returns>A simple bowling game.</returns>
		public abstract ISimpleBowlingGame Create();
	}
}