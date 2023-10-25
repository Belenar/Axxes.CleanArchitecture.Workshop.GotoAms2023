namespace BeerSender.Application;

public interface IHandleCommand<in TCommand, out TResult>
{
    TResult Handle(TCommand command);
}