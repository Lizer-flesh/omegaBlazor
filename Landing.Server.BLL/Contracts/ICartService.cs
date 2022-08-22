using Landing.Server.BLL.DTO;
namespace Landing.Server.BLL.Contracts;

public interface ICartService
{
    Task<AddCartDTO> AddCartAsync(AddCartDTO addCartDto);
    Task<RemoveCartDTO> RemoveCartAsync(RemoveCartDTO removeCartDto);
    Task<GetCartDTO> GetCartAsync(int id);
    Task<UpdateCartDTO> UpdateCartAsync(UpdateCartDTO updateCartDto);
}