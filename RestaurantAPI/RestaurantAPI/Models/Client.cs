using System;
using System.Collections.Generic;

namespace RestaurantAPI.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public string Name { get; set; } = null!;

    public string Document { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
