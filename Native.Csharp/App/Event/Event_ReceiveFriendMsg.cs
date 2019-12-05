using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;

namespace Native.Csharp.App.Event
{
    public class Event_ReceiveFriendMsg : IReceiveFriendMessage
    {
        private IReceiveFriendMessage _receiveFriendMessageImplementation;
        public void ReceiveFriendMessage(object sender, CqPrivateMessageEventArgs e)
        {
            Common.CqApi.SendPrivateMessage(e.FromQQ, e.Message);
        }
    }
}