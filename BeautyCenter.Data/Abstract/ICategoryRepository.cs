using BeautyCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Data.Abstract
{
	public interface ICategoryRepository : IRepository<Category>
	{
		Task<Category> GetCategoryByProducts(int id);
	}
}
