// ConsoleApplication3.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h" 
#include <iostream> 
#include <math.h> 
using namespace std;

int main()
{
	double a, S ,b, n, h, sum = 0, x;
	a = 1;
	b = 3;
	n = 512;
	h = (b - a) / n;
	for (int i = 0; i < n; i++)
	{
		x = a + i * h;
		sum += (sin(0.1) / cos(0.1))* (x * x + sqrt((1 + 0.2 * x)));
	}
	S = sum * h;
	cout << S; 
	system("PAUSE");
}

