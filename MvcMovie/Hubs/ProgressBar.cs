using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MvcMovie.Hubs
{
    public class ProgressBar : Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task getRabbitStatus(int liebreDist)
        {

            var randDist = new Random();
            var randSleep = new Random();
            int distLiebre = randDist.Next(1, 10);
            int liebreSleep = randSleep.Next(1, distLiebre * 2);
            await Task.Run(() =>
            {
                Thread.Sleep(liebreSleep * 1000);
                liebreDist += distLiebre;
                return Clients.All.SendAsync("ReceiveRabbitDist", liebreDist);
            });            
        }

        public async Task getTurtleStatus(int tortugaDist)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                tortugaDist++;
                return Clients.All.SendAsync("ReceiveTurtleDist", tortugaDist);
            });            
        }
    }
}
