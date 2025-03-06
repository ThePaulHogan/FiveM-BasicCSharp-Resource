using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace SampleResource.Client
{
    public class ClientMain : BaseScript
    {
        public ClientMain()
        {
            Debug.WriteLine("Hi from MyResour ce.Client!");
            Tick += OnTick;
        }
        public Task OnTick()
        {
            DrawRect(0.5f, 0.5f, 0.5f, 0.5f, 255, 255, 255, 150);

            return Task.FromResult(0);
        }
    }
}