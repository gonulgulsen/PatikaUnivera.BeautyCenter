using BeautyCenter.Data.Abstract;
using BeautyCenter.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Data.Concrete
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(DatabaseContext _context) : base(_context)
		{
		}
		public async Task<IEnumerable<Product>> GetAllProductsByCategoriesBrandsAsync()
	{
		return await context.Products.Include(c => c.Category).Include(b => b.Brand).AsNoTracking().ToListAsync();
	}

	public async Task<Product> GetProductByCategoriesBrandsAsync(int id)
	{
		return await context.Products.Include(c => c.Category).Include(b => b.Brand).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
	}
}
}
