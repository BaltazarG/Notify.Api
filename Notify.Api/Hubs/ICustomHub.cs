namespace Notify.Api.Hubs
{
    public interface ICustomHub
    {
        Task ReceiveMessage(NotifyModel model);

    }
}
