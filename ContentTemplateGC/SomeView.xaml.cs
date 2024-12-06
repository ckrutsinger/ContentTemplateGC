namespace ContentTemplateGC;

public partial class SomeView : ContentView
{
	public SomeView()
	{
        InitializeComponent();

        DeviceDisplay.Current.MainDisplayInfoChanged += (sender, args) =>
        {
            SetContent();
        };
    }

    private void SetContent()
    {
        if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
        {
            ControlTemplate = (ControlTemplate)Resources["LandscapeTemplate"];
        }
        else
        {
            ControlTemplate = (ControlTemplate)Resources["PortraitTemplate"];
        }
    }
}