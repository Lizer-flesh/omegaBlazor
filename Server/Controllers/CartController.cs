using Landing.Server.BLL.Contracts;
using Landing.Server.BLL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Landing.Server.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<AddCartDTO>> AddCart(AddCartDTO addCartDto)
    {
        if (ModelState.IsValid)
        {
            var cartDTO = await _cartService.AddCartAsync(AddCartDTO);
            return Ok(cartDTO);
        }

        var validationErrors = ModelState.Values.Where(e => e.Errors.Count > 0)
            .SelectMany(e => e.Errors)
            .Select(e => e.ErrorMessage)
            .ToList();
        return BadRequest(validationErrors);

    }
}