#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
	struct stagaire{
	int id [100];
	char Nom[100];
	};
typedef struct stagaire
stagaire;
		
int main(int argc, char *argv[]) {
		struct stagaire s1;
	printf("Donner votre Nom: ");
	scanf("%s",s1.Nom);
	printf("Donner votre id: ");
	scanf("%s",s1.id);
	return 0;
}
