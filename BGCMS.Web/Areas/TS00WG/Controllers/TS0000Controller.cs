using BGMES.Model;
using Newtonsoft.Json;
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

        /// <summary>
        /// 首次加载
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index(string CODE_SOURCE = "", string CODE_CLASS = "", string CODE_NAME = "")
        {
            ViewData["ListCodeData"] = _bll.GetCodeName();
            var dict = _bll.GetAll(10, CODE_SOURCE, CODE_CLASS, CODE_NAME);
            var TTS0091 = dict["TTS0091"] as IList<TTS0091>;
            ViewData["ListCode"] = TTS0091;
            ViewData["Count"] = dict["Count"];
            return View();
        }

        /// <summary>
        /// Ajax提交分页
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Index(int index = 1,string CODE_SOURCE = "", string CODE_CLASS = "", string CODE_NAME = "")
        {
            index--;
            var ListCode = _bll.Get(10,index, CODE_SOURCE, CODE_CLASS, CODE_NAME);
            return Json(ListCode, JsonRequestBehavior.DenyGet);
        }
        
        /// <summary>
        /// 查看代码详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Detail(string CodeClass)
        {
            var list = _bll.GetTTS0092(CodeClass);
            return Json(list,JsonRequestBehavior.AllowGet);
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
