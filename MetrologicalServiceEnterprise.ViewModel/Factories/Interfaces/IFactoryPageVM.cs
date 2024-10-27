using MetrologicalServiceEnterprise.ViewModel.Core;

namespace MetrologicalServiceEnterprise.ViewModel.Factories.Interfaces;

public interface IFactoryPageVM
{
    public BasePageVM Create<T>() where T : BasePageVM;
}