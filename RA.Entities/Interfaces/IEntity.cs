﻿namespace RA.Entities.Interfaces
{
    public interface IEntity
    {
        public int ID { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedUserId { get; set; }
    }
}
