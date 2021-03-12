using API.Entities;

namespace API.Intarfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}