using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class UserProfile
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
