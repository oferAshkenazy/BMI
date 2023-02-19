namespace BMI;

public partial class MainPage : ContentPage
{
    private string stateName;
    private double weight;
    private double height;

    public MainPage()
	{
		InitializeComponent();
	}

    private void XAMLSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        stateName = e.Value ? "female" : "male";
        switchStateLabel.Text = $" {stateName}";
    }
   private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
         weight = e.NewValue;
       
       
        _displayLabel.Text = string.Format("The weight is {0}", weight);
    }
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
         height = args.NewValue;
       
        displayLabel.Text = String.Format("the height is {0:0.##}", height);
    }
    private void OnButtonClicked(object sender, EventArgs args)
    {
        double calc = weight/((height/100) * (height/100)) ;
       label.Text=($"{calc}");
       if(calc<=18.5)
        {
            result.Text = "under weight";
        }
        else if (calc > 18.5 && calc <= 25)
        {
            result.Text = "ok weight";
        }
        else if (calc > 25 && calc <= 29.9)
        {
            result.Text = "a little over weight";
        }
        else if (calc > 29.9 && calc <= 40)
        {
            result.Text = "over weight";
        }
        else if (calc > 40)
        {
            result.Text = "really over weight";
        }

    }
}

