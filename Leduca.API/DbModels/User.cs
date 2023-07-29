using System;
using System.Collections.Generic;

namespace Leduca.API.DbModels;

public partial class User
{
    public Guid Id { get; set; }

    public int? UserProfileId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Message> MessageFromUsers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageToUsers { get; set; } = new List<Message>();

    public virtual ICollection<UserAward> UserAwards { get; set; } = new List<UserAward>();

    public virtual ICollection<UserBookQuiz> UserBookQuizzes { get; set; } = new List<UserBookQuiz>();

    public virtual ICollection<UserBookRecommendation> UserBookRecommendationRecommendedByUsers { get; set; } = new List<UserBookRecommendation>();

    public virtual ICollection<UserBookRecommendation> UserBookRecommendationUsers { get; set; } = new List<UserBookRecommendation>();

    public virtual UserProfile? UserProfile { get; set; }
}
