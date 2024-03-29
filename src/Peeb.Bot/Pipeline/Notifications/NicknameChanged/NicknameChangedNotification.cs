using MediatR;

namespace Peeb.Bot.Pipeline.Notifications.NicknameChanged
{
    public class NicknameChangedNotification : INotification
    {
        public ulong UserId { get; }
        public string Nickname { get; }

        public NicknameChangedNotification(ulong userId, string nickname)
        {
            UserId = userId;
            Nickname = nickname;
        }
    }
}
