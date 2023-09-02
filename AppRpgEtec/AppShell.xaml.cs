namespace AppRpgEtec;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		string login = Preferences.Get("UsuarioUsername", string.Empty);
		lblLogin.Text = $"login: {login}";
	}
}
