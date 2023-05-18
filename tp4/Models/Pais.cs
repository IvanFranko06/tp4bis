public class Pais
{
public string Nombre {get; private set;}
public string imgBandera {get; private set;}
public int Poblacion {get; private set;}
public DateTime FechaIndependencia{get; private set;}
public string AtractivosTuristicos {get; private set;}


public Pais()
        {
         Nombre ="";
         imgBandera = "";
         Poblacion=0;
         AtractivosTuristicos="";
         FechaIndependencia=new DateTime();
        }



      public Pais(string nom, string img, int pob, string atrac, DateTime ind)
        {
            Nombre = nom;
            Poblacion = pob;
            AtractivosTuristicos = atrac;
            FechaIndependencia = ind;
            imgBandera = img;
        }







}