using BeautyCenter.Data.Concrete;
using BeautyCenter.Data;
using BeautyCenter.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Service.Concrete
{
	public class ProductService : ProductRepository, IProductService
	{
		public ProductService(DatabaseContext _context) : base(_context)
		{
		}
	}
}
