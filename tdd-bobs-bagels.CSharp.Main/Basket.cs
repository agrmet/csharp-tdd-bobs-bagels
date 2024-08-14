


namespace csharp_tdd_bobs_bagels.Main
{
    public class Basket
    {
        private List<string> _basket = [];
        public bool Add(string bagel)
        {
            _basket.Add(bagel);
            return true;
        }

        public bool Remove(string bagel)
        {
            return _basket.Remove(bagel);
        }

        public List<string> basket { get { return _basket; } }
    }
}
