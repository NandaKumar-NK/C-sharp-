using System;
using System.Collections.Generic;

namespace DBFIRST.Models;

public partial class PassangerDetail
{
    public int PassId { get; set; }

    public string? PassangerName { get; set; }

    public long? MobileNo { get; set; }

    public virtual ICollection<BookingDeatil> BookingDeatils { get; set; } = new List<BookingDeatil>();
}
