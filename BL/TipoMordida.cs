using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TipoMordida
    {

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.CONS_DENTALContext context = new DL.CONS_DENTALContext())
                {
                    var query = context.TipoMordida.FromSqlRaw("TipoMordidaGetAll").ToList();

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.TipoMordida tipoMordida = new ML.TipoMordida();

                            tipoMordida.IdTipoMordida = item.IdTipoMordida;
                            tipoMordida.Tipo = item.Tipo;

                            result.Objects.Add(tipoMordida);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "NO SE ENCONTRARON TIPO DE MORDIDA REGISTRADAS";
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
