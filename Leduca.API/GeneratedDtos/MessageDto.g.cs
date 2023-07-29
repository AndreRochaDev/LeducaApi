using System;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class MessageDto
    {
        public int Id { get; set; }
        public Guid? FromUserId { get; set; }
        public Guid? ToUserId { get; set; }
        public string? Message1 { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsArchived { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public UserDto? FromUser { get; set; }
        public UserDto? ToUser { get; set; }
    }
}