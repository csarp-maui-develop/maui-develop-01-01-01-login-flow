using Kreta.Maui.Services;

namespace Kreta.Maui.Pages;

public partial class LoadingPage : ContentPage
{
    private readonly AuthenticationService _authenticationService;
    public LoadingPage()
	{
		InitializeComponent();
        _authenticationService = new AuthenticationService();
	}

    public LoadingPage(AuthenticationService authenticationServices)
    {
        InitializeComponent();
        _authenticationService = authenticationServices;
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (_authenticationService is not null)
        {
            if (await _authenticationService.IsAuthenticatedAsync())
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
        }
    }
}