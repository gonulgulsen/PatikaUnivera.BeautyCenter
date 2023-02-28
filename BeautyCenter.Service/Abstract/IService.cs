using BeautyCenter.Data.Abstract;
using BeautyCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Service.Abstract
{
	public interface IService<T> : IRepository<T> where T : class
	{

	}
}
