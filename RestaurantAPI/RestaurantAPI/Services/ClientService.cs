using RestaurantAPI.Interfaces;
using RestaurantAPI.Models;

namespace RestaurantAPI.Services
{
    public class ClientService : IClient
    {
        private readonly RestaurantContext _restaurantContext;
        public ClientService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext;
        }

        public void DeleteClient(int id)
        {
            var client = GetClient(id);
            _restaurantContext.Clients.Remove(client);
            _restaurantContext.SaveChanges();
        }


        public Client GetClient(int id)
        {
            return _restaurantContext.Clients.Where(client => client.IdClient == id).FirstOrDefault();
        }


        public List<Client> GetClients()
        {
            return _restaurantContext.Clients.ToList();
        }

        public void PostClient(Client client)
        {
            _restaurantContext.Clients.Add(client);
            _restaurantContext.SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            _restaurantContext.Clients.Update(client);
            _restaurantContext.SaveChanges();
        }
    }
}
