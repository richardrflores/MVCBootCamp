using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCBootCamp.Models;
using MVCBootCamp.Models.ViewModels;

namespace MVCBootCamp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var target = GetTarget();
            var feedBack = new FeedBack { Message = "Scan your lane!" };
            var viewModel = new DefaultViewModel {Target = target, FeedBack = feedBack};

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(DefaultViewModel model)
        {
            if (model.Target.Selected != null)
            {
                return RedirectToAction("Index");
            }

            model.FeedBack = new FeedBack { Message = "Missed!" };

            return View(model);
        }

        private Target GetTarget()
        {
            var targets = new List<Target>
            {
                new Target {
                    Id = 1,
                    Code = 50,
                    Description = "50m"
                },
                new Target
                {
                    Id = 2,
                    Code = 100,
                    Description = "100m"
                },
                new Target
                {
                    Id = 3,
                    Code = 150,
                    Description = "150m"
                },
                new Target
                {
                    Id = 4,
                    Code = 200,
                    Description = "200m"
                },
                new Target
                {
                    Id = 5,
                    Code = 250,
                    Description = "250m"
                },
                new Target
                {
                    Id = 6,
                    Code = 300,
                    Description = "300m"
                }
            };

            return targets.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        }
    }
}