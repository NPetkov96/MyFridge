using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MyFridge.Common
{
    public class GetUserId
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetUserId(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetCurrentUserId()
        {
            var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim != null)
            {
                return Guid.Parse(userIdClaim.Value);
            }

            throw new InvalidOperationException("User ID not found.");
        }
    }
}
