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
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void Add(Supplier supplier)
        {
            if (!_supplierDal.FirstOrDefaultBool(x => x.CompanyName == supplier.CompanyName))
            {
                _supplierDal.Add(supplier);
            }
        }
        public void Update(Supplier supplier)
        {
            if (_supplierDal.FirstOrDefaultBool(x => x.ID == supplier.ID))
            {
                _supplierDal.Update(supplier);
            }
        }
        public void Delete(int id)
        {
            var getSupplier = _supplierDal.FirstOrDefault(x => x.ID == id);
            if (getSupplier != null)
            {
                _supplierDal.Delete(getSupplier);
            }
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetAll();
        }

        public List<Supplier> GetAllComboBox()
        {
            return _supplierDal.GetAll().Select(x => new Supplier
            {
                ID = x.ID,
                CompanyName = x.CompanyName
            }).ToList();
        }

        public Supplier GetById(int id)
        {
            return _supplierDal.FirstOrDefault(x => x.ID == id);
        }

        public Supplier GetByName(string companyName)
        {
            return _supplierDal.FirstOrDefault(x => x.CompanyName == companyName);
        }

        public bool GetByNameBool(string companyName)
        {
            return _supplierDal.FirstOrDefaultBool(x => x.CompanyName == companyName);
        }
    }
}
