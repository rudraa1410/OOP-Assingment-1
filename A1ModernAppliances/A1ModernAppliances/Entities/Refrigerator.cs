using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    internal class Refrigerator : Appliance
    {
        private readonly short _doors;
      
        private readonly int _width;
        
        private readonly int _height;

        public short Doors
        {
            get { return _doors; }
        }
        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int NumberOfDoors { get; internal set; }

        public Refrigerator(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, short doors, int width, int height) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._doors = doors;
            this._width = width;
            this._height = height;
        }

        public override string FormatForFile()
        {
            string commonFormatted = base.FormatForFile();
            string formatted = string.Join(';', commonFormatted, Doors, Width, Height);

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
                string.Format("Doors: {0}", Doors) + "\n" +
                string.Format("Width: {0}", Width) + "\n" +
                string.Format("Height: {0}", Height);

                return display;
        }
    }
}
