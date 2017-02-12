using BinomialInterface;
using System.Runtime.InteropServices;
using System;

namespace BinomialCoefficient {

    [ComVisible(true)]
    [Guid("4256000c-cc30-44ea-a719-dc47f526ae6a")]
    public class BinomialCoefficient : IBinomialCoefficient {

        private readonly BinomialCoefficientBridge.BinomialCoefficientBridge _bridge;

        public BinomialCoefficient() {
            _bridge = new BinomialCoefficientBridge.BinomialCoefficientBridge();
        }

        public ulong BinCo(ulong n, ulong k) {
            return _bridge.Calculate(n, k);
        }

        public void Dispose() {
            _bridge.Dispose();
        }
    }
}
