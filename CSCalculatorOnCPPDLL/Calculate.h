#pragma once
class Calculate {
private:
	int x;
public:
	Calculate(int x);
	int add(int y);
	int subtract(int y);
	int multiply(int y);
	int divide(int y);
};

// Helper methods for constructor and other method
extern "C" _declspec(dllexport) void* Initialize(int x) {
	return (void*) new Calculate(x);
}

extern "C" _declspec(dllexport) int Add(Calculate* x, int y) {
	return x->add(y);
}

extern "C" _declspec(dllexport) int Multiply(Calculate* x, int y) {
	return x->multiply(y);
}

extern "C" _declspec(dllexport) double Divide(Calculate * x, int y) {
	return x->divide(y);
}

extern "C" _declspec(dllexport) int Subtract(Calculate * x, int y) {
	return x->subtract(y);
}