using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class UserBookQuizAnswer
{
    public Guid Id { get; set; }

    public Guid? UserBookQuizId { get; set; }

    public int? QuestionId { get; set; }

    public int? QuestionAnswerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual Question? Question { get; set; }

    public virtual QuestionAnswer? QuestionAnswer { get; set; }

    public virtual UserBookQuiz? UserBookQuiz { get; set; }
}
