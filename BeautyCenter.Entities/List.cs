using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeautyCenter.Entities
{
	public  class List 
	{
		
		public int Id { get; set; }
		public string  ListName { get; set; }

		[Display(Name = "Durum")]
		public bool IsActive { get; set; }
		public DateTime? CreateDate { get; set; } = DateTime.Now;
		public DateTime? CompletionDate { get; set; } = DateTime.Now;

		public int? UserId { get; set; }
		public User? User { get; set; }
	}
}
