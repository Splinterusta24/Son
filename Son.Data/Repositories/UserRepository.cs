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
    public class UserRepository:Repository<User>,IUserRepository
    {
        public UserRepository(DbContext dbContext): base(dbContext)
        {
           //Spesifik Repository'e ekleme yapmak adına bu yola başvurduk. Solid kurallarını bozmadan.

                
        }
    }
}
