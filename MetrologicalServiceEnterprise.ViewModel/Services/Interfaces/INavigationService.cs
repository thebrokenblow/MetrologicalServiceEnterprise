using MetrologicalServiceEnterprise.ViewModel.Core;

namespace MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;

public interface INavigationService
{
    BasePageVM? BasePageVM { get; }
    void NavigateTo<T>() where T : BasePageVM;
}