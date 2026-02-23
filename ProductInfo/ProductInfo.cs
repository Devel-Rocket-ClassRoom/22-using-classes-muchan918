using System;

class ProductInfo
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int DiscountPercent { get; set; }
    public int DiscountAmount { get; }
    public int FinalPrice { get; }

    public ProductInfo(string name, int price)
    {
        Name = name; Price = price;
        DiscountPercent = 0;
    }

    public ProductInfo(string name, int price, int discountPercent)
    {
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
    }
}