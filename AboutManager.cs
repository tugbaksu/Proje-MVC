using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _abouDal;

        public AboutManager(IAboutDal abouDal)
        {
            _abouDal = abouDal;
        }

        public void AboutAdd(About about)
        {
            _abouDal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            _abouDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _abouDal.Update(about);
        }

        public List<About> GetList()
        {
            return _abouDal.List();
        }

        About IAboutService.GetByID(int id)
        {
            return _abouDal.Get(x => x.AboutID == id);
        }
    }
}
