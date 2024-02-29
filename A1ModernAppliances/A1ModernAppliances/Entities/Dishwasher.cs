using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Entities
{
    internal class Dishwasher : Appliance
    {
        public const string SoundRatingQuietest = "Qt";
        
        public const string SoundRatingQuieter = "Qr";
       
        public const string SoundRatingQuiet = "Qu";
        
        public const string SoundRatingModerate = "M";

        private string _feature;
        
        private string _soundRating;

        public string Feature
        {
            get
            {
                return _feature;
            }
        }

        public string SoundRating
        {
            get
            {
                return _soundRating;
            }
        }

        public string SoundRatingDisplay
        {
            get
            {
                switch (_soundRating)
                {
                    case SoundRatingQuietest:
                        return "Quietest";
                    case SoundRatingQuieter:
                        return "Quieter";
                    case SoundRatingQuiet:
                        return "Quiet";
                    case SoundRatingModerate:
                        return "Moderate";
                    default:
                        return "(Unknown)";
                }
            }
        }

        public Dishwasher(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, string feature, string soundRating) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this._feature = feature;
            this._soundRating = soundRating;
        }

        public override string FormatForFile()
        {
            string commonFormatted = base.FormatForFile();
            string formatted = string.Join(';', commonFormatted, Feature, SoundRating);

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
                string.Format("Feature: {0}", Feature) + "\n" +
                string.Format("Sound Rating: {0}", SoundRatingDisplay);

            return display;
        }
    }
}
