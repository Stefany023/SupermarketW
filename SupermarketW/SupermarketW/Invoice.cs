namespace SupermarketW
{
    public class Invoice : IPay
    {
        //private List<Product>? _products { get; set; }
        private List<Product>? _products = new List<Product>();
        public void AddProduct(Product products)
        {
            _products.Add(products);
        }
        public Invoice()
        { }
        public override string ToString()
        {

            return $" RECEIPT " +
                $"\n--------------------------------------------------" +
                $"\n{string.Join("\n", _products!.Select(product => product).ToList())}" +
                $"\n                    =================" +
                $"\n\tTOTAL:      {$"{ValueToPay():C2}",16}";
        }
        public /*override*/ decimal ValueToPay()

        {
            decimal TotalValue = 0;

            foreach (Product Product in _products)
            {
                TotalValue += Product.ValueToPay();
            }
            return TotalValue;
        }

    }
}
