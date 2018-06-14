using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BGCMS.Web.Areas.TS00WG.Controllers
{
    public class TS0000Controller : Controller
    {
        public static BGMES.BLL.TS0000 _bll = new BGMES.BLL.TS0000();
        //
        // GET: /TS00WG/TS0000/
        public ActionResult Index()
        {
            ViewData["ListCodeData"] = _bll.GetCodeName();
            ViewData["ListCode"] = _bll.GetAll();
            return View();
        }

        //
        // GET: /TS00WG/TS0000/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TS00WG/TS0000/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TS00WG/TS0000/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TS00WG/TS0000/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TS00WG/TS0000/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TS00WG/TS0000/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TS00WG/TS0000/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
