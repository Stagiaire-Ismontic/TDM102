#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int a=0;
	while(a<10)
{
	a++;
	if(a==5)
	{continue;}
	else if(a==8)
	{continue;}
	printf("%d \n",a);
	}	
	
	return 0;
}
