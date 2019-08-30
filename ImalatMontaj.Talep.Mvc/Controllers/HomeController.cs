using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImalatMontaj.Talep.Mvc.Models;
using ImalatMontaj.Talep.Business.Abstract;
using ImalatMontaj.Talep.Entities.Concrete;
using System.IO;

namespace ImalatMontaj.Talep.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private ITalepService _iTalepService;
        private IFotoService _iFotoService;
        private ITalepUnitService _iTalepUnitService;

        public HomeController(ITalepService iTalepService, ITalepUnitService iTalepUnitService, IFotoService iFotoService)
        {
            _iTalepService = iTalepService;
            _iTalepUnitService = iTalepUnitService;
            _iFotoService = iFotoService;
        }

        public IActionResult Index()
        {
            var v = _iTalepService.GetAll();
            return View(v);
        }

        public IActionResult Detail(int id)
        {
            TalepDetay td = new TalepDetay();
            td.talep = _iTalepService.GetById(id);
            td.fotos = _iFotoService.GetByTalep(id);
            ViewBag.Id = id;

            return View(td);
        }

        public IActionResult Edit(int id)
        {
            return View("TalepEditor", _iTalepService.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Entities.Concrete.Talep entity)
        {
            if (entity.Id == 0)
            {
                entity.TalepEdenTarihi = DateTime.Now;
                _iTalepService.Add(entity);
            }
            else
            {
                if (entity.TalepEdenTarihi != null && entity.TalepOnayTarihi == null)
                {
                    entity.TalepOnayTarihi = DateTime.Now;
                }
                else if (entity.TalepOnayTarihi != null && entity.TalepYapanTalepTarihi == null)
                {
                    entity.TalepYapanTalepTarihi = DateTime.Now;
                }
                else if (entity.TalepYapanTalepTarihi != null && entity.TalepKontrolTarihi == null)
                {
                    entity.TalepKontrolTarihi = DateTime.Now;
                }
                _iTalepService.Update(entity);
            }
            return RedirectToAction("Detail", new { id = entity.Id });
        }

        public IActionResult Delete(int id)
        {
            var entity = _iTalepService.GetById(id);
            _iTalepService.Delete(entity);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(int id)
        {
            var files = Request.Form.Files;

            long size = files.Sum(f => f.Length);

            //var path = Path.GetTempFileName();

            foreach (var file in files)
            {

                var foto = new Foto();

                foto.TalepId = id;

                if (file.Length > 0)
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "wwwroot/img", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                foto.Yol = "img/" + file.FileName;

                _iFotoService.Add(foto);
            }
            //Ok(new { count = files.Count, size });
            return RedirectToAction("Detail", new { id = id });

        }

        public ActionResult Remove(int id, int rid)
        {
            var foto = _iFotoService.GetById(id);
            _iFotoService.Delete(foto);

            //Ok(foto);
            return RedirectToAction("Detail", new { id = rid });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
