using System;
using System.Linq;
using WpfChat.Common;
using WpfChat.Infrastructure;

namespace WpfChat.Business
{
    public class LoginBusiness : ILoginBusiness
    {
        private readonly IRepository<User> _userRepository;

        public LoginBusiness(IRepository<User> userRepostory)
        {
            _userRepository = userRepostory;
        }

        public bool ExistUser(User user)
        {
            return _userRepository.GetByCustomLambda
                        (u => u.Nombre == user.Nombre && u.Contraseña == user.Contraseña)
                        .Any();

        }
    }
}
