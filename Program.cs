// See https://aka.ms/new-console-template for more information
/***
Rôle : Renvoie le carré d'un nombre passé en paramètre
Paramètre d'entrée : Nombre entier
Valeur de retour : Le carré du nombre passé en paramètre

***/
int RenvoieCarre(int i) {
	return i*i;
}

int nbrSaisi = Convert.ToInt32(Console.ReadLine());

int resultat = RenvoieCarre(nbrSaisi);
Console.WriteLine(resultat);