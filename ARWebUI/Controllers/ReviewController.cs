using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARBL;
using ARModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRWebUI.Models;

namespace ARWebUI.Controllers
{
    public class ReviewController : Controller
    {
        private IAssociateBL _associateBL;
        private IReviewBL _reviewBL;

        public ReviewController(IAssociateBL associateBL, IReviewBL reviewBL)
        {
            _associateBL = associateBL;
            _reviewBL = reviewBL;
        }
        // GET: ReviewController
        public ActionResult Index(int id)
        {

            ViewBag.Associate = _associateBL.GetAssociateById(id);
            Tuple<List<Review>, int> result = _reviewBL.GetReviews(_associateBL.GetAssociateById(id));
            if (result.Item1.Count > 0)
            {
                ViewData.Add("OverallRating", result.Item2);
            }
            else
            {
                ViewData.Add("OverallRating", "No reviews yet");
            }
            return View(result.Item1.Select(review => new ReviewVM(review)).ToList());
            
        }

        // GET: ReviewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReviewController/Create
        public ActionResult Create(int id)
        {
            return View(new ReviewVM(id));
        }

        // POST: ReviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewVM review)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _reviewBL.AddReview(_associateBL.GetAssociateById(review.AssociateId), new Review { Rating = review.Rating, Description = review.Description });
                    
                    return RedirectToAction(nameof(Index), new { id = review.AssociateId });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ReviewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReviewController/Edit/5
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

        // GET: ReviewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReviewController/Delete/5
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
