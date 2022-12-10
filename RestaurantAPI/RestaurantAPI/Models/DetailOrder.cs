using System;
using System.Collections.Generic;

namespace RestaurantAPI.Models;

public partial class DetailOrder
{
    public int IdDetailOrder { get; set; }

    public int IdOrder { get; set; }

    public int IdProduct { get; set; }

    public int Quantity { get; set; }

    public string? Observations { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
