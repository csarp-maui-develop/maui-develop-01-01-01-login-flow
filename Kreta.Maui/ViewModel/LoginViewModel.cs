using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Maui.Pages;

namespace Kreta.Maui.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
