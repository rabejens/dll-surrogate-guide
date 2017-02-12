// UnmanagedBinomialCoefficient.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "UnmanagedBinomialCoefficient.h"

UnmanagedBinomialCoefficient::UnmanagedBinomialCoefficient() {
	// nothing, just for demo purposes
	// In a real project, constructor code would go here
}

ull UnmanagedBinomialCoefficient::factorial(ull n) {
	if (n < 2) {
		return 1;
	}
	ull res = 2;
	for (ull l = 3; l <= n; l++) {
		res = res * l;
	}
	return res;
}
ull UnmanagedBinomialCoefficient::calculate(ull n, ull k) {
	return factorial(n) / (factorial(k) * factorial(n - k));
}
