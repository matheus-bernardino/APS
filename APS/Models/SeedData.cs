using APS.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
			context.Database.Migrate();
			if(!context.Books.Any())
			{
				context.Books.AddRange(
					new Book { Title = "Livro1", PublishingCompany = "Editora1", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro2", PublishingCompany = "Editora2", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro3", PublishingCompany = "Editora3", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro4", PublishingCompany = "Editora4", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro5", PublishingCompany = "Editora5", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro6", PublishingCompany = "Editora6", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro7", PublishingCompany = "Editora7", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro8", PublishingCompany = "Editora8", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro9", PublishingCompany = "Editora9", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro10", PublishingCompany = "Editora10", Category = "Gênero1", Value = 40 },
					new Book { Title = "Livro11", PublishingCompany = "Editora11", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro12", PublishingCompany = "Editora12", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro13", PublishingCompany = "Editora13", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro14", PublishingCompany = "Editora14", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro15", PublishingCompany = "Editora15", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro16", PublishingCompany = "Editora16", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro17", PublishingCompany = "Editora17", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro18", PublishingCompany = "Editora18", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro19", PublishingCompany = "Editora19", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro20", PublishingCompany = "Editora20", Category = "Gênero2", Value = 40 },
					new Book { Title = "Livro21", PublishingCompany = "Editora21", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro22", PublishingCompany = "Editora22", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro23", PublishingCompany = "Editora23", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro24", PublishingCompany = "Editora24", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro25", PublishingCompany = "Editora25", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro26", PublishingCompany = "Editora26", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro27", PublishingCompany = "Editora27", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro28", PublishingCompany = "Editora28", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro29", PublishingCompany = "Editora29", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro30", PublishingCompany = "Editora30", Category = "Gênero3", Value = 40 },
					new Book { Title = "Livro31", PublishingCompany = "Editora31", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro32", PublishingCompany = "Editora32", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro33", PublishingCompany = "Editora33", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro34", PublishingCompany = "Editora34", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro35", PublishingCompany = "Editora35", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro36", PublishingCompany = "Editora36", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro37", PublishingCompany = "Editora37", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro38", PublishingCompany = "Editora38", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro39", PublishingCompany = "Editora39", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro40", PublishingCompany = "Editora40", Category = "Gênero4", Value = 40 },
					new Book { Title = "Livro41", PublishingCompany = "Editora41", Category = "Gênero5", Value = 40 },
					new Book { Title = "Livro42", PublishingCompany = "Editora42", Category = "Gênero5", Value = 40 },
					new Book { Title = "Livro43", PublishingCompany = "Editora43", Category = "Gênero5", Value = 40 }
					);
				context.SaveChanges();
			}
		}
	}
}
