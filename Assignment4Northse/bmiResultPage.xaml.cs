namespace Assignment4Northse;

public partial class bmiResultPage : ContentPage
{
    string healthStatus = "";
    public bmiResultPage(double bmi, string choice)
    {
        InitializeComponent();

        lblBMI.Text = bmi.ToString();

        if (choice.Equals("male"))
        {
            if (bmi < 18.5) { healthStatus = "Underweight"; }
            else if (bmi >= 18.5 && bmi < 25) { healthStatus = "Normal weight"; }
            else if (bmi >= 25 && bmi < 30) { healthStatus = "Overweight"; }
            else if (bmi >= 30) { healthStatus = "Obese"; }
        }
        else if (choice.Equals("female"))
        {
            if (bmi < 18) { healthStatus = "Underweight"; }
            else if (bmi >= 18 && bmi < 24) { healthStatus = "Normal weight"; }
            else if (bmi >= 24 && bmi < 29) { healthStatus = "Overweight"; }
            else if (bmi >= 29) { healthStatus = "Obese"; }
        }

        lblCategory.Text = healthStatus;

    }
    public void btnNext_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new healthRecPage(healthStatus));
    }
    public void btnReturn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}