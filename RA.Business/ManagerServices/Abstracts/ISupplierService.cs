using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Abstracts
{
    public interface ISupplierService
    {
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int id);
        List<Supplier> GetAll();
        List<Supplier> GetAllComboBox();
        Supplier GetById(int id);
        Supplier GetByName(string companyName);
        bool GetByNameBool(string companyName);
    }
}
