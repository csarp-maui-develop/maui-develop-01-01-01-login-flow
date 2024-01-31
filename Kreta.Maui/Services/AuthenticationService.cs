namespace Kreta.Maui.Services
{
    public class AuthenticationService
    {
        public async Task<bool> IsAuthenticatedAsync()
        {
            await Task.Delay(200);
            return false;
        }
            
    }
}
