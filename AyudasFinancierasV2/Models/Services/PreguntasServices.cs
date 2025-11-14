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
namespace AyudasFinancierasV2.Models.Services
{
    public class PreguntasServices {
        private static readonly string _conString = ConfigurationManager.ConnectionStrings["BANNER"].ConnectionString;
        public static List<Pregunta> listarPreguntas(Evaluacion item)
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_OBTENER_PREGUNTAS";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                if(item.info.NIVEL.Equals((lector.IsDBNull(2) ? "" : lector.GetString(2))))
                                {
                            preguntas.Add(new Pregunta()
                                {
                                    id = (lector.IsDBNull(0) ? 0 : lector.GetInt32(0)),
                                    orden = (lector.IsDBNull(1) ?  0: lector.GetInt32(1)),
                                    nivel = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    categoria = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                    posicion = (lector.IsDBNull(4) ? "" : lector.GetString(4)),
                                    tipo = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
                                     oculta = (lector.IsDBNull(6) ? "" : lector.GetString(6).Substring(2)),
                                    pregunta = (lector.IsDBNull(7) ? "" : lector.GetString(7)),
                                 comentario = (lector.IsDBNull(9) ? "" : lector.GetString(9)),
                            });
                                }
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
            preguntas = listarOpciones(preguntas);
            preguntas = RespuestasServices.HomologarRespuestas(preguntas, RespuestasServices.listarRespuestas(item));
            return preguntas;
        }
        public static List<Pregunta> listarOpciones(List<Pregunta> preguntas)
        {
            foreach( Pregunta p1 in preguntas)
            {
                p1.opciones = getOpciones(p1.id);
            }
            return preguntas;
        }
        public static List<Opciones> getOpciones(int pregunta)
        {
            int[] idNacEst = { 15, 18, 37,40,54,57,71,74 };
            List<Opciones> op = new List<Opciones>();
            if (idNacEst.Contains(pregunta))
            {
                op.Add(new Opciones
                {
                    valor="Nacional",
                    descripcion="Nacional"
                });
                op.Add(new Opciones
                {
                    valor = "Estatal",
                    descripcion = "Estatal"
                });
            }
            int[] idCongregacion = {6, 26};
            if (idCongregacion.Contains(pregunta))
                {
                op.Add(new Opciones { valor = "HM", descripcion = "Hermanos Maristas" });
                op.Add(new Opciones { valor = "HL", descripcion = "Hermanos Lasallistas" });
                op.Add(new Opciones { valor = "HCV", descripcion = "Hermanas de la Caridad del Verbo Encarnado" });
                op.Add(new Opciones { valor = "HSCJ", descripcion = "Hermanas del Sagrado Corazón de Jesús" });
                op.Add(new Opciones { valor = "HMG", descripcion = "Hijas de María Inmaculada de Guadalupe" });
            }
            int[] idDeportesBA = { 16 };
            if (idDeportesBA.Contains(pregunta))
            {
                op.Add(new Opciones { valor = "1", descripcion = "Futbol soccer" });
                op.Add(new Opciones { valor = "2", descripcion = "Basquetbol" });
                op.Add(new Opciones { valor = "3", descripcion = "Voleibol de sala" });
                op.Add(new Opciones { valor = "4", descripcion = "Atletismo" });
                op.Add(new Opciones { valor = "5", descripcion = "Natación" });
                op.Add(new Opciones { valor = "6", descripcion = "Taekwondo" });
            }
            int[] idTiempo = { 12,34 };
            if (idTiempo.Contains(pregunta))
            {
                 op.Add(new Opciones { valor = "1", descripcion = "1 año" });
                op.Add(new Opciones { valor = "2", descripcion = "2 años" });
                op.Add(new Opciones { valor = "3", descripcion = "3 años" });
                op.Add(new Opciones { valor = "4", descripcion = "4 años" });
                op.Add(new Opciones { valor = "5", descripcion = "5 años" });
                op.Add(new Opciones { valor = "6", descripcion = "Más de 5 años" });
            }
            int[] idDeportesNi = { 38,55,72 };
            if (idDeportesNi.Contains(pregunta))
            {
                op.Add(new Opciones { valor = "1", descripcion = "Futbol soccer" });
                op.Add(new Opciones { valor = "2", descripcion = "Basquetbol" });
                op.Add(new Opciones { valor = "3", descripcion = "Voleibol de sala" });
                op.Add(new Opciones { valor = "4", descripcion = "Atletismo" });
                op.Add(new Opciones { valor = "5", descripcion = "Natación" });
                op.Add(new Opciones { valor = "6", descripcion = "Taekwondo" });
                op.Add(new Opciones { valor = "7", descripcion = "Tenis" });
                op.Add(new Opciones { valor = "8", descripcion = "Rugby" });
            }
            int[] idArtes = { 19, 41, 58,75 };
            if (idArtes.Contains(pregunta))
            {
                op.Add(new Opciones { valor = "1", descripcion = "Música" });
                op.Add(new Opciones { valor = "2", descripcion = "Danza" });
                op.Add(new Opciones { valor = "3", descripcion = "Teatro" });
                op.Add(new Opciones { valor = "4", descripcion = "Canto" });
                op.Add(new Opciones { valor = "5", descripcion = "Orquesta" });
            }
            return op;
        }
    }
    }
