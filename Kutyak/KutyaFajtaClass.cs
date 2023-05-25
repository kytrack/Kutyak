using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class KutyaFajtaClass
    {
        int kutyaid;
        string kutyanev;
        string realkutyanev;
        public KutyaFajtaClass(int kutyaid, string kutyanev, string realkutyanev)
        {
            this.kutyaid = kutyaid;
            this.kutyanev = kutyanev;
            this.realkutyanev = realkutyanev;
        }
        public int Kutyaid { get => kutyaid; }
        public string Kutyanev { get => kutyanev; }
        public string Realkutyanev { get => realkutyanev; }
    }
}
