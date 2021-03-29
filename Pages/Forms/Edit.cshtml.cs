using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstProject.Models;

namespace MyFirstProject.Pages.Forms
{
    public class EditModel : PageModel
    {
        public EditModel(RegistrationDBContext registrationDBContext)
        {
            _registrationDBContext = registrationDBContext;
        }

        private readonly RegistrationDBContext _registrationDBContext;

        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet(int id)
        {
            Person = _registrationDBContext.Persons.
                FirstOrDefault(Persons => Persons.PersonId ==id);
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //// first approch is to use generic variable
            ////get the person to edit
            //var pers = _registrationDBContext.Persons.FirstOrDefault(Persons => Persons.PersonId== Person.PersonId);


            // second approch
            PersonModel pers = new PersonModel();
            pers = _registrationDBContext.Persons.FirstOrDefault(Persons => Persons.PersonId == Person.PersonId);



            if (pers != null)
            {
                //update each field
                pers.Name = Person.Name;
                pers.Lastname = Person.Lastname;
                pers.Email = Person.Email;
                pers.Age = Person.Age;
                pers.Contactnumber = Person.Contactnumber;
                pers.Password = Person.Password;
                pers.Confirmpassword = Person.Confirmpassword;

                //update the person
                _registrationDBContext.Update(pers);

                //save changes
                _registrationDBContext.SaveChanges();
            }
                return Redirect("Registration");
            
            
        }
    }

}
