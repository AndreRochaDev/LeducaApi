using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class UserAward
{
    public int Id { get; set; }

    public Guid? UserId { get; set; }

    public int? UserAwardTypeId { get; set; }

    public double? Amount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual User? User { get; set; }

    public virtual UserAwardType? UserAwardType { get; set; }
}
