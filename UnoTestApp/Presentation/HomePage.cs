namespace UnoTestApp.Presentation;

public sealed partial class HomePage : Page
{
    public HomePage()
    {
        this.DataContext<HomeViewModel>((page, vm) => page
            .Content(new StackPanel()
                .VerticalAlignment(VerticalAlignment.Center)
                .HorizontalAlignment(HorizontalAlignment.Center)
                .Children
                (
                    new TextBlock()
                        .Text("Ma première page")
                )
            )
        );
    }
}
