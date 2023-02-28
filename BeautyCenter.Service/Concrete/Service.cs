using BeautyCenter.Data.Concrete;
using BeautyCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BeautyCenter.Service.Abstract;
using BeautyCenter.Entities;

namespace BeautyCenter.Service.Concrete
{
	public class Service<T> : Repository<T>, IService<T> where T : class
	{
		public Service(DatabaseContext _context) : base(_context)
		{

		}
	}
}
