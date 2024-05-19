#include "pch.h"
#include "Calculate.h"
#include "stdexcept"

Calculate::Calculate(int x) {
	this->x = x;
}

int Calculate::add(int y) {
	return this->x + y;
}

int Calculate::multiply(int y) {
	return this->x * y;
}

int Calculate::subtract(int y) {
	return this->x - y;
}

int Calculate::divide(int y) {
	if (y == 0) {
		throw std::domain_error("Cannot divide by 0");
	}
	return this->x / y;
}