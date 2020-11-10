using Core.Entities.Idenity;

namespace Core.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser user);
    }
}