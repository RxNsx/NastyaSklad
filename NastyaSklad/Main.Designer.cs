
namespace NastyaSklad
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv_ProduitsList = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.LoadFromFileToDgv = new System.Windows.Forms.Button();
			this.WriteFromDgvToFile = new System.Windows.Forms.Button();
			this.ProduitNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ArtikulTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ProduitValueTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProduitSellerTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ProduitSpecsTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button_AddProduitToList = new System.Windows.Forms.Button();
			this.button_DeleteProduitFromList = new System.Windows.Forms.Button();
			this.ProduitIncomeDOB = new System.Windows.Forms.DateTimePicker();
			this.ProduitOutcomeDOB = new System.Windows.Forms.DateTimePicker();
			this.ProduitNumberOfRackTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ProduitNumberOfShelfTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button_EditProduit = new System.Windows.Forms.Button();
			this.CurrentProduitNameTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.CurrentProduitArtikulTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.CurrentProduitValueTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.CurrentProduitSellerTextBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.CurrentProduitSpecsTextBox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.CurrentProduitNumberOfRackTextBox = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.CurrentProduitNumberOfShelfTextBox = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.CurrentProduitDOBIncome = new System.Windows.Forms.DateTimePicker();
			this.CurrentProduitDOBOutcome = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ProduitsList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_ProduitsList
			// 
			this.dgv_ProduitsList.AllowUserToAddRows = false;
			this.dgv_ProduitsList.AllowUserToDeleteRows = false;
			this.dgv_ProduitsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_ProduitsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ProduitsList.Location = new System.Drawing.Point(12, 100);
			this.dgv_ProduitsList.Name = "dgv_ProduitsList";
			this.dgv_ProduitsList.ReadOnly = true;
			this.dgv_ProduitsList.RowTemplate.Height = 25;
			this.dgv_ProduitsList.Size = new System.Drawing.Size(979, 412);
			this.dgv_ProduitsList.TabIndex = 0;
			this.dgv_ProduitsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProduitsList_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(521, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Система Склад";
			// 
			// LoadFromFileToDgv
			// 
			this.LoadFromFileToDgv.Location = new System.Drawing.Point(12, 52);
			this.LoadFromFileToDgv.Name = "LoadFromFileToDgv";
			this.LoadFromFileToDgv.Size = new System.Drawing.Size(204, 42);
			this.LoadFromFileToDgv.TabIndex = 2;
			this.LoadFromFileToDgv.Text = "Загрузить товары из файла";
			this.LoadFromFileToDgv.UseVisualStyleBackColor = true;
			this.LoadFromFileToDgv.Click += new System.EventHandler(this.LoadFromFileToDgv_Click);
			// 
			// WriteFromDgvToFile
			// 
			this.WriteFromDgvToFile.Location = new System.Drawing.Point(222, 52);
			this.WriteFromDgvToFile.Name = "WriteFromDgvToFile";
			this.WriteFromDgvToFile.Size = new System.Drawing.Size(204, 42);
			this.WriteFromDgvToFile.TabIndex = 2;
			this.WriteFromDgvToFile.Text = "Сохранить товары в файл";
			this.WriteFromDgvToFile.UseVisualStyleBackColor = true;
			this.WriteFromDgvToFile.Click += new System.EventHandler(this.WriteFromDgvToFile_Click);
			// 
			// ProduitNameTextBox
			// 
			this.ProduitNameTextBox.Location = new System.Drawing.Point(1019, 115);
			this.ProduitNameTextBox.Name = "ProduitNameTextBox";
			this.ProduitNameTextBox.Size = new System.Drawing.Size(225, 23);
			this.ProduitNameTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1081, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Название товара";
			// 
			// ArtikulTextBox
			// 
			this.ArtikulTextBox.Location = new System.Drawing.Point(1019, 159);
			this.ArtikulTextBox.Name = "ArtikulTextBox";
			this.ArtikulTextBox.Size = new System.Drawing.Size(225, 23);
			this.ArtikulTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1106, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Артикул";
			// 
			// ProduitValueTextBox
			// 
			this.ProduitValueTextBox.Location = new System.Drawing.Point(1019, 203);
			this.ProduitValueTextBox.Name = "ProduitValueTextBox";
			this.ProduitValueTextBox.Size = new System.Drawing.Size(225, 23);
			this.ProduitValueTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1097, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Количество";
			// 
			// ProduitSellerTextBox
			// 
			this.ProduitSellerTextBox.Location = new System.Drawing.Point(1019, 247);
			this.ProduitSellerTextBox.Name = "ProduitSellerTextBox";
			this.ProduitSellerTextBox.Size = new System.Drawing.Size(225, 23);
			this.ProduitSellerTextBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1097, 229);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Поставщик";
			// 
			// ProduitSpecsTextBox
			// 
			this.ProduitSpecsTextBox.Location = new System.Drawing.Point(1019, 291);
			this.ProduitSpecsTextBox.Multiline = true;
			this.ProduitSpecsTextBox.Name = "ProduitSpecsTextBox";
			this.ProduitSpecsTextBox.Size = new System.Drawing.Size(225, 135);
			this.ProduitSpecsTextBox.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1064, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 15);
			this.label6.TabIndex = 4;
			this.label6.Text = "Характеристики товара";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1098, 429);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 15);
			this.label7.TabIndex = 4;
			this.label7.Text = "Дата заказа";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(1097, 473);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 15);
			this.label8.TabIndex = 4;
			this.label8.Text = "Дата отгрузки";
			// 
			// button_AddProduitToList
			// 
			this.button_AddProduitToList.Location = new System.Drawing.Point(1019, 613);
			this.button_AddProduitToList.Name = "button_AddProduitToList";
			this.button_AddProduitToList.Size = new System.Drawing.Size(224, 45);
			this.button_AddProduitToList.TabIndex = 5;
			this.button_AddProduitToList.Text = "Добавить товар на склад";
			this.button_AddProduitToList.UseVisualStyleBackColor = true;
			this.button_AddProduitToList.Click += new System.EventHandler(this.button_AddProduitToList_Click);
			// 
			// button_DeleteProduitFromList
			// 
			this.button_DeleteProduitFromList.Location = new System.Drawing.Point(591, 683);
			this.button_DeleteProduitFromList.Name = "button_DeleteProduitFromList";
			this.button_DeleteProduitFromList.Size = new System.Drawing.Size(224, 45);
			this.button_DeleteProduitFromList.TabIndex = 5;
			this.button_DeleteProduitFromList.Text = "Убрать товар со склада";
			this.button_DeleteProduitFromList.UseVisualStyleBackColor = true;
			this.button_DeleteProduitFromList.Click += new System.EventHandler(this.button_DeleteProduitFromList_Click);
			// 
			// ProduitIncomeDOB
			// 
			this.ProduitIncomeDOB.Location = new System.Drawing.Point(1019, 447);
			this.ProduitIncomeDOB.Name = "ProduitIncomeDOB";
			this.ProduitIncomeDOB.Size = new System.Drawing.Size(224, 23);
			this.ProduitIncomeDOB.TabIndex = 6;
			// 
			// ProduitOutcomeDOB
			// 
			this.ProduitOutcomeDOB.Location = new System.Drawing.Point(1019, 491);
			this.ProduitOutcomeDOB.Name = "ProduitOutcomeDOB";
			this.ProduitOutcomeDOB.Size = new System.Drawing.Size(224, 23);
			this.ProduitOutcomeDOB.TabIndex = 6;
			// 
			// ProduitNumberOfRackTextBox
			// 
			this.ProduitNumberOfRackTextBox.Location = new System.Drawing.Point(1019, 533);
			this.ProduitNumberOfRackTextBox.Name = "ProduitNumberOfRackTextBox";
			this.ProduitNumberOfRackTextBox.Size = new System.Drawing.Size(225, 23);
			this.ProduitNumberOfRackTextBox.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(1083, 515);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 15);
			this.label9.TabIndex = 4;
			this.label9.Text = "Номер стеллажа";
			// 
			// ProduitNumberOfShelfTextBox
			// 
			this.ProduitNumberOfShelfTextBox.Location = new System.Drawing.Point(1019, 575);
			this.ProduitNumberOfShelfTextBox.Name = "ProduitNumberOfShelfTextBox";
			this.ProduitNumberOfShelfTextBox.Size = new System.Drawing.Size(225, 23);
			this.ProduitNumberOfShelfTextBox.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1087, 557);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 15);
			this.label10.TabIndex = 4;
			this.label10.Text = "Номер полки";
			// 
			// button_EditProduit
			// 
			this.button_EditProduit.Location = new System.Drawing.Point(361, 683);
			this.button_EditProduit.Name = "button_EditProduit";
			this.button_EditProduit.Size = new System.Drawing.Size(224, 45);
			this.button_EditProduit.TabIndex = 5;
			this.button_EditProduit.Text = "Редактировать количество товара";
			this.button_EditProduit.UseVisualStyleBackColor = true;
			this.button_EditProduit.Click += new System.EventHandler(this.button_EditProduit_Click);
			// 
			// CurrentProduitNameTextBox
			// 
			this.CurrentProduitNameTextBox.Location = new System.Drawing.Point(16, 549);
			this.CurrentProduitNameTextBox.Name = "CurrentProduitNameTextBox";
			this.CurrentProduitNameTextBox.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitNameTextBox.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(36, 531);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(99, 15);
			this.label11.TabIndex = 4;
			this.label11.Text = "Название товара";
			// 
			// CurrentProduitArtikulTextBox
			// 
			this.CurrentProduitArtikulTextBox.Location = new System.Drawing.Point(189, 549);
			this.CurrentProduitArtikulTextBox.Name = "CurrentProduitArtikulTextBox";
			this.CurrentProduitArtikulTextBox.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitArtikulTextBox.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(237, 531);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 15);
			this.label12.TabIndex = 4;
			this.label12.Text = "Артикул";
			// 
			// CurrentProduitValueTextBox
			// 
			this.CurrentProduitValueTextBox.Location = new System.Drawing.Point(361, 549);
			this.CurrentProduitValueTextBox.Name = "CurrentProduitValueTextBox";
			this.CurrentProduitValueTextBox.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitValueTextBox.TabIndex = 3;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(381, 531);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 15);
			this.label13.TabIndex = 4;
			this.label13.Text = "Количество";
			// 
			// CurrentProduitSellerTextBox
			// 
			this.CurrentProduitSellerTextBox.Location = new System.Drawing.Point(521, 549);
			this.CurrentProduitSellerTextBox.Name = "CurrentProduitSellerTextBox";
			this.CurrentProduitSellerTextBox.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitSellerTextBox.TabIndex = 3;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(566, 531);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(70, 15);
			this.label14.TabIndex = 4;
			this.label14.Text = "Поставщик";
			// 
			// CurrentProduitSpecsTextBox
			// 
			this.CurrentProduitSpecsTextBox.Location = new System.Drawing.Point(696, 549);
			this.CurrentProduitSpecsTextBox.Multiline = true;
			this.CurrentProduitSpecsTextBox.Name = "CurrentProduitSpecsTextBox";
			this.CurrentProduitSpecsTextBox.Size = new System.Drawing.Size(281, 98);
			this.CurrentProduitSpecsTextBox.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(716, 531);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(135, 15);
			this.label15.TabIndex = 4;
			this.label15.Text = "Характеристики товара";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(54, 604);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(69, 15);
			this.label16.TabIndex = 4;
			this.label16.Text = "Дата заказа";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(222, 604);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(83, 15);
			this.label17.TabIndex = 4;
			this.label17.Text = "Дата отгрузки";
			// 
			// CurrentProduitNumberOfRackTextBox
			// 
			this.CurrentProduitNumberOfRackTextBox.Location = new System.Drawing.Point(361, 622);
			this.CurrentProduitNumberOfRackTextBox.Name = "CurrentProduitNumberOfRackTextBox";
			this.CurrentProduitNumberOfRackTextBox.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitNumberOfRackTextBox.TabIndex = 3;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(389, 604);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 15);
			this.label18.TabIndex = 4;
			this.label18.Text = "Номер стеллажа";
			// 
			// CurrentProduitNumberOfShelfTextBox
			// 
			this.CurrentProduitNumberOfShelfTextBox.Location = new System.Drawing.Point(521, 622);
			this.CurrentProduitNumberOfShelfTextBox.Name = "CurrentProduitNumberOfShelfTextBox";
			this.CurrentProduitNumberOfShelfTextBox.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitNumberOfShelfTextBox.TabIndex = 3;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(554, 604);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(82, 15);
			this.label19.TabIndex = 4;
			this.label19.Text = "Номер полки";
			// 
			// CurrentProduitDOBIncome
			// 
			this.CurrentProduitDOBIncome.Location = new System.Drawing.Point(16, 622);
			this.CurrentProduitDOBIncome.Name = "CurrentProduitDOBIncome";
			this.CurrentProduitDOBIncome.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitDOBIncome.TabIndex = 6;
			// 
			// CurrentProduitDOBOutcome
			// 
			this.CurrentProduitDOBOutcome.Location = new System.Drawing.Point(189, 622);
			this.CurrentProduitDOBOutcome.Name = "CurrentProduitDOBOutcome";
			this.CurrentProduitDOBOutcome.Size = new System.Drawing.Size(154, 23);
			this.CurrentProduitDOBOutcome.TabIndex = 6;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1255, 774);
			this.Controls.Add(this.ProduitOutcomeDOB);
			this.Controls.Add(this.CurrentProduitDOBOutcome);
			this.Controls.Add(this.CurrentProduitDOBIncome);
			this.Controls.Add(this.ProduitIncomeDOB);
			this.Controls.Add(this.button_EditProduit);
			this.Controls.Add(this.button_DeleteProduitFromList);
			this.Controls.Add(this.button_AddProduitToList);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ProduitSpecsTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.ProduitNumberOfShelfTextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.ProduitNumberOfRackTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ProduitSellerTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ProduitValueTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ArtikulTextBox);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CurrentProduitNumberOfShelfTextBox);
			this.Controls.Add(this.CurrentProduitNumberOfRackTextBox);
			this.Controls.Add(this.CurrentProduitSpecsTextBox);
			this.Controls.Add(this.CurrentProduitSellerTextBox);
			this.Controls.Add(this.CurrentProduitValueTextBox);
			this.Controls.Add(this.CurrentProduitArtikulTextBox);
			this.Controls.Add(this.CurrentProduitNameTextBox);
			this.Controls.Add(this.ProduitNameTextBox);
			this.Controls.Add(this.WriteFromDgvToFile);
			this.Controls.Add(this.LoadFromFileToDgv);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv_ProduitsList);
			this.Name = "Main";
			this.Text = "Система склад";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_ProduitsList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_ProduitsList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button LoadFromFileToDgv;
		private System.Windows.Forms.Button WriteFromDgvToFile;
		private System.Windows.Forms.TextBox ProduitNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ArtikulTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ProduitValueTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProduitSellerTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ProduitSpecsTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button_AddProduitToList;
		private System.Windows.Forms.Button button_DeleteProduitFromList;
		private System.Windows.Forms.DateTimePicker ProduitIncomeDOB;
		private System.Windows.Forms.DateTimePicker ProduitOutcomeDOB;
		private System.Windows.Forms.TextBox ProduitNumberOfRackTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox ProduitNumberOfShelfTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button_EditProduit;
		private System.Windows.Forms.TextBox CurrentProduitNameTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox CurrentProduitArtikulTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox CurrentProduitValueTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox CurrentProduitSellerTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox CurrentProduitSpecsTextBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox CurrentProduitNumberOfRackTextBox;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox CurrentProduitNumberOfShelfTextBox;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker CurrentProduitDOBIncome;
		private System.Windows.Forms.DateTimePicker CurrentProduitDOBOutcome;
	}
}

