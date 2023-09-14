using System;
using System.Collections.Generic;

namespace TP1_SLAM5.Entities;

public partial class Style
{
    public int NumStyle { get; set; }

    public string? LibStyle { get; set; }

    public virtual ICollection<Partition> Partitions { get; set; } = new List<Partition>();
}
