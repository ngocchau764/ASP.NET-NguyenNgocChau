using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenThingocChau_2122110055.Model;

[HttpPost("create-sample-products")]
public async Task<ActionResult<IEnumerable<Product>>> CreateSampleProducts()
{
    var categories = await _context.Categories.ToListAsync();

    var products = new List<Product>
    {
        new Product
        {
            Product_name = "Laptop",
            Category_id = categories.First(c => c.Category_name == "Electronics").Category_id,
            Price = 1000,
            Stock = 50,
            Create_at = DateTime.Now,
            Create_by = "admin"
        },
        new Product
        {
            Product_name = "T-shirt",
            Category_id = categories.First(c => c.Category_name == "Clothing").Category_id,
            Price = 20,
            Stock = 100,
            Create_at = DateTime.Now,
            Create_by = "admin"
        },
        new Product
        {
            Product_name = "Washing Machine",
            Category_id = categories.First(c => c.Category_name == "Home Appliances").Category_id,
            Price = 300,
            Stock = 30,
            Create_at = DateTime.Now,
            Create_by = "admin"
        },
        new Product
        {
            Product_name = "Novel Book",
            Category_id = categories.First(c => c.Category_name == "Books").Category_id,
            Price = 10,
            Stock = 200,
            Create_at = DateTime.Now,
            Create_by = "admin"
        },
        new Product
        {
            Product_name = "Football",
            Category_id = categories.First(c => c.Category_name == "Sports Equipment").Category_id,
            Price = 15,
            Stock = 150,
            Create_at = DateTime.Now,
            Create_by = "admin"
        }
    };

    // Thêm sản phẩm vào cơ sở dữ liệu
    _context.Products.AddRange(products);
    await _context.SaveChangesAsync();

    return Ok(new { message = "Sample products created successfully", products });
}
