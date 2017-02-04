#include <stdio.h>
#include <stdlib.h>

int main(){
	int n, c, k, space = 1;
	printf("Unesi broj \n");
	scanf(" %d", &n);
	space = n - 1;
	for (k = 1; k <= n; k++){
		for (c = 1; c <= space; c++)
			printf(" ");
		space--;
		for (c = 1; c <= 2 * k - 1; c++)
			printf("*");
		printf("\n");
	}
	space = 1;
	for (k = 1; k <= n - 1; k++){
		for (c = 1; c <= space; c++)
			printf(" ");
		space++;
		for (c = 1; c <= 2 * (n - k) - 1; c++)
			printf("*");
		printf("\n");
	}
	return 0;
}

//#include <stdio.h>
//#include <stdlib.h>
//#include <string>
//
//typedef struct autobus { int id; int sedista; char vreme[6], char naziv[31] } Autobus;
//typedef struct elem{ Autobus a; int br; struct elem* sl } Elem;
//
//Elem* na_kraj(Elem* prvi, Autobus aa){
//	Elem* novi, *tek;
//	novi = (Elem*)malloc(sizeof(Elem));
//	if (novi == NULL) exit(2);
//	novi->a.id = aa.id;
//	novi->a.sedista = aa.sedista;
//	strcpy(novi->a.vreme, aa.vreme);
//	strcpy(novi->a.naziv, aa.naziv);
//	novi->a.br = 0;
//	if (prvi == NULL)
//		prvi = novi;
//	else
//	for (tek = prvi; tek->sl; tek = tek->sl)
//		tek->sl = novi;
//	return(prvi);
//
//}
//
//void main()
//{
//	Autobus aa;
//	Elem* prvi = NULL;
//	FILE *linije, *rezervacije;
//	char ime[30];
//	char prezime[30];
//	int idd;
//
//	linije = fopen("linije.txt" "r");
//	rezervacije = fopen("rezervacije.txt", "r");
//
//	if (!linije || !rezervacije) exit(1);
//
//	while (!feof(linije))
//	if (fscanf("%d %d %s \n", &aa.id, &aa.sedista, aa.vreme, aa.naziv) == EOF) break;
//	prvi = na_kraj(prvi, aa);
//
//	while (!feof(rezervacije))
//	if (fscanf("%s %s %d", ime, prezime, &idd) == EOF) break;
//	for (tek = prvi; tek; tek = tek->sl)
//	if (tek->a.id == idd)
//		tek->br += 1;
//
//	for (tek = prvi; tek; tek = tek->sl)
//	if (tek->br>tek->a.sedista)
//		printf("%d %d", tek->a.id, tek->br - tek->a.sedista);
//
//	free(ime);
//	free(prezime);
//
//	tek = prvi;
//	while (tek){
//		free(prvi);
//		tek = tek->sl;
//		prvi = tek;
//	}

	