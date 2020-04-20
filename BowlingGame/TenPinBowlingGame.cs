using System;

namespace BowlingGame
{
	public class TenPinBowlingGame : ISimpleBowlingGame
	{
		/// <summary>The current game score.</summary>
		public int Score => throw new NotImplementedException();

		/// <summary>Called when a player completes a frame.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordFrame(params int[] throws)
		{
			throw new NotImplementedException();
		}
	}
}