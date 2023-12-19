using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
	public abstract class Engine
	{
		//мощьность двигателя(N)
		public virtual double EnginePower { get; set; }
		//момент инерции(I)
		public virtual double MomentOfInertia { get; set; }
		//крутящий момент(М)
		public virtual int Torque { get; set; }
		//скорость вращения коленвала(V)
		public virtual double SpeedOfRotationOfTheCrankshaft { get; set; }
		//температура перегрева(Tпере)
		public virtual double OverheatTemperature { get; set; }
		//коэффициент зависимости скорости нагрева от крутящего момента(Hм)
		public virtual double CoefficientOfHeatingSpeedOnTorque { get; set; }
		//коэффициент зависимости скорости нагрева от скорости вращения коленвала(Hv)
		public virtual double CoefficientOfHeatingSpeedOnCrankshaft { get; set; }
		//коэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды(C)
		public virtual double CoefficientOfCoolingRateOfEngineAndEnvironment { get; set; }
		//ускорение(a)
		public virtual double Boost { get; set; }
		//скорость нагрева двигателя(Vh)
		public virtual double EngineHeatingSpeed { get; set; }
		//скорость охлаждения двигателя(Vс)
		public virtual double EngineCoolingRate { get; set; }
		//Температура среды(Tсреды)
		public virtual double OutsideTemperature { get; set; }
		//Температура двигателя(Tдвиг)
		public virtual double EngineTemperature { get; set; }
		public abstract double Time(double OutsideTemperature, double MomentOfInertia, int Torque,
			double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque,
			double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment);
		public abstract void Start(double OutsideTemperature, double MomentOfInertia, int Torque,
			double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque,
			double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment);
		public abstract double Power(double OutsideTemperature, double MomentOfInertia, int Torque,
			double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque,
			double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment);
		public abstract double Boost_Function(double OutsideTemperature, double MomentOfInertia, int Torque,
			double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque,
			double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment);
		//public abstract void Stop();
	}
}
