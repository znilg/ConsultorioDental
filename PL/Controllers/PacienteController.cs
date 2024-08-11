using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class PacienteController : Controller
    {
        // GET: PacienteController
        public ActionResult GetAll(ML.Paciente paciente)
        {
            paciente.Nombre = (paciente.Nombre == null) ? "" : paciente.Nombre;
            paciente.ApellidoPaterno = (paciente.ApellidoPaterno == null) ? "" : paciente.ApellidoPaterno;
            paciente.ApellidoMaterno = (paciente.ApellidoMaterno == null) ? "" : paciente.ApellidoMaterno;

            ML.Result result = BL.Paciente.GetAll(paciente);

            paciente = new ML.Paciente();

            paciente.Pacientes = result.Correct == true ? paciente.Pacientes = result.Objects : new List<object>();

            return View(paciente);
        }

        [HttpPost]
        public ActionResult Prueba(ML.HistoriaClinica jdbs)
        {
            return View();
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PacienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
