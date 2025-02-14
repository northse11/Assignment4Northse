namespace Assignment4Northse;

public partial class bmiCalculatorPage : ContentPage
{
	public bmiCalculatorPage()
	{
		InitializeComponent();
	}

	string choice = "female";
    string healthStatus = "Underweight";
    string healthRec = "";

	public void tapFemale_Tapped(object sender, TappedEventArgs e)
	{
        frameFemale.BorderColor = Color.FromArgb("#0a0e29");
        frameMale.BorderColor = Color.FromArgb("#fdfdfd");
        choice = "female";
    }

    public void tapMale_Tapped(object sender, TappedEventArgs e)
    {
        frameMale.BorderColor = Color.FromArgb("#0a0e29");
        frameFemale.BorderColor = Color.FromArgb("#fdfdfd");
        choice = "male";
    }

    public void btnCalculate_Clicked(object sender, EventArgs e)
    {
        double height = double.Parse(lblHeight.Text);
        double weight = double.Parse(lblWeight.Text);
        double bmi = Math.Round((weight * 703) / (height * height), 1);

        Navigation.PushAsync(new bmiResultPage(bmi, choice));
    }

}