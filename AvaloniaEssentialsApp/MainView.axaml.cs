using System.Text;
using Avalonia.Controls;
using Microsoft.Maui.Devices;

namespace AvaloniaEssentialsApp;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        DataContext = this;
    }

    public string DeviceInfoString
    {
        get
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Model: {DeviceInfo.Current.Model}");
            stringBuilder.AppendLine($"Manufacturer: {DeviceInfo.Current.Manufacturer}");
            stringBuilder.AppendLine($"Name: {DeviceInfo.Current.Name}");
            stringBuilder.AppendLine($"OS Version: {DeviceInfo.Current.VersionString}");
            stringBuilder.AppendLine($"Idiom: {DeviceInfo.Current.Idiom}");
            stringBuilder.AppendLine($"Platform: {DeviceInfo.Current.Platform}");

            return stringBuilder.ToString();
        }
    }
}