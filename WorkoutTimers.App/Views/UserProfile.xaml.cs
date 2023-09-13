namespace WorkoutTimers.App.Views;

public partial class UserProfile : ContentPage
{
	public UserProfile(Lib.ViewModels.UserProfileModel userName)
	{
		InitializeComponent();
		BindingContext = userName;
		userName.DisplayName.Except(userName.DisplayName);
	}
}