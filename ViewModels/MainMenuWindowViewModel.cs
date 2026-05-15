using System;
using System.Reactive;
using ReactiveUI;

namespace MedStation.ViewModels;

public class MainMenuWindowViewModel: ViewModelBase
{
    
    public ReactiveCommand<Unit, Unit> OpenAdmin { get; }
    public ReactiveCommand<Unit, Unit> OpenPatient { get; }
    public ReactiveCommand<Unit, Unit> OpenEmployee { get; }


    public MainMenuWindowViewModel(MainWindowViewModel mainWindow)
    {
        OpenAdmin = ReactiveCommand.Create(() =>
        {
            mainWindow.CurrentView = new AdminPanelWindowViewModel();
        });
        OpenEmployee = ReactiveCommand.Create(() =>
        {
            mainWindow.CurrentView = new EmployeePanelWindowViewModel();
        });
        OpenPatient = ReactiveCommand.Create(() =>
        {
            mainWindow.CurrentView = new PatientPanelWindowViewModel();
        });
    }
}