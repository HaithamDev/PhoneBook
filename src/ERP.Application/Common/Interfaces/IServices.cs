using System.Threading.Tasks;

namespace ERP.Application.Common.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> AuthenticateAsync(string username, string password);
    }

    public interface IEncryptionService
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
    
    public interface ICurrentUserService
    {
        string? UserId { get; }
    }
}
