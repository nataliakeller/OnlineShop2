namespace OnlineShop2.Client.Services;

using OnlineShop2.Client.Models;
using global::OnlineShop2.Client.Models;

public interface ICustomersService
{
    Task<IEnumerable<Customer>> GetCustomersAsync();
}
