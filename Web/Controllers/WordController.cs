using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LetsLearnCzech.Web.CzechService;
using LetsLearnCzech.Web.Models;
using LetsLearnCzech.Web.Business;

namespace LetsLearnCzech.Web.Controllers
{
    public class WordController : Controller
    {
        private readonly CzechServiceClient db;

        public WordController()
        {
            db = new CzechServiceClient();
        }

        // GET: /Word/
        public ActionResult Index()
        {
            return View(db.GetAllWords().Select(w => ViewModelFactory.GetViewModel(w)).ToList());
        }

        // GET: /Word/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Word word = db.GetSingleWord(id);
            if (word == null)
            {
                return HttpNotFound();
            }

            return View("Details" + word.WordType.ToString(), ViewModelFactory.GetViewModel(word));
        }

        // GET: /Word/Create
        public ActionResult Create(WordType wordType)
        {
            return View("Create" + wordType.ToString(), ViewModelFactory.GetEmptyViewModel(wordType));
 
        }

        // POST: /Word/CreateNoun
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNoun([Bind(Include = "Id,ForeignWord,LocalWord,IsProcessed,Case,ForeignGender,LocalGender")] NounModel noun)
        {
            if (ModelState.IsValid)
            {
                Word word = ViewModelFactory.CreateWordFromNoun(noun);
                db.CreateWord(word);
                return RedirectToAction("Index");
            }

            return View("CreateNoun", noun);
        }

        // POST: /Word/CreateVerb
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateVerb([Bind(Include = "Id,ForeignWord,LocalWord,IsProcessed,Aspect,Conjugation,Person")] VerbModel verb)
        {
            if (ModelState.IsValid)
            {
                Word word = ViewModelFactory.CreateWordFromVerb(verb);
                db.CreateWord(word);
                return RedirectToAction("Index");
            }

            return View("CreateVerb", verb);
        }

        // GET: /Word/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Word word = db.GetSingleWord(id);
            if (word == null)
            {
                return HttpNotFound();
            }
            return View("Edit" + word.WordType.ToString(), ViewModelFactory.GetViewModel(word));;
        }

        // POST: /Word/EditNoun
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditNoun([Bind(Include = "Id,ForeignWord,LocalWord,IsProcessed,Case,ForeignGender,LocalGender")] NounModel noun)
        {
            if (ModelState.IsValid)
            {
                Word word = ViewModelFactory.CreateWordFromNoun(noun);
                db.UpdateWord(word);
                return RedirectToAction("Index");
            }
            return View(noun);
        }

        // POST: /Word/EditVerb
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVerb([Bind(Include = "Id,ForeignWord,LocalWord,IsProcessed,Aspect,Conjugation,Person")] VerbModel verb)
        {
            if (ModelState.IsValid)
            {
                Word word = ViewModelFactory.CreateWordFromVerb(verb);
                db.UpdateWord(word);
                return RedirectToAction("Index");
            }

            return View(verb);
        }


        // GET: /Word/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Word word = db.GetSingleWord(id);
            if (word == null)
            {
                return HttpNotFound();
            }
            return View(ViewModelFactory.GetViewModel(word));
        }

        // POST: /Word/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.DeleteWord(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
