using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Product
{
    public string Pname { get; set; } = null!;

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public int Id { get; set; }
}
