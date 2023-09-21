using IntroToMVCW23.Data;
using IntroToMVCW23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroToMVCW23.Controllers
{
    public class TodoListController : Controller
    {
        private IntroIdentityDbContext _context;

        public TodoListController(IntroIdentityDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Show all lists in the database
            return View(_context.TodoLists.ToList());
        }
        
        // parameters in the request URL are checked against the parameter list in the method
        // when Details is invoked, the value of the URL parameter "listId" is provided as the ASP.NET method argument
        public IActionResult Details(int listId)
        {
            // single instance of an object as a model
            TodoList list = _context.TodoLists.Include(l => l.Items).FirstOrDefault(l => l.Id == listId);

            if(list == null)
            {
                return Problem();
            }

            return View(list);
        }

        [HttpPost]
        public IActionResult SwitchItemStatus(int itemId)
        {
            TodoItem item = _context.TodoItem.FirstOrDefault(l => l.Id == itemId);

            if(item == null)
            {
                return Problem();
            }

            item.Completed = !item.Completed;
            _context.SaveChanges();

            return RedirectToAction("Details", new {listId = item.TodoListId});
            // change an item's status between true or false
        }

        // HTTP GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Title")] TodoList newList)
        {
            return View();
        }
    }
}
