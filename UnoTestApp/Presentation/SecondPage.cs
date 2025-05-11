namespace UnoTestApp.Presentation;

public sealed partial class SecondPage : Page
{
    public SecondPage()
    {
        this.DataContext<SecondViewModel>((page, vm) => page
            .Content(new Grid()
                .Children(
                    new TextBlock()
                        .Text("Second Page")
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .VerticalAlignment(VerticalAlignment.Center)
                    )
            )
        );
    }
}
