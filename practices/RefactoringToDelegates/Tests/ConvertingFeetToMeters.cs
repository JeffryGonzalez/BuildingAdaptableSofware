using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class ConvertingFeetToMeters : Conversions
	{
		[TestMethod]
		public void OneFoot()
		{
			const double feet = 1;

			double meters = _converter.ConvertFeetToMeters(feet);

			Assert.AreEqual(.31, meters,.01);
		}

		[TestMethod]
		public void OnePointFiveFeetInMeters()
		{
			const double feet = 1.5;

			var meters = _converter.ConvertFeetToMeters(feet);

			Assert.AreEqual(0.46, meters, .01);
		}

		[TestMethod]
		public void BigFeet() // Ha!
		{
			const double feet = 182.3F;

			var meters = _converter.ConvertFeetToMeters(feet);

			Assert.AreEqual(55.60, meters, .01);
		}
	}
}