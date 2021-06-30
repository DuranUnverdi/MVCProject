using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByID(int id);
        void ContentAddBL(Content content);
        Category GetByID(int id);
        void ContentDeleteBL(Content content);
        void ContentUpdateBL(Content content);
    }
}
