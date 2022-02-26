namespace SupermarketW
{
    public abstract class Product : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public override string ToString()
        {
            return $"   {Id}\t{Description} " +
                $"\n\tPrice......: {$"{Price:C2}",15}" +
                $"\n\tTax........: {$"{Tax:P2}",17}";

        }
        public abstract decimal ValueToPay();

    }
}
