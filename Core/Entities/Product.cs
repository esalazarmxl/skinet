using System;
using System.Runtime.ConstrainedExecution;

namespace Core.Entities;

public class Product :  BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public string PictureUrl { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string Brand { get; set; } = null!;
    public int QuantityInStock { get; set; }
}
