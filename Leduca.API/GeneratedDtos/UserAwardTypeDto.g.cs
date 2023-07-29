using System;
using System.Collections.Generic;
using GeneratedDtos;

namespace GeneratedDtos
{
    public partial class UserAwardTypeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Active { get; set; }
        public ICollection<UserAwardDto> UserAwards { get; set; }
    }
}