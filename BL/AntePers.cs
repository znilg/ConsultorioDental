using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AntePers
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.CONS_DENTALContext context = new DL.CONS_DENTALContext())
                {
                    var query = context.AntePers.FromSqlRaw("AntePersGetAll").ToList();

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.AntePers antePers = new ML.AntePers();

                            antePers.IdAntePers = item.IdAntePers;
                            antePers.Nombre = item.Nombre;

                            result.Objects.Add(antePers);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "NO SE ENCONTRARON ANTECEDENTES PERSONALES REGISTRADOS";
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
