using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class DiskFullExceptionArgs : ExceptionArgs
    {
        private readonly string m_diskpath;     //private field, initialized during creation time

        public DiskFullExceptionArgs(string diskpath)
        {
            m_diskpath = diskpath;
        }

        //public readonly property, which returns field
        public string DiskPath { get { return m_diskpath; } }

        public override string Message {
            get {
                return (m_diskpath == null) ? base.Message : "DiskPath=" + m_diskpath;
            }
        }
    }
}
