namespace UnoTestApp.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.Content(
            new Grid()
                .Region(attached: true)
                .RowDefinitions(",Auto")
                .ColumnDefinitions("Auto,*")
                .Visibility(Visibility.Visible)
                .Children(
                    new Grid()
                        .Region(attached: true)
                        .Visibility(Visibility.Visible)
                        .Grid(row: 0, column: 1)
                        .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                        .Children(
                            new TabBar()
                                .Region(attached: true)
                                .Visibility(Visibility.Visible)
                                .Grid(row: 1, column: 1)
                                .Style(x => x.StaticResource("BottomTabBarStyle"))
                                .SelectedIndex(0)
                                .Items(
                                    new TabBarItem().Icon(new SymbolIcon(Symbol.Home))
                                        .Region(attached: true)
                                        .Name("Home")
                                        .Content("Accueil")
                                        .Style(x => x.StaticResource("MaterialBottomTabBarItemStyle")),
                                    new TabBarItem().Icon(new SymbolIcon(Symbol.BlockContact))
                                        .Region(attached: true)
                                        .Content("Second")
                                        .Name("Second").Style(x => x.StaticResource("MaterialBottomTabBarItemStyle")
                                        ),
                                    new TabBarItem().Icon(new SymbolIcon(Symbol.Setting))
                                        .Region(attached: true)
                                        .Content("Paramètres")
                                        .Name("Settings").Style(x => x.StaticResource("MaterialBottomTabBarItemStyle")
                                        )
                                )
                        )
                )
        );
    }
}
