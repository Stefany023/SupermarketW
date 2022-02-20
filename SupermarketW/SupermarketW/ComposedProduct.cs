//namespace SupermarketW
//{
//    public class ComposedProduct : Product
//    {
//        public float Discount { get; set; }
//        public string Products { get; set; }
//        //public List<string> Products { get; set; }
//        public override decimal ValueToPay()
//        {
//            return Price * (decimal)Tax + Price;
//        }
//        public override string ToString()
//        {
//            return $"{base.ToString()}" +
//                $"\n\tValue......:{$"{ValueToPay():C2}",16}";

//        }
//    }
//}