using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PL.Controllers
{
    public class HistoriaClinicaController : Controller
    {
        [HttpGet]
        public ActionResult Form(int? IdHistoriaClinica)
        {
            if (IdHistoriaClinica == null)
            {
                ML.HistoriaClinica historiaClinica = new ML.HistoriaClinica();

                ML.Result result = BL.AnteFam.GetAll();

                if (result.Correct)
                {

                    historiaClinica.AnteHeredoFam = new ML.AnteHeredoFam();
                    historiaClinica.AnteHeredoFam.AntesHeredoFams = new List<ML.AnteHeredoFam>();

                    for (int i = 0; i < result.Objects.Count; i++)
                    {
                        ML.AnteHeredoFam anteHeredoFam = new ML.AnteHeredoFam();
                        anteHeredoFam.AnteFam = (ML.AnteFam)result.Objects[i];

                        historiaClinica.AnteHeredoFam.AntesHeredoFams.Add(anteHeredoFam);
                    }

                    result = BL.AntePers.GetAll();

                    if (result.Correct)
                    {
                        historiaClinica.AnteNoPatoPers = new ML.AnteNoPatoPers();
                        historiaClinica.AnteNoPatoPers.AntesNoPatosPers = new List<ML.AnteNoPatoPers>();

                        for (int i = 0; i < result.Objects.Count; i++)
                        {
                            ML.AnteNoPatoPers anteNoPatoPers = new ML.AnteNoPatoPers();
                            anteNoPatoPers.AntePers = (ML.AntePers)result.Objects[i];

                            historiaClinica.AnteNoPatoPers.AntesNoPatosPers.Add(anteNoPatoPers);
                        }

                        result = BL.AntePato.GetAll();

                        if (result.Correct)
                        {
                            historiaClinica.AntePersPato = new ML.AntePersPato();
                            historiaClinica.AntePersPato.AntesPersPatos = new List<ML.AntePersPato>();
                            
                            for (int i = 0; i < result.Objects.Count; i++)
                            {
                                ML.AntePersPato antePersPato = new ML.AntePersPato();
                                antePersPato.AntePato = (ML.AntePato)result.Objects[i];

                                historiaClinica.AntePersPato.AntesPersPatos.Add(antePersPato);
                            }

                            result = BL.TipoMordida.GetAll();

                            if (result.Correct)
                            {
                                historiaClinica.ExamOclusion = new ML.ExamOclusion();
                                historiaClinica.ExamOclusion.TipoMordida = new ML.TipoMordida();
                                historiaClinica.ExamOclusion.TipoMordida.TiposMordidas = new List<ML.TipoMordida>();

                                for (int i = 0; i < result.Objects.Count; i++)
                                {
                                    ML.TipoMordida tipoMordida = new ML.TipoMordida();
                                    tipoMordida = (ML.TipoMordida)result.Objects[i];

                                    historiaClinica.ExamOclusion.TipoMordida.TiposMordidas.Add(tipoMordida);
                                }

                                result = BL.TipoExamComp.GetAll();

                                if (result.Correct)
                                {
                                    historiaClinica.ExamComplementario = new ML.ExamComplementario();
                                    historiaClinica.ExamComplementario.TipoExamCompl = new ML.TipoExamCompl();
                                    historiaClinica.ExamComplementario.TipoExamCompl.TiposExamenesCompls = new List<ML.TipoExamCompl>();

                                    for (int i = 0; i < result.Objects.Count; i++)
                                    {
                                        ML.TipoExamCompl tipoExamCompl = new ML.TipoExamCompl();
                                        tipoExamCompl = (ML.TipoExamCompl)result.Objects[i];

                                        historiaClinica.ExamComplementario.TipoExamCompl.TiposExamenesCompls.Add(tipoExamCompl);
                                    }
                                }
                                else
                                {
                                    ViewBag.Message = "Ocurrio un error al recopilar la información de: Tipo de Examen Complementario: " + result.ErrorMessage;
                                }
                            }
                            else
                            {
                                ViewBag.Message = "Ocurrio un error al recopilar la información de: Tipo de Mordida: " + result.ErrorMessage;
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Ocurrio un error al recopilar la información de: Antecedentes Personales Patológicos: " + result.ErrorMessage;
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Ocurrio un error al recopilar la información de: Antecedentes Personales: " + result.ErrorMessage;
                    }
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al recopilar la información de: Antecedentes Heredo-Familiares: " + result.ErrorMessage;
                }

                historiaClinica.Paciente = new ML.Paciente();
                historiaClinica.Exploracion = new ML.Exploracion();
                historiaClinica.ExamIntrabucal = new ML.ExamIntrabucal();

                return View(historiaClinica);
            }
            else
            {
                //FORMULARIO EN CASO DE EDITAR LA INFORMACION DE UN PACIENTE
            }

            return PartialView("ValidationModal");
        }

        [HttpPost]
        public ActionResult Form(ML.HistoriaClinica historiaClinica)
        {
            if (ModelState.IsValid)
            {
                if (historiaClinica.IdHistoriaClinica == 0)
                {
                    historiaClinica.AnteHeredoFam.AntesHeredoFams = historiaClinica.AnteHeredoFam.AntesHeredoFams.Where(p => p.CheckBox).ToList();
                    historiaClinica.AnteNoPatoPers.AntesNoPatosPers = historiaClinica.AnteNoPatoPers.AntesNoPatosPers.Where(p => p.CheckBoxAnteNoPatoPers).ToList();
                    historiaClinica.AntePersPato.AntesPersPatos = historiaClinica.AntePersPato.AntesPersPatos.Where(p => p.CheckBoxAntePersPato).ToList();

                    ML.Result result = BL.HistoriaClinica.Add(historiaClinica);

                    if (result.Correct)
                    {
                        ViewBag.Message = "Historia Clinica registrada con éxito";
                    }
                    else
                    {
                        ViewBag.Message = "Ocurrio un error al registrar la Historia Clinica: " + result.ErrorMessage;
                    }
                }
                else
                {
                    ML.Result result = BL.HistoriaClinica.Add(historiaClinica);
                    if (result.Correct)
                    {
                        ViewBag.Message = "Proveedor actualizado con éxito";
                    }
                    else
                    {
                        ViewBag.Message = "Ocurrio un error al actualizar el proveedor: " + result.ErrorMessage;
                    }
                }
                return PartialView("ValidationModal");
            }
            else
            {
                return View(historiaClinica);
            }
        }

        [HttpPost]
        public ML.HistoriaClinica addObjectTiList(ML.HistoriaClinica historiaClinica)
        {
            ML.ExamComplementario examComplementario = new ML.ExamComplementario();

            historiaClinica.ExamComplementario.ExamenesComplementarios = new List<ML.ExamComplementario>();
            historiaClinica.ExamComplementario.ExamenesComplementarios.Add(examComplementario);

            return historiaClinica;
        }
    }
}
