using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class UserBookRecommendation
{
    public int Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? BookId { get; set; }

    public Guid? RecommendedByUserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual Book? Book { get; set; }

    public virtual User? RecommendedByUser { get; set; }

    public virtual User? User { get; set; }
}
