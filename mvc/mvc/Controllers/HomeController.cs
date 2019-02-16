// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Mvc.Controllers
{
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
        /// <returns>"Success", if post methon ends successfully.</returns>
        [HttpPost]
        public string Index(FormData formData)
        {
            return "Success";
        }
    }
}