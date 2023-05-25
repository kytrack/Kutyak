using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class KutyaClass
    {
        int kutyaid;
        int fajtaid;
        int nevid;
        int eletkor;
        string utolsoell;

        public KutyaClass(int kutyaid, int fajtaid, int nevid, int eletkor, string utolsoell)
        {
            this.kutyaid = kutyaid;
            this.fajtaid = fajtaid;
            this.nevid = nevid;
            this.eletkor = eletkor;
            this.utolsoell = utolsoell;
        }

        public int Kutyaid { get => kutyaid; }
        public int Fajtaid { get => fajtaid; }
        public int Nevid { get => nevid; }
        public int Eletkor { get => eletkor; }
        public string Utolsoell { get => utolsoell; }
    }
}
