﻿using System;
using System.Collections.Generic;

namespace DBFIRST.Models;

public partial class BookingDeatil
{
    public int TicketId { get; set; }

    public int? TrainId { get; set; }

    public string? CompartmentType { get; set; }

    public int? PassId { get; set; }

    public string? TDate { get; set; }

    public int? SeatNo { get; set; }

    public virtual PassangerDetail? Pass { get; set; }

    public virtual TrainDetail? Train { get; set; }
}
