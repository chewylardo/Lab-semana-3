#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX 20
#define MAX1 5
#define MIN 1
#include <time.h>


typedef struct {
char name[MAX];
int nivel,salud,puntaje,dmg;
} Player;


Player imprimir(int cantPlayers,Player players[]){
	
	int i = 0;
	char auxstr[MAX];
	int a = 0;
	int auxNiv = 0;
	int auxSal = 0;
	int auxPNTJe = 0;
	int auxDmg  = 0;
	
	

	
	for(i=0;i<cantPlayers;i++){
		gets(auxstr);
		printf("\n ingrese el nombre del jugador %d",i);
		gets(auxstr);
		printf("\n ingrese el nivel del jugador %d",i);
		scanf("%d",&auxNiv);
		printf("\n ingrese la salud del jugador %d",i);
		scanf("%d",&auxSal);
		printf("\n ingrese el puntaje del jugador %d",i);
		scanf("%d",&auxPNTJe);
		printf("\n ingrese el daño del jugador %d",i);
		scanf("%d",&auxDmg);
	
	
		
		
		
		printf("%s,%d,%d,%d,%d",auxstr,auxNiv,auxSal,auxPNTJe,auxDmg);
		
		
		for(a = 0; a < MAX;	a++)
		{
			players[i].name[a] = auxstr[a];
		}
		
		players[i].nivel =auxNiv;
		players[i].salud =auxSal;
		players[i].puntaje = auxPNTJe;
		players[i].dmg = auxDmg;
		
		
		
		printf("\n\n\n\n");
	}
	
	return *players;

}



Player Pelear(int cantPlayers,Player players1[], Player players2[]){
	
	srand(time(NULL));
	int i=0;
	int auxSelector1,auxSelector2,auxSelector3;
	
	system("cls");
	printf("\n\n que personaje del equipo1 quiere que pelee?");
		for(i=0;i<cantPlayers;i++){
			printf("\n[%d] = %s",i, players1[i].name);
		}
		scanf("%d",&auxSelector1);		
	system("cls");

	printf("\n\n que personaje del equipo2 quiere que pelee?");
		for(i=0;i<cantPlayers;i++){
			printf("\n[%d] = %s",i, players2[i].name);
		}
	scanf("%d",&auxSelector2);
	system("cls");
	
	printf("desea que %s del equipo 1 pelee contra %s del equipo 2",players1[auxSelector1].name,players2[auxSelector2].name);
	printf("\n ingrese 1 para si y 2 para no");
	scanf("%d",&auxSelector3);
	
	int random = rand()%2;
	
	if(auxSelector3 == 1){
		
		if(random == 0){
			players1[auxSelector1].salud-=players2[auxSelector2].dmg;
			if(players1[auxSelector1].salud>0){
				players2[auxSelector2].salud-=players1[auxSelector1].dmg;
				if(players2[auxSelector2].salud<=0){
					printf("\n %s del equipo 2 murio en combate",players2[auxSelector2].name);	
				}	
			}else{
				printf("\n %s del equipo 1 murio en combate",players1[auxSelector1].name);
			}
		}else{
			players2[auxSelector2].salud-=players1[auxSelector1].dmg;
			if(players2[auxSelector2].salud>0){
				players1[auxSelector1].salud-=players2[auxSelector2].dmg;
				if(players1[auxSelector1].salud<=0){
					printf("\n %s del equipo 1 murio en combate",players1[auxSelector1].name);	
				}	
			}else{
				printf("\n %s del equipo 2 murio en combate",players2[auxSelector2].name);
			}
		}
		
		
	}
	
	
		return *players1,*players2;
	
	
}















int main(int argc, char *argv[]) {
	
	int cantPlayers = 0;

/*Para el combate al jugador se le pide que ingrese cuales son los 2 personajes que quiere pelear ,luego se randomiza cual de los 2 pelea primero.
si uno de los 2 queda con 0 o menos de vida se le envia un mensaje al usuario de que personaje murio y cual sobrevivio, sino muere ninguno se le dice con cuanta vida quedo cada uno
todo esto ocurre en una funcion que retorna el puntero de donde quedo guardado todo dado a que el array de estructuras no se puede retornar de forma directa*/	

	
	while(cantPlayers>MAX1 || cantPlayers<MIN){
	printf("ingrese la cantidad de jugadores por equipo");
	scanf("%d",&cantPlayers);	
	}
	
	
	Player players1[cantPlayers];
	Player players2[cantPlayers];

	printf("\n\nPara el equipo 1");	
	*players1=imprimir(cantPlayers,players1);
	printf("\n\nPara el equipo 2");
	*players1=imprimir(cantPlayers,players2);	
	
	

	*players1,*players2 = Pelear(cantPlayers,players1,players2);
	
	
	
	return 0;
}
