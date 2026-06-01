using ReactiveUI;

namespace MedStation.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase? _currentView;

    public MainWindowViewModel()
    {
        CurrentView = new MainMenuWindowViewModel(this);
    }

    public ViewModelBase? CurrentView
    {
        get => _currentView;
        set => this.RaiseAndSetIfChanged(ref _currentView, value);
    }
}