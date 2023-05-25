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
        string kutyanev;

        public KutyaClass(int kutyaid, string kutyanev)
        {
            this.kutyaid = kutyaid;
            this.kutyanev = kutyanev;
        }

        public int Kutyaid { get => kutyaid;}
        public string Kutyanev { get => kutyanev;}
    }
}
