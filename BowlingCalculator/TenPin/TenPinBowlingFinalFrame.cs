using System.Collections.Generic;
using System.Linq;

namespace BowlingCalculator.TenPin
{
	public class TenPinBowlingFinalFrame : ISimpleBowlingFrame
	{
		private readonly List<int> _Throws = new List<int>();

		/// <summary>The current frame score.</summary>
		public int? Score => _Throws?.Sum();

		/// <summary>Records the ball throws.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordThrows(params int[] throws) => _Throws.AddRange(throws);
	}
}