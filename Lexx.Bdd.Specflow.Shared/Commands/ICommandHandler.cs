using System.Threading.Tasks;

namespace Lexx.Bdd.Specflow.Shared.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task<ICommandResult> HandleAsync(T command);
    }
}
