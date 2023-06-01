using System.Collections.Generic;


static class Info
{
static private List<Pais> listaPaises = new List<Pais>();



private static void InicializarLista()
{
    Pais arg=new Pais("Argentina","banderaArg.png",4581000,"Glaciar perito moreno", new DateTime(1816,7,9));
    Pais bolivia=new Pais("Bolivia","banderaBoliviana.png",1208000,"El mar", new DateTime(1825,8,6));
    Pais estadosUnidos=new Pais("Estados Unidos","banderaEEUU.png",331900000,"El gran cañon", new DateTime(1776,7,4));
    Pais mejico=new Pais("Mexico","banderaMex.png",126700000,"chichenitza", new DateTime(1821,9,27));
    Pais brasil=new Pais("Brasil","banderaBrasil.png",214300000,"amazonas", new DateTime(1822,9,7));
listaPaises.Add(arg);
listaPaises.Add(bolivia);
listaPaises.Add(estadosUnidos);
listaPaises.Add(mejico);
listaPaises.Add(brasil);

}

public static List<Pais> ListarPaises()
{
   
  if (listaPaises.Count==0)
  {
    InicializarLista();
   return listaPaises; 
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