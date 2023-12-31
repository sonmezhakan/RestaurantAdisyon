﻿using RA.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public  int ID { get; set; }
        public  bool? IsActive { get; set; }
        public  DateTime CreatedDate { get; set; }
        public  DateTime? UpdatedDate { get; set; }
        public  int CreatedUserId { get; set; }
    }
}
