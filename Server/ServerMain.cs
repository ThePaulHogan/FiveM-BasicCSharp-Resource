using System;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace SampleResource.Server
{
    public class ServerMain : BaseScript
    {
        public ServerMain()
        {
            Debug.WriteLine("Hi from SampleResource.Server!");
        }

        [Command("hello_server")]
        public void HelloServer()
        {
            Debug.WriteLine("Sure, hello.");
        }
    }
}