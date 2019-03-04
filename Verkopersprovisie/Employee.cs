using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkopersprovisie
{
    class Employee
    {
        private string name;
        private double commission;//
        private double extra;//

        public Employee(string name, double commission, double extra)
        {
            this.name = name;
            this.commission = commission;
            this.extra = extra;
        }

        public override string ToString()
        {
            return $"Name:{name}, Commission:{commission}, Extra:{extra}";
        }

        public string Name
        {
            get { return name; }
        }

        public double Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public double Extra
        {
            get { return extra; }
            set { extra = value; }
        }
    }
}
