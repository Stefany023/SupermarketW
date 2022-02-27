namespace SupermarketW
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()

        {
            decimal TotalValue = 0;
            decimal TotalToPay = 0;

            foreach (Product Product in Products)
            {            
                TotalValue += Product.ValueToPay();
                TotalToPay = TotalValue - (TotalValue * (decimal)Discount);
            }
            return TotalToPay;
        }

        public override string ToString()
        {
            return $"   {Id}\t{Description} " +
            $"\n\tProducts...: {string.Join(", ", Products!.Select(product => product.Description).ToList())}" +
            $"\n\tDiscount...: {$"{Discount:P2}",16}" +
            $"\n\tValue......:{$"{ValueToPay():C2}",16}";

        }

    }



}




