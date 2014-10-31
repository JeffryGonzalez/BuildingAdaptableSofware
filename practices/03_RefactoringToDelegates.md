# Refactoring to Delegates

Finally, some code!

The Project `RefactoringToDelegates` in this folder is a C# Visual Studio 2012 solution that contains two projects.

* ConvertersDomain
	* A C# Class Library with a single class called "ImperialUnitsToMetricConverter".
	* It has the following public methods:
		* ConvertInchesToMillimeters
		* ConvertFeetToMeters
		* ConvertMilesToKilometers
* Tests
	* Some unit tests for the conversion domain.

Current, all but three of the tests pass. The three failing tests are in the `ConvertingYardsToMeters` test class. Please look over the other test classes, and then implement the functionality in the `ImperialUnitsToMetricConverter' class that is implicit in the names of the failing test methods.

*Then* we have a requirement change that will impact many of the tests (and the `ImperialUnitsToMetricConverter' class). We want all results from conversions to return a rounded double precision number. The results should be rounded to three (3) or fewer decimal places.
* Please remove all the `delta` arguments in the assertions
	* `Assert.AreEqual(25.4, mm, .01); // the third argument is a delta - how close does the float have to be. Comparing floats for equality is bad. See http://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html`
	* Here the `.01` should be removed.
	* Have the methods return rounded values.
	* Correct the test assertions (verifying independently that the results are correct) with the new results.


*Then* See if you can refactor the `ImperialUnitsTometricConverter` class.
## Goals
* Remove the enumerated constant
* Remove the conditional (`switch`) statement
* Centralize the rounding of the results