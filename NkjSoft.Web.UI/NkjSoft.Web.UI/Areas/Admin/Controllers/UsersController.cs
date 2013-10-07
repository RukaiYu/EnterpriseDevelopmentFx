﻿using NkjSoft.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NkjSoft.Web.UI.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Admin/Users/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetUsers(int? page, int? rows, IEnumerable<QueryParameter> queryParams, IEnumerable<string> ids)
        {
            var testData = new List<NkjSoft.Model.Common.Menu>();
            testData.Add(new Model.Common.Menu() { Action = "test", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test2", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test3", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test4", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test5", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test6", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test7", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test8", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test9", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test10", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test11", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test12", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test13", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test14", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test15", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test16", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test17", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test18", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test19", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test20", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test21", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test22", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test23", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test24", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });
            testData.Add(new Model.Common.Menu() { Action = "test25", Controller = "Home", Id = Guid.NewGuid(), Text = "Add", });

            var result = testData.Skip((page.GetValueOrDefault() - 1) * rows.GetValueOrDefault())
                .Take(rows.GetValueOrDefault())
                .ToList();

            return Json(new PageList<NkjSoft.Model.Common.Menu>(25, result), JsonRequestBehavior.AllowGet);
        }
    }
}
