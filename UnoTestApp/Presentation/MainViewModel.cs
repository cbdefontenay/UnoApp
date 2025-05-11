namespace UnoTestApp.Presentation;

public partial class MainViewModel
{
    private INavigator _navigator;

    public MainViewModel(
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
       
    }
}
