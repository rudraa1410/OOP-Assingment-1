using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    internal class Microwave : Appliance
    {
        public const char RoomTypeKitchen = 'K';
        
        public const char RoomTypeWorkSite = 'W';

        private readonly float _capacity;
        
        private readonly char _roomType;

        public float Capacity
        {
            get { return _capacity; }
        }

        public char RoomType
        {
            get { return _roomType; }
        }

        public string RoomTypeDisplay
        {
            get
            {
                switch (_roomType)
                {
                    case RoomTypeKitchen:
                        return "Kitchen";
                    case RoomTypeWorkSite:
                        return "Work Site";
                    default:
                        return "(Unknown)";
                }
            }
        }

        public Microwave(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, float capacity, char roomType) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._capacity = capacity;
            this._roomType = roomType;
        }

        public override string FormatForFile()
        {
            string commonFormatted = base.FormatForFile();
            string formatted = string.Join(';', commonFormatted, Capacity, RoomType);

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
                string.Format("Capacity: {0}", Capacity) + "\n" +
                string.Format("Room Type: {0}", RoomTypeDisplay);

            return display;
        }
    }
}
