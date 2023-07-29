using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class Question
{
    public int Id { get; set; }

    public string? Text { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<BookQuiz> BookQuizzes { get; set; } = new List<BookQuiz>();

    public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; } = new List<QuestionAnswer>();

    public virtual ICollection<UserBookQuizAnswer> UserBookQuizAnswers { get; set; } = new List<UserBookQuizAnswer>();
}
