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

		private float Convert(float measure, ImperialUnits unit)
		{

			switch (unit)
			{
				case ImperialUnits.Feet:
					return measure*0.305F;
					break;
				case ImperialUnits.Inches:
					return measure*25.4F;
					break;
				case ImperialUnits.Miles:
					return measure*1.61F;
				default:
					throw new ArgumentException();
			}
		}
	
		public float ConvertInchesToMillimeters(float inches)
		{
			return Convert(inches, ImperialUnits.Inches);
		}

		public float ConvertFeetToMeters(float feet)
		{
			return Convert(feet, ImperialUnits.Feet);
		}

		public float ConvertMilesToKilometers(float miles)
		{
			return Convert(miles, ImperialUnits.Miles);
		}
	}
}
