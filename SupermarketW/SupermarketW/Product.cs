namespace SupermarketW
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Description}, " +
                $"Precio: {Price},IVA: {Tax}";
        }
        public abstract decimal ValueToPay();
    }
}
