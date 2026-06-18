using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerce.Data;

public class ProductsController : Controller
{
    private readonly ApplicationDbContext _db;
    public ProductsController(ApplicationDbContext db) => _db = db;

    public async Task<IActionResult> Index(string? search, string? brand, decimal? minPrice, decimal? maxPrice, int page = 1)
    {
        var query = _db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
            query = query.Where(p => p.Name.Contains(search) || p.Description.Contains(search));

        if (!string.IsNullOrWhiteSpace(brand))
            query = query.Where(p => p.Name.Contains(brand));

        if (minPrice.HasValue)
            query = query.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            query = query.Where(p => p.Price <= maxPrice.Value);

        // Distinct brands for dropdown
        var allNames = await _db.Products.Select(p => p.Name).ToListAsync();
        var brands = allNames.Select(n => n.Split(' ')[0]).Distinct().OrderBy(b => b).ToList();

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

    public async Task<IActionResult> Details(int id)
    {
        var p = await _db.Products.FindAsync(id);
        if (p == null) return NotFound();
        return View(p);
    }
}
