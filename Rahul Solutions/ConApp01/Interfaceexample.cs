using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    interface IDataSource
    {
        void GetData();

    }
    class MSsql : IDataSource
    {
        public void GetData()
        {
            Console.WriteLine("Data coming from the Sql server");

        }
    }
    class Oracle : IDataSource
    {
        public void GetData()
        {
            Console.WriteLine("Data coming from Oracle server");

        }
    }
    public class Interfaceexample
    {
        static void Main ()
        {
            IDataSource source;
            source = new Oracle ();
            source = new MSsql ();
            source.GetData();
        }
    }
}
