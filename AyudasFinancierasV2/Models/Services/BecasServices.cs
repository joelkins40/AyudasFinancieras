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
using Microsoft.Ajax.Utilities;
using System.Xml.Schema;
namespace AyudasFinancierasV2.Models.Services
{
    public class BecasServices
    {
        private static readonly string UrlBecas = ConfigurationManager.AppSettings["urlBecas"];
        private static readonly string _conString = ConfigurationManager.ConnectionStrings["BANNER"].ConnectionString;
        public static List<Beca> listarBecas(string nv)
        {
            List<Beca> becas = new List<Beca>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_OBTENER_BECAS_NIVEL";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_NIVEL", OracleDbType.Varchar2)
                        {
                            Value = nv,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                if (nv.Equals((lector.IsDBNull(2) ? "" : lector.GetString(2))))
                                {
                                    becas.Add(new Beca()
                                    {
                                        code = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                        nombre = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                        nivel = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                        desde = (lector.IsDBNull(3) ? 0 : lector.GetDouble(3)),
                                        hasta = (lector.IsDBNull(4) ? 0 : lector.GetDouble(4)),
                                        icon = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
                                        uri = (lector.IsDBNull(6) ? "" : lector.GetString(6)),
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
            return becas;
        }
        public static string ConstruirUrl(string apfrCode, string aidyCode, string aidpCode)
        {
            string baseUrl =UrlBecas+ "bwvkkapf.P_ShowModules";
            string parametros = $"?p_apfr_code={apfrCode}&p_aidy_code={aidyCode}&p_aidp_code={aidpCode}";
            return baseUrl + parametros;
        }
        public static List<Regla> reglasBecas(string nv,string prepaUdem)
        {
            List<Regla> reglas = new List<Regla>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_OBTENER_REGLAS_NIVEL";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_NIVEL", OracleDbType.Varchar2)
                        {
                            Value = nv,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                if (!(prepaUdem.Equals("N")&& (lector.IsDBNull(10) ? false : lector.GetString(10) == "Y")))
                                {
                                    reglas.Add(new Regla()
                                    {
                                        id = (lector.IsDBNull(0) ? 0 : lector.GetInt32(0)),
                                        beca = new Beca()
                                        {
                                            code = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                            nombre = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                            nivel = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                        },
                                        pregunta = new Pregunta()
                                        {
                                            id = (lector.IsDBNull(7) ? 0 : lector.GetInt32(7)),
                                            pregunta = (lector.IsDBNull(8) ? "" : lector.GetString(8)),
                                        },
                                        nombre = (lector.IsDBNull(9) ? "" : lector.GetString(9)),
                                        udemPrepa = (lector.IsDBNull(10) ? false : lector.GetString(10) == "Y"),
                                        valor = (lector.IsDBNull(11) ? "" : lector.GetString(11)),
                                        min = (lector.IsDBNull(12) ? 0 : lector.GetDouble(12)),
                                        max = (lector.IsDBNull(13) ? 0 : lector.GetDouble(13)),
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
            return reglas;
        }
        public static List<Beca> validarBeca(Evaluacion item)
        {
            List<Respuesta> respuestas = RespuestasServices.listarRespuestas(item).respuestas;
            List<Beca> existentes = new List<Beca>();
            List<Beca> noexistentes = new List<Beca>();
            List<Beca> todaslasbecas = listarBecas(item.info.NIVEL);
            List<Regla> reglas = reglasBecas(item.info.NIVEL,item.info.ISPREPAUDEM);
            var reglasPorBeca = reglas.GroupBy(r => r.beca.code).ToDictionary(g => g.Key, g => g.ToList());
            List<string> listaDeBecasEncontradas = new List<string>();
            foreach (var becaGroup in reglasPorBeca)
            {
                string code = becaGroup.Key;
                List<Regla> reglasAgrupadas = becaGroup.Value;
                if (item.info.ISPREPAUDEM.Equals("Y"))
                {
                    reglasAgrupadas = reglasAgrupadas
                        .GroupBy(r => r.pregunta.id)
                        .SelectMany(g => g.Any(r => r.udemPrepa) ? g.Where(r => r.udemPrepa || g.Count() == 1) : g)
                        .ToList();
                }
                List<Regla> reglasUnicas = reglasAgrupadas.Where(r => !r.nombre.Equals("")).ToList();
                List<Regla> reglasGenerales = reglasAgrupadas.Where(r => r.nombre.Equals("")).ToList();
                var reglasConbinadas = reglasUnicas.GroupBy(r => r.nombre).ToDictionary(g => g.Key, g => g.ToList());
                foreach (var iteme in reglasConbinadas)
                {
                    foreach (Regla regla in iteme.Value)
                    {
                        bool match = false;
                        foreach (Respuesta respuesta in respuestas)
                        {
                            if (respuesta.id.Equals(regla.pregunta.id))
                            {
                                match = validarRespuesta(regla, respuesta.respuesta);
                            }
                        }
                        regla.isValid = match;
                    }
                }
                var reglasFiltradas = reglasConbinadas.Where(kv => kv.Value.All(r => r.isValid)).ToDictionary(kv => kv.Key, kv => kv.Value.Where(r => r.isValid).ToList());
                foreach (Regla regla in reglasGenerales)
                    {
                    foreach (Respuesta respuesta in respuestas)
                    {
                        if (respuesta.id.Equals(regla.pregunta.id))
                        {
                           var respuestasFiltradas = reglasAgrupadas.Where(r => r.pregunta.id == respuesta.id).ToList();
                            bool isValidRespuesta = false;
                            if (respuestasFiltradas.Count == 1)
                            {
                                isValidRespuesta= validarRespuesta(regla, respuesta.respuesta);
                            }
                            else
                            {
                                isValidRespuesta= validarRespuestaMultiple(respuestasFiltradas, respuesta.respuesta);
                            }
                            regla.isValid = isValidRespuesta;
                        }
                    }
                }
                bool todasValidas = reglasGenerales.All(r => r.isValid);
                bool todasConbinadas = false;
                    if(reglasConbinadas.Count>0&& reglasFiltradas.Count > 0|| reglasConbinadas.Count == 0 && reglasFiltradas.Count== 0)
                {
                    todasConbinadas = true;
                }
                    if(todasValidas&& todasConbinadas)
                {
                    listaDeBecasEncontradas.Add(code);               
                }
            }
            todaslasbecas= todaslasbecas.Where(b => listaDeBecasEncontradas.Any(cadena => b.code.Contains(cadena)))
            .ToList();
            return todaslasbecas;
        }
        public static bool validarRespuestaMultiple(List<Regla> reglas, string respuesta)
        {
            bool becas = false;
            foreach (var r in reglas)
            {
                if (r.valor.Equals("NA"))
                {
                    becas = true;
                    break;
                }
                else if (r.valor.Equals("LISTA VALORES"))
                {
                    becas = true;
                    break;
                }
                else if (r.valor.Equals(""))
                {
                    double valor=double.Parse(respuesta);
                    if (valor >= r.min && valor <= r.max)
                    {
                        becas = true;
                        break;
                    }
                }
                else if (!r.valor.Equals(""))
                {
                    if (r.valor.Equals(respuesta))
                    {
                        becas = true;
                        break;
                    }
                }
            }
            return becas;
        }
        public static bool validarRespuesta(Regla r, string respuesta)
        {
            bool becas = false;
            if (r.valor.Equals("NA"))
            {
                becas= true;
            }else 
            if (r.valor.Equals("LISTA VALORES"))
            {
                becas = true;
            }else
            if (r.valor.Equals(""))
            {
                double valor = double.Parse(respuesta);
                if (valor >= r.min && valor <= r.max)
                {
                    becas = true;
                }
            }
            else 
            if (!r.valor.Equals("")){
                if (r.valor.Equals(respuesta))
                {
                    becas= true;
                }
            }
            return becas;
        }
        public static bool GuardarBecaSeleccionada(int pidm, int aidyCode, string fndcCode)
        {
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGA_SIAF.P_DML_SZRBSTU";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("P_DML", OracleDbType.Int32)
                        {
                            Value = 1, // 1 = INSERT
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int32)
                        {
                            Value = pidm,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_AIDY_CODE", OracleDbType.Int32)
                        {
                            Value = aidyCode,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_FNDC_CODE", OracleDbType.Varchar2)
                        {
                            Value = fndcCode,
                            Direction = ParameterDirection.Input
                        });
                        cnx.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar beca seleccionada: {ex.Message}");
                return false;
            }
        }
        public static bool EliminarBecaSeleccionada(int pidm, int aidyCode, string fndcCode)
        {
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGA_SIAF.P_DML_SZRBSTU";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("P_DML", OracleDbType.Int32)
                        {
                            Value = 3, // 3 = DELETE
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int32)
                        {
                            Value = pidm,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_AIDY_CODE", OracleDbType.Int32)
                        {
                            Value = aidyCode,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_FNDC_CODE", OracleDbType.Varchar2)
                        {
                            Value = fndcCode,
                            Direction = ParameterDirection.Input
                        });
                        cnx.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar beca seleccionada: {ex.Message}");
                return false;
            }
        }
        public static List<Beca> ConsultarBecasGuardadas(int pidm, int aidyCode)
        {
            List<Beca> becasGuardadas = new List<Beca>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_BECAS_GUARDADAS";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int32)
                        {
                            Value = pidm,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_AIDY_CODE", OracleDbType.Int32)
                        {
                            Value = aidyCode,
                            Direction = ParameterDirection.Input
                        });
                        cnx.Open();
                        OracleDataReader lector = comando.ExecuteReader();
                        while (lector.Read())
                        {
                            var beca = new Beca()
                            {
                                code = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                nombre = (lector.IsDBNull(1) ? "" : lector.GetString(1))
                            };
                            becasGuardadas.Add(beca);
                        }
                        lector.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar becas guardadas: {ex.Message}");
            }
            return becasGuardadas;
        }
        public static bool GuardarBecasSeleccionadas(int pidm, int aidyCode, List<string> codigosBecas)
        {
            try
            {
                EliminarTodasBecasSeleccionadas(pidm, aidyCode);
                foreach (string codigoBeca in codigosBecas)
                {
                    if (!GuardarBecaSeleccionada(pidm, aidyCode, codigoBeca))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar becas seleccionadas: {ex.Message}");
                return false;
            }
        }
        private static bool EliminarTodasBecasSeleccionadas(int pidm, int aidyCode)
        {
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "DELETE FROM SZRBSTU WHERE SZRBSTU_PIDM = :pidm AND SZRBSTU_AIDY_CODE = :aidyCode";
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add(new OracleParameter("pidm", OracleDbType.Int32)
                        {
                            Value = pidm,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("aidyCode", OracleDbType.Int32)
                        {
                            Value = aidyCode,
                            Direction = ParameterDirection.Input
                        });
                        cnx.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar todas las becas seleccionadas: {ex.Message}");
                return false;
            }
        }
    }
}
