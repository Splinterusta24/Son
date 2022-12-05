using Microsoft.EntityFrameworkCore;
using Son.Entities;
using Son.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Data.Repository
{
    public class ArticleRepository:Repository<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext dbContext):base(dbContext)
        {



        }
    }
}
