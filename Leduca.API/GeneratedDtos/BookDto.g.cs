using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class BookDto
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
        public BookLevelDto? BookLevel { get; set; }
        public ICollection<BookQuizDto> BookQuizzes { get; set; }
        public ICollection<UserBookQuizDto> UserBookQuizzes { get; set; }
        public ICollection<UserBookRecommendationDto> UserBookRecommendations { get; set; }
    }
}