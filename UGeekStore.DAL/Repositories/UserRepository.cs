﻿using UGeekStore.Core.Entities;
using UGeekStore.Core.Infrastructre.RepositoryInterfaces;

namespace UGeekStore.DAL.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(StoreContext _context) : base(_context)
        {

        }
    }
}
