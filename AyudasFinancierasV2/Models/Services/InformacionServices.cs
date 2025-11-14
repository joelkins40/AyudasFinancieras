using AyudasFinancierasV2.Models.Entity;
using System;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Configuration;
using AyudasFinancierasV2.AxServiceInterface;
using System.Net;
using System.Web;
using System.Xml;
using System.IO;
using AyudasFinancierasV2.Models.Entites;
namespace AyudasFinancierasV2.Models.Services
{
    public class InformacionServices
    {
        private static readonly string _conString = ConfigurationManager.ConnectionStrings["BANNER"].ConnectionString;
        public static Informacion getInformacion(int item)
        {
            Informacion info = new Informacion();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_OBTENER_DATOS_GENERALES";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int16)
                        {
                            Value = item,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                string isNuevo = (lector.IsDBNull(2) ? "" : lector.GetString(2));
                                isNuevo = (!isNuevo.Equals("N") ? "R" : "N");
                                info = new Informacion()
                                {
                                    PERIODO_ADMISION = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    NIVEL = (lector.IsDBNull(1) ? "" : lector.GetString(1)) + isNuevo,
                                    STYP_CODE = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    CODIGO_CARRERA = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                    CAMP_CODE = (lector.IsDBNull(4) ? "" : lector.GetString(4)),
                                    PERIODO_EFECTIVO = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
                                    NACIONALIDAD = (lector.IsDBNull(6) ? "" : lector.GetString(6)),
                                    CIUDAD = (lector.IsDBNull(7) ? "" : lector.GetString(7)),
                                    ESTADO = (lector.IsDBNull(8) ? "" : lector.GetString(8)),
                                    PREPA_UDEM = (lector.IsDBNull(9) ? "" : lector.GetString(9)),
                                    PROCEDENCIA = (lector.IsDBNull(10) ? "" : lector.GetString(10)),
                                    ISPREPAUDEM = (lector.IsDBNull(11) ? "" : lector.GetString(11)),
                                    PROMEDIO_ADMISION = (lector.IsDBNull(12) ? "" : lector.GetString(12)),
                                    PAA = (lector.IsDBNull(13) ? "" : lector.GetString(13)),
                                    PROGRAMA_INTERES = (lector.IsDBNull(14) ? "" : lector.GetString(14)),
                                    PROGRAMA_ACADEMICO = (lector.IsDBNull(15) ? "" : lector.GetString(15)),
                                    AVANCE_ACADEMICO = (lector.IsDBNull(16) ? "" : lector.GetString(16)),
                                    PROM_PRIMER_PARCIAL = (lector.IsDBNull(17) ? "" : lector.GetString(17)),
                                    MATERIAS_APROBADAS = (lector.IsDBNull(18) ? "" : lector.GetString(18)),
                                    PROM_SEM_ANT = (lector.IsDBNull(19) ? "" : lector.GetString(19)),
                                    PROM_GLOBAL = (lector.IsDBNull(20) ? "" : lector.GetString(20)),
                                    CARGA_ACADEMICA = (lector.IsDBNull(21) ? "" : lector.GetString(21)),
                                };
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
            return info;
        }
        public static List<Renovacion> getHistorialRenovaciones(string matricula)
        {
            List<Renovacion> renovaciones = new List<Renovacion>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_RENOVACION_HISTORICO";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = matricula,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                renovaciones.Add(new Renovacion()
                                {
                                    MATRICULA = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    ESTATUS = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    PROMEDIO = (lector.IsDBNull(2) ? 0.0 : Convert.ToDouble(lector.GetString(2))),
                                    PROM_REQUERIDO = (lector.IsDBNull(3) ? 0.0 : Convert.ToDouble(lector.GetString(3))),
                                    REPROBADAS = (lector.IsDBNull(4) ? 0 : Convert.ToInt16(lector.GetString(4))),
                                    PERIODOS_BECA = (lector.IsDBNull(5) ? 0 : Convert.ToInt16(lector.GetString(5))),
                                    CONDICION_ANT = (lector.IsDBNull(6) ? "" : lector.GetString(6)),
                                    TALENTO = (lector.IsDBNull(7) ? "" : lector.GetString(7)),
                                    FECHA = (lector.IsDBNull(8) ? "" : lector.GetString(8)),
                                    DESCRIPCION = (lector.IsDBNull(9) ? "" : lector.GetString(9)),
                                    PERIODO = (lector.IsDBNull(10) ? "" : lector.GetString(10)),
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
            return renovaciones;
        }
   public static List<Beca> getBecasActuales(string pidm)
        {
            List<Beca> becas = new List<Beca>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_BECA_OFER_ALUMN";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Varchar2)
                        {
                            Value = pidm,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                becas.Add(new Beca()
                                {
                                    pidm = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    anio = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    code = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    nombre = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                    porcentaje = (lector.IsDBNull(4) ? "" : lector.GetString(4)),
                                    fecha = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
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
            return becas;
        }
        public static List<Renovacion> getRenovaciones(string matricula)
        {
            List<Renovacion> renovaciones = new List<Renovacion>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_RENOVACION";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = matricula,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                renovaciones.Add(new Renovacion()
                                {
                                    MATRICULA = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    ESTATUS = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    PROMEDIO = (lector.IsDBNull(2) ? 0.0 : Convert.ToDouble(lector.GetString(2))),
                                    PROM_REQUERIDO = (lector.IsDBNull(3) ? 0.0 : Convert.ToDouble(lector.GetString(3))),
                                    REPROBADAS = (lector.IsDBNull(4) ? 0 : Convert.ToInt16(lector.GetString(4))),
                                    PERIODOS_BECA = (lector.IsDBNull(5) ? 0 : Convert.ToInt16(lector.GetString(5))),
                                    CONDICION_ANT = (lector.IsDBNull(6) ? "" : lector.GetString(6)),
                                    TALENTO = (lector.IsDBNull(7) ? "" : lector.GetString(7)),
                                    FECHA = (lector.IsDBNull(8) ? "" : lector.GetString(8)),
                                    DESCRIPCION=(lector.IsDBNull(9) ? "" : lector.GetString(9)),
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
            return renovaciones;
        }
        public static Periodo getPeriodoActivo(string matricula)
        {
            Periodo periodo = new Periodo();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_PERIODO_DESC";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = matricula,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                periodo = new Periodo()
                                {
                                    CODIGO = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    NOMBRE = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    Alumno = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                };
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
            return periodo;
        }
        public static List<DatosHisotricoBecas> getBecasActivas(string item)
        {
            List<DatosHisotricoBecas> info = new List<DatosHisotricoBecas>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_BECOEX_ACTIVAS";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = item,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                info.Add(new DatosHisotricoBecas()
                                {
                                    periodo = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    descripcion = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    porcentaje = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    tipo = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
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
            return info;
        }
        public static List<DatosHisotricoBecas> getEstatusDocumentos(string item)
        {
            List<DatosHisotricoBecas> info = new List<DatosHisotricoBecas>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_ESTATUS_DOC";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = item,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                info.Add(new DatosHisotricoBecas()
                                {
                                    periodo = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    descripcion = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    documento = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    estatus = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                    mensaje = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
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
            return info;
        }
        public static List<DatosHisotricoBecas> getBecasNoActivas(string item)
        {
            List<DatosHisotricoBecas> info = new List<DatosHisotricoBecas>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_BECA_NOACTIVA";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = item,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                info.Add(new DatosHisotricoBecas()
                                {
                                    periodo = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    descripcion = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    porcentaje = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    estatus = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                    fecha = (lector.IsDBNull(4) ? "" : (lector.GetDateTime(4).ToString("MM/dd/yyyy"))),
                                    tipo = (lector.IsDBNull(5) ? "" : lector.GetString(5)),
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
            return info;
        }
        public static List<DatosHisotricoBecas> getHistoricoBecas(string item)
        {
            List<DatosHisotricoBecas> info = new List<DatosHisotricoBecas>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_BECOEX_HIST";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = item,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                info.Add(new DatosHisotricoBecas()
                                {
                                    periodo = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    descripcion = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    porcentaje = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    tipo = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
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
            return info;
        }
        public static List<DatosHisotricoBecas> getSolicitudes(string item)
        {
            List<DatosHisotricoBecas> info = new List<DatosHisotricoBecas>();
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_SOLICITUD_ACT";
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("salida", OracleDbType.RefCursor)
                        {
                            Direction = ParameterDirection.ReturnValue
                        });
                        comando.Parameters.Add(new OracleParameter("P_MATRICULA", OracleDbType.Varchar2)
                        {
                            Value = item,
                            Direction = System.Data.ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            OracleDataReader lector = comando.ExecuteReader();
                            while (lector.Read())
                            {
                                info.Add(new DatosHisotricoBecas()
                                {
                                    periodo = (lector.IsDBNull(0) ? "" : lector.GetString(0)),
                                    codigo = (lector.IsDBNull(1) ? "" : lector.GetString(1)),
                                    descripcion = (lector.IsDBNull(2) ? "" : lector.GetString(2)),
                                    porcentaje = (lector.IsDBNull(3) ? "" : lector.GetString(3)),
                                    estatus = (lector.IsDBNull(4) ? "" : lector.GetString(4)),
                                    fecha = (lector.IsDBNull(5) ? "" : (lector.GetDateTime(5).ToString("MM/dd/yyyy"))),
                                    tipo = (lector.IsDBNull(6) ? "" : lector.GetString(6)),
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
            return info;
        }
        public static int ObtenerPidm(string usuario)
        {
            int pidm;
            using (var connection = new OracleConnection(_conString))
            {
                using (var command = new OracleCommand("SZ_BFQ_REGISTRATION.F_OBTENER_PIDM", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    BindByName = true
                })
                {
                    command.Parameters.Add(new OracleParameter("salida", OracleDbType.Int32)
                    {
                        Direction = ParameterDirection.ReturnValue
                    });
                    command.Parameters.Add(new OracleParameter("p_usuario", OracleDbType.Varchar2, 200)
                    {
                        Value = usuario,
                        Direction = ParameterDirection.Input
                    });
                    connection.Open();
                    command.ExecuteNonQuery();
                    try
                    {
                        pidm = Convert.ToInt32(command.Parameters["salida"]?.Value.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                };
            }
            return pidm;
        }
        public static string getTalentoBecario(int usuario)
        {
            string url;
            using (var connection = new OracleConnection(_conString))
            {
                using (var command = new OracleCommand("SZ_BGQ_SIAF.F_TALBECA", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    BindByName = true
                })
                {
                    command.Parameters.Add(new OracleParameter("salida", OracleDbType.Varchar2, 1)
                    {
                        Direction = ParameterDirection.ReturnValue
                    });
                    command.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int16)
                    {
                        Value = usuario,
                        Direction = ParameterDirection.Input
                    });
                    connection.Open();
                    command.ExecuteNonQuery();
                    try
                    {
                        url = command.Parameters["salida"]?.Value.ToString();
                    }
                    finally
                    {
                        connection.Close();
                    }
                };
            }
            return url;
        }
        public static string getUrlBSA(string BecaCode, string anioCode, string nivel)
        {
            string pidm;
            using (var connection = new OracleConnection(_conString))
            {
                using (var command = new OracleCommand("SZ_BGQ_SIAF.F_CREATE_BSA_URL", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    BindByName = true
                })
                {
                    command.Parameters.Add(new OracleParameter("salida", OracleDbType.Varchar2,500)
                    {
                        Direction = ParameterDirection.ReturnValue
                    });
                    command.Parameters.Add(new OracleParameter("P_BECA_CODE", OracleDbType.Varchar2)
                    {
                        Value = BecaCode,
                        Direction = ParameterDirection.Input
                    });
                    command.Parameters.Add(new OracleParameter("P_ANIO_CODE", OracleDbType.Int32)
                    {
                        Value = anioCode,
                        Direction = ParameterDirection.Input
                    });
                    command.Parameters.Add(new OracleParameter("P_NIVEL_CODE", OracleDbType.Varchar2)
                    {
                        Value = nivel,
                        Direction = ParameterDirection.Input
                    });
                    connection.Open();
                    command.ExecuteNonQuery();
                    try
                    {
                        pidm = command.Parameters["salida"]?.Value.ToString();
                    }
                    finally
                    {
                        connection.Close();
                    }
                };
            }
            return pidm;
        }
        public static async Task<string> ObtenerMatricula(int pidm)
        {
            string matricula = "";
            try
            {
                using (var connection = new OracleConnection(_conString))
                {
                    OracleCommand command = new OracleCommand("F_UDEM_STU_ID", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure,
                        BindByName = true
                    };
                    command.Parameters.Add(new OracleParameter("salida", OracleDbType.Char, 9)
                    {
                        Direction = ParameterDirection.ReturnValue
                    });
                    command.Parameters.Add(new OracleParameter("cPidm", OracleDbType.Int32)
                    {
                        Value = pidm,
                        Direction = ParameterDirection.Input
                    });
                    connection.Open();
                    int ejecucion = await command.ExecuteNonQueryAsync();
                    try
                    {
                        matricula = Convert.ToString(command.Parameters["salida"]?.Value);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                var error = ex;
            }
            return matricula;
        }
        public static Documento DisplayFile(Documento documento)
        {
            AxServicesInterface axServicesInterface = new AxServicesInterface();
            string sessionTicket = axServicesInterface.Login("", GlobalVariables.dataSource, GlobalVariables.xtUser,
                                                             GlobalVariables.xtPass, Convert.ToInt32(EAxType.AxFeature_FullTextSearch));

            AxDocumentIndexQueryData newDocument = new AxDocumentIndexQueryData();

            newDocument.addField(1, false, documento.matricula);
            newDocument.addField(2, false, documento.pidm);
            newDocument.addField(3, false, documento.nombre);
            newDocument.addField(4, false, "");
            newDocument.addField(5, false, "");
            newDocument.addField(6, false, "");
            newDocument.addField(7, false, "");
            newDocument.addField(8, false, "");
            newDocument.addField(9, false, "");
            newDocument.addField(10, false, "");

            string documents;
            AxRow row = new AxRow();
            AxStreamResult axStreamResult = new AxStreamResult();

            try
            {
                documents = axServicesInterface.QueryApplicationIndexesByAppId(
                   sessionTicket, GlobalVariables.dataSource, 504, false, true, newDocument.ToString(), 0, 1, 20);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(documents);

                string xmlString = xml.GetElementsByTagName(
                        "ax:Rows")[0].InnerXml.
                        Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "").
                        Replace("xsi:", "");

                row = Serialization<AxRow>.DeserializeFromXmlFile(xmlString);

                string exportId = axServicesInterface.ExportDocumentPagesByRef(sessionTicket, row.attributes[2].value,
                    new AxDocumentExportData()
                    {
                        Format = AxImageExportFormatData.TIFF,
                        Formtype = AxFormTypes.None,
                        HideAnnotations = true,
                        SinglePDFFile = false
                    }.ToString());

                AxStringArray stringArray = Serialization<AxStringArray>.DeserializeFromXmlFile(axServicesInterface.GetExportDocumentPagesResult
                                            (sessionTicket, GlobalVariables.dataSource, exportId, false));

                while (stringArray.itemString == null)
                {
                    string arrayTemp = axServicesInterface.GetExportDocumentPagesResult(
                               sessionTicket, GlobalVariables.dataSource, exportId, false);
                    stringArray = Serialization<AxStringArray>.DeserializeFromXmlFile(arrayTemp);

                    System.Threading.Thread.Sleep(50);

                }

                AxImageStreamData data = new AxImageStreamData()
                {
                    Encryption = false,
                    Maxbytes = 10000000,
                    Startbyte = 0
                };

                axStreamResult = Serialization<AxStreamResult>.DeserializeFromXmlFile(axServicesInterface.DownloadImageStream(
                                sessionTicket, GlobalVariables.dataSource, stringArray.itemString[0], data.ToString()));

            }
            catch (Exception ex)
            {

                documento.error = ex.Message;
            }
            finally
            {
                if (row.attributes != null && row.attributes.Length > 2)
                {
                    axServicesInterface.CloseDocumentByRef(sessionTicket, row.attributes[2].value, false, "");
                }
                axServicesInterface.Logout(sessionTicket);
            }
            if (axStreamResult.ImageBytes != null)
            {


                documento.fileInfo = new FileInfoFtp()
                {
                    FileContent = axStreamResult.ImageBytes,
                    FileName = "Prueba_Documento",
                    FileType = "application/pdf"
                };
            }

            return documento;
        }
        public static Documento DisplayFile2(Documento document)
        {
            AxServicesInterface axServicesInterface = new AxServicesInterface();
            string sessionTicket = axServicesInterface.Login("", GlobalVariables.dataSource, GlobalVariables.xtUser,
                                                             GlobalVariables.xtPass, Convert.ToInt32(EAxType.AxFeature_FullTextSearch));

            AxDocumentIndexQueryData newDocument = new AxDocumentIndexQueryData();

            newDocument.addField(1, false, document.matricula);
            newDocument.addField(2, false, document.pidm);
            newDocument.addField(3, false, document.nombre);
            newDocument.addField(4, false, "");
            newDocument.addField(5, false, "");
            newDocument.addField(6, false, "");
            newDocument.addField(7, false, "");
            newDocument.addField(8, false, "");
            newDocument.addField(9, false, "");
            newDocument.addField(10, false, "");

            string documents;
            AxRow row = new AxRow();
            AxStreamResult axStreamResult = new AxStreamResult();

            try
            {
                documents = axServicesInterface.QueryApplicationIndexesByAppId(
                   sessionTicket, GlobalVariables.dataSource, 504, false, true, newDocument.ToString(), 0, 1, 20);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(documents);

                string xmlString = xml.GetElementsByTagName(
                        "ax:Rows")[0].InnerXml.
                        Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "").
                        Replace("xsi:", "");

                row = Serialization<AxRow>.DeserializeFromXmlFile(xmlString);

                string exportId = axServicesInterface.ExportDocumentPagesByRef(sessionTicket, row.attributes[2].value,
                    new AxDocumentExportData()
                    {
                        Format = AxImageExportFormatData.TIFF,
                        Formtype = AxFormTypes.None,
                        HideAnnotations = true,
                        SinglePDFFile = false
                    }.ToString());

                AxStringArray stringArray = Serialization<AxStringArray>.DeserializeFromXmlFile(axServicesInterface.GetExportDocumentPagesResult
                                            (sessionTicket, GlobalVariables.dataSource, exportId, false));

                while (stringArray.itemString == null)
                {
                    string arrayTemp = axServicesInterface.GetExportDocumentPagesResult(
                               sessionTicket, GlobalVariables.dataSource, exportId, false);
                    stringArray = Serialization<AxStringArray>.DeserializeFromXmlFile(arrayTemp);

                    System.Threading.Thread.Sleep(50);

                }

                AxImageStreamData data = new AxImageStreamData()
                {
                    Encryption = false,
                    Maxbytes = 10000000,
                    Startbyte = 0
                };

                axStreamResult = Serialization<AxStreamResult>.DeserializeFromXmlFile(axServicesInterface.DownloadImageStream(
                                sessionTicket, GlobalVariables.dataSource, stringArray.itemString[0], data.ToString()));

            }
            catch (Exception ex)
            {
                throw new HttpException((int)HttpStatusCode.InternalServerError, ex.Message);

            }
            finally
            {
                if (row.attributes != null)

                {
                    axServicesInterface.CloseDocumentByRef(sessionTicket, row.attributes[2].value, false, "");
                    axServicesInterface.Logout(sessionTicket);

                }
            }

            document.fileInfo= new FileInfoFtp()
            {
                FileContent = axStreamResult.ImageBytes,
                FileName = "Prueba_Documento",
                FileType = "application/pdf"
            };
            return document;


        }


        public static string GuardarDocumento(Documento document)
        {
            AxServicesInterface axServicesInterface = new AxServicesInterface();

            byte[] fileContents = new byte[document.file.ContentLength];
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(
                    "ftp://" + GlobalVariables.ftpip + "/Cartas_Aceptacion/"+document.matricula+"-"+document.periodo+"-"+document.beca);//Nombre documento = Matricula+Año ayuda+Codigo Beca 000612260-2511-PEOPONI

                request.KeepAlive = false;

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential(GlobalVariables.ftpUser, GlobalVariables.ftpPassword);
                request.UseBinary = true;

                fileContents = new BinaryReader(document.file.InputStream).ReadBytes(document.file.ContentLength);

                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine("Resultado: " + response.StatusDescription);
                    response.Close();
                    request.Abort();
                }


            }
            catch (Exception ex)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, ex.Message);
            }

            var prueba = Convert.ToInt32(EAxType.AxFeature_Basic);
            string sessionTicket = axServicesInterface.Login("", GlobalVariables.dataSource, GlobalVariables.xtUser,
                                                             GlobalVariables.xtPass, Convert.ToInt32(EAxType.AxFeature_Basic));


            string result = null;

            try
            {

                AxDocumentCreationData newDocument = new AxDocumentCreationData(504, GlobalVariables.dataSource,
                                GlobalVariables.ftpRuta + "/Cartas_Aceptacion/"+document.matricula+"-"+document.periodo+"-"+document.beca+"", EAxFileType.FT_UNKNOWN, //Nombre documento = Matricula+Año ayuda+Codigo Beca 000612260-2511-PEOPONI
                                true, true, false, 0);


                AxDocumentIndex newDocumentIndex = new AxDocumentIndex("-1",
                    document.matricula, //Matricula,
                    document.pidm, //PIDM)
                    document.nombre,//Nombre de documento
                    document.apellidos,//Apellidos 
                    document.periodo,//Periodo
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") //Fecha del día de hoy
                    );

                result = axServicesInterface.CreateNewDocument(sessionTicket, newDocument.ToString(),
                                                       newDocumentIndex.ToString());


            }
            catch (Exception ex)
            {
                result = ex.Message;
                throw new HttpException((int)HttpStatusCode.BadRequest, ex.Message);
            }
            finally
            {
                axServicesInterface.Logout(sessionTicket);
            }

            return result;
        }

        public static string ActualizarDocumento(Documento document)
        {
            AxServicesInterface axServicesInterface = new AxServicesInterface();
            byte[] fileContents = new byte[document.file.ContentLength];

            //Validar que el archivo exista
            try
            {
                AxDocument.DeleteDocument(document);
            }
            catch (Exception ex)
            {
                throw new HttpException(
                    (int)HttpStatusCode.InternalServerError
                    , ex.Message);
            }

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(
                    "ftp://" + GlobalVariables.ftpip + "/Cartas_Aceptacion/"+document.matricula+"-"+document.periodo+"-"+document.beca+"");
                request.KeepAlive = false;

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential(GlobalVariables.ftpUser, GlobalVariables.ftpPassword);
                request.UseBinary = true;

                fileContents = new BinaryReader(document.file.InputStream).ReadBytes(document.file.ContentLength);

                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    response.Close();
                    request.Abort();
                }

            }
            catch (Exception ex)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, ex.Message);
            }
            string sessionTicket = axServicesInterface.Login("", GlobalVariables.dataSource,
                /*"services.bdmapp", "W#7hdw!68dxZ",*//*"BSASSBUSR1", "u_pick_it",*/GlobalVariables.xtUser, GlobalVariables.xtPass,
                                                        Convert.ToInt32(EAxType.AxFeature_Basic));

            string result = null;
            try
            {

                AxDocumentCreationData newDocument = new AxDocumentCreationData(504, GlobalVariables.dataSource,
                                GlobalVariables.ftpRuta + "/Cartas_Aceptacion/"+document.matricula+"-"+document.periodo+"-"+document.beca, EAxFileType.FT_UNKNOWN,
                                true, true, false, 0);

                AxDocumentIndex newDocumentIndex = new AxDocumentIndex("-1",
                  document.matricula, //Matricula,
                  document.pidm, //PIDM)
                   document.nombre,
                  document.apellidos,
                   document.periodo,
                   DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                result = axServicesInterface.CreateNewDocument(sessionTicket, newDocument.ToString(),
                                                                       newDocumentIndex.ToString());
            }
            catch (Exception ex)
            {
                result = ex.Message;
                throw new HttpException((int)HttpStatusCode.BadRequest, ex.Message);
            }
            finally
            {
                axServicesInterface.Logout(sessionTicket);
            }

            return result;

        }

    }
}
