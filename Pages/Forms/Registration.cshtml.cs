using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstProject.Models;

namespace MyFirstProject.Pages.Forms
{
    public class RegistrationModel : PageModel
    {
        public RegistrationModel(RegistrationDBContext registercontext)
        {
            _registrationdbcontext = registercontext;
        }
        // create property for DBContext instance
        private readonly RegistrationDBContext _registrationdbcontext;

        [BindProperty]
        public PersonModel Person { get; set; }

        public List<PersonModel> Persons = new List<PersonModel>();

        //GET handlers
        public void OnGet()
        {
            Persons = _registrationdbcontext.Persons.ToList();
        }

        //POST handler

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Persons = _registrationdbcontext.Persons.ToList();
                return Page();
            }
            _registrationdbcontext.Persons.Add(Person);
            _registrationdbcontext.SaveChanges();
            return Redirect("/Forms/Registration");
        }

        public void OnGetDelete(int id)
        {
            //query the person to delete
            var pers = _registrationdbcontext.Persons
                .FirstOrDefault(p => p.PersonId == id);

            //null check
            if(pers != null)
            {
                _registrationdbcontext.Persons.Remove(pers);
                _registrationdbcontext.SaveChanges();
            }

            // refresh the page
            OnGet();
        }

    
        }
    }

