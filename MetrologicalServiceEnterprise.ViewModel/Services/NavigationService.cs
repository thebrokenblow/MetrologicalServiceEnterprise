using CommunityToolkit.Mvvm.ComponentModel;
using MetrologicalServiceEnterprise.ViewModel.Core;
using MetrologicalServiceEnterprise.ViewModel.Factories.Interfaces;
using MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;

namespace MetrologicalServiceEnterprise.ViewModel.Services;

public class NavigationService(IFactoryPageVM factoryPageVM) : ObservableObject, INavigationService
{
    private BasePageVM? basePageVM;
    public BasePageVM? BasePageVM
    {
        get => basePageVM;
        private set
        {
            basePageVM = value;
            OnPropertyChanged();
        }
    }

    public void NavigateTo<T>() where T : BasePageVM
    {
        BasePageVM = factoryPageVM.Create<T>();
    }
}