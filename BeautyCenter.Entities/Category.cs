using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyCenter.Entities
{
	public class Category
	{
		public int Id { get; set; }


		[Required(ErrorMessage ="{0} alanı boş geçilemez!"), StringLength(50), Display(Name = "Kategori Adı")]
		public string Name { get; set; }

		[StringLength(150), Display(Name = "Kategori Resmi")]
		public string? Image { get; set; }

		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime? CreateDate { get; set; } = DateTime.Now;

		public DateTime? CompletionDate { get; set; } = DateTime.Now;
		public bool IsActive { get; set; }
		public bool IsTopMenu { get; set; }
		public int ParentId { get; set; }
		public virtual ICollection<Product>? Products { get; set; }

	}
}
