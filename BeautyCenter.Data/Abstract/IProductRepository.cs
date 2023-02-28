using BeautyCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Data.Abstract
{
	public interface IProductRepository : IRepository<Product>
	{
		Task<IEnumerable<Product>> GetAllProductsByCategoriesBrandsAsync();
		Task<Product> GetProductByCategoriesBrandsAsync(int id);
	}
}
