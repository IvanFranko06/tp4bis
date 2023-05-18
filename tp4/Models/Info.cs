using System.Collections.Generic;


static class info
{
static private List<Pais> listaPaises;



private static void InicializarLista()
{
    Pais argentina=new Pais();
    Pais bolivia=new Pais();
    Pais estadosUnidos=new Pais();
    Pais mejico=new Pais();
    Pais brasil=new Pais();
listaPaises.Add(argentina);
listaPaises.Add(bolivia);
listaPaises.Add(estadosUnidos);
listaPaises.Add(mejico);
listaPaises.Add(brasil);

}

public static List<Pais> ListarPaises()
{
    List<Pais> Paises=new List<Pais>();
  if (listaPaises==null)
  {
    InicializarLista();
   return Paises;
  }
  else
  {
   

   return Paises;
  }





}

public static Pais DetallePais(string Nombre)
{

}


}