using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Dto;
using RestaurantAPI.Interfaces;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClient _client;
        public ClientController(IClient client)
        {
            _client = client;
        }
        [HttpGet("Get")]
        public List<Client> GetAll()
        {
            return _client.Get();
        }

        [HttpGet("GetById")]
        public Client Get(int id)
        {
            return _client.GetById(id);
        }

        [HttpPost("Create")]
        public void Create(ClientDto client)
        {
            _client.Create(client);

        }

        [HttpPut("Update")]
        public void Update(Client client)
        {
            _client.Update(client);
        }

        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
            _client.DeleteById(id);

        }
    }
}
