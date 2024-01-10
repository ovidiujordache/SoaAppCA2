namespace WebApiCA2MobileApp;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}
	public void Login_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new LoginPage());
    }
	
	public void Register_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new RegisterPage());
	}
}