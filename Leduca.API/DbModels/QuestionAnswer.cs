using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class QuestionAnswer
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? Text { get; set; }

    public int? Order { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public bool? Correct { get; set; }

    public virtual Question? Question { get; set; }

    public virtual ICollection<UserBookQuizAnswer> UserBookQuizAnswers { get; set; } = new List<UserBookQuizAnswer>();
}
