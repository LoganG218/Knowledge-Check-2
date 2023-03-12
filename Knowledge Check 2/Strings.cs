using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_2
{
    public class Instrument
    {
        public string Name;
    }
    public class StringInstrument : Instrument 
    {
        public int strings;
        public bool acoustic;
    }
}
