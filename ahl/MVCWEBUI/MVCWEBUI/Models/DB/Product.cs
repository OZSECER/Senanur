using System;
using System.Collections.Generic;

namespace MVCWEBUI.Models.DB;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int SupplierId { get; set; }

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public string Unit { get; set; } = null!;
}
