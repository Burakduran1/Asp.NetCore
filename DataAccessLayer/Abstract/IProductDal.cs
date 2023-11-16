using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        //void Insert(Product p);
        //void Update(Product p);
        //void Delete(Product p);
        //List<Product> GetList();  //GetList metodunun adıdır.List<Product> dönüş değerini ifade eder. Bu, Product türünden nesneler içeren bir liste döndürüleceği anlamına gelir. Yani bu metod bir liste döndürecek ve bu liste ürün (Product) nesnelerini içerecek.
    }
}
