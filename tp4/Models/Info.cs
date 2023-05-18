using System.Collections.Generic;


static class info
{
static private List<Pais> listaPaises;



private static void InicializarLista()
{
    Pais arg=new Pais("Argentina","banderaArg",4581000,"arquitectura y paisajes", new DateTime(9/5/1816));
    Pais bolivia=new Pais("Bolivia","banderaBoliviana",1208000,"cultura y paisajes", new DateTime(6/8/1825));
    Pais estadosUnidos=new Pais("Estados Unidos","banderaEEUU",331900000,"autos y cultura", new DateTime(4/7/1776));
    Pais mejico=new Pais("Mexico","banderaMex",126700000,"comida, musica y paisajes", new DateTime(27/9/1821));
    Pais brasil=new Pais("Brasil","banderaBrasil",214300000,"amazonas", new DateTime(7/9/1822));
listaPaises.Add(arg);
listaPaises.Add(bolivia);
listaPaises.Add(estadosUnidos);
listaPaises.Add(mejico);
listaPaises.Add(brasil);

}

public static List<Pais> ListarPaises()
{
   
  if (listaPaises==null)
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