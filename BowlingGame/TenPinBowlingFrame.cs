using System.Linq;

namespace BowlingGame
{
	public class TenPinBowlingFrame : ISimpleBowlingFrame
	{
		private int[] _throws;

		/// <summary>The current frame score.</summary>
		public int Score => _throws.Sum();

		/// <summary>Records the ball throws.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordThrows(params int[] throws)
		{
			_throws = throws;
		}
	}
}