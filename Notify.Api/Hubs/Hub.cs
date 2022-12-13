using Microsoft.AspNetCore.SignalR;

namespace Notify.Api.Hubs
{
    public class Hub : Hub<ICustomHub>
    {
        public async Task SendMessage(NotifyModel model)
        {
            await Clients.All.ReceiveMessage(model);
        }
    }
}
