using AutoMapper;
using Landing.Server.BLL.Contracts;
using Landing.Server.BLL.DTO;
using Landing.Server.DAL.Contracts;
using Landing.Shared.Entities;

namespace Landing.Server.BLL.Services;

public class CartService:ICartService
{
    private readonly IMapper _mapper;
    private readonly ICartRepository _cartRepository;

    public CartService(ICartRepository cartRepository, IMapper mapper)
    {
        _cartRepository = cartRepository;
        _mapper = mapper;
    }
    
    public async Task<AddCartDTO> AddCartAsync(AddCartDTO addCartDto)
    {
        var cart = _mapper.Map<Cart>(addCartDto);
        await _cartRepository.AddAsync(cart);
        return addCartDto;
    }

    public async Task<RemoveCartDTO> RemoveCartAsync(RemoveCartDTO removeCartDto)
    {
        var removeCart = _mapper.Map<Cart>(removeCartDto);
        await _cartRepository.DeleteAsync(removeCart);
        return removeCartDto;
    }

    public async Task<GetCartDTO> GetCartAsync(int id)
    {
        var getCart = await _cartRepository.GetByIdAsync(id);
        var getCartDto = _mapper.Map<GetCartDTO>(getCart);
        return getCartDto;
    }

    public async Task<UpdateCartDTO> UpdateCartAsync(UpdateCartDTO updateCartDto)
    {
        var updateCart = _mapper.Map<Cart>(updateCartDto);
        await _cartRepository.UpdateAsync(updateCart);
        return updateCartDto;
    }
}