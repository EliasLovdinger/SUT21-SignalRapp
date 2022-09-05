using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SUT21_SignalRapp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string fromUser, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",fromUser,message);
        }
    }
}
