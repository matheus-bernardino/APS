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
					//new Book { Title = "A Game of Thrones", Author = "George RR Martin", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\ASOIAF\\a-game-of-thrones.jpg" },
					//new Book { Title = "A Clash of Kings", Author = "George RR Martin", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\ASOIAF\\a-clash-of-kings.jpg" },
					//new Book { Title = "A Storm of Swords", Author = "George RR Martin", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\ASOIAF\\a-storm-of-swords.jpg" },
					//new Book { Title = "A Feast for Crows", Author = "George RR Martin", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\ASOIAF\\a-feast-for-crows.jpg" },
     //               new Book { Title = "A Dance with Dragons", Author = "George RR Martin", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\ASOIAF\\a-dance-with-dragons.jpg" },
     //               new Book { Title = "The Winds of Winter", Author = "George RR Martin", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\ASOIAF\\the-winds-of-winter.jpg" },
     //               new Book { Title = "The Fellowship of the Ring", Author = "JRR Tolkien", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\LOTR\\the-fellowship.jpg" },
     //               new Book { Title = "The Two Towers", Author = "JRR Tolkien", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\LOTR\\the-two-towers.jpg" },
     //               new Book { Title = "The Return of the King", Author = "JRR Tolkien", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\LOTR\\the-return.jpg" },
     //               new Book { Title = "The Hobbit", Author = "JRR Tolkien", PublishingCompany = " HarperCollins", Category = "Epic Fantasy", Value = 40, Quantity = 1, Images = "\\images\\LOTR\\the-hobbit.jpg" },
     //               new Book { Title = "1984", Author = "George Orwell", PublishingCompany = "Secker & Warburg", Category = "Dystopian", Value = 40, Quantity = 1, Images = "\\images\\1984\\1984.jpg" },
					//new Book { Title = "Brave New World", Author = "Aldous Huxley", PublishingCompany = "Chatto & Windus", Category = "Dystopian", Value = 40, Quantity = 1, Images = "\\images\\BNW\\brave-new-world.jpg" },
					//new Book { Title = "Como Eu Era Antes de Você", Author = "Jojo Moyes", PublishingCompany = "Intrinseca", Category = "Drama", Value = 40, Quantity = 1, Images = "\\images\\Drama\\drama1.jpg" },
					//new Book { Title = "A Culpa É Das Estrelas", Author = "John Green",PublishingCompany = "Intrinseca", Category = "Drama", Value = 40, Quantity = 1, Images = "\\images\\Drama\\drama2.jpg" },
					//new Book { Title = "As Vantagens de Ser Invisível", Author = "Stephen Chbosky", PublishingCompany = "Rocco", Category = "Drama", Value = 40, Quantity = 1, Images = "\\images\\Drama\\drama3.png" },
					//new Book { Title = "Métrica (slammed)", Author = "Colleen Hooever", PublishingCompany = "Galera Record", Category = "Romance", Value = 40, Quantity = 1, Images = "\\images\\Romance\\romance1.jpg" },
					//new Book { Title = "A Escolha - Até Onde Devemos Ir Em Nome do Amor?", Author = "Nicholas Sparks", PublishingCompany = "Novo Conceito", Category = "Romance", Value = 40, Quantity = 1, Images = "\\images\\Romance\\romance2.png" },
					//new Book { Title = "O Projeto Rosie", Author = "Graeme Simsion", PublishingCompany = "Record", Category = "Romance", Value = 40, Quantity = 1, Images = "\\images\\Romance\\romance3.jpg" },
					//new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", PublishingCompany = "Ballantine Books", Category = "Dystopian", Value = 40, Quantity = 1, Images = "\\images\\F451\\fahrenheit.jpg"}
					//new Book { Title = "Livro14", PublishingCompany = "Editora14", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro15", PublishingCompany = "Editora15", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro16", PublishingCompany = "Editora16", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro17", PublishingCompany = "Editora17", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro18", PublishingCompany = "Editora18", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro19", PublishingCompany = "Editora19", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro20", PublishingCompany = "Editora20", Category = "Gênero2", Value = 40 },
					//new Book { Title = "Livro21", PublishingCompany = "Editora21", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro22", PublishingCompany = "Editora22", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro23", PublishingCompany = "Editora23", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro24", PublishingCompany = "Editora24", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro25", PublishingCompany = "Editora25", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro26", PublishingCompany = "Editora26", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro27", PublishingCompany = "Editora27", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro28", PublishingCompany = "Editora28", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro29", PublishingCompany = "Editora29", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro30", PublishingCompany = "Editora30", Category = "Gênero3", Value = 40 },
					//new Book { Title = "Livro31", PublishingCompany = "Editora31", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro32", PublishingCompany = "Editora32", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro33", PublishingCompany = "Editora33", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro34", PublishingCompany = "Editora34", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro35", PublishingCompany = "Editora35", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro36", PublishingCompany = "Editora36", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro37", PublishingCompany = "Editora37", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro38", PublishingCompany = "Editora38", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro39", PublishingCompany = "Editora39", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro40", PublishingCompany = "Editora40", Category = "Gênero4", Value = 40 },
					//new Book { Title = "Livro41", PublishingCompany = "Editora41", Category = "Gênero5", Value = 40 },
					//new Book { Title = "Livro42", PublishingCompany = "Editora42", Category = "Gênero5", Value = 40 },
					//new Book { Title = "Livro43", PublishingCompany = "Editora43", Category = "Gênero5", Value = 40 }
					);
				context.SaveChanges();
			}
		}
	}
}
