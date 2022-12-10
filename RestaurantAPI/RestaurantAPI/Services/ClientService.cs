using RestaurantAPI.Dto;
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

        public void DeleteById(int id)
        {
            var client = GetById(id);
            _restaurantContext.Clients.Remove(client);
            _restaurantContext.SaveChanges();
        }


        public Client GetById(int id)
        {
            return _restaurantContext.Clients.Where(client => client.IdClient == id).FirstOrDefault();
        }


        public List<Client> Get()
        {
            return _restaurantContext.Clients.ToList();
        }

        public void Create(ClientDto client)
        {
            var clientCreate = new Client()
            {
                Name = client.Name,
                Document = client.Document,
                Adress = client.Adress,
                Phone = client.Phone
            };

            _restaurantContext.Clients.Add(clientCreate);
            _restaurantContext.SaveChanges();
        }

        public void Update(Client client)
        {
            _restaurantContext.Clients.Update(client);
            _restaurantContext.SaveChanges();
        }
    }
}
