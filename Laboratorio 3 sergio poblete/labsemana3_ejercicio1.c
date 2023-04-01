
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX 20


typedef struct {
char name[MAX];
int nivel,salud,puntaje;
} Player;


void imprimir(int a,Player players[]){
	int i  = 0;
	
	for(i=0;i<a;i++){
	printf("%s,%d,%d,%d",players[i].name,players[i].nivel,players[i].salud,players[i].puntaje);	
	}

}


int main(int argc, char *argv[]) {
	
	int cantPlayers = 0;
	int i,j;
	char auxstr[MAX];
	int a;
	int auxNiv = 0;
	int auxSal = 0;
	int auxPNTJe = 0;
	
	
	printf("ingrese la cantidad de jugadores");
	scanf("%d",&cantPlayers);
	
	Player players[cantPlayers];

	gets(auxstr);	
	
	for(i=0;i<cantPlayers;i++){
		printf("\n ingrese el nombre del jugador %d",i);
		gets(auxstr);
		printf("\n ingrese el nivel del jugador %d",i);
		scanf("%d",&auxNiv);
		printf("\n ingrese la salud del jugador %d",i);
		scanf("%d",&auxSal);
		printf("\n ingrese el puntaje del jugador %d",i);
		scanf("%d",&auxPNTJe);
		
		
		
		printf("%s,%d,%d,%d",auxstr,auxNiv,auxSal,auxPNTJe);
		
		
		for(a = 0; a < MAX;	a++)
		{
			players[i].name[a] = auxstr[a];
		}
		
		players[i].nivel =auxNiv;
		players[i].salud =auxSal;
		players[i].puntaje = auxPNTJe;
		
		printf("\n\n\n\n");
		gets(auxstr);	
	}
	
	
	imprimir(cantPlayers,players);
	
	
	
	
	
	
	
	return 0;
}
