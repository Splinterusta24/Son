using Son.Model;
using Son.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Service
{
    public interface IArticleService
    {
        IResult Get(int articleId);
        void GetAll();
        void GetAllByNonDeleted();
        void GetAllByNonDeletedAndActive();
        void GetAllByCategory(int categoryId);
        void Add();
        void Update();
        void Delete();
        void HardDelete();
    }
}
