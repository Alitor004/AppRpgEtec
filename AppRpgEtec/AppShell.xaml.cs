using AppRpgEtec.Views.Personagens;

namespace AppRpgEtec;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("cadPersonagemView", typeof(CadastroPersonagemView));

		string login = Preferences.Get("UsuarioUsername", string.Empty);
		lblLogin.Text = $"login: {login}";
	}
}
