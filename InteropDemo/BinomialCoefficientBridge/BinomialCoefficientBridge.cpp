// This is the main DLL file.

#include "stdafx.h"

#include "BinomialCoefficientBridge.h"

namespace BinomialCoefficientBridge {

	BinomialCoefficientBridge::BinomialCoefficientBridge() {
		u_delegate = new UnmanagedBinomialCoefficient();
		m_disposed = false;
	}

	BinomialCoefficientBridge::~BinomialCoefficientBridge() {
		if (m_disposed) return;
		delete u_delegate;
		m_disposed = true;
	}

	ull BinomialCoefficientBridge::Calculate(ull n, ull k) {
		if (m_disposed) {
			throw gcnew ObjectDisposedException("BinomialCoefficientBridge");
		}
		return u_delegate->calculate(n, k);
	}
}
