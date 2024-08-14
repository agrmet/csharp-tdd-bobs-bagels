


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
            throw new NotImplementedException();
        }

        public List<string> basket { get { return _basket; } }
    }
}
