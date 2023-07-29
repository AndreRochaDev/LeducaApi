using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class Message
{
    public int Id { get; set; }

    public Guid? FromUserId { get; set; }

    public Guid? ToUserId { get; set; }

    public string? Message1 { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsArchived { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual User? FromUser { get; set; }

    public virtual User? ToUser { get; set; }
}
