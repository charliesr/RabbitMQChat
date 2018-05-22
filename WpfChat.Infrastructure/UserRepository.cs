using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WpfChat.Common;
using WpfChat.Infrastucture.DatabaseContexts;

namespace WpfChat.Infrastructure
{
    public class UserRepository : IRepository<User>
    {
        private readonly UserContext _context;

        public UserRepository()
        {
            _context = new UserContext();
        }

        public User GetById(int id)
        {
            User userFound = null;
            using (var context = _context)
            {
                userFound = context.Users.Find(id);
            }
            return userFound;
        }

        public IEnumerable<User> GetByCustomLambda(Expression<Func<User, bool>> expression)
        {
            IEnumerable<User> usersFound = null;
            using (var context = _context)
            {
                usersFound = context.Users.Where(expression).ToList();
            }
            return usersFound;
        }
    }
}
