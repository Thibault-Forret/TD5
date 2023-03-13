// See https://aka.ms/new-console-template for more information

int RenvoieCarre(int i) {
	return i*i;
}

int nbrSaisi = Convert.ToInt32(Console.ReadLine());

int resultat = RenvoieCarre(nbrSaisi);
Console.WriteLine(resultat);