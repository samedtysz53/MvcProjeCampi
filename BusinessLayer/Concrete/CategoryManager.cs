using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository <Category> rep=new GenericRepository<Category> ();
        public List<Category> GetAllB() 
        {

            return rep.List();
        }
        public void CategoryAddB(Category p) 
        {
            if (p.CategoryName==""||p.CategoryName.Length<=3||p.CategoryDescription==""||p.CategoryStatus==false|| p.CategoryName.Length>=51) 
            {
                //hata mesajı
            }
            else 
            {
                rep.Insert(p);
            }
        }
    }
}
