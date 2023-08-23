using System;
using System.Collections.Generic;

namespace MVCWEBUI.Models.DB;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime OrderDate { get; set; }
}
