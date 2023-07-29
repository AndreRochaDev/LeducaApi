using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class UserBookQuizDto
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
        public BookDto? Book { get; set; }
        public BookQuizDto? BookQuizNavigation { get; set; }
        public UserDto? User { get; set; }
        public ICollection<UserBookQuizAnswerDto> UserBookQuizAnswers { get; set; }
    }
}