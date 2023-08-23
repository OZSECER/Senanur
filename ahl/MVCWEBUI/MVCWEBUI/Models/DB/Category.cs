using System;
using System.Collections.Generic;

namespace MVCWEBUI.Models.DB;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;
}
