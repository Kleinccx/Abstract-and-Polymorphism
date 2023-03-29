using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract
{
    internal abstract class Worker

    {
        private string FSname;
        private string LSname;

        public Worker(string FSnameval, string LSnameval)
        {
            FSname = FSnameval;
            LSname = LSnameval;
        }
        public string Fsname
        {
            get
            {
                return FSname;
            }
            set
            {
                FSname = value;
            }
        }
        public string Lsname
        {
            get
            {
                return LSname;
            }
            set
            {
                LSname = value;
            }
        }
        public override string ToString()
        {
            return Fsname + " " + LSname;
        }
        public abstract decimal Income();


    }


}