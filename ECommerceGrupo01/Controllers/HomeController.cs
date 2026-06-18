using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _db;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public async Task<IActionResult> Index(string payment, string? search, string? brand, decimal? minPrice, decimal? maxPrice, int page = 1)
    {
        if (payment == "success")
        {
            ViewBag.Message = "Pago realizado con exito.";
        }
        else if (payment == "cancel")
        {
            ViewBag.Message = "El pago fue cancelado.";
        }

        // Build product query
        var query = _db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
            query = query.Where(p => p.Name.Contains(search) || p.Description.Contains(search));

        if (!string.IsNullOrWhiteSpace(brand))
            query = query.Where(p => p.Name.Contains(brand));

        if (minPrice.HasValue)
            query = query.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            query = query.Where(p => p.Price <= maxPrice.Value);

        // Get distinct brand names for filter dropdown
        var allNames = await _db.Products
            .Select(p => p.Name)
            .ToListAsync();
        var brands = allNames
            .Select(n => n.Split(' ')[0])
            .Distinct()
            .OrderBy(b => b)
            .ToList();

        ViewBag.Brands = brands;
        ViewBag.CurrentSearch = search;
        ViewBag.CurrentBrand = brand;
        ViewBag.CurrentMinPrice = minPrice;
        ViewBag.CurrentMaxPrice = maxPrice;

        // Pagination
        int pageSize = 8;
        int totalItems = await query.CountAsync();
        int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        page = Math.Clamp(page, 1, Math.Max(totalPages, 1));

        var products = await query
            .OrderBy(p => p.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;

        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
