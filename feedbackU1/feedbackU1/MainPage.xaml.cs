namespace feedbackU1;

public partial class MainPage : ContentPage
{
	int users = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		users++;

		if (users == 1) {
			FormLabel.Text = $"Usuario registrado con éxito";
		} else {
            FormLabel.Text = $"{users}Usuario registrado con éxito";
        }
		

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    void nameText_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
		FormLabel.Text = NameText.Text;
    }
}


