using Restaurants_MinimalAPI_Mediator.Model;

namespace Restaurants_MinimalAPI_Mediator.IRepository
{
    public interface IJWT
    {
        AuthenticateResponse Authenticate(Login model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
