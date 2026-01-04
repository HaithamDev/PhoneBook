using ERP.Application.Common.Interfaces;
using ERP.Domain.Entities;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IEncryptionService _encryptionService;

        public AuthenticationService(IRepository<User> userRepository, IEncryptionService encryptionService)
        {
            _userRepository = userRepository;
            _encryptionService = encryptionService;
        }

        public async Task<string> AuthenticateAsync(string username, string password)
        {
            // Simplified authentication for prototype
            // In a real app, this would check against the database and verify password hash
            // Then it would generate a JWT token
            
            return await Task.FromResult("mock_token_" + Guid.NewGuid());
        }
    }
}
