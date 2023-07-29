using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class BookQuiz
{
    public int Id { get; set; }

    public Guid? BookId { get; set; }

    public int? QuestionId { get; set; }

    public int? Order { get; set; }

    public double? Points { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Question? Question { get; set; }

    public virtual ICollection<UserBookQuiz> UserBookQuizzes { get; set; } = new List<UserBookQuiz>();
}
