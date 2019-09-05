using System;

namespace Producto
{


    public class Vehiculo{
        private int id;
        private string nombre;
        private string tipo;

        private string marca;
        private int año;

        public int Id{ //metodos de acceso
            get{ return id;}
            set{id = value;}


        }

        public string Nombre{ //metodos de acceso
            get{ return nombre;}
            set{nombre = value;}


        }


        public string Tipo{ //metodos de acceso
            get{ return tipo;}
            set{tipo = value;}


        }

        public string Marca{ //metodos de acceso
            get{ return marca;}
            set{marca = value;}


        }

        public int Año{ //metodos de acceso
            get{ return año;}
            set{año = value;}


        }






    }

    public class RepoVehiculo{

       public void Mostrar_Vehiculo(Vehiculo v){

           Console.WriteLine(v.Nombre + "  "+v.Id + "  "+v.Marca + "  "+v.Tipo +"  "+v.Año );



       }


       public void ListarVehiculo(Vehiculo[] vs){

           for(int c =0; c!=5; c++ ){

               Console.WriteLine(vs[c].Nombre + "  "+vs[c].Id + "  "+vs[c].Marca + "  "+vs[c].Tipo +"  "+vs[c].Año);
               

           }






       }






    }


    public class Operaciones{

         public void Verproducto( Producto Ps){

            Console.WriteLine(Ps.Id + "  " + Ps.Nombre + " " + Ps.Precio + " " + Ps.Codigo);
            Console.ReadKey();
        }





    }
    public class Producto{


        private string codigo;
        private string nombre;
        private decimal precio;
        private int id;

        public int Id{ //metodos de acceso
            get{ return id;}
            set{id = value;}


        }


         public string Codigo{ //metodos de acceso
            get{ return codigo;}
            set{codigo = value;}


        }



         public string Nombre{ //metodos de acceso
            get{ return nombre;}
            set{nombre = value;}


        }


         public decimal Precio{ //metodos de acceso
            get{ return precio;}
            set{precio = value;}


        }

        public void Verproducto(){

            Console.WriteLine(Id + "  " + Nombre + " " + Precio + " " + Codigo);
            Console.ReadKey();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
          /*   Operaciones op = new Operaciones();

            

            Producto productox = new Producto();
            productox.Id = 619;
            productox.Nombre = "Sabritas";
            productox.Precio = 9.67m;
            productox.Codigo = "A1121";

            

            op.Verproducto(productox); */

            Vehiculo x = new Vehiculo();
            x.Año = 2002;
            x.Marca = "Volkswagen";
            x.Tipo = "Sedan";
            x.Nombre = "Jetta";
            x.Id = 032;
            
            Vehiculo x4 = new Vehiculo();
            x4.Año = 2010;
            x4.Marca = "BMW";
            x4.Tipo = "Coupe";
            x4.Nombre = "325is";
            x4.Id = 6456;

            Vehiculo x3 = new Vehiculo();
            x3.Año = 2008;
            x3.Marca = "Nissan";
            x3.Tipo = "Sedan";
            x3.Nombre = "Sentra";
            x3.Id = 232;

            Vehiculo x2 = new Vehiculo();
            x2.Año = 2010;
            x2.Marca = "Honda";
            x2.Tipo = "Coupe";
            x2.Nombre = "Civic";
            x2.Id = 664;

            Vehiculo x1 = new Vehiculo();
            x1.Año = 1968;
            x1.Marca = "Ford";
            x1.Tipo = "Coupe";
            x1.Nombre = "Mustang";
            x1.Id = 323;

            Vehiculo[] V1 = {x,x1,x2,x3,x4};






            RepoVehiculo G = new RepoVehiculo();

            G.ListarVehiculo(V1);

        }
    }
}
