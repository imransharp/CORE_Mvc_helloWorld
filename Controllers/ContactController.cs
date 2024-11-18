using helloWorldMvcCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace helloWorldMvcCore.Controllers
{
    public class ContactController : Controller
    {
        private static List<Contact> contacts = new List<Contact>();
        public IActionResult Index()
        {
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            contact.Id = contacts.Count + 1;
            contacts.Add(contact);
            return RedirectToAction("Index");
        }


        // Delete Action Method
        public IActionResult Delete(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
            return RedirectToAction("Index");
        }
    }
}
