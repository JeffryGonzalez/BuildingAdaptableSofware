using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class ConvertingInchesToMilllimeters : Conversions
	{
		[TestMethod]
		public void Example1Inch()
		{
			const double inches = 1;

			double mm = _converter.ConvertInchesToMillimeters(inches);

			Assert.AreEqual(25.4, mm, .01); // the third argument is a delta - how close does the float have to be. Comparing floats for equality is bad. See http://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html

		}

		[TestMethod]
		public void Example1point5Inches()
		{
			const double inches = 1.5;

			var mm = _converter.ConvertInchesToMillimeters(inches);

			Assert.AreEqual(38.09, mm, .01);

		}

		[TestMethod]
		public void BigInches()
		{
			const double inches = 128.385f;

			var mm = _converter.ConvertInchesToMillimeters(inches);

			Assert.AreEqual(3260.98, mm, .01);
		}
		
	}
}