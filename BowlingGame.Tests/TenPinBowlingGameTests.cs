using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingCalculator.Tests
{
	[TestClass]
	public class TenPinBowlingGameTests
	{
		private SimpleBowlingGameFactory factory;

		[TestInitialize]
		public void Initialize()
		{
			factory = new TenPinBowlingGameFactory();
		}

		[TestMethod]
		public void PerfectGame()
		{
			// Arrange
			ISimpleBowlingGame game = factory.Create();

			// Act
			game.RecordFrame(10); // 1st frame
			game.RecordFrame(10); // 2nd frame
			game.RecordFrame(10); // 3rd frame
			game.RecordFrame(10); // 4th frame
			game.RecordFrame(10); // 5th frame
			game.RecordFrame(10); // 6th frame
			game.RecordFrame(10); // 7th frame
			game.RecordFrame(10); // 8th frame
			game.RecordFrame(10); // 9th frame
			game.RecordFrame(10, 10, 10); // 10th frame

			// Assert
			Assert.AreEqual(300, game.Score);
		}

		[TestMethod]
		public void EmptyGame()
		{
			// Arrange
			ISimpleBowlingGame game = factory.Create();

			// Act
			game.RecordFrame(0, 0); // 1st frame
			game.RecordFrame(0, 0); // 2nd frame
			game.RecordFrame(0, 0); // 3rd frame
			game.RecordFrame(0, 0); // 4th frame
			game.RecordFrame(0, 0); // 5th frame
			game.RecordFrame(0, 0); // 6th frame
			game.RecordFrame(0, 0); // 7th frame
			game.RecordFrame(0, 0); // 8th frame
			game.RecordFrame(0, 0); // 9th frame
			game.RecordFrame(0, 0); // 10th frame

			// Assert
			Assert.AreEqual(0, game.Score);
		}

		[TestMethod]
		public void LowGame()
		{
			// Arrange
			ISimpleBowlingGame game = factory.Create();

			// Act
			game.RecordFrame(1, 1); // 1st frame
			game.RecordFrame(1, 1); // 2nd frame
			game.RecordFrame(1, 1); // 3rd frame
			game.RecordFrame(1, 1); // 4th frame
			game.RecordFrame(1, 1); // 5th frame
			game.RecordFrame(1, 1); // 6th frame
			game.RecordFrame(1, 1); // 7th frame
			game.RecordFrame(1, 1); // 8th frame
			game.RecordFrame(1, 1); // 9th frame
			game.RecordFrame(1, 1); // 10th frame

			// Assert
			Assert.AreEqual(20, game.Score);
		}

		[TestMethod]
		public void MidGame()
		{
			// Arrange
			ISimpleBowlingGame game = factory.Create();

			// Act
			game.RecordFrame(5, 5); // 1st frame
			game.RecordFrame(5, 5); // 2nd frame
			game.RecordFrame(5, 5); // 3rd frame
			game.RecordFrame(5, 5); // 4th frame
			game.RecordFrame(5, 5); // 5th frame
			game.RecordFrame(5, 5); // 6th frame
			game.RecordFrame(5, 5); // 7th frame
			game.RecordFrame(5, 5); // 8th frame
			game.RecordFrame(5, 5); // 9th frame
			game.RecordFrame(5, 5, 5); // 10th frame

			// Assert
			Assert.AreEqual(150, game.Score);
		}
	}
}