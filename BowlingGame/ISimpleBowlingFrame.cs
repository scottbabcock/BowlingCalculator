namespace BowlingGame
{
	public interface ISimpleBowlingFrame
	{
		/// <summary>The current frame score.</summary>
		int? Score { get; }

		/// <summary>Records the ball throws.</summary>s
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		void RecordThrows(params int[] throws);
	}
}