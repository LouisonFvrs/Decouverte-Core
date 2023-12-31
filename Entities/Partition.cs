﻿using System;
using System.Collections.Generic;

namespace TP1_SLAM5.Entities;

public partial class Partition
{
    public int Numpart { get; set; }

    public string? Libpart { get; set; }

    public int? Prixpart { get; set; }

    public int? NumStyle { get; set; }

    public virtual Style? NumStyleNavigation { get; set; }

    public virtual ICollection<Auteur> Numauts { get; set; } = new List<Auteur>();

    public virtual ICollection<Commande> Numcdes { get; set; } = new List<Commande>();
}
