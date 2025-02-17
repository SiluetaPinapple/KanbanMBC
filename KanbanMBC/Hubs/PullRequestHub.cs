using Microsoft.AspNetCore.SignalR;

namespace KanbanMBC.Hubs
{
    public class PullRequestHub : Hub
    {
        // This method can be called by clients to notify the hub
        // and then the hub broadcasts to all clients.
        public async Task NotifyPullRequestUpdated()
        {
            await Clients.All.SendAsync("RefreshPullRequests");
        }
    }
}
