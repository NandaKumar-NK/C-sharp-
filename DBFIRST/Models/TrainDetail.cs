using System;
using System.Collections.Generic;

namespace DBFIRST.Models;

public partial class TrainDetail
{
    public int TrainId { get; set; }

    public string? TrainName { get; set; }

    public string? Sources { get; set; }

    public string? Distination { get; set; }

    public virtual ICollection<BookingDeatil> BookingDeatils { get; set; } = new List<BookingDeatil>();
}
