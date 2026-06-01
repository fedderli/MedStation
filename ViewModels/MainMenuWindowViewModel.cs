using System.Reactive;
using ReactiveUI;

namespace MedStation.ViewModels;

public class MainMenuWindowViewModel : ViewModelBase
{
    public MainMenuWindowViewModel(MainWindowViewModel mainWindow)
    {
        OpenAdmin = ReactiveCommand.Create(() => { mainWindow.CurrentView = new AdminLoginWindowViewModel(mainWindow); });
        OpenEmployee = ReactiveCommand.Create(() => { mainWindow.CurrentView = new EmployeePanelWindowViewModel(); });
        OpenPatient = ReactiveCommand.Create(() => { mainWindow.CurrentView = new PatientPanelWindowViewModel(); });
    }

    public ReactiveCommand<Unit, Unit> OpenAdmin { get; }
    public ReactiveCommand<Unit, Unit> OpenPatient { get; }
    public ReactiveCommand<Unit, Unit> OpenEmployee { get; }
}