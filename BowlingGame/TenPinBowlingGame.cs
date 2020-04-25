using System.Collections.Generic;
using System.Linq;

namespace BowlingCalculator
{
	public class TenPinBowlingGame : ISimpleBowlingGame
	{
		private List<ISimpleBowlingFrame> _frames = new List<ISimpleBowlingFrame>();
		private int _CurrentIndex = 0;

		public TenPinBowlingGame()
		{
			for (int i = 0; i < 9; i++)
			{
				_frames.Add(new TenPinBowlingFrame());
			}
			_frames.Add(new TenPinBowlingFinalFrame());
		}

		/// <summary>The current game score.</summary>
		public int Score => _frames.Sum(f => f.Score ?? 0);

		/// <summary>Called when a player completes a frame.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordFrame(params int[] throws)
		{
			for (int i = _CurrentIndex; i > -1; i--)
			{
				_frames[i].RecordThrows(throws);
			}
			_CurrentIndex++;
		}
	}
}