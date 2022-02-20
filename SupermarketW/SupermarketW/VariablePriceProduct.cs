namespace SupermarketW
{
    public class VariablePriceProduct : Product

    {
        public float Measurement { get; set; }
        public int Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValueToPay: {ValueToPay()}";
        }
    }
}
