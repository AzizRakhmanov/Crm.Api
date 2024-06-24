﻿namespace Crm.Entities.Commons
{
    public class Auditable
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
