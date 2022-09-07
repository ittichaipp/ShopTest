using System.Reflection;

namespace ShopTest1.Models.entity

{
    public class Product
    {
        public int ProductID { get; set; } = 0;
        

        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductPrice { get; set; } = string.Empty;
        
        public string Img1 { get; set; } = string.Empty;
        public string Img2 { get; set; } = string.Empty;
        public string Img3 { get; set; } = string.Empty;

    }
}
