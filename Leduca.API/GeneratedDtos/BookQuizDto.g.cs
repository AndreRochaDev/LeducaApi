using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class BookQuizDto
    {
        public int Id { get; set; }
        public Guid? BookId { get; set; }
        public int? QuestionId { get; set; }
        public int? Order { get; set; }
        public bool? Correct { get; set; }
        public double? Points { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public BookDto? Book { get; set; }
        public QuestionDto? Question { get; set; }
        public ICollection<UserBookQuizDto> UserBookQuizzes { get; set; }
    }
}