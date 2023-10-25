using BeerSender.Domain;

namespace BeerSender.Application.Boxes.Create;

public class CreateBoxHandler : IHandleCommand<CreateBox, CreateBoxResult>
{
    private readonly IBoxSaver _boxSaver;
    private readonly IEnumerable<IBoxCreatedNotifier> _notifiers;

    public CreateBoxHandler(
        IBoxSaver boxSaver, 
        IEnumerable<IBoxCreatedNotifier> notifiers)
    {
        _boxSaver = boxSaver;
        _notifiers = notifiers;
    }

    public CreateBoxResult Handle(CreateBox command)
    {
        // Validate the input
        try
        {
            var capacity = BoxCapacity.FromNumberOfSpots(command.NumberOfSpots);
            
            // Create a box entity
            var box = new Box(capacity);

            // Persist
            _boxSaver.SaveBox(box);

            // Notify other services
            foreach (var boxCreatedNotifier in _notifiers)
            {
                boxCreatedNotifier.NotifyOfBoxCreated(box);
            }

            return CreateBoxResult.Success;
        }
        catch (InvalidNumberOfSpotsException)
        {
            return CreateBoxResult.InvalidNumberOfSpots;
        }
    }
}