using MVC.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class FootwearController : Controller
    {
        // GET: Footwear
        public ActionResult Index()
        {
            IEnumerable<mvcFootwearModel> footList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Footwear").Result;
            footList = response.Content.ReadAsAsync<IEnumerable<mvcFootwearModel>>().Result;
            return View(footList);
        }

        public ActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new mvcFootwearModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Footwear/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcFootwearModel>().Result);
            }
        }

        [HttpPost]

        public ActionResult AddorEdit(mvcFootwearModel foot)
        {
            if (foot.FootwearID == 0) { 
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Footwear", foot).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
        }
        else
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Footwear/" + foot.FootwearID, foot).Result;
            TempData["SuccessMessage"] = "Updated Successfully";
        }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Footwear/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}