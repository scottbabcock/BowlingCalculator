using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
	public class TenPinBowlingGame : ISimpleBowlingGame
	{
		private readonly IEnumerator<ISimpleBowlingFrame> _Enumerator;

		public TenPinBowlingGame()
		{
			Frames = Enumerable.Repeat<ISimpleBowlingFrame>(new TenPinBowlingFrame(), 9).ToList();
			Frames.Add(new TenPinBowlingFinalFrame());
			_Enumerator = Frames.GetEnumerator();
		}

		/// <summary>The current game score.</summary>
		public int Score => Frames.Sum(f => f.Score);

		public List<ISimpleBowlingFrame> Frames { get; }

		/// <summary>Called when a player completes a frame.</summary>
		/// <param name="throws">Number of pins knocked down by each throw.</param>
		public void RecordFrame(params int[] throws)
		{
			if (_Enumerator.MoveNext())
			{
				_Enumerator.Current.RecordThrows(throws);
			}
		}
	}
}