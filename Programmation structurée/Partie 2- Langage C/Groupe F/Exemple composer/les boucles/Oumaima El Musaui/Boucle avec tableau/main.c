#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	double tableau [4]={1.1,2.2,3.3,4.4};
	int i ;
	for ( i=0;i<4;i++)
	{
		printf ("%.1lf\n",tableau [i]);
	}
	return 0;
}
