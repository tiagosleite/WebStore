using WebStore.Shared.Entities;

namespace WebStore.Shared.Commands
{
    public interface ICommandHandler<T> where T : Command
    {
         CommandResult Handle(T command);
    }
}