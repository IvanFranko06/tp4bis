using System.Collections.Generic;


static class info
{
static private List<Pais> listaPaises;



private static void InicializarLista()
{
    
listaPaises.Add( new Pais("Argentina","banderaArg.PNG",4581000,"arquitectura y paisajes", new DateTime(9/5/1816)));
listaPaises.Add(new Pais("Bolivia","banderaBoliviana.PNG",1208000,"cultura y paisajes", new DateTime(6/8/1825)));
listaPaises.Add(new Pais("Estados Unidos","banderaEEUU.PNG",331900000,"autos y cultura", new DateTime(4/7/1776)));
listaPaises.Add(new Pais("Mexico","banderaMex.PNG",126700000,"comida, musica y paisajes", new DateTime(27/9/1821)));
listaPaises.Add(new Pais("Brasil","banderaBrasil.PNG",214300000,"amazonas", new DateTime(7/9/1822)));

}

public static List<Pais> ListarPaises()
{
   
  if (listaPaises.Count==0)
  {
    InicializarLista();
   
  }
  return listaPaises;





}

public static Pais DetallePais(string nombre)
{
 Pais paisBuscado=new Pais();
 foreach (Pais item in listaPaises)
 {
  if (item.Nombre==nombre)
  {
   return item;
  }
 }
 return paisBuscado;
}


}