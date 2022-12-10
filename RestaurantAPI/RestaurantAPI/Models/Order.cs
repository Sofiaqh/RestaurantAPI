using System;
using System.Collections.Generic;

namespace RestaurantAPI.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public DateTime OrderDate { get; set; }

    public int IdClient { get; set; }

    public string Price { get; set; } = null!;

    public virtual ICollection<DetailOrder> DetailOrders { get; } = new List<DetailOrder>();

    public virtual Client IdClientNavigation { get; set; } = null!;
}
