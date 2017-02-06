using System;
using System.Runtime.InteropServices;

namespace ComUser {

    class Program {

        static void Main(string[] args) {
            dynamic com = null;
            try {
                com = ComHelper.CoCreateInstance(Guid.Parse("4256000c-cc30-44ea-a719-dc47f526ae6a"),
                                                    null,
                                                    CLSCTX.CLSCTX_LOCAL_SERVER,
                                                    ComHelper.UNKNOWN);
                ulong n = 5;
                ulong k = 3;
                ulong b = com.BinCo(n, k);
                Console.WriteLine(string.Format("b({0}, {1}) = {2}", n, k, b));
            } finally {
                if (com != null) {
                    Marshal.ReleaseComObject(com);
                }
            }
            Console.ReadKey();
        }
    }
}
