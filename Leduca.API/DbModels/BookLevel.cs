using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class BookLevel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
