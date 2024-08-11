using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

namespace BL
{
    public class Paciente
    {
        public static ML.Result GetAll(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.CONS_DENTALContext context = new DL.CONS_DENTALContext())
                {
                    var query = context.Pacientes.FromSqlRaw($"PacienteGetAll '{paciente.Nombre}','{paciente.ApellidoPaterno}','{paciente.ApellidoMaterno}'").ToList();

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            paciente = new ML.Paciente();
                            
                            paciente.IdPaciente = item.IdPaciente;
                            paciente.Nombre = item.Nombre;
                            paciente.ApellidoPaterno = item.ApellidoPaterno;
                            paciente.ApellidoMaterno = item.ApellidoMaterno;
                            paciente.Edad = (int)item.Edad;
                            paciente.Direccion = item.Direccion;
                            paciente.Ocupacion = item.Ocupacion;
                            paciente.Genero = item.Genero;
                            paciente.Telefono = item.Telefono;
                            paciente.HistoriaClinica = new ML.HistoriaClinica();
                            paciente.HistoriaClinica.IdHistoriaClinica = (int)item.IdHistoriaClinica;

                            result.Objects.Add(paciente);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "NO SE ENCONTRARON PACIENTES REGISTRADOS";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

    }
}