using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using si0n;

namespace si0n_csharp_wrapper {
    class Program {
        static void Main(string[] args) {
            Module1 si0nMod = new Module1();

            // Manually update offsets here
            // EX: Offsets.dwClientState = 0x000;

            string[] si0nArgs = {
                "si0n - CS:GO" // console title here

            };

            si0nMod.Main(si0nArgs);
        }
    }
}
