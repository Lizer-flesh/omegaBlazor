using Landing.Server.BLL.DTO;
namespace Landing.Server.BLL.Contracts;

public class ICartService
{
    Task<AddCartDTO> AddCartAsync(AddCartDTO addCartDto);
}