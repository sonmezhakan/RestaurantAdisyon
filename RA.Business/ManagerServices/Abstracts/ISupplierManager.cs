using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Abstracts
{
    public interface ISupplierManager:IManager<Supplier>
    {
        List<Supplier> GetAllComboBox();
        Supplier GetById(int id);
        Supplier GetByName(string companyName);
        bool GetByNameBool(string companyName);
    }
}
