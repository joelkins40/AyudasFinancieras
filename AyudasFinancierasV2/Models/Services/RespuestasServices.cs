using AyudasFinancierasV2.Models.Entity;
using System;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Web.Mvc;
namespace AyudasFinancierasV2.Models.Services
{
    public class RespuestasServices
    {
        private static readonly string _conString = ConfigurationManager.ConnectionStrings["BANNER"].ConnectionString;
        public static Evaluacion listarRespuestas(Evaluacion item)
        {
            List<Respuesta> respuestas = new List<Respuesta>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_OBTENER_RESPUESTAS";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int16)
                        {
                            Value = item.pid,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_TERM", OracleDbType.Varchar2)
                        {
                            Value = item.periodo.CODIGO,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                respuestas.Add(new Respuesta()
                                {
                                    id = (lector.IsDBNull(4) ? 0 : lector.GetInt32(4)),
                                    respuesta = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
                                });
                            }
                        }
                        finally
                        {
                            cnx.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            item.respuestas=respuestas;
            return item;
        }
        public static List<Pregunta> HomologarRespuestas(List<Pregunta> preguntas,Evaluacion item)
        {
            if (item.respuestas.Count>0)
            {
                foreach (Respuesta i in item.respuestas)
                {
                    foreach (Pregunta p in preguntas)
                    {
                        if (p.id == i.id)
                        {
                            string respuestaBanner= getRespuestas(p.id, item.info);
                            if (respuestaBanner.Equals("NA"))
                            {
                                p.respuesta = i.respuesta;
                            }
                            else
                            {
                                p.respuesta = respuestaBanner;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Pregunta p in preguntas)
                {
                        p.respuesta = getRespuestas(  p.id, item.info);
                }
            }
            return preguntas;
        }
        public static string getRespuestas(int pregunta,Informacion info)
        {
            string respuesta = "NA";
            int[] idNacionalidad = { 1, 21,46,63 };
            if (idNacionalidad.Contains(pregunta))
            {            
                respuesta = info.NACIONALIDAD;
            }
            int[] idCiudad = { 2, 22, 47, 64 };
            if (idCiudad.Contains(pregunta))
            {
                respuesta = info.CIUDAD;
            }
            int[] idEstado = { 3, 23, 48, 65 };
            if (idEstado.Contains(pregunta))
            {
                respuesta = info.ESTADO;
            }
            int[] idEscuela = { 4, 24, 49, 66 };
            if (idEscuela.Contains(pregunta))
            {
                respuesta =  info.PROCEDENCIA;
            }
            int[] idGPA = { 7, 27, 51, 68 };
            if (idGPA.Contains(pregunta))
            {
                respuesta = info.PROMEDIO_ADMISION;
            }
            int[] idPAA = { 8, 28 };
            if (idPAA.Contains(pregunta))
            {
                respuesta = info.PAA;
            }
            int[] idPrograma = { 9, 29,52,69 };
            if (idPrograma.Contains(pregunta))
            {
                respuesta = info.PROGRAMA_INTERES;
            }
            return respuesta;
        }
        public static String InsertRespuesta(Respuesta respuesta, int pidm,Periodo periodo)
        {
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGA_SIAF.F_INSERT_RESPUESTAS";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int16)
                        {
                            Value = pidm,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_TERM", OracleDbType.Varchar2)
                        {
                            Value = periodo.CODIGO,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_ID_PREG", OracleDbType.Varchar2)
                        {
                            Value = respuesta.id,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_RESPUESTA", OracleDbType.Varchar2)
                        {
                            Value = respuesta.respuesta,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("V_Salida", OracleDbType.Varchar2, 400)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        try
                        {
                            cnx.Open();
                            comando.ExecuteNonQuery();
                        }
                        finally
                        {
                            cnx.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Registro Ingresado Con Éxito";
        }
        public static string guardarRespuestas(Evaluacion item)
        {
            EliminarRespuesta(item.pid, item.periodo);
            foreach(Respuesta i in item.respuestas)
            {
                InsertRespuesta(i, item.pid, item.periodo);
            }
            return "Datos guardados con éxito";
        }
        public static string EliminarRespuesta(int pidm, Periodo term)
        {
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGA_SIAF.F_ELIMINA_RESPUESTAS";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int32)
                        {
                            Value = pidm,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_TERM", OracleDbType.Int32)
                        {
                            Value = term.CODIGO,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("V_Salida", OracleDbType.Varchar2, 400)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        cnx.Open();
                        try
                        {
                            comando.ExecuteNonQuery();
                        }
                        finally
                        {
                            cnx.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Registro Eliminado Con Éxito";
        }
    }
}
