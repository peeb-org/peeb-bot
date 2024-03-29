using MediatR;

namespace Peeb.Bot.Pipeline.Notifications.RoleAdded
{
    public class RoleAddedNotification : INotification
    {
        public ulong UserId { get; }
        public ulong RoleId { get; }

        public RoleAddedNotification(ulong userId, ulong roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}
