using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Assignment1_COMP2139.Data;
using Assignment1_COMP2139.Models;

namespace SmartInventory.Controllers
{
    public class OrdersController : Controller
    {
        private readonly InventoryDbContext _context;

        public OrdersController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            order.OrderDate = DateTime.UtcNow;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Products");
        }
    }
}