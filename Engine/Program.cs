using Engine.Models;

namespace Engine
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в меню моделяции работы двигателя!");
			Console.Write("Введите значение температуры на улице: ");
			string outsideTemperature = Console.ReadLine();
			bool isOutsideTemperature = Double.TryParse(outsideTemperature, out double value1);
			if (isOutsideTemperature)
			{
				double OutsideTemperature = Double.Parse(outsideTemperature);
				double EngineTemperature = OutsideTemperature;
				Console.Write("Введите значение момента инерции двигателя: ");
				string momentOfInertia = Console.ReadLine();
				bool isMomentOfInsertia = Double.TryParse(outsideTemperature, out double value2);
				if (isMomentOfInsertia)
				{
					double MomentOfInertia = Double.Parse(momentOfInertia);
					Console.Write("Введите крутящий момент: ");
					string torque = Console.ReadLine();
					bool isTorque = Int32.TryParse(outsideTemperature, out int value3);
					if (isTorque)
					{
						int Torque = Int32.Parse(torque);
						Console.Write("Введите скорость вращения коленвала: ");
						string speedOfRotationOfTheCrankshaft = Console.ReadLine();
						bool isSpeedOfRotationOfTheCrankshaft = Double.TryParse(speedOfRotationOfTheCrankshaft, out double value4);
						if (isSpeedOfRotationOfTheCrankshaft)
						{
							double SpeedOfRotationOfTheCrankshaft = Double.Parse(speedOfRotationOfTheCrankshaft);
							Console.Write("Введите температуру перегрева: ");
							string overheatTemperature = Console.ReadLine();
							bool isOverheatTemperature = Double.TryParse(overheatTemperature, out double value5);
							if (isOverheatTemperature)
							{
								double OverheatTemperature = Double.Parse(overheatTemperature);
								Console.Write("Введите коэффициент зависимости скорости нагрева от крутящего момента: ");
								string coefficientOfHeatingSpeedOnTorque = Console.ReadLine();
								bool isCoefficientOfHeatingSpeedOnTorque = Double.TryParse(coefficientOfHeatingSpeedOnTorque, out double value6);
								if (isCoefficientOfHeatingSpeedOnTorque)
								{
									double CoefficientOfHeatingSpeedOnTorque = Double.Parse(coefficientOfHeatingSpeedOnTorque);
									Console.Write("Введите коэффициент зависимости скорости нагрева от скорости вращения коленвала: ");
									string сoefficientOfHeatingSpeedOnCrankshaft = Console.ReadLine();
									bool isCoefficientOfHeatingSpeedOnCrankshaft = Double.TryParse(сoefficientOfHeatingSpeedOnCrankshaft, out double value7);
									if (isCoefficientOfHeatingSpeedOnCrankshaft)
									{
										double CoefficientOfHeatingSpeedOnCrankshaft = Double.Parse(сoefficientOfHeatingSpeedOnCrankshaft);
										Console.Write("Введите коэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды: ");
										string coefficientOfCoolingRateOfEngineAndEnvironment = Console.ReadLine();
										bool isCoefficientOfCoolingRateOfEngineAndEnvironment = Double.TryParse(coefficientOfCoolingRateOfEngineAndEnvironment, out double value8);
										if (isCoefficientOfCoolingRateOfEngineAndEnvironment)
										{
											double CoefficientOfCoolingRateOfEngineAndEnvironment = Double.Parse(coefficientOfCoolingRateOfEngineAndEnvironment); ;
											CoefficientOfHeatingSpeedOnCrankshaft = Double.Parse(coefficientOfCoolingRateOfEngineAndEnvironment);
											CombustionEngine combustionEngine = new CombustionEngine();
											Console.WriteLine("Время: " + combustionEngine.Time(OutsideTemperature, MomentOfInertia, Torque,
			SpeedOfRotationOfTheCrankshaft, OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,
			CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment) + " миллисекунд");
                                            Console.WriteLine("Мощность двигателя: " + combustionEngine.Power(OutsideTemperature, MomentOfInertia, Torque,
			SpeedOfRotationOfTheCrankshaft, OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,
			CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment));
											Console.WriteLine("Ускорение двигателя: " + combustionEngine.Boost_Function(OutsideTemperature, MomentOfInertia, Torque,
			SpeedOfRotationOfTheCrankshaft, OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,
			CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment));
										}

									}
								}
							}
						}
					}
				}
			}
		}
	}
}