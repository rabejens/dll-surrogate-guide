using BinomialInterface;
using ComUtil;
using System;
using System.Runtime.InteropServices;

namespace BinomialCoefficientApp {

    public class BinomialCoefficient : IBinomialCoefficient {

        private readonly dynamic _com;
        private bool _disposed;

        public BinomialCoefficient() {
            _com = ComHelper.CreateOutOfProcessComObject(Guid.Parse("4256000c-cc30-44ea-a719-dc47f526ae6a"));
        }

        public ulong BinCo(ulong n, ulong k) {
            if (_disposed) {
                throw new ObjectDisposedException("BinomialCoefficient");
            }
            return _com.BinCo(n, k);
        }

        public void Dispose() {
            if (_disposed) return;
            _com.Dispose();
            Marshal.ReleaseComObject(_com);
            _disposed = true;
        }
    }
}
