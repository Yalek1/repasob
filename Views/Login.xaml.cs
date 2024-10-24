namespace repasob.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private void btnAbrir_Clicked(object sender, EventArgs e)
	{
		string dato = txtDato.Text;
		Navigation.PushAsync(new Vista1(dato, 10, 5, "HOLA"));
    }
}