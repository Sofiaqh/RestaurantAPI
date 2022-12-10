using RestaurantAPI.Dto;
using RestaurantAPI.Models;

namespace RestaurantAPI.Interfaces
{
    public interface IClient
    {
        void Update(Client client);
        Client GetById(int id);
        void DeleteById(int id);
        List<Client> Get();
        void Create(ClientDto client);

    }
}
