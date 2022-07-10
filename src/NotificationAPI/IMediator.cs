namespace Bosch.CodeManagement.Extension.NotificationAPI;

//Todo
public interface IMediator
{
    // todo
    ValueTask<object?> Send(object command);
}