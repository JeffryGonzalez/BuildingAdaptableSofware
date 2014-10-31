using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class ConvertingFeetToMeters : Conversions
	{
		[TestMethod]
		public void OneFoot()
		{
			const float feet = 1;

			float meters = _converter.ConvertFeetToMeters(feet);

			Assert.AreEqual(.31F, meters,.01);
		}

		[TestMethod]
		public void OnePointFiveFeetInMeters()
		{
			const float feet = 1.5F;

			var meters = _converter.ConvertFeetToMeters(feet);

			Assert.AreEqual(0.46F, meters, .01);
		}

		[TestMethod]
		public void BigFeet() // Ha!
		{
			const float feet = 182.3F;

			var meters = _converter.ConvertFeetToMeters(feet);

			Assert.AreEqual(55.60F, meters, .01);
		}
	}
}