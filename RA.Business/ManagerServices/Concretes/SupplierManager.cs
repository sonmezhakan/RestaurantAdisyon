using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Concretes
{
    public class SupplierManager : BaseManager<Supplier>, ISupplierManager
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierManager(ISupplierRepository supplierRepository) : base(supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public List<Supplier> GetAllComboBox()
        {
            return _supplierRepository.GetAll().Select(x => new Supplier
            {
                ID = x.ID,
                CompanyName = x.CompanyName
            }).ToList();
        }

        public Supplier GetById(int id)
        {
            return _supplierRepository.FirstOrDefault(x => x.ID == id);
        }

        public Supplier GetByName(string companyName)
        {
            return _supplierRepository.FirstOrDefault(x=>x.CompanyName == companyName);
        }

        public bool GetByNameBool(string companyName)
        {
            return _supplierRepository.FirstOrDefaultBool(x => x.CompanyName == companyName);
        }
        /* public void Add(Supplier supplier)
{
if (!_supplierRepository.FirstOrDefaultBool(x=>x.CompanyName == supplier.CompanyName))
{
_supplierRepository.Add(supplier);
}
}
public void Update(Supplier supplier)
{
if (_supplierRepository.FirstOrDefaultBool(x=>x.ID == supplier.ID))
{
_supplierRepository.Update(supplier);
}
}
public void Delete(int id)
{
var getSupplier = _supplierRepository.FirstOrDefault(x => x.ID == id);
if (getSupplier != null)
{
_supplierRepository.Delete(getSupplier);
}
}*/

        /* 

         public List<Supplier> GetAllComboBox()
         {
             return _supplierService.GetAll().Select(x => new Supplier
             {
                 ID = x.ID,
                 CompanyName = x.CompanyName
             }).ToList();
         }
 */


    }
}
