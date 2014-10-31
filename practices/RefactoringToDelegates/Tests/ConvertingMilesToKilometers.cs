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
			const double miles = 1;

			double kilometers = _converter.ConvertMilesToKilometers(miles);

			Assert.AreEqual(1.61, kilometers, .01);
		}

		[TestMethod]
		public void OneAndAHalfMiles()
		{
			const double miles = 1.5F;

			double kilometers = _converter.ConvertMilesToKilometers(miles);

			Assert.AreEqual(2.42, kilometers, .01);
		}

		[TestMethod]
		public void LotsOfMiles()
		{
			const double miles = 500; // I would walk 500 hundred miles... 
			var kilometers = _converter.ConvertMilesToKilometers(miles);
			Assert.AreEqual(805, kilometers);
		}
	}
}
