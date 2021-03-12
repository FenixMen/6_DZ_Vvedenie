using System;
using System.Collections.Generic;
using System.Text;

namespace _6_DZ_Vvedenie
{
    class Processes
    {


        public static void KillById(int id, GetProcess allProcesses) => allProcesses.Kill(id);
        public static void KillByName(string name, GetProcess allProcesses) => allProcesses.Kill(name);
    }
}
