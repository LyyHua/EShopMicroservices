﻿namespace Basket.API.Models;

public class ShoppingCart
{
    public string UserName { get; set; } = default!;
    public List<ShoppingCartItem> Items { get; set; } = [];
    public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);

    public ShoppingCart(string username)
    {
        UserName = username;
    }

    // Required for mapping
    public ShoppingCart()
    {
        
    }
}
