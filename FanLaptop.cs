using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300025
{
    internal class FanLaptop
    {
        public enum state {quite, balance, performence, turbo}
        private state currentState;

        public FanLaptop()
        {
            if (currentState == state.quite) { 
            }
            currentState = state.quite;
            Console.WriteLine("fan dalam keadaan quite");
        }
        public void FanBalance()
        {
            if (currentState == state.quite)
            {
                currentState = state.balance;
                Console.WriteLine("fan quite berubah menjadi balance");
            }
            else
            {
                Console.WriteLine("fan tidak dalam keadaan balance");
            }
           
        }
        public void Fanperformence()
        {
            if (currentState == state.quite)
            {
                currentState = state.performence;
                Console.WriteLine("fan quite berubah menjadi performence");
            }
            else
            {
                Console.WriteLine("fan tidak dalam keaadan performence");
            }
        }
        public void Fanturbo()
        {
            if (currentState == state.quite)
            {
                currentState = state.turbo;
                Console.WriteLine("fan dalam keadaan turbo");
            }
            else
            {
                Console.WriteLine("fan tidak dalam keaadan turbo");
            }
            
        }
    }
}
