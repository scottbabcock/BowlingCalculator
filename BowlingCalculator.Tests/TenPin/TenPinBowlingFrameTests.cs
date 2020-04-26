using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingCalculator.TenPin.Tests
{
	[TestClass]
	public class TenPinBowlingFrameTests
	{
		[TestMethod]
		public void NoThrows()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act

			// Assert
			Assert.IsFalse(frame.IsSpare);
			Assert.IsFalse(frame.IsStrke);
			Assert.AreEqual(null, frame.Score);
		}

		[TestMethod]
		public void OneThrow()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act
			frame.RecordThrows(6);

			// Assert
			Assert.IsFalse(frame.IsSpare);
			Assert.IsFalse(frame.IsStrke);
			Assert.AreEqual(null, frame.Score);
		}

		[TestMethod]
		public void StrikeNoFutureThrows()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act
			frame.RecordThrows(10);

			// Assert
			Assert.IsFalse(frame.IsSpare);
			Assert.IsTrue(frame.IsStrke);
			Assert.AreEqual(null, frame.Score);
		}

		[TestMethod]
		public void StrikeWithFutureThrows()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act
			frame.RecordThrows(10);
			frame.RecordThrows(3, 4);

			// Assert
			Assert.AreEqual(17, frame.Score);
		}

		[TestMethod]
		public void SpareNoFutureThrows()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act
			frame.RecordThrows(7, 3);

			// Assert
			Assert.IsTrue(frame.IsSpare);
			Assert.IsFalse(frame.IsStrke);
			Assert.AreEqual(null, frame.Score);
		}

		[TestMethod]
		public void SpareWithFutureThrows()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act
			frame.RecordThrows(7, 3);
			frame.RecordThrows(4);

			// Assert
			Assert.IsTrue(frame.IsSpare);
			Assert.IsFalse(frame.IsStrke);
			Assert.AreEqual(14, frame.Score);
		}

		[TestMethod]
		public void TwoThrowsScore()
		{
			// Arrange
			TenPinBowlingFrame frame = new TenPinBowlingFrame();

			// Act
			frame.RecordThrows(7, 2);

			// Assert
			Assert.IsFalse(frame.IsSpare);
			Assert.IsFalse(frame.IsStrke);
			Assert.AreEqual(9, frame.Score);
		}
	}
}