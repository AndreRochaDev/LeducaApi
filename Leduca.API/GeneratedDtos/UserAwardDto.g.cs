using System;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class UserAwardDto
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public int? UserAwardTypeId { get; set; }
        public double? Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public UserDto? User { get; set; }
        public UserAwardTypeDto? UserAwardType { get; set; }
    }
}