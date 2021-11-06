using System;
using System.Collections.Generic;
using System.Text;

namespace NastyaSklad
{
	public class Produit
	{
		
		public int Id { get; set; }
		public string ProduitName { get; set; }
		public string ProduitArtikul { get; set; }
		public int ProduitValue { get; set; }
		public string ProduitSeller { get; set; }
		public string ProduitSpecs { get; set; }
		public DateTime DateProduitIncome { get; set; }
		public DateTime DateProduitOutcome { get; set; }

		//Номер стеллажа
		public int NumberOfRack { get; set; }
		//Название полки
		public string NumberOfShelf { get; set; }

		public Produit(int id,string produitName,string produitArtikul,int produitValue,string produitSeller,string produitSpecs,DateTime dateProduitIncome,DateTime dateProduitOutcome,int numberOfRack,string numberOfShelf)
		{
			//TODO: Доработать обработку исключений при введение товара

			if(string.IsNullOrEmpty(produitName))
			{
				throw new ArgumentNullException("Заполните имя товара!", (produitName));
			}
			if (string.IsNullOrEmpty(produitArtikul))
			{
				throw new ArgumentNullException("У товара должен быть артикул!", (produitArtikul));
			}
			if (string.IsNullOrEmpty(produitValue.ToString()) || produitValue < 0)
			{
				throw new Exception("Недопустимое количество товара на складе");
			}
			if(string.IsNullOrEmpty(produitSeller))
			{
				throw new ArgumentNullException("Не указан поставщик товара");
			}
			if (string.IsNullOrEmpty(produitSpecs))
			{
				throw new ArgumentNullException("Должна быть указана спецификация товара");
			}
			if(dateProduitIncome > dateProduitOutcome)
			{
				throw new Exception("Дата заказа не может быть позже даты отгрузки товара!");
			}
			if(dateProduitIncome.Year < 1900 || dateProduitOutcome.Year < 1900)
			{
				throw new Exception("Ошибка года погрузки или заказа");
			}
			if(dateProduitIncome.Month > 12 || dateProduitOutcome.Month > 12 || dateProduitIncome.Month < 1 || dateProduitOutcome.Month < 1)
			{
				throw new Exception("Ошибка числа месяца в дате погрузки или дате заказа");
			}
			if(dateProduitIncome.Day > 31 || dateProduitIncome.Day < 1 || dateProduitOutcome.Day > 31 || dateProduitOutcome.Day < 1)
			{
				throw new Exception("Ошибка числа дня в дате погрузки или дате заказа");
			}
			if(numberOfRack < 1)
			{
				throw new ArgumentException("Недопустимое значение стеллажа");
			}
			if(string.IsNullOrEmpty(numberOfShelf))
			{
				throw new ArgumentException("Недопустимое значение полки");
			}



			Id = id;
			ProduitName = produitName;
			ProduitArtikul = produitArtikul;
			ProduitValue = produitValue;
			ProduitSeller = produitSeller;
			ProduitSpecs = produitSpecs;
			DateProduitIncome = dateProduitIncome;
			DateProduitOutcome = dateProduitOutcome;
			NumberOfRack = numberOfRack;
			NumberOfShelf = numberOfShelf;

		}
	}
}
