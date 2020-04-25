using System.Collections.Generic;
using System.Linq;

namespace BowlingCalculator
{
	public class TenPinBowlingFrame : ISimpleBowlingFrame
	{
		private List<int> _throws = new List<int>();
		private readonly List<int> _futureThrows = new List<int>();

		/// <summary>Gets a value indicating if the frame is a strike.</summary>
		public bool IsStrke => _throws.Count == 1 && _throws[0] == 10;

		/// <summary>Gets a value indicating if the frame is a spare.</summary>
		public bool IsSpare => _throws.Count == 2 && _throws.Sum() == 10;

		/// <summary>The current frame score.</summary>
		public int? Score => _throws?.Sum() + (IsStrke ? _futureThrows.Take(2).Sum() : (IsSpare ? _futureThrows.Take(1).Sum() : 0));

		/// <summary>Records the ball throws.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordThrows(params int[] throws)
		{
			if (_throws.Count == 0)
			{
				_throws.AddRange(throws);
			}
			else
			{
				_futureThrows.AddRange(throws);
			}
		}
	}
}