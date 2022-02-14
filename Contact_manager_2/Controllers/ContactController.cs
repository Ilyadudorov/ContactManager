using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> objList = _db.Contacts;
            return View(objList);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id ==0)
            {
                return NotFound();
            }
            var obj = _db.Contacts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                _db.Contacts.Add(contact);
                _db.SaveChanges();
                return View("NotifyAdd", contact);
            }
            
        }
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                _db.Contacts.Update(contact);
                _db.SaveChanges();
                return View("NotifyEdit", contact);
            }

        }

    }
}


//if (!ModelState.IsValid)
//{
//    if (string.IsNullOrEmpty(contact.First_Name))
//    {
//        ModelState.AddModelError("First_Name", "Некорректное имя");
//    }
//}
//else if (contact.First_Name.Length < 2)
//{
//    ModelState.AddModelError("First_Name", "Недопустимая длина строки");
//}
//else
//{
//    _db.Contacts.Add(contact);
//    await _db.SaveChangesAsync();
//    return View("Index");
//}
//return View(contact);