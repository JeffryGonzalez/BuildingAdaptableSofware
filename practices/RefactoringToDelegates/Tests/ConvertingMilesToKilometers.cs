using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class ConvertingMilesToKilometers : Conversions
	{
		[TestMethod]
		public void OneMile()
		{
			const float miles = 1;

			float kilometers = _converter.ConvertMilesToKilometers(miles);

			Assert.AreEqual(1.61F, kilometers, .01);
		}

		[TestMethod]
		public void OneAndAHalfMiles()
		{
			const float miles = 1.5F;

			float kilometers = _converter.ConvertMilesToKilometers(miles);

			Assert.AreEqual(2.42, kilometers, .01);
		}
	}
}
