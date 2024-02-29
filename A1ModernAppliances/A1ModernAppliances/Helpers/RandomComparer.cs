using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Helpers
{
    internal class RandomComparer : IComparer<Appliance>
    {
        private readonly Random _random = new Random();

        public int Compare(Appliance x, Appliance y)
        {
            return _random.Next(-1, 2);
        }
    }
}
