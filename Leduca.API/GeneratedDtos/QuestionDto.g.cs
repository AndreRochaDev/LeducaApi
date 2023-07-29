using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class QuestionDto
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public ICollection<BookQuizDto> BookQuizzes { get; set; }
        public ICollection<QuestionAnswerDto> QuestionAnswers { get; set; }
        public ICollection<UserBookQuizAnswerDto> UserBookQuizAnswers { get; set; }
    }
}