using LABS_CORE.Models.Person;
using Microsoft.AspNetCore.Mvc;

namespace LABS_CORE.Controllers;

public class PersonController : Controller
{
    
    
    public IActionResult Index()
    {
        
        var model = new PersonViewModel()
        {
            Persons = new PersonModel().GetPersons()
        };
        
        return View(model);
    }
}