//Нахождение интеграла методом прямоугольников с использование процедур. 
#include "stdafx.h" 
#include <iostream> 
#include <math.h> 
using namespace std;
float f(float x)
{
	return(sin(0.1) / cos(0.1))* (x * x + sqrt((1 + 0.2 * x)));
}
float integral(double a, double b, double n)
{
	double h, S, x;
	int i;
	h = (b - a) / (float)n;
	S = 0;
	for (i = 0; i <= n; i++)
	{
		x = a + i*h;
		S = S + f(x);
	}
	S = h*S;
	return S;
}
void main()
{
	double y;
	y = integral(1, 3, 1024);
	cout << y;
	system("PAUSE");
}