using Calculator2022.Logic;

namespace Calculator2022;

public partial class MainPage : ContentPage
{
	int count = 0;
	Calculator calc = new Calculator();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		calc.Press(Calculator.Clear);
		//...
	}
}

