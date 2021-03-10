using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _6_DZ_Vvedenie
{
    class GetProcess
    {
        private Process[] AllProcesses = Process.GetProcesses();

        public int Lenght()
        {
            return AllProcesses.Length;
        }
        public String Name(int i)
        {
            return AllProcesses[i].ProcessName;
        }
        public long VirtualMemorySize(int i)
        {
            long mb = AllProcesses[i].VirtualMemorySize64 / 1024;
            return mb;
        }


    }
}
