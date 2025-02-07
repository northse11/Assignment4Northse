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
        double bmi = Math.Round((weight * 703)/(height * height), 1);
        if (choice.Equals("male")) 
        {
            if (bmi < 18.5) { healthStatus = "Underweight"; }
            else if (bmi >= 18.5 && bmi < 25) { healthStatus = "Normal weight"; }
            else if (bmi >=25 && bmi < 30) { healthStatus = "Overweight"; }
            else if (bmi >= 30) { healthStatus = "Obese"; }
        }
        else if(choice.Equals("female"))
        {
            if (bmi < 18) { healthStatus = "Underweight"; }
            else if (bmi >= 18 && bmi < 24) { healthStatus = "Normal weight"; }
            else if (bmi >= 24 && bmi < 29) { healthStatus = "Overweight"; }
            else if (bmi >= 29) { healthStatus = "Obese"; }
        }
        if (healthStatus.Equals("Underweight")) { healthRec = ("-Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains)" + "\n" + 
                                                               "-Incorporate strength training to build muscle mass" + "\n" +
                                                               "-Consult a nutritionist if needed"); }
        else if (healthStatus.Equals("Normal weight")) { healthRec = ("-Maintain a balanced diet with proteins, healthy fats, and fiber" + "\n" +
                                                                      "-Stay physically active with at least 150 minutes of exercise per week" + "\n" +
                                                                      "-Keep regular check-ups to monitor overall health"); }
        else if (healthStatus.Equals("Overweight")) { healthRec = ("-Reduce processed foods and focus on portion control" + "\n" +
                                                                   "-Engage in regular aerobic exercises(e.g., jogging, swimming) and strength training" + "\n" +
                                                                   "-Drink plenty of water and track your progress"); }
        else if (healthStatus.Equals("Obese")) { healthRec = ("-Consult a doctor for personalized guidance" + "\n" +
                                                              "-Start with low-impact exercises (e.g., walking, cycling)" + "\n" +
                                                               "-Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes" + "\n" +
                                                               "-Avoid sugary drinks and maintain a consistent sleep schedule"); }

        DisplayAlert("Your calculated BMI results are: ", "Gender: " + choice + "\n" + "BMI: " + bmi.ToString() + "\n" + "Health Status: " + healthStatus + "\n" + "Health Reccomendations: " + "\n" + healthRec,"Ok");
    }

}