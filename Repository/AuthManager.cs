using AutoMapper;
using Microsoft.AspNetCore.Identity;

public class AuthManager : IAuthManager
{
    private readonly IMapper _mapper;
    private readonly UserManager<ApiUser> _userManager;
    public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
    {
        _userManager = userManager;
        _mapper = mapper;
    }
    public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
    {
        var user = _mapper.Map<ApiUser>(userDto);
        user.UserName = userDto.Email;
        var result = await _userManager.CreateAsync(user, userDto.Password);
        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, "User");

        }
         return result.Errors;
    }
}