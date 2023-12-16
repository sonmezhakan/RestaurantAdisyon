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
    public class SupplierManager :BaseManager<Supplier>, ISupplierManager
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierManager(ISupplierRepository supplierRepository):base(supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public void Add(Supplier supplier)
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
        }

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
