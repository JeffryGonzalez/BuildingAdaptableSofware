using ConvertersDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class Conversions
	{
		protected ImperialUnitsToMetricConverter _converter;

		[TestInitialize]
		public void Setup()
		{
			_converter = new ImperialUnitsToMetricConverter();
		}
	}

	[TestClass]
	public class ConvertingYardsToMeters : Conversions
	{
		[TestMethod]
		public void OneYard()
		{
			Assert.Fail("Pending");
		}

		[TestMethod]
		public void OnePointFiveYards()
		{
			Assert.Fail("Pending");
		}

		[TestMethod]
		public void LotsOfYards()
		{
			Assert.Fail("Pending");
		}
	}
}