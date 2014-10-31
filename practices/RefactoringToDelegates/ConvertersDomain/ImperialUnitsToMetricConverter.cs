using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertersDomain
{
	public class ImperialUnitsToMetricConverter
	{
		private enum ImperialUnits
		{
			Inches,
			Feet,
			Miles
		}

		private double Convert(double measure, ImperialUnits unit)
		{

			switch (unit)
			{
				case ImperialUnits.Feet:
					return measure*0.305;
					break;
				case ImperialUnits.Inches:
					return measure*25.4;
					break;
				case ImperialUnits.Miles:
					return measure*1.61;
				default:
					throw new ArgumentException();
			}
		}
	
		public double ConvertInchesToMillimeters(double inches)
		{
			return Convert(inches, ImperialUnits.Inches);
		}

		public double ConvertFeetToMeters(double feet)
		{
			return Convert(feet, ImperialUnits.Feet);
		}

		public double ConvertMilesToKilometers(double miles)
		{
			return Convert(miles, ImperialUnits.Miles);
		}
	}
}
