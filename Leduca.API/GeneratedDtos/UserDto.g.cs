using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class UserDto
    {
        public Guid Id { get; set; }
        public int? UserProfileId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public ICollection<MessageDto> MessageFromUsers { get; set; }
        public ICollection<MessageDto> MessageToUsers { get; set; }
        public ICollection<UserAwardDto> UserAwards { get; set; }
        public ICollection<UserBookQuizDto> UserBookQuizzes { get; set; }
        public ICollection<UserBookRecommendationDto> UserBookRecommendationRecommendedByUsers { get; set; }
        public ICollection<UserBookRecommendationDto> UserBookRecommendationUsers { get; set; }
        public UserProfileDto? UserProfile { get; set; }
    }
}