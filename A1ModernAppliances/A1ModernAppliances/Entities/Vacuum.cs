using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    internal class Vacuum : Appliance
    {
        private readonly string _grade;
       
        private readonly short _batteryVoltage;

        public string Grade
        {
            get { return _grade; }
        }
        public short BatteryVoltage
        {
            get { return _batteryVoltage; }
        }

        public int Voltage { get; internal set; }

      
        public Vacuum(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, string grade, short batteryVoltage) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._grade = grade;
            this._batteryVoltage = batteryVoltage;
        }

        public override string FormatForFile()
        {
            string commonFormatted = base.FormatForFile();
            string formatted = string.Join(';', commonFormatted, Grade, BatteryVoltage);

            return formatted;
        }

        public override string ToString()
        {
            string display =
                string.Format("Item Number: {0}", ItemNumber) + "\n" +
                string.Format("Brand: {0}", Brand) + "\n" +
                string.Format("Quantity: {0}", Quantity) + "\n" +
                string.Format("Wattage: {0}", Wattage) + "\n" +
                string.Format("Color: {0}", Color) + "\n" +
                string.Format("Price: {0}", Price) + "\n" +
                string.Format("Grade: {0}", Grade) + "\n" +
                string.Format("Battery Voltage: {0}", BatteryVoltage);

            return display;
        }
    }
}
