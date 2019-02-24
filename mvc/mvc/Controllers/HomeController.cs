// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Mvc.Controllers
{
    using System;
    using System.Web.Mvc;
    using Mvc.Models;

    /// <summary>
    /// HomeController.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Get method of Index.
        /// </summary>
        /// <returns>Form view.</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Post method of Index.
        /// </summary>
        /// <param name="formData">Contains info of form elements.</param>
        /// <returns> .</returns>
        [HttpPost]
        public ActionResult Index(FormData formData)
        {
            formData.FormGuid = Guid.NewGuid();
            if (this.ModelState.IsValid)
            {
                this.Session["MyForm"] = formData;
                return this.RedirectToAction("Editor", new { guid = formData.FormGuid });
            }

            return this.ViewBag.Message("oops");
        }

        /// <summary>
        /// Editing form.
        /// </summary>
        /// <param name="guid">Contains info of form id.</param>
        /// <returns> .</returns>
        public ActionResult Editor(Guid guid)
        {
            FormData formData = (FormData)this.Session["MyForm"];
            if (formData.FormGuid == guid)
            {
                return this.View(formData);
            }

            return this.ViewBag.Message("AAAAAAAAA");
        }
    }
}