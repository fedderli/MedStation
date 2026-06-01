using System.Reactive;
using MedStation.Views;
using ReactiveUI;

namespace MedStation.ViewModels;

public class AdminLoginWindowViewModel : ViewModelBase
{

    public AdminLoginWindowViewModel(MainWindowViewModel mainWindow)
    {
        openMainMenu = ReactiveCommand.Create( () => { mainWindow.CurrentView = new MainMenuWindowViewModel(mainWindow); });
    }
    
    public ReactiveCommand<Unit, Unit> openMainMenu { get; }
}