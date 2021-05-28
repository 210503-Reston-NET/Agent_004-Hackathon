using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ARBL;
using ARWebUI.Models;
using ARModels;

namespace ARWebUI.Controllers
{
    public class AssociateController : Controller
    {
        // GET: AssociateController


        private IAssociateBL _associateBL;

        public AssociateController(IAssociateBL associateBL)
        {
            _associateBL = associateBL;
        }
        public ActionResult Index()
        {
            return View(_associateBL.GetAllAssociates().Select(assoc => new AssociateVM(assoc)).ToList());
        }

        // GET: AssociateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssociateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssociateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssociateVM associateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _associateBL.AddAssociate(new Associate
                    {
                        Id = associateVM.Id,
                        Name = associateVM.name,
                        City = associateVM.City,
                        State = associateVM.State,
                        RevaturePoints = associateVM.RevaPoints
                    }
                    );
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: AssociateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(new AssociateVM(_associateBL.GetAssociateById(id)));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AssociateVM associateVM)
        {
            try
            {
                _associateBL.UpdateAssociate(new Associate(associateVM.Id, associateVM.name, associateVM.City, associateVM.State, associateVM.RevaPoints));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        //public ActionResult Edits(int id)
        //{
          //  return View(new AssociateVM(_associateBL.GetAssociateById(id)));
        //}
        // POST: AssociateController/Edit/5
        
        public ActionResult Edits(int id, AssociateVM associateVM)
        {
            try
            {
                _associateBL.UpdateAssociate(new Associate(associateVM.Id, associateVM.name, associateVM.City, associateVM.State, associateVM.RevaPoints));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: AssociateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssociateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AssociateVM associateVM)
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
