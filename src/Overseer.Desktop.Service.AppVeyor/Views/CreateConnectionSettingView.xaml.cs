using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Overseer.Desktop.Service.AppVeyor.Views
{
    public class CreateConnectionSettingView : UserControl
    {
        public CreateConnectionSettingView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
