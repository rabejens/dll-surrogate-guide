// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the UNMANAGEDBINOMIALCOEFFICIENT_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// UNMANAGEDBINOMIALCOEFFICIENT_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef UNMANAGEDBINOMIALCOEFFICIENT_EXPORTS
#define UNMANAGEDBINOMIALCOEFFICIENT_API __declspec(dllexport)
#else
#define UNMANAGEDBINOMIALCOEFFICIENT_API __declspec(dllimport)
#endif

#ifndef ull
#define ull unsigned long long
#endif

class UNMANAGEDBINOMIALCOEFFICIENT_API UnmanagedBinomialCoefficient {
private:
	ull factorial(ull n);
public:
	UnmanagedBinomialCoefficient(void);
	ull calculate(ull n, ull k);
};
