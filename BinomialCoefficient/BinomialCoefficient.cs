using BinomialInterface;
using System.Runtime.InteropServices;
using System;

namespace BinomialCoefficient {

    [ComVisible(true)]
    [Guid("4256000c-cc30-44ea-a719-dc47f526ae6a")]
    public class BinomialCoefficient : IBinomialCoefficient {

        public ulong BinCo(ulong n, ulong k) {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        private ulong Factorial(ulong n) {
            if (n < 2) {
                return 1;
            }
            ulong res = 2;
            for (ulong l = 3; l <= n; l++) {
                res *= l;
            }
            return res;
        }

        public void Dispose() {
            // not needed for now
        }
    }
}
