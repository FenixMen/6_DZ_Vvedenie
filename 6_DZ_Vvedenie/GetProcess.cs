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
        public string VirtualMemorySize(int i)
        {
            string mb = MbFormat.FormatToMb((AllProcesses[i].WorkingSet64));
            return mb;
        }
        public int Id(int i)
        {
            int id = (AllProcesses[i].Id);
            return id;
        }
        public void Kill(int id)
        {
            for (int i = 0; i < AllProcesses.Length; i++)
            {
                if (AllProcesses[i].Id == id)
                {
                    id = i;
                    break;
                }
            }
            try
            {
                Console.WriteLine($"Завершить процес {AllProcesses[id].ProcessName} Y - да, N - нет");
                if (Console.ReadLine().ToLower() == "y")
                AllProcesses[id].Kill();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Введен неверный индекс");
                Console.ReadLine();
            }
        }
        public void Kill(string name)
        {
            int id = -1;
            for (int i = 0; i < AllProcesses.Length; i++)
            {
                if (AllProcesses[i].ProcessName == name)
                {
                    id = i;
                    break;
                }
            }
            try
            {
                Console.WriteLine($"Завершить процес {AllProcesses[id].ProcessName} Y - да, N - нет");
                if (Console.ReadLine().ToLower() == "y")
                    AllProcesses[id].Kill();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Введено неверное имя");
                Console.ReadLine();
            }
        }
    }
}
