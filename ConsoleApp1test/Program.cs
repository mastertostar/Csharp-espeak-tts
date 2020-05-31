using ESpeakWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1test
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Initialize("." );
            Client.SetVoiceByName("zh+m10");
            Client.Speak("helloworld！");
            // 等待发音结束
            Client.Espeak_Synchronize();
            //Client.Espeak_Terminate();
            //Thread.Sleep(5000);
            Client.Stop();
            Client.Speak("我爱，中国。Hello world");
            Client.Espeak_Synchronize();
            Client.Espeak_Terminate();
            Console.Read();
        }

        
    }
}
