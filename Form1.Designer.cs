
using System;
using System.Drawing;
using System.Windows.Forms;

namespace zd2_3_Shengals_Roman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Quest2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Quest3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSellMultiple = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentSong = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClearPlaylist = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnGoToIndex = new System.Windows.Forms.Button();
            this.numericUpDownIndex = new System.Windows.Forms.NumericUpDown();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.btnSavePlaylist = new System.Windows.Forms.Button();
            this.btnLoadPlaylist = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(20, 20);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.productsListBox.Size = new System.Drawing.Size(300, 199);
            this.productsListBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quest2ToolStripMenuItem,
            this.Quest3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // Quest2ToolStripMenuItem
            // 
            this.Quest2ToolStripMenuItem.Name = "Quest2ToolStripMenuItem";
            this.Quest2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.Quest2ToolStripMenuItem.Text = "Задание 2";
            this.Quest2ToolStripMenuItem.Click += new System.EventHandler(this.Quest2ToolStripMenuItem_Click_1);
            // 
            // Quest3ToolStripMenuItem
            // 
            this.Quest3ToolStripMenuItem.Name = "Quest3ToolStripMenuItem";
            this.Quest3ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.Quest3ToolStripMenuItem.Text = "Задание 3";
            this.Quest3ToolStripMenuItem.Click += new System.EventHandler(this.Quest3ToolStripMenuItem_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(350, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(350, 80);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(150, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(350, 120);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(150, 20);
            this.QuantityTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(350, 160);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить товар";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(350, 190);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(150, 23);
            this.SellButton.TabIndex = 5;
            this.SellButton.Text = "Продать 1 шт";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цена (руб.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.profitLabel.Location = new System.Drawing.Point(20, 230);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(129, 17);
            this.profitLabel.TabIndex = 9;
            this.profitLabel.Text = "Прибыль: 0 руб.";
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnSellMultiple);
            this.panel1.Controls.Add(this.numericUpDownQuantity);
            this.panel1.Controls.Add(this.productsListBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.profitLabel);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.QuantityTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SellButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 442);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество для продажи";
            // 
            // BtnSellMultiple
            // 
            this.BtnSellMultiple.Location = new System.Drawing.Point(350, 266);
            this.BtnSellMultiple.Name = "BtnSellMultiple";
            this.BtnSellMultiple.Size = new System.Drawing.Size(150, 23);
            this.BtnSellMultiple.TabIndex = 11;
            this.BtnSellMultiple.Text = "Продать выбранные";
            this.BtnSellMultiple.UseVisualStyleBackColor = true;
            this.BtnSellMultiple.Click += new System.EventHandler(this.BtnSellMultiple_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(350, 236);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownQuantity.TabIndex = 10;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Controls.Add(this.lblCurrentSong);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnClearPlaylist);
            this.panel3.Controls.Add(this.btnRemoveSong);
            this.panel3.Controls.Add(this.btnGoToIndex);
            this.panel3.Controls.Add(this.numericUpDownIndex);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnAddSong);
            this.panel3.Controls.Add(this.txtFilename);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.txtAuthor);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.playlistListBox);
            this.panel3.Controls.Add(this.btnSavePlaylist);
            this.panel3.Controls.Add(this.btnLoadPlaylist);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 442);
            this.panel3.TabIndex = 11;
            // 
            // lblCurrentSong
            // 
            this.lblCurrentSong.AutoSize = true;
            this.lblCurrentSong.Location = new System.Drawing.Point(162, 4);
            this.lblCurrentSong.Name = "lblCurrentSong";
            this.lblCurrentSong.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentSong.TabIndex = 24;
            this.lblCurrentSong.Text = "....";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(17, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Текущая композиция:";
            // 
            // btnClearPlaylist
            // 
            this.btnClearPlaylist.Location = new System.Drawing.Point(350, 354);
            this.btnClearPlaylist.Name = "btnClearPlaylist";
            this.btnClearPlaylist.Size = new System.Drawing.Size(150, 23);
            this.btnClearPlaylist.TabIndex = 22;
            this.btnClearPlaylist.Text = "Очистить плейлист";
            this.btnClearPlaylist.UseVisualStyleBackColor = true;
            this.btnClearPlaylist.Click += new System.EventHandler(this.btnClearPlaylist_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(350, 296);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(150, 23);
            this.btnRemoveSong.TabIndex = 21;
            this.btnRemoveSong.Text = "Удалить выбранную";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnGoToIndex
            // 
            this.btnGoToIndex.Location = new System.Drawing.Point(350, 267);
            this.btnGoToIndex.Name = "btnGoToIndex";
            this.btnGoToIndex.Size = new System.Drawing.Size(150, 23);
            this.btnGoToIndex.TabIndex = 19;
            this.btnGoToIndex.Text = "Перейти по индексу";
            this.btnGoToIndex.UseVisualStyleBackColor = true;
            this.btnGoToIndex.Click += new System.EventHandler(this.btnGoToIndex_Click);
            // 
            // numericUpDownIndex
            // 
            this.numericUpDownIndex.Location = new System.Drawing.Point(350, 240);
            this.numericUpDownIndex.Name = "numericUpDownIndex";
            this.numericUpDownIndex.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownIndex.TabIndex = 18;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(350, 211);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(150, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "Предыдущая";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(350, 180);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(350, 146);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(150, 23);
            this.btnAddSong.TabIndex = 15;
            this.btnAddSong.Text = "Добавить песню";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(350, 120);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(150, 20);
            this.txtFilename.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(350, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(150, 20);
            this.txtTitle.TabIndex = 13;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(350, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(150, 20);
            this.txtAuthor.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Название:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Автор:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Файл:";
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.Location = new System.Drawing.Point(20, 20);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(300, 394);
            this.playlistListBox.TabIndex = 0;
            // 
            // btnSavePlaylist
            // 
            this.btnSavePlaylist.Location = new System.Drawing.Point(350, 325);
            this.btnSavePlaylist.Name = "btnSavePlaylist";
            this.btnSavePlaylist.Size = new System.Drawing.Size(150, 23);
            this.btnSavePlaylist.TabIndex = 25;
            this.btnSavePlaylist.Text = "Сохранить плейлист";
            this.btnSavePlaylist.Click += new System.EventHandler(this.btnSavePlaylist_Click);
            // 
            // btnLoadPlaylist
            // 
            this.btnLoadPlaylist.Location = new System.Drawing.Point(350, 383);
            this.btnLoadPlaylist.Name = "btnLoadPlaylist";
            this.btnLoadPlaylist.Size = new System.Drawing.Size(150, 23);
            this.btnLoadPlaylist.TabIndex = 26;
            this.btnLoadPlaylist.Text = "Загрузить плейлист";
            this.btnLoadPlaylist.Click += new System.EventHandler(this.btnLoadPlaylist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 475);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Управление магазином и плейлист";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSavePlaylist;
        private Button btnLoadPlaylist;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Quest2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Quest3ToolStripMenuItem;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button BtnSellMultiple;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.NumericUpDown numericUpDownIndex;
        private System.Windows.Forms.Button btnGoToIndex;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnClearPlaylist;
        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.Label label13;
    }
}

