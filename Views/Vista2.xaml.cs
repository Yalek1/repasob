namespace repasob.Views;

public partial class Vista2 : ContentPage
{
	public Vista2()
	{
		InitializeComponent();
	}

    public Vista2(string datoU)
    {
        InitializeComponent();
        lblDato.Text = "USUARIO CONECTADO" + datoU;
    }
}