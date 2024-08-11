using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AnteFam
    {

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.CONS_DENTALContext context = new DL.CONS_DENTALContext())
                {
                    var query = context.AnteFams.FromSqlRaw("AnteFamGetAll").ToList();

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.AnteFam anteFam = new ML.AnteFam();

                            anteFam.IdAnteFam = item.IdAnteFam;
                            anteFam.Nombre = item.Nombre;

                            result.Objects.Add(anteFam);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "NO SE ENCONTRARON ANTECEDENTES FAMILIARES REGISTRADOS";
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
