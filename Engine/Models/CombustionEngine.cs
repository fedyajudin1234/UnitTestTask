using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
	public class CombustionEngine: Engine
	{
		public override double EnginePower { get; set; }
		public override double MomentOfInertia { get; set; }
		public override int Torque { get; set; }
		public override double SpeedOfRotationOfTheCrankshaft { get; set; }
		public override double OverheatTemperature { get; set; }
		public override double CoefficientOfHeatingSpeedOnTorque { get; set; }
		public override double CoefficientOfHeatingSpeedOnCrankshaft { get; set; }
		public override double CoefficientOfCoolingRateOfEngineAndEnvironment { get; set; }
		public override double Boost { get; set; }
		public override double EngineHeatingSpeed { get; set; }
		public override double EngineCoolingRate { get; set; }
		public override double OutsideTemperature { get; set; }
		public override double EngineTemperature { get; set; }
		public override double Time(double OutsideTemperature, double MomentOfInertia, int Torque,
			double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque,
			double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment)
		{
			DateTime startTime = DateTime.Now;
			Start(OutsideTemperature, MomentOfInertia, Torque,
			SpeedOfRotationOfTheCrankshaft, OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,
			CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment);
			while (EngineTemperature < OverheatTemperature)
			{
				this.EngineTemperature += (EngineHeatingSpeed - EngineCoolingRate);
			}
			DateTime finishTime = DateTime.Now;
			TimeSpan timeCost = finishTime - startTime;
			return timeCost.Milliseconds;
		}
		public override void Start(double OutsideTemperature, double MomentOfInertia, int Torque,
			double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque,
			double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment)
		{
			this.OutsideTemperature = OutsideTemperature;
			this.EngineTemperature = OutsideTemperature;
			this.MomentOfInertia = MomentOfInertia;
			this.Torque = Torque;
			this.SpeedOfRotationOfTheCrankshaft = SpeedOfRotationOfTheCrankshaft;
			this.OverheatTemperature = OverheatTemperature;
			this.CoefficientOfHeatingSpeedOnTorque = CoefficientOfHeatingSpeedOnTorque;
			this.CoefficientOfHeatingSpeedOnCrankshaft = CoefficientOfHeatingSpeedOnCrankshaft;
			this.CoefficientOfCoolingRateOfEngineAndEnvironment = CoefficientOfCoolingRateOfEngineAndEnvironment;
			this.EngineHeatingSpeed = Torque * CoefficientOfHeatingSpeedOnTorque + Math.Pow(SpeedOfRotationOfTheCrankshaft, 2) * CoefficientOfHeatingSpeedOnCrankshaft;
			this.Boost = Torque / MomentOfInertia;
			this.EngineCoolingRate = CoefficientOfCoolingRateOfEngineAndEnvironment * (OutsideTemperature - EngineTemperature);
			this.EnginePower = (Torque * SpeedOfRotationOfTheCrankshaft) / 1000;
		}

		public override double Power(double OutsideTemperature, double MomentOfInertia, int Torque, double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque, double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment)
		{
			Start(OutsideTemperature, MomentOfInertia, Torque,
			SpeedOfRotationOfTheCrankshaft, OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,
			CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment);
			//Console.WriteLine($"Максимальная мощьность: {EnginePower} при ускорении {Boost}");
			return EnginePower;

		}

		public override double Boost_Function(double OutsideTemperature, double MomentOfInertia, int Torque, double SpeedOfRotationOfTheCrankshaft, double OverheatTemperature, double CoefficientOfHeatingSpeedOnTorque, double CoefficientOfHeatingSpeedOnCrankshaft, double CoefficientOfCoolingRateOfEngineAndEnvironment)
		{
			Start(OutsideTemperature, MomentOfInertia, Torque,
			SpeedOfRotationOfTheCrankshaft, OverheatTemperature, CoefficientOfHeatingSpeedOnTorque,
			CoefficientOfHeatingSpeedOnCrankshaft, CoefficientOfCoolingRateOfEngineAndEnvironment);
			return Boost;
		}
	}
}
