using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception<DiskFullExceptionArgs>(new DiskFullExceptionArgs(null), "The disk is full");
                throw new Exception<DiskFullExceptionArgs>(new DiskFullExceptionArgs(@"C:\"), "The disk is full");
            }
            catch (Exception<DiskFullExceptionArgs> e)
            {
                Console.WriteLine(e.Message);
            }
            throw new Exception<DiskFullExceptionArgs>(new DiskFullExceptionArgs(@"C:\"), "The disk is full");
        }
    }
}
