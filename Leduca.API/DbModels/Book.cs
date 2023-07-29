using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class Book
{
    public Guid Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public int? BookLevelId { get; set; }

    public string? Isbn { get; set; }

    public string? Summary { get; set; }

    public int? Duration { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual BookLevel? BookLevel { get; set; }

    public virtual ICollection<BookQuiz> BookQuizzes { get; set; } = new List<BookQuiz>();

    public virtual ICollection<UserBookQuiz> UserBookQuizzes { get; set; } = new List<UserBookQuiz>();

    public virtual ICollection<UserBookRecommendation> UserBookRecommendations { get; set; } = new List<UserBookRecommendation>();
}
