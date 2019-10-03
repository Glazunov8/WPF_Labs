using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1B
{
    class Elevator
    {
        public int Stage = 0;
        public int Now { get; set; } = 1;
        public int Way { get; set; }
        public readonly int MaxFloor = 5;

        public Elevator(int MaxFloor)
        {
            this.MaxFloor = MaxFloor;
        }

        public string Upstairs()
        {
            return "Лифт едет (" + ++Now + ")";
        }

        public string Downstairs()
        {
            return "Лифт едет (" + --Now + ")";
        }

        public string OpenTheDoor()
        {
            return "Двери открыты";
        }

        public string CloseTheDoor()
        {
            return "Двери закрыты";
        }

        public bool IsTheEnd()
        {
            if (Now == Way) return true;
            return false;
        }
    }
}
