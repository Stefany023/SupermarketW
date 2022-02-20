namespace SupermarketW
{
    public class VariablePriceProduct : Product

    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return (Price*(decimal)Quantity) * (decimal)Tax + (Price * (decimal)Quantity);
        }
        public override string ToString()
        { 

            return $"   {Id}\t{Description} " +
            $"\n\tMeasurement: {Measurement} " +
            $"\n\tQuantity...: {$"{Quantity:N2}",15}" +
            $"\n\tPrice......: {$"{Price:C2}",15}" +
            $"\n\tTax........: {$"{Tax:P2}",17}" +
            $"\n\tValue......:{$"{ValueToPay():C2}",16}";

        }
    }
}
