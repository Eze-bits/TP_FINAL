using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

using Entidades;




namespace Mapper
{
    public class LoteMP
    {
     //   DAL Ac = new DAL();

        public bool checkear_l(Lote L)   // checkea si existe lote del dia si es true sino false
        {




           
            { return false; }
        }


        public bool checkear_ltodos()     //checkea si hay lotes en la base
        {



            { return false; }
        }



        public void graba_l(Lote L)                                         // graba un Lote nuevo
        {

      
          



       

            agregar_prod(L);
        }

       


        

          

        
        public void actualizar_stock_lot(List<Lote> Lista_lotes)
        {
            foreach (Lote L in Lista_lotes)
            {

                Modificar(L);
            }


        }

        public void Modificar(Lote L)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();

            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@uni";
            P1.Value = 0;
            P1.SqlDbType = SqlDbType.Int;
            Parametros.Add(P1);

            SqlParameter P2 = new SqlParameter();
            P2.ParameterName = "@nrolote";
            P2.Value = L.Nro_lote;
            P2.SqlDbType = SqlDbType.Int;
            Parametros.Add(P2);

            SqlParameter P3 = new SqlParameter();
            P3.ParameterName = "@peso";
            P3.SqlDbType = SqlDbType.Int;
            P3.Value = 0;
            Parametros.Add(P3);


            if (L.retorna_Phc() != null)
            {
                Parametros[0].Value = L.retorna_Phc().Unidades;
                Parametros[2].Value = L.retorna_Phc().Peso;

               ///////// Ac.Modificar("Modificar_hamburguesa", Parametros);
            }

            if (L.retorna_Pmm() != null)
            {
                Parametros[0].Value = L.retorna_Pmm().Unidades;
                Parametros[2].Value = L.retorna_Pmm().Peso;
           //     Ac.Modificar("Modificar_hamburguesa", Parametros);
            }

            if (L.retorna_Plc() != null)
            {
                Parametros[0].Value = L.retorna_Plc().Unidades;
                Parametros[2].Value = L.retorna_Plc().Peso;
            //    Ac.Modificar("Modificar_lactal", Parametros);
            }

            if (L.retorna_Plg() != null)
            {
                Parametros[0].Value = L.retorna_Plg().Unidades;
                Parametros[2].Value = L.retorna_Plg().Peso;
               // Ac.Modificar("Modificar_lactal", Parametros);
            }

            if (L.retorna_Ppc() != null)
            {
                Parametros[0].Value = L.retorna_Ppc().Unidades;
                Parametros[2].Value = L.retorna_Ppc().Peso;
             //   Ac.Modificar("Modificar_pancho", Parametros);
            }

            if (L.retorna_Ppm() != null)
            {
                Parametros[0].Value = L.retorna_Ppm().Unidades;
                Parametros[2].Value = L.retorna_Ppm().Peso;
              //  Ac.Modificar("Modificar_pancho", Parametros);
            }



            //       Ac.Modificar("DELETE FROM PANCHOS WHERE Unidades = '0' ");     /// LIMPIO PRODUCTOS CON UNIDADES EN CERO
            //       Ac.Modificar("DELETE FROM LACTAL WHERE Unidades = '0' ");
            //       Ac.Modificar("DELETE FROM HAMBURGUESAS WHERE Unidades = '0' "); */



        }

        public void borrar_prod(Panificados p)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            
            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@nrolote";
            P1.SqlDbType = SqlDbType.Int;
            P1.Value = p.Nro_lote;
            Parametros.Add(P1);

            SqlParameter P2 = new SqlParameter();
            P2.ParameterName = "@peso";
            P2.SqlDbType = SqlDbType.Int;
            P2.Value = p.Peso;
            Parametros.Add(P2);
          

            switch (p.Peso)
            {
                case 200:

             //       Ac.Modificar("Borrar_hamburguesa", Parametros);
                    break;

                case 320:
                //    Ac.Modificar("Borrar_hamburguesa", Parametros);
                    break;

                case 300:

                //    Ac.Modificar("Borrar_lactal", Parametros);
                    break;

                case 600:

                 //   Ac.Modificar("Borrar_lactal", Parametros);
                    break;

                case 230:

                   // Ac.Modificar("Borrar_pancho", Parametros);
                    break;

                case 350:

                 //   Ac.Modificar("Borrar_pancho", Parametros);
                    break;



            }
        }

        public void agregar_prod(Lote L)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            SqlParameter P0 = new SqlParameter();
            P0.ParameterName = "@nrolote";
            P0.SqlDbType = SqlDbType.Int;
            P0.Value = L.Nro_lote;
            Parametros.Add(P0);

            SqlParameter P1 = new SqlParameter();
            P1.ParameterName = "@peso";
            P1.SqlDbType = SqlDbType.Int;
            P1.Value = 0;
            Parametros.Add(P1);


            SqlParameter P2 = new SqlParameter();
            P2.ParameterName = "@uni";
            P2.SqlDbType = SqlDbType.Int;
            P2.Value = 0;
            Parametros.Add(P2);



            if (L.retorna_Phc() != null)
            {
                Parametros[1].Value = L.retorna_Phc().Peso;
                Parametros[2].Value = L.retorna_Phc().Unidades;
               // Ac.Modificar("Agregar_hamburguesa", Parametros);

            }

            if (L.retorna_Pmm() != null)
            {
                Parametros[1].Value = L.retorna_Pmm().Peso;
                Parametros[2].Value = L.retorna_Pmm().Unidades;
               // Ac.Modificar("Agregar_hamburguesa", Parametros);
            }

            if (L.retorna_Plc() != null)
            {
                Parametros[1].Value = L.retorna_Plc().Peso;
                Parametros[2].Value = L.retorna_Plc().Unidades;
               // Ac.Modificar("Agregar_lactal", Parametros);
            }

            if (L.retorna_Plg() != null)
            {
                Parametros[1].Value = L.retorna_Plg().Peso;
                Parametros[2].Value = L.retorna_Plg().Unidades;
             //   Ac.Modificar("Agregar_lactal", Parametros);
            }

            if (L.retorna_Ppc() != null)
            {
                Parametros[1].Value = L.retorna_Ppc().Peso;
                Parametros[2].Value = L.retorna_Ppc().Unidades;
               // Ac.Modificar("Agregar_pancho", Parametros);

            }

            if (L.retorna_Ppm() != null)
            {
                Parametros[1].Value = L.retorna_Ppm().Peso;
                Parametros[2].Value = L.retorna_Ppm().Unidades;
            //    Ac.Modificar("Agregar_pancho", Parametros);
            }





        }

    }

}
