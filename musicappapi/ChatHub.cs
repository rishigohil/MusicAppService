using Microsoft.AspNet.SignalR;

namespace MusicAppApi
{
    /// <summary>
    /// Test class for Chathub.
    /// </summary>
    /// <seealso cref="Microsoft.AspNet.SignalR.Hub" />
    public class ChatHub : Hub
    {
        /// <summary>
        /// Sends the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="message">The message.</param>
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}