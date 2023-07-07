using System;
using System.Collections.Generic;

namespace DBFIRST.Models;

public partial class Seat
{
    public int? TrainId { get; set; }

    public string? CompartmentType { get; set; }

    public string? CompartmentCount { get; set; }

    public int? TotalSeatCount { get; set; }

    public virtual TrainDetail? Train { get; set; }
}
