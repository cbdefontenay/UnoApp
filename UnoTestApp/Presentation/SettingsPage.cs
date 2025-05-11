namespace UnoTestApp.Presentation;

public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        this.DataContext<SettingsViewModel>((page, vm) => page
            .Content(new StackPanel()
                .VerticalAlignment(VerticalAlignment.Center)
                .HorizontalAlignment(HorizontalAlignment.Center)
                .Children
                (
                    new TextBlock()
                        .Text("Les Paramètres")
                )
            )
        );
    }
}
