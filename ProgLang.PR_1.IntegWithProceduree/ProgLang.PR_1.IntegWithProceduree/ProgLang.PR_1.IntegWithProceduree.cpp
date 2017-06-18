//Нахождение интеграла методом прямоугольников без использования процедур. 
#include "stdafx.h" 
#include <iostream> 
#include <math.h> 
using namespace std;
void main()
{
	double h, S, x, a, b;
	int i, n;
	double f[1000];
	a = 1;  
	b = 3;  
	n = 512; 
	x = 0;
	h = (b - a) / (float)n; 
	S = 0; 
	for (i = 0; i <= n; i++)
	{
		x = a + i*h;
		f[i] = (sin(0.1) / cos(0.1))* (x * x + sqrt((1 + 0.2 * x))); 
		S = S + f[i];
	}
	S = h*S;
	cout << S;
	system("PAUSE");
}

