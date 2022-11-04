using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectTest.Models;

namespace WebProjectTest.Controllers
{
    [Route("api/Contacts")]
    [ApiController]
    public class ContactsController : Controller
    {
        private List<Contacts> contacts = new List<Contacts>
        {
            new Contacts{Id = 1, FirstName = "Developer", LastName = "Code", NickName= "Smart", Place= "Lagos", DateCreated = DateTime.Now, IsDeleted = false},
            new Contacts{Id = 2, FirstName = "Channel", LastName= "People", NickName= "Today", Place= "Ikoyi"},
            new Contacts{Id = 3, FirstName = "Yahkwulu", LastName= "People", NickName= "Today", Place= "Ikoyi"},
            new Contacts{Id = 4, FirstName = "Bosun", LastName= "Lekan", NickName= "Progress", Place= "Ikoyi"},
        };

        // // GET: ContactsController
        [HttpGet]
        public IEnumerable<Contacts> Get()
        {
            return contacts;
        }

        // // GET: ContactsController/Details/5
        [HttpGet("{id}")]
        public ActionResult<Contacts> Get(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        // // GET: ContactsController/Create
        // public ActionResult Create()
        // {
        //     return View();
        // }

        // POST: ContactsController/Create    
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult<IEnumerable<Contacts>> Post(Contacts newContacts)
        {
            contacts.Add(newContacts);
            return contacts;
        }

        //    // GET: ContactsController/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: ContactsController/Edit/5
        //   // [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: ContactsController/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: ContactsController/Delete/5
        //  //  [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
        //}
    }
}