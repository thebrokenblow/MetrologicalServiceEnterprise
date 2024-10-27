using MetrologicalServiceEnterprise.ViewModel.Core;
using MetrologicalServiceEnterprise.ViewModel.Factories.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace MetrologicalServiceEnterprise.ViewModel.Factories;

public class FactoryPageVM(IServiceProvider serviceProvider) : IFactoryPageVM
{
    public BasePageVM Create<T>() where T : BasePageVM =>
        serviceProvider.GetRequiredService<T>();
}