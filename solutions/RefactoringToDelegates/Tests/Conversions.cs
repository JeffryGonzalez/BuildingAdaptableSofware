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
}