using System.Diagnostics;
using System.Text.Json;
using WebApiCA2MobileApp.Services;
using WebApiCA2MobileApp.Models;


namespace WebApiCA2MobileApp;

public partial class UserDashboard : ContentPage
{

    public List<User> User { get; private set; }

    private UserService _userService;
    public UserDashboard()
    {
        InitializeComponent();
        _userService=new UserService();
    }

    
    public async void ShowUserData(object sender, EventArgs e)
    {
        // RefreshDataAsync();
        User = await _userService.RefreshUserDataAsync();


    }
}