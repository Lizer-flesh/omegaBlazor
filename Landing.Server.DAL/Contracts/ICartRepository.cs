using Landing.Server.DAL.Core;
using Landing.Shared.Entities;

namespace Landing.Server.DAL.Contracts;

public interface ICartRepository:IAsyncRepository<Cart, int>
{
    
}