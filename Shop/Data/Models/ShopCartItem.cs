namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int itemId { get; set; }
        public Car car { get; set; }
        private int price { get; set; }
        public string ShopCartId { get; set; }
    }
}