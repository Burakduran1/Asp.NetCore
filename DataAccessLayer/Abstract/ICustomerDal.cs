using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer> //ilgili interface ait sınıf çağırılmalı
    {
        //void Insert(Customer p);
        //void Update(Customer p);
        //void Delete(Customer p);
        //List<Customer> GetList();

    }
}
