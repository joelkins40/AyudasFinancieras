using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using AyudasFinancierasV2.Models.Entity;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace AyudasFinancierasV2.Models.Services
{
    public class AceptacionBecaService
    {
        private static readonly string _conString = ConfigurationManager.ConnectionStrings["BANNER"].ConnectionString;
        public AceptacionBeca ObtenerDatosAceptacionBeca(string matricula, InfoAdmisionFinanciera info)
        {
            var aceptacionBeca = ObtenerDatosDummyPorMatricula(matricula, info);
            return aceptacionBeca;
        }
        private AceptacionBeca ObtenerDatosDummyPorMatricula(string matricula, InfoAdmisionFinanciera info)
        {
            var aceptacionBeca = new AceptacionBeca
            {
                Nombre = info.Nombre,
                NombreAyudaFinanciera = info.NombreAyudaFinanciera,
                Matricula = info.Matricula,
                EscuelaProcedencia = info.EscuelaProcedencia,
                PorcentajeAyudaFinanciera = info.PorcentajeBeca,
                FechaOfrecimiento = (DateTime)info.FechaOfrecimiento,
                Programa = info.Programa,
                Campus = info.Campus,
                TipoAdmision = info.Nivel,
                Periodo = info.Periodo,
                Talento = info.Talento,
                Horas = info.Horas,
                Tiempo = info.Tiempo,
                NIVEL_ANTERIOR=info.NivelAnterior,
                PuntosExamenAdmision = (int)info.PAA,
                PuntosMinimosRequeridos = (int)info.PAA,
                PoliticasAsignacion = new PoliticasAsignacion
                {
                    PromedioMinimoRequerido = (int)info.Promedio,
                    DebeAprobarTodasMaterias = true,
                    PuntosMinimosExamen = (int)info.PAA,
                    DebeCompletarSolicitud = true,
                    ConsultarProcesoAdmision = info.Nivel,
                },
                PoliticasRenovacion = new PoliticasRenovacion
                {
                    PromedioMinimoRenovacion = info.PromedioRenovacion,
                    DebeAprobarTodasMateriasRenovacion = true,
                    NotaImportante = "De incumplir con alguna de las políticas mencionadas, el ofrecimiento de ayuda financiera será retirado.",
                    ConsideracionesAdicionales = "La ayuda financiera únicamente cubre el número de períodos del programa de estudio en el que estoy inscrito, más un período adicional, esto no considerar intercambio directo (es decir, si me inscribo y le pago directamente a la universidad extranjera)."
                },
                Compromisos = ObtenerCompromisosDelDocumento(),
                LugarFirma = "San Pedro Garza García, N.L.",
                FechaFirma = DateTime.Now,
                FirmaBeneficiario = info.Nombre,
                EstaAceptada = false
            };
            return aceptacionBeca;
        }
        private List<Compromiso> ObtenerCompromisosDelDocumento()
        {
            return new List<Compromiso>
            {
                new Compromiso
                {
                    Numero = 1,
                    Titulo = "Hago constar que me doy por enterado(a), acepto y me comprometo a cumplir",
                    Descripcion = "con lo siguiente:",
                    Incisos = new List<string>
                    {
                        "a. Me comprometo a leer, observar, respetar y cumplir los lineamiento de ayudas financieras y cualquier otra normatividad aplicable a mi programa académico, así como a mantenerme informado de posibles modificaciones que se realicen a los mismos. ",
                        "b. Comunicarme a través de los medios oficiales para emitir cualquier comentario o sugerencia sobre la UDEM y sus instancias son el buzón de sugerencia y UDEM Te Escucha. El uso de medios alternos, físicos o electrónicos podrá ser motivo de análisis por las autoridades educativas correspondientes, quienes podrán emitir las medidas que consideren aplicables",
                     }
                }

            };
        }
        public bool AceptarBeca(string matricula, DateTime fechaAceptacion)
        {
            try
            {
                RegistrarAceptacionEnLog(matricula, fechaAceptacion);
                EnviarNotificacionAceptacion(matricula, null);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al aceptar beca para matrícula {matricula}: {ex.Message}");
                return false;
            }
        }
        private void RegistrarAceptacionEnLog(string matricula, DateTime fechaAceptacion)
        {
            System.Diagnostics.Debug.WriteLine($"Beca aceptada - Matrícula: {matricula}, Fecha: {fechaAceptacion}");
        }
        private void EnviarNotificacionAceptacion(string matricula, AceptacionBeca datos)
        {
            System.Diagnostics.Debug.WriteLine($"Notificación enviada a {datos.Nombre} ({matricula})");
        }
        public string GenerarCodigoBeca(string matricula, string tipoBeca)
        {
            var timestamp = DateTime.Now.ToString("yyyyMMdd");
            var codigo = $"BEA-{tipoBeca}-{matricula}-{timestamp}";
            return codigo;
        }
        public InfoAdmisionFinanciera ObtenerInfoAdmisionFinanciera(int pidm, string codigoBeca, int codigoAno)
        {
            try
            {
                var infoAdmision = ObtenerInfoAdmisionFinancieraOracle(pidm, codigoBeca, codigoAno);
                if (infoAdmision == null)
                {
                    System.Diagnostics.Debug.WriteLine("No se pudieron obtener datos de Oracle, usando datos dummy como fallback");
                    infoAdmision = ObtenerDatosInfoAdmisionDummy(pidm, codigoBeca, codigoAno);
                }
                return infoAdmision;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al obtener información de admisión financiera - PIDM: {pidm}, Código Beca: {codigoBeca}, Año: {codigoAno}. Error: {ex.Message}");
                try
                {
                    return ObtenerDatosInfoAdmisionDummy(pidm, codigoBeca, codigoAno);
                }
                catch
                {
                    return null;
                }
            }
        }
        private InfoAdmisionFinanciera ObtenerDatosInfoAdmisionDummy(int pidm, string codigoBeca, int codigoAno)
        {
            var info = new InfoAdmisionFinanciera
            {
                Nombre = "Enrique Cantú Guerrero",
                Matricula = "000205524",
                EscuelaProcedencia = "Preparatoria UDEM (UFU)",
                NombreAyudaFinanciera = "Beca de Excelencia Académica",
                Periodo = "202501", // Formato de período académico
                PorcentajeBeca = "50%",
                FechaOfrecimiento = new DateTime(2025, 3, 7),
                Promedio = 95.5m,
                PAA = 1300,
                Programa = "IISE", // Ingeniería Industrial y de Sistemas
                Campus = "UDEM",
                Nivel = "BA" // Bachelor/Licenciatura
            };
            if (pidm != 950270)
            {
                info.Nombre = $"Estudiante {pidm}";
                info.Matricula = $"00{pidm.ToString().Substring(Math.Max(0, pidm.ToString().Length - 6))}";
                info.Programa = DeterminarPrograma(pidm);
                info.Campus = DeterminarCampus(pidm);
                info.Promedio = GenerarPromedioAleatorio(pidm);
                info.PAA = GenerarPAAaleatorio(pidm);
            }
            info.NombreAyudaFinanciera = ObtenerNombreAyudaFinanciera(codigoBeca);
            return info;
        }
        private string ObtenerNombreAyudaFinanciera(string codigoBeca)
        {
            var ayudasFinancieras = new Dictionary<string, string>
            {
                { "BEA", "Beca de Excelencia Académica" },
                { "BES", "Beca de Excelencia Social" },
                { "BED", "Beca de Excelencia Deportiva" },
                { "BAE", "Beca de Apoyo Económico" },
                { "BCA", "Beca de Colaborador Académico" },
                { "BCU", "Beca Cultural" },
                { "BLE", "Beca de Liderazgo Estudiantil" }
            };
            return ayudasFinancieras.ContainsKey(codigoBeca)
                ? ayudasFinancieras[codigoBeca]
                : "Ayuda Financiera";
        }
        private string DeterminarPrograma(int pidm)
        {
            var programas = new[] { "IISE", "LAE", "IIS", "ARQ", "MED", "DER", "ING", "PSI" };
            return programas[pidm % programas.Length];
        }
        private string DeterminarCampus(int pidm)
        {
            var campus = new[] { "UDEM", "LAGUNA", "TAMPICO" };
            return campus[pidm % campus.Length];
        }
        private decimal GenerarPromedioAleatorio(int pidm)
        {
            var semilla = pidm % 100;
            return Math.Round(85 + (semilla * 15.0m / 100), 1);
        }
        private int GenerarPAAaleatorio(int pidm)
        {
            var semilla = pidm % 100;
            return 1000 + (semilla * 400 / 100); // Rango de 1000 a 1400
        }
        public InfoAdmisionFinanciera ObtenerInfoAdmisionFinancieraPorMatricula(int pidm, string codigoBeca, int codigoAno)
        {
            return ObtenerInfoAdmisionFinanciera(pidm, codigoBeca, codigoAno);
        }
        public InfoAdmisionFinanciera ObtenerInfoAdmisionFinancieraOracle(int pidm, string codigoBeca, int codigoAno)
        {
            InfoAdmisionFinanciera info = null;
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGQ_SIAF.F_INFO_ADMSS_FNDC";
                        comando.CommandType = CommandType.StoredProcedure;
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
                        comando.Parameters.Add(new OracleParameter("P_FNDC_CODE", OracleDbType.Varchar2)
                        {
                            Value = codigoBeca ?? string.Empty,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_AIDY_CODE", OracleDbType.Int32)
                        {
                            Value = codigoAno,
                            Direction = ParameterDirection.Input
                        });
                        cnx.Open();
                        try
                        {
                            comando.ExecuteNonQuery();
                            using (OracleDataReader reader = ((OracleRefCursor)comando.Parameters["salida"].Value).GetDataReader())
                            {
                                if (reader.Read())
                                {
                                    info = new InfoAdmisionFinanciera
                                    {
                                        Nombre = reader["NOMBRE"]?.ToString(),
                                        Matricula = reader["MATRICULA"]?.ToString(),
                                        EscuelaProcedencia = reader["ESCUELA_PROCEDENCIA"]?.ToString(),
                                        NombreAyudaFinanciera = reader["NOMBRE_AYUDA_FINANCIERA"]?.ToString(),
                                        Periodo = reader["PERIODO"]?.ToString(),
                                        PorcentajeBeca = reader["PORCENTAJE_BECA"]?.ToString(),
                                        FechaOfrecimiento = reader["FECHA_OFRECIMIENTO"] != DBNull.Value
                                            ? Convert.ToDateTime(reader["FECHA_OFRECIMIENTO"])
                                            : (DateTime?)null,
                                        Promedio = reader["PROMEDIO_ADMISION"] != DBNull.Value
                                            ? Convert.ToDecimal(reader["PROMEDIO_ADMISION"])
                                            : (decimal?)null,
                                        PAA = reader["PAA_ADMISION"] != DBNull.Value
                                            ? Convert.ToInt32(reader["PAA_ADMISION"])
                                            : (int?)null,
                                        Programa = reader["PROGRAMA"]?.ToString(),
                                        Campus = reader["CAMPUS"]?.ToString(),
                                        Nivel = reader["NIVEL"]?.ToString(),
                                        Tiempo = reader["TIEMPO_INTERV"]?.ToString(),
                                        Talento = reader["TALENTO_BECARIO"]?.ToString(),
                                        Horas = reader["HORAS_TALENTO"]?.ToString(),
                                        PromedioRenovacion = reader["PROM_RENOV"]?.ToString(),
                                        NivelAnterior = reader["NIVEL_ANTERIOR"]?.ToString(),
                                    };
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error ejecutando función Oracle F_INFO_ADMSS_FNDC: {ex.Message}");
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en ObtenerInfoAdmisionFinancieraOracle - PIDM: {pidm}, Código: {codigoBeca}, Año: {codigoAno}. Error: {ex.Message}");
                return null;
            }

            return info;
        }
        public InfoAdmisionFinanciera ObtenerInfoAdmisionFinanciera(int pidm, string codigoBeca, int codigoAno, bool usarOracle)
        {
            try
            {
                if (usarOracle)
                {
                    var infoAdmision = ObtenerInfoAdmisionFinancieraOracle(pidm, codigoBeca, codigoAno);
                    if (infoAdmision == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Oracle falló, usando datos dummy como fallback");
                        return ObtenerDatosInfoAdmisionDummy(pidm, codigoBeca, codigoAno);
                    }
                    return infoAdmision;
                }
                else
                {
                    return ObtenerDatosInfoAdmisionDummy(pidm, codigoBeca, codigoAno);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en ObtenerInfoAdmisionFinanciera - PIDM: {pidm}, Código Beca: {codigoBeca}, Año: {codigoAno}, Usar Oracle: {usarOracle}. Error: {ex.Message}");
                try
                {
                    return ObtenerDatosInfoAdmisionDummy(pidm, codigoBeca, codigoAno);
                }
                catch
                {
                    return null;
                }
            }
        }
        public InfoAdmisionFinanciera ObtenerInfoAdmisionFinancieraPorMatricula(string matricula, string codigoBeca, int codigoAno, bool usarOracle)
        {
            try
            {
                int pidmSimulado = ConvertirMatriculaAPIDM(matricula);
                return ObtenerInfoAdmisionFinanciera(pidmSimulado, codigoBeca, codigoAno, usarOracle);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al obtener información por matrícula: {matricula}. Error: {ex.Message}");
                return null;
            }
        }
        public string ActualizarEstatusBeca(int pidm, string codigoBeca, int codigoAno, string estatusOfrecimiento)
        {
            string resultado = string.Empty;
            try
            {
                using (OracleConnection cnx = new OracleConnection(_conString))
                {
                    using (OracleCommand comando = new OracleCommand())
                    {
                        comando.Connection = cnx;
                        comando.CommandText = "SZ_BGA_SIAF.P_STATUS_AWRD";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.BindByName = true;
                        comando.Parameters.Add(new OracleParameter("P_PIDM", OracleDbType.Int32)
                        {
                            Value = pidm,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_AIDY_CODE", OracleDbType.Int32)
                        {
                            Value = codigoAno,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_FNDC_CODE", OracleDbType.Varchar2)
                        {
                            Value = codigoBeca ?? string.Empty,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_OFFER_STATUS", OracleDbType.Varchar2)
                        {
                            Value = estatusOfrecimiento ?? string.Empty,
                            Direction = ParameterDirection.Input
                        });
                        comando.Parameters.Add(new OracleParameter("P_RESULT", OracleDbType.Varchar2, 500)
                        {
                            Direction = ParameterDirection.Output
                        });
                        cnx.Open();
                        try
                        {
                            comando.ExecuteNonQuery();
                            resultado = comando.Parameters["P_RESULT"].Value?.ToString() ?? "Sin respuesta del servidor";
                            System.Diagnostics.Debug.WriteLine($"Resultado P_STATUS_AWRD: {resultado}");
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error ejecutando P_STATUS_AWRD: {ex.Message}");
                            resultado = $"ERROR: Excepción al ejecutar procedimiento - {ex.Message}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en ActualizarEstatusBeca - PIDM: {pidm}, Código: {codigoBeca}, Año: {codigoAno}, Estatus: {estatusOfrecimiento}. Error: {ex.Message}");
                resultado = $"ERROR: Error de conexión - {ex.Message}";
            }
            return resultado;
        }
        public string AceptarBecaOracle(int pidm, string codigoBeca, int codigoAno)
        {
            return ActualizarEstatusBeca(pidm, codigoBeca, codigoAno, "ACEP");
        }
        public string RechazarBecaOracle(int pidm, string codigoBeca, int codigoAno)
        {
            return ActualizarEstatusBeca(pidm, codigoBeca, codigoAno, "CANC");
        }
        public string AceptarBecaPorMatricula(int pidm, string codigoBeca, int codigoAno)
        {
            return AceptarBecaOracle(pidm, codigoBeca, codigoAno);
        }
        public string RechazarBecaPorMatricula(int pidm, string codigoBeca, int codigoAno)
        {
            return RechazarBecaOracle(pidm, codigoBeca, codigoAno);
        }
        private int ConvertirMatriculaAPIDM(string matricula)
        {
            if (int.TryParse(matricula, out int resultado))
            {
                return resultado;
            }
            return Math.Abs(matricula.GetHashCode()) % 999999 + 100000;
        }
    }
}