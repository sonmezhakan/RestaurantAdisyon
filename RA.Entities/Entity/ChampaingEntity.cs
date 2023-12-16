using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RA.Entities.Interfaces;

namespace RA.Entities.Entity
{
    public abstract class ChampaingEntity : BaseEntity
    {
        public short Champaing { get; set; }
    }
}
