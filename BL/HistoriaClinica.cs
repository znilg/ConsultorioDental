using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HistoriaClinica
    {
        public static ML.Result Add(ML.HistoriaClinica historiaClinica)
        {
            ML.Result result = new ML.Result();

            try
            {

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }

            return result;
        }
    }
}
