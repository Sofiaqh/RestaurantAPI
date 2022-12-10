using RestaurantAPI.Models;

namespace RestaurantAPI.Interfaces
{
    public interface IClient
    {
        void UpdateClient(Client client);
        Client GetClient(int id);
        void DeleteClient(int id);
        List<Client> GetClients();
        void PostClient(Client client);

    }
}
