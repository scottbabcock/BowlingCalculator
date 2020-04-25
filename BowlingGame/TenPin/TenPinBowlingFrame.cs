using System.Collections.Generic;
using System.Linq;

namespace BowlingCalculator.TenPin
{
	public class TenPinBowlingFrame : ISimpleBowlingFrame
	{
		private readonly List<int> _Throws = new List<int>();
		private readonly List<int> _FutureThrows = new List<int>();

		/// <summary>Gets a value indicating if the frame is a strike.</summary>
		public bool IsStrke => _Throws.Count == 1 && _Throws[0] == 10;

		/// <summary>Gets a value indicating if the frame is a spare.</summary>
		public bool IsSpare => _Throws.Count == 2 && _Throws.Sum() == 10;

		/// <summary>The current frame score.</summary>
		public int? Score => _Throws?.Sum() + (IsStrke ? _FutureThrows.Take(2).Sum() : (IsSpare ? _FutureThrows.Take(1).Sum() : 0));

		/// <summary>Records the ball throws.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordThrows(params int[] throws)
		{
			if (_Throws.Count == 0)
			{
				_Throws.AddRange(throws);
			}
			else
			{
				_FutureThrows.AddRange(throws);
			}
		}
	}
}