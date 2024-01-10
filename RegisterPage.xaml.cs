namespace WebApiCA2MobileApp;

public partial class RegisterPage : ContentPage
{
	
	public RegisterPage()
	{
		InitializeComponent();
	}

	public void Register(object sender, EventArgs e)
	{
		//doing some user validation email and password 
		//then if valid navigate to UserDashboardPage
        Navigation.PushAsync(new UserDashboard());
    }
	public void TogglePasswordVisibility(object sender, CheckedChangedEventArgs e)

	{
		if (!e.Value)
		{
			CheckBoxLabel.Text = "Hide Password";
		}
		else { CheckBoxLabel.Text = "Show Password"; }

    }	

}