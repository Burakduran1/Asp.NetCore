using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal) //CTOR + tab + tab
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public object TGetList()
        {
            return _productDal.Getlist();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public List<Product> TList()
        {
            return _productDal.Getlist();
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
