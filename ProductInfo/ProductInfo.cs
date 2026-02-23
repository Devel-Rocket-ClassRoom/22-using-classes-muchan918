using System;

class ProductInfo
{
    private int discountAmount;
    private int finalPrice;

    public string Name { get; set; }
    public int Price { get; set; }
    public int DiscountPercent { get; set; }
    public int DiscountAmount { get{ return discountAmount;} }
    public int FinalPrice { get{return finalPrice;} }

    public ProductInfo(string name, int price)
    {
        Name = name; Price = price;
        DiscountPercent = 0;
        discountAmount = 0;
        finalPrice = 0;
    }

    public ProductInfo(string name, int price, int discountPercent)
    {
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
        discountAmount = Price * discountPercent / 100;
        finalPrice = Price - discountAmount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[상품 정보] {Name} - 가격: {Price}원, 할인: {DiscountPercent}% (-{discountAmount}원), 최종가: {finalPrice}원");
    }
}