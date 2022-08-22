using Landing.Server.DAL.Core;
using Landing.Shared.Entities;
using Landing.Server.DAL.Contracts;
namespace Landing.Server.DAL;

public class CartRepository:BaseRepository<Cart, int>, ICartRepository
{
    public CartRepository(ApplicationContext context) : base(context)
    {
    }
}