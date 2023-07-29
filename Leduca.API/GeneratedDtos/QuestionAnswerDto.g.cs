using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class QuestionAnswerDto
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public string? Text { get; set; }
        public int? Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public QuestionDto? Question { get; set; }
        public ICollection<UserBookQuizAnswerDto> UserBookQuizAnswers { get; set; }
    }
}