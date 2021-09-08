using System;

namespace Voltage_Convertor_App
{
    public class ConverterBase
    {
        protected double srcValue;
    }

    public abstract class VoltageConverter : ConverterBase
    {
        public abstract double getVolts();

        public abstract double getMilliVolts();

        public abstract double getKiloVolts();
    }

    public class Volts : VoltageConverter
    {
        public Volts(double srcValue)
        {
            this.srcValue = srcValue;
        }

        public override double getVolts()
        {
            return srcValue;
        }

        public override double getMilliVolts()
        {
            return srcValue * 1000;
        }

        public override double getKiloVolts()
        {
            return srcValue / 1000;
        }
    }

    public class MilliVolts : VoltageConverter
    {
        public MilliVolts(double srcValue)
        {
            this.srcValue = srcValue;
        }

        public override double getVolts()
        {
            return srcValue / 1000;
        }

        public override double getMilliVolts()
        {
            return srcValue;
        }

        public override double getKiloVolts()
        {
            return srcValue / (1000 * 1000); 
        }
    }

    public class KiloVolts : VoltageConverter
    {
        public KiloVolts(double srcValue)
        {
            this.srcValue = srcValue;
        }

        public override double getVolts()
        {
            return srcValue * 1000;
        }

        public override double getMilliVolts()
        {
            return srcValue * 1000 * 1000;
        }

        public override double getKiloVolts()
        {
            return srcValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Volts volts = new Volts(230);
            MilliVolts milliVolts = new MilliVolts(5000);
            KiloVolts kiloVolts = new KiloVolts(2);

            Console.WriteLine("*************");
            Console.WriteLine("Base: {0} V", volts.getVolts());
            Console.WriteLine("Converted to mV: {0}", volts.getMilliVolts());
            Console.WriteLine("Converted to kV: {0}", volts.getKiloVolts());
            Console.WriteLine("*************");
            Console.WriteLine("Base: {0} mV", milliVolts.getMilliVolts());
            Console.WriteLine("Converted to V: {0}", milliVolts.getVolts());
            Console.WriteLine("Converted to kV: {0}", milliVolts.getKiloVolts());
            Console.WriteLine("*************");
            Console.WriteLine("Base: {0} kV", kiloVolts.getKiloVolts());
            Console.WriteLine("Converted to mV: {0}", kiloVolts.getMilliVolts());
            Console.WriteLine("Converted to V: {0}", kiloVolts.getVolts());
        }
    }
}
