﻿namespace Catalog_API.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<string> Category { get; set; } = [];
    public string Description { get; set; } = default!;
    public string ImageFile { get; set; } = default!;
    public decimal Price { get; set; }
}
