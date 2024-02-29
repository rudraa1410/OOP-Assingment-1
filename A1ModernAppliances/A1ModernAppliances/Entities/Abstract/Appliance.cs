namespace ModernAppliances.Entities.Abstract
{
    internal abstract class Appliance
    {
        public enum ApplianceTypes
        {
            Unknown,
            Refrigerator = 1,
            Vacuum = 2,
            Microwave = 3,
            Dishwasher = 4
        }

        private readonly long _itemNumber;
        private readonly string _brand;
        private int _quantity;
        private readonly decimal _wattage;
        private readonly string _color;
        private readonly decimal _price;

        public ApplianceTypes Type
        {
            get
            {
                return DetermineApplianceTypeFromItemNumber(_itemNumber);
            }
        }

        public long ItemNumber
        {
            get
            {
                return _itemNumber;
            }
        }

        public string Brand
        {
            get { return _brand; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public decimal Wattage
        {
            get { return _wattage; }
        }

        public string Color
        {
            get { return _color;  }
        }

        public decimal Price
        {
            get { return _price; }
        }
        public bool IsAvailable
        {
            get
            {
                bool isAvailable = Quantity > 0 ? true : false;
                return isAvailable;
            }
        }

        protected Appliance(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price)
        {
            this._itemNumber = itemNumber;
            this._brand = brand;
            this._quantity = quantity;
            this._wattage = wattage;
            this._color = color;
            this._price = price;
        }

        public void Checkout()
        {
            this._quantity = this._quantity - 1;
        }

        public virtual string FormatForFile()
        {
            return string.Join(';', ItemNumber, Brand, Quantity, Wattage, Color, Price);
        }

        public static ApplianceTypes DetermineApplianceTypeFromItemNumber(long itemNumber)
        {
            string firstDigitStr = itemNumber.ToString().Substring(0, 1);
            short firstDigit = short.Parse(firstDigitStr);

            if (firstDigit == 1)
            {
                // Refrigerator
                return ApplianceTypes.Refrigerator;
            }
            else if (firstDigit == 2)
            {
                // Vacuum
                return ApplianceTypes.Vacuum;
            }
            else if (firstDigit == 3)
            {
                // Microwave
                return ApplianceTypes.Microwave;
            }
            else if (firstDigit == 4 || firstDigit == 5)
            {
                // Dishwasher
                return ApplianceTypes.Dishwasher;
            }
            else
            {
                // Unknown
                return ApplianceTypes.Unknown;
            }
        }
    }
}
