using Bosch.CodeManagement.Extension.Domain;

namespace Bosch.CodeManagement.Extension.Application.UseCases.Bitbucket;

public interface INotifyUsers
{
    public void NotifyBitBucketUsers(ICollection<Notification> notifications);
}