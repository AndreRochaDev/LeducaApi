using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class UserBookQuiz
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? BookId { get; set; }

    public int? BookQuiz { get; set; }

    public double? TotalPoints { get; set; }

    public DateTime? DateStarted { get; set; }

    public DateTime? DateEnded { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual Book? Book { get; set; }

    public virtual BookQuiz? BookQuizNavigation { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<UserBookQuizAnswer> UserBookQuizAnswers { get; set; } = new List<UserBookQuizAnswer>();
}
