using System;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class UserBookQuizAnswerDto
    {
        public Guid Id { get; set; }
        public Guid? UserBookQuizId { get; set; }
        public int? QuestionId { get; set; }
        public int? QuestionAnswerId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public QuestionDto? Question { get; set; }
        public QuestionAnswerDto? QuestionAnswer { get; set; }
        public UserBookQuizDto? UserBookQuiz { get; set; }
    }
}