namespace TaskApi.Services
{
    public interface ITokenService
    {
        string CreateToken(ApplicationUser user);
    }
}
