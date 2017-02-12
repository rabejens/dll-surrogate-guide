using System;

namespace BinomialInterface {

    public interface IBinomialCoefficient : IDisposable {

        ulong BinCo(ulong n, ulong k);
    }
}
