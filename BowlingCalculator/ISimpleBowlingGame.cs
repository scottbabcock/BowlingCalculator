namespace BowlingCalculator
{
	public interface ISimpleBowlingGame
	{
		/// <summary>The current game score.</summary>
		int Score { get; }

		/// <summary>Called when a player completes a frame.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		void RecordFrame(params int[] throws);
	}
}