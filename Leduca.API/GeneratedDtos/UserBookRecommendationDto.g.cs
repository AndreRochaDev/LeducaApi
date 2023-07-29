using System;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class UserBookRecommendationDto
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? BookId { get; set; }
        public Guid? RecommendedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public BookDto? Book { get; set; }
        public UserDto? RecommendedByUser { get; set; }
        public UserDto? User { get; set; }
    }
}