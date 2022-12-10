using System;
using System.Collections.Generic;

namespace RestaurantAPI.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<DetailOrder> DetailOrders { get; } = new List<DetailOrder>();
}
