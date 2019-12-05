using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;

namespace Native.Csharp.App.Event
{
    public class Event_ReceiveGroupMsg : IReceiveGroupMessage
    {
        public void ReceiveGroupMessage(object sender, CqGroupMessageEventArgs e)
        {
            Common.CqApi.SendGroupMessage(e.FromGroup, $"收到消息，群号[{e.FromGroup}]，QQ[{e.FromQQ}],内容[{e.Message}]");
        }
    }
}