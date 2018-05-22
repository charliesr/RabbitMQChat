using WpfChat.Common;

namespace WpfChat.Business
{
    public interface ILoginBusiness
    {
        bool ExistUser(User user);
    }
}