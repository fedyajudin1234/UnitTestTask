using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTests
{
	[TestClass]
	public class EngineTester
	{
		[TestMethod]
		public void Time()
		{
			//Arrenge 

			CombustionEngine combustionEngine = new CombustionEngine();

			string outsideTemperature = null;

			bool isOutsideTemperature = true;

			double OutsideTemperature = 5;

			double MomentOfInertia = 10;

			int[] Torque = { 20, 75, 100, 105, 75, 0 };

			int[] SpeedOfRotationOfTheCrankshaft = { 0, 75, 150, 200, 250, 300 };

			double OverheatTemperature = 110;

			double CoefficientOfHeatingSpeedOnTorque = 0.01;

			double CoefficientOfHeatingSpeedOnCrankshaft = 0.0001;

			double CoefficientOfCoolingRateOfEngineAndEnvironment = 0.1;

			List<double> predictedTime = new List<double>();

			double predictableTime = 0;



			////Act 

			//Console.WriteLine("Добро пожаловать в меню моделяции работы двигателя!");

			//Console.Write("Введите значение температуры на улице: ");

			//outsideTemperature = Console.ReadLine();

			//isOutsideTemperature = Double.TryParse(outsideTemperature, out double value1);

			for (int i = 0; i < Torque.Length; i++)

			{

				predictedTime.Add(combustionEngine.Time(OutsideTemperature, MomentOfInertia, Torque[i],

		SpeedOfRotationOfTheCrankshaft[i], OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,

		CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment));
            }



			////Assert 

			foreach (var value in predictedTime)
			{
				Console.WriteLine($"Время: {value}");
				//if(value != null)
				//{
				//	Assert.AreEqual(predictableTime, predictedTime, "Test error");
				//}
			}
		}
		[TestMethod]
		public void Power()
		{
			//Arrenge 

			CombustionEngine combustionEngine = new CombustionEngine();

			string outsideTemperature = null;

			bool isOutsideTemperature = true;

			double OutsideTemperature = 5;

			double MomentOfInertia = 10;

			int[] Torque = { 20, 75, 100, 105, 75, 0 };

			int[] SpeedOfRotationOfTheCrankshaft = { 0, 75, 150, 200, 250, 300 };

			double OverheatTemperature = 110;

			double CoefficientOfHeatingSpeedOnTorque = 0.01;

			double CoefficientOfHeatingSpeedOnCrankshaft = 0.0001;

			double CoefficientOfCoolingRateOfEngineAndEnvironment = 0.1;

			List<double> predictedPower = new List<double>();

			double predictablePower = 5.625;



			////Act
			for (int i = 0; i < Torque.Length; i++)

			{

				predictedPower.Add(combustionEngine.Power(OutsideTemperature, MomentOfInertia, Torque[i],

		SpeedOfRotationOfTheCrankshaft[i], OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,

		CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment));

			}



			////Assert 
			foreach(var value in predictedPower)
			{
                Console.WriteLine($"Мощность: {value}");
            }
		}

		[TestMethod]
		public void Boost()
		{
			//Arrenge 

			CombustionEngine combustionEngine = new CombustionEngine();

			string outsideTemperature = null;

			bool isOutsideTemperature = true;

			double OutsideTemperature = 5;

			double MomentOfInertia = 10;

			int[] Torque = { 20, 75, 100, 105, 75, 0 };

			int[] SpeedOfRotationOfTheCrankshaft = { 0, 75, 150, 200, 250, 300 };

			double OverheatTemperature = 110;

			double CoefficientOfHeatingSpeedOnTorque = 0.01;

			double CoefficientOfHeatingSpeedOnCrankshaft = 0.0001;

			double CoefficientOfCoolingRateOfEngineAndEnvironment = 0.1;

			List<double> predictedBoost = new List<double>();

			double predictableBoost = 2;



			////Act
			for (int i = 0; i < Torque.Length; i++)

			{

				predictedBoost.Add(combustionEngine.Boost_Function(OutsideTemperature, MomentOfInertia, Torque[i],

		SpeedOfRotationOfTheCrankshaft[i], OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,

		CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment));

			}
			//if (isOutsideTemperature)

			//{

			//	//OutsideTemperature = Double.Parse(outsideTemperature);

			//	for (int i = 0; i < Torque.Length; i++)

			//	{

			//		predictedPower.Add(combustionEngine.Power(OutsideTemperature, MomentOfInertia, Torque[i],

			//SpeedOfRotationOfTheCrankshaft[i], OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,

			//CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment)); 

			//	}

			//}



			////Assert 
			foreach (var value in predictedBoost)
			{
				Console.WriteLine($"Ускорение: {value}");
				//if (value != null)
				//{
				//	Assert.AreEqual(predictableBoost, value, "Test error");
				//}
			}
		}
	}
}
