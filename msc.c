int main(int argc, char const *argv[])
{

  int s[] = {0, 1, 5, 7, 1, 6, 9, 8, 7};
  int tamanho = sizeof(s);
  int p[tamanho + 1], l[tamanho + 1];
  int k, j;

  p[0] = 0; // pretesessores
  l[0] = 0; // cumprimento

  for (k = 1; k < tamanho; k++)
  { //

    for (j = k - 1; j >= 0; j--)
    {

      if (s[k] > s[j]) 
      {
        l[k] = l[j] + 1;
        p[k] = j;
      }
     

      
    }
     
  }
}
