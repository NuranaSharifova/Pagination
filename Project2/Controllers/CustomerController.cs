using Microsoft.AspNetCore.Mvc;
using Project2.Data;
using Project2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly TestContext _context;
        public CustomerController(TestContext context)
        {
            _context = context;
        }

        public IActionResult Index(int pg=1)
        {
            const int pageSize = 10;
            if (pg < 1) pg = 1;
            int ressCount = _context.Customers.Count();
            var pager=new Pager(ressCount,pg,pageSize);
            int recSkip = (pg - 1) * pageSize;
            List<Customer> customers = _context.Customers.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(customers);
        }
        public IActionResult Details(int id)
        {
            Customer customer = _context.Customers.Where(p => p.Id == id).FirstOrDefault();

            return View(customer);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Customer customer = _context.Customers.Where(p => p.Id == id).FirstOrDefault();

            return View(customer);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer customer = _context.Customers.Where(p => p.Id == id).FirstOrDefault();

            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            _context.Attach(customer);
            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            _context.Attach(customer);
            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
