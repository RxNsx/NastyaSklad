using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NastyaSklad
{
	public partial class Main : Form
	{
		//Cписок товаров
		List<Produit> ProduitsBase = new List<Produit>();

		public Main()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DisplayProduits();
		}

		private void DisplayProduits()
		{
			var bindingList = new BindingList<Produit>(ProduitsBase);
			BindingSource source = new BindingSource(bindingList, null);

			dgv_ProduitsList.DataSource = source;

			dgv_ProduitsList.Columns["ProduitName"].HeaderText = "Имя товара";
			dgv_ProduitsList.Columns["ProduitArtikul"].HeaderText = "Артикул";
			dgv_ProduitsList.Columns["ProduitValue"].HeaderText = "Кол-во товара";
			dgv_ProduitsList.Columns["ProduitSeller"].HeaderText = "Поставщик";
			dgv_ProduitsList.Columns["ProduitSpecs"].HeaderText = "Характеристики товара";
			dgv_ProduitsList.Columns["DateProduitIncome"].HeaderText = "Дата погрузки";
			dgv_ProduitsList.Columns["DateProduitOutcome"].HeaderText = "Дата отгрузки";
			dgv_ProduitsList.Columns["NumberOfRack"].HeaderText = "Номер стеллажа";
			dgv_ProduitsList.Columns["NumberOfShelf"].HeaderText = "Номер полки";

		}

		int KeyId = 0;

		//Ключ для создания первого пользователя в таблице dgv_ProduitsList
		int ProduitId = 1;

		/// <summary>
		/// Загружаем файл в таблицу
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadFromFileToDgv_Click(object sender, EventArgs e)
		{
			//Очищение базы товаров на складе перед новой загрузкой базы из файла
			ProduitsBase.Clear();

			var openfile = new OpenFileDialog()
			{
				InitialDirectory = "c:\\",
				Filter = @"Текстовые файлы(*.txt)|*.txt",
				FilterIndex = 1,
				RestoreDirectory = true
			};

			//Если открытие файла подтвердилось кнопкой ОК
			if (openfile.ShowDialog() == DialogResult.OK)
			{

				//Считывание данные файла в поток
				var filestream = openfile.OpenFile();

				using (var streamReader = new StreamReader(filestream, Encoding.UTF8, true))
				{
					string newline;

					while ((newline = streamReader.ReadLine()) != null)
					{

						string[] values = newline.Split(' ');

						ProduitsBase.Add(new Produit(int.Parse(values[0]),values[1],values[2],int.Parse(values[3]),values[4],values[5],DateTime.Parse(values[6]),DateTime.Parse(values[7]),int.Parse(values[8]),values[9]));

						try
						{
							ProduitId = int.Parse(values[0])+1;
						}
						catch (Exception Ex)
						{
							MessageBox.Show(Ex.Message);
						}

					}

				}

				filestream.Close();

				DisplayProduits();
			}
		}

		/// <summary>
		/// Выгружаем таблицу в файл
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WriteFromDgvToFile_Click(object sender, EventArgs e)
		{
			var save = new SaveFileDialog
			{
				AddExtension = true,
				InitialDirectory = "c:\\",
				DefaultExt = "txt",
				Filter = @"Текстовые файлы(*.txt)|*.txt",
				FilterIndex = 1,
				RestoreDirectory = false

			};

			if (save.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			using (var streamWriter = new StreamWriter(save.FileName, true, Encoding.UTF8))
			{
				foreach (var produit in ProduitsBase)
				{
					streamWriter.Write($"{produit.Id} ");
					streamWriter.Write($"{produit.ProduitName} ");
					streamWriter.Write($"{produit.ProduitArtikul} ");
					streamWriter.Write($"{produit.ProduitValue} ");
					streamWriter.Write($"{produit.ProduitSeller} ");
					streamWriter.Write($"{produit.ProduitSpecs} ");
					streamWriter.Write($"{produit.DateProduitIncome.ToString("dd.MM.yyyy")} ");
					streamWriter.Write($"{produit.DateProduitOutcome.ToString("dd.MM.yyyy")} ");
					streamWriter.Write($"{produit.NumberOfRack} ");
					streamWriter.WriteLine($"{produit.NumberOfShelf} ");

				}
			}
		}



		private void button_AddProduitToList_Click(object sender, EventArgs e)
		{
			if (ProduitNameTextBox.Text == "" || ArtikulTextBox.Text == "" || ProduitValueTextBox.Text == "" || ProduitSellerTextBox.Text == "" || ProduitSpecsTextBox.Text == "" 
				|| ProduitNumberOfRackTextBox.Text == "" || ProduitNumberOfShelfTextBox.Text == "")
			{
				MessageBox.Show("Поля заполнены некорректно!");
			}
			else
			{
				try
				{

					//Добавление тового экземпляра товара в список
					ProduitsBase.Add(new Produit(ProduitId++, ProduitNameTextBox.Text, ArtikulTextBox.Text, int.Parse(ProduitValueTextBox.Text),
						ProduitSellerTextBox.Text, ProduitSpecsTextBox.Text, ProduitIncomeDOB.Value.Date, ProduitOutcomeDOB.Value.Date, int.Parse(ProduitNumberOfRackTextBox.Text), ProduitNumberOfShelfTextBox.Text));




				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}

				DisplayProduits();

				//TODO: Сброс полей
				//Reset();
			}
		}

		/// <summary>
		/// Выбор конкретного товара в таблице
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgv_ProduitsList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Определяем текущую строку выделенную пользователем
			int rowIndex = dgv_ProduitsList.CurrentCell.RowIndex;


			#region  Присваиваем значения в поля текущего товара

			CurrentProduitNameTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[1].Value.ToString();
			CurrentProduitArtikulTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[2].Value.ToString();
			CurrentProduitValueTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[3].Value.ToString();
			CurrentProduitSellerTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[4].Value.ToString();
			CurrentProduitSpecsTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[5].Value.ToString();
			CurrentProduitDOBIncome.Value = DateTime.Parse(dgv_ProduitsList.Rows[rowIndex].Cells[6].Value.ToString());
			CurrentProduitDOBOutcome.Value = DateTime.Parse(dgv_ProduitsList.Rows[rowIndex].Cells[7].Value.ToString());
			CurrentProduitNumberOfRackTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[8].Value.ToString();
			CurrentProduitNumberOfShelfTextBox.Text = dgv_ProduitsList.Rows[rowIndex].Cells[9].Value.ToString();

			#endregion

			if(CurrentProduitArtikulTextBox.Text == "")
			{
				KeyId = 0;
			}
			else
			{
				//Берём айдишник этого товара
				KeyId = int.Parse(dgv_ProduitsList.Rows[rowIndex].Cells[0].Value.ToString());
			}

		}

		private void button_EditProduit_Click(object sender, EventArgs e)
		{
			if (CurrentProduitNameTextBox.Text == "" || CurrentProduitArtikulTextBox.Text == "" || CurrentProduitValueTextBox.Text == "" || CurrentProduitSellerTextBox.Text == "" || CurrentProduitSpecsTextBox.Text == ""
				|| CurrentProduitNumberOfRackTextBox.Text == "" || CurrentProduitNumberOfShelfTextBox.Text == "")
			{
				MessageBox.Show("Поля заполнены некорректно!");
			}
			else
			{
				try
				{
					//Находим нужный товар  по ключу
					var produit = ProduitsBase.Find(x => x.Id == KeyId);

					produit.ProduitName = CurrentProduitNameTextBox.Text;
					produit.ProduitArtikul = CurrentProduitArtikulTextBox.Text;
					produit.ProduitValue = int.Parse(CurrentProduitValueTextBox.Text);
					produit.ProduitSeller = CurrentProduitSellerTextBox.Text;
					produit.DateProduitIncome = CurrentProduitDOBIncome.Value;
					produit.DateProduitOutcome = CurrentProduitDOBOutcome.Value;
					produit.ProduitSpecs = CurrentProduitSpecsTextBox.Text;
					produit.NumberOfRack = int.Parse(CurrentProduitNumberOfRackTextBox.Text);
					produit.NumberOfShelf = CurrentProduitNumberOfShelfTextBox.Text;

				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				DisplayProduits();
				//TODO: Сброс позиций скрытие полей
			}
		}

		private void button_DeleteProduitFromList_Click(object sender, EventArgs e)
		{
			if (KeyId == 0)
			{
				MessageBox.Show("Выберите товар для удаления");
			}
			else
			{
				try
				{
					//Поиск найденного студента
					Produit id = ProduitsBase.Find(x => x.Id == KeyId);

					ProduitsBase.Remove(id);

				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}

			DisplayProduits();
		}
	}
}
