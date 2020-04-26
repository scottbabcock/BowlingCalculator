using System.Collections.Generic;
using System.Linq;

namespace BowlingCalculator.TenPin
{
	public class TenPinBowlingGame : ISimpleBowlingGame
	{
		private readonly List<ISimpleBowlingFrame> _Frames = new List<ISimpleBowlingFrame>();
		private int _CurrentIndex = 0;

		/// <summary>Initializes a new instance of the <see cref="TenPinBowlingGame" /> class.</summary>
		public TenPinBowlingGame()
		{
			for (int i = 0; i < 9; i++)
			{
				_Frames.Add(new TenPinBowlingFrame());
			}
			_Frames.Add(new TenPinBowlingFinalFrame());
		}

		/// <summary>The current game score.</summary>
		public int Score => _Frames.Sum(f => f.Score ?? 0);

		/// <summary>Called when a player completes a frame.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordFrame(params int[] throws)
		{
			for (int i = _CurrentIndex; i > -1; i--)
			{
				_Frames[i].RecordThrows(throws);
			}
			_CurrentIndex++;
		}
	}
}