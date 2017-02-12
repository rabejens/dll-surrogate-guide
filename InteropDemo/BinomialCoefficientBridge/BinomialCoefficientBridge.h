// BinomialCoefficientBridge.h

#pragma once

#include <UnmanagedBinomialCoefficient.h>

using namespace System;

namespace BinomialCoefficientBridge {

	public ref class BinomialCoefficientBridge {
	private:
		UnmanagedBinomialCoefficient* u_delegate;
		bool m_disposed;
	public:
		BinomialCoefficientBridge();
		~BinomialCoefficientBridge();
		ull Calculate(ull n, ull k);
	};
}
