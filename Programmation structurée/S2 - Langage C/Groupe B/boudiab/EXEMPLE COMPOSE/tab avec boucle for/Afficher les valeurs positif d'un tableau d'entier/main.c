#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main()
{
int tableau[4]={10,-20,-30,-76};
int i;
for(i=0;i<4;i++)
{
if(tableau[i]>0)
printf("%d \n",tableau[i]);
}
	return 0;
}
