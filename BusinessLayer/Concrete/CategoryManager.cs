using BusinessLayer.Abstract;
using DataAccessLayer.Abstrack;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }


        //   GenericRepository <Category> rep=new GenericRepository<Category> ();
        //public List<Category> GetAllB() 
        //{

        //    return rep.List();
        //}
        //public void CategoryAddB(Category p) 
        //{
        //    rep.Insert(p);

        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryStatus == false || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //    }
        //}
        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
