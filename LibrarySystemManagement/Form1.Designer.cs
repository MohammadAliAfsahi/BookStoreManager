namespace LibrarySystemManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PopfromStackButton = new System.Windows.Forms.Button();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.AddBookToCartButton = new System.Windows.Forms.Button();
            this.CartStackListView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.StatusTab = new System.Windows.Forms.TabPage();
            this.GetFactureButton = new System.Windows.Forms.Button();
            this.AddToFemaleQueue = new System.Windows.Forms.Button();
            this.AddToMenQueue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FemaleListView = new System.Windows.Forms.ListView();
            this.MenListView = new System.Windows.Forms.ListView();
            this.BooksTab = new System.Windows.Forms.TabPage();
            this.numberOfBooksLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bookpricelabel = new System.Windows.Forms.Label();
            this.bookpublishyearlabel = new System.Windows.Forms.Label();
            this.BookPriceTextBox = new System.Windows.Forms.TextBox();
            this.BookYearNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.bookauthorlabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.SortaccordingtoNumbersButton = new System.Windows.Forms.Button();
            this.SortPbBtn = new System.Windows.Forms.Button();
            this.SortNameBtn = new System.Windows.Forms.Button();
            this.Tota = new System.Windows.Forms.Label();
            this.TotalNumberLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.StatusTab.SuspendLayout();
            this.BooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookYearNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "We wish you a nice day!";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::LibrarySystemManagement.Properties.Resources.cancel;
            this.ExitButton.Location = new System.Drawing.Point(863, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 26);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.PopfromStackButton);
            this.panel2.Controls.Add(this.TotalAmountLabel);
            this.panel2.Controls.Add(this.AddBookToCartButton);
            this.panel2.Controls.Add(this.CartStackListView);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 422);
            this.panel2.TabIndex = 3;
            // 
            // PopfromStackButton
            // 
            this.PopfromStackButton.Location = new System.Drawing.Point(87, 400);
            this.PopfromStackButton.Name = "PopfromStackButton";
            this.PopfromStackButton.Size = new System.Drawing.Size(61, 20);
            this.PopfromStackButton.TabIndex = 6;
            this.PopfromStackButton.Text = "Calculate";
            this.PopfromStackButton.UseVisualStyleBackColor = true;
            this.PopfromStackButton.Click += new System.EventHandler(this.PopfromStackButton_Click);
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.TotalAmountLabel.Location = new System.Drawing.Point(3, 402);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(79, 16);
            this.TotalAmountLabel.TabIndex = 5;
            this.TotalAmountLabel.Text = "Total Cost";
            // 
            // AddBookToCartButton
            // 
            this.AddBookToCartButton.Location = new System.Drawing.Point(5, 140);
            this.AddBookToCartButton.Name = "AddBookToCartButton";
            this.AddBookToCartButton.Size = new System.Drawing.Size(141, 23);
            this.AddBookToCartButton.TabIndex = 4;
            this.AddBookToCartButton.Text = "Add Selected Books";
            this.AddBookToCartButton.UseVisualStyleBackColor = true;
            this.AddBookToCartButton.Click += new System.EventHandler(this.AddBookToCartButton_Click);
            // 
            // CartStackListView
            // 
            this.CartStackListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.CartStackListView.Location = new System.Drawing.Point(3, 167);
            this.CartStackListView.Name = "CartStackListView";
            this.CartStackListView.Size = new System.Drawing.Size(145, 232);
            this.CartStackListView.TabIndex = 1;
            this.CartStackListView.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::LibrarySystemManagement.Properties.Resources.books;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(150, 44);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(746, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.StatusTab);
            this.materialTabControl1.Controls.Add(this.BooksTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(150, 71);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(721, 395);
            this.materialTabControl1.TabIndex = 4;
            // 
            // StatusTab
            // 
            this.StatusTab.Controls.Add(this.GetFactureButton);
            this.StatusTab.Controls.Add(this.AddToFemaleQueue);
            this.StatusTab.Controls.Add(this.AddToMenQueue);
            this.StatusTab.Controls.Add(this.label3);
            this.StatusTab.Controls.Add(this.label2);
            this.StatusTab.Controls.Add(this.FemaleListView);
            this.StatusTab.Controls.Add(this.MenListView);
            this.StatusTab.Location = new System.Drawing.Point(4, 22);
            this.StatusTab.Name = "StatusTab";
            this.StatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatusTab.Size = new System.Drawing.Size(713, 369);
            this.StatusTab.TabIndex = 0;
            this.StatusTab.Text = "Status";
            this.StatusTab.UseVisualStyleBackColor = true;
            // 
            // GetFactureButton
            // 
            this.GetFactureButton.Location = new System.Drawing.Point(331, 106);
            this.GetFactureButton.Name = "GetFactureButton";
            this.GetFactureButton.Size = new System.Drawing.Size(52, 114);
            this.GetFactureButton.TabIndex = 6;
            this.GetFactureButton.Text = "Get Facture";
            this.GetFactureButton.UseVisualStyleBackColor = true;
            this.GetFactureButton.Click += new System.EventHandler(this.GetFactureButton_Click);
            // 
            // AddToFemaleQueue
            // 
            this.AddToFemaleQueue.Location = new System.Drawing.Point(333, 275);
            this.AddToFemaleQueue.Name = "AddToFemaleQueue";
            this.AddToFemaleQueue.Size = new System.Drawing.Size(50, 23);
            this.AddToFemaleQueue.TabIndex = 5;
            this.AddToFemaleQueue.Text = "Add=>";
            this.AddToFemaleQueue.UseVisualStyleBackColor = true;
            this.AddToFemaleQueue.Click += new System.EventHandler(this.AddToFemaleQueue_Click);
            // 
            // AddToMenQueue
            // 
            this.AddToMenQueue.Location = new System.Drawing.Point(331, 43);
            this.AddToMenQueue.Name = "AddToMenQueue";
            this.AddToMenQueue.Size = new System.Drawing.Size(50, 23);
            this.AddToMenQueue.TabIndex = 4;
            this.AddToMenQueue.Text = "<=Add";
            this.AddToMenQueue.UseVisualStyleBackColor = true;
            this.AddToMenQueue.Click += new System.EventHandler(this.AddToMenQueue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Female=>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "<=Men";
            // 
            // FemaleListView
            // 
            this.FemaleListView.Location = new System.Drawing.Point(385, 5);
            this.FemaleListView.Name = "FemaleListView";
            this.FemaleListView.Size = new System.Drawing.Size(322, 345);
            this.FemaleListView.TabIndex = 1;
            this.FemaleListView.UseCompatibleStateImageBehavior = false;
            // 
            // MenListView
            // 
            this.MenListView.LabelEdit = true;
            this.MenListView.Location = new System.Drawing.Point(6, 6);
            this.MenListView.Name = "MenListView";
            this.MenListView.Size = new System.Drawing.Size(322, 345);
            this.MenListView.TabIndex = 0;
            this.MenListView.UseCompatibleStateImageBehavior = false;
            // 
            // BooksTab
            // 
            this.BooksTab.Controls.Add(this.TotalNumberLbl);
            this.BooksTab.Controls.Add(this.Tota);
            this.BooksTab.Controls.Add(this.SortNameBtn);
            this.BooksTab.Controls.Add(this.SortPbBtn);
            this.BooksTab.Controls.Add(this.SortaccordingtoNumbersButton);
            this.BooksTab.Controls.Add(this.numberOfBooksLabel);
            this.BooksTab.Controls.Add(this.label5);
            this.BooksTab.Controls.Add(this.NumberNumericUpDown);
            this.BooksTab.Controls.Add(this.bookpricelabel);
            this.BooksTab.Controls.Add(this.bookpublishyearlabel);
            this.BooksTab.Controls.Add(this.BookPriceTextBox);
            this.BooksTab.Controls.Add(this.BookYearNumericUpdown);
            this.BooksTab.Controls.Add(this.bookauthorlabel);
            this.BooksTab.Controls.Add(this.BookNameLabel);
            this.BooksTab.Controls.Add(this.BookAuthorTextBox);
            this.BooksTab.Controls.Add(this.BookNameTextBox);
            this.BooksTab.Controls.Add(this.InsertButton);
            this.BooksTab.Controls.Add(this.DeleteBookButton);
            this.BooksTab.Controls.Add(this.booksGridView);
            this.BooksTab.Location = new System.Drawing.Point(4, 22);
            this.BooksTab.Name = "BooksTab";
            this.BooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.BooksTab.Size = new System.Drawing.Size(713, 369);
            this.BooksTab.TabIndex = 1;
            this.BooksTab.Text = "Books";
            this.BooksTab.UseVisualStyleBackColor = true;
            // 
            // numberOfBooksLabel
            // 
            this.numberOfBooksLabel.AutoSize = true;
            this.numberOfBooksLabel.Location = new System.Drawing.Point(6, 344);
            this.numberOfBooksLabel.Name = "numberOfBooksLabel";
            this.numberOfBooksLabel.Size = new System.Drawing.Size(119, 13);
            this.numberOfBooksLabel.TabIndex = 16;
            this.numberOfBooksLabel.Text = "Total Number of Books:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "NO.";
            // 
            // NumberNumericUpDown
            // 
            this.NumberNumericUpDown.Location = new System.Drawing.Point(521, 313);
            this.NumberNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberNumericUpDown.Name = "NumberNumericUpDown";
            this.NumberNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.NumberNumericUpDown.TabIndex = 14;
            this.NumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bookpricelabel
            // 
            this.bookpricelabel.AutoSize = true;
            this.bookpricelabel.Location = new System.Drawing.Point(411, 297);
            this.bookpricelabel.Name = "bookpricelabel";
            this.bookpricelabel.Size = new System.Drawing.Size(31, 13);
            this.bookpricelabel.TabIndex = 13;
            this.bookpricelabel.Text = "Price";
            // 
            // bookpublishyearlabel
            // 
            this.bookpublishyearlabel.AutoSize = true;
            this.bookpublishyearlabel.Location = new System.Drawing.Point(326, 297);
            this.bookpublishyearlabel.Name = "bookpublishyearlabel";
            this.bookpublishyearlabel.Size = new System.Drawing.Size(78, 13);
            this.bookpublishyearlabel.TabIndex = 12;
            this.bookpublishyearlabel.Text = "Published Year";
            // 
            // BookPriceTextBox
            // 
            this.BookPriceTextBox.Location = new System.Drawing.Point(415, 313);
            this.BookPriceTextBox.Name = "BookPriceTextBox";
            this.BookPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookPriceTextBox.TabIndex = 11;
            // 
            // BookYearNumericUpdown
            // 
            this.BookYearNumericUpdown.Location = new System.Drawing.Point(329, 313);
            this.BookYearNumericUpdown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.BookYearNumericUpdown.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.BookYearNumericUpdown.Name = "BookYearNumericUpdown";
            this.BookYearNumericUpdown.Size = new System.Drawing.Size(75, 20);
            this.BookYearNumericUpdown.TabIndex = 10;
            this.BookYearNumericUpdown.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // bookauthorlabel
            // 
            this.bookauthorlabel.AutoSize = true;
            this.bookauthorlabel.Location = new System.Drawing.Point(224, 298);
            this.bookauthorlabel.Name = "bookauthorlabel";
            this.bookauthorlabel.Size = new System.Drawing.Size(38, 13);
            this.bookauthorlabel.TabIndex = 9;
            this.bookauthorlabel.Text = "Author";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(111, 298);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(35, 13);
            this.BookNameLabel.TabIndex = 8;
            this.BookNameLabel.Text = "Name";
            // 
            // BookAuthorTextBox
            // 
            this.BookAuthorTextBox.Location = new System.Drawing.Point(223, 313);
            this.BookAuthorTextBox.Name = "BookAuthorTextBox";
            this.BookAuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookAuthorTextBox.TabIndex = 7;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(114, 313);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(103, 20);
            this.BookNameTextBox.TabIndex = 6;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(6, 311);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(95, 23);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Add new Book";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Location = new System.Drawing.Point(576, 311);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(131, 23);
            this.DeleteBookButton.TabIndex = 5;
            this.DeleteBookButton.Text = "Delete selected book";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // booksGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(244)))), ((int)(((byte)(66)))));
            this.booksGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.booksGridView.Location = new System.Drawing.Point(6, 6);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(701, 289);
            this.booksGridView.TabIndex = 0;
            // 
            // SortaccordingtoNumbersButton
            // 
            this.SortaccordingtoNumbersButton.Location = new System.Drawing.Point(627, 339);
            this.SortaccordingtoNumbersButton.Name = "SortaccordingtoNumbersButton";
            this.SortaccordingtoNumbersButton.Size = new System.Drawing.Size(80, 23);
            this.SortaccordingtoNumbersButton.TabIndex = 17;
            this.SortaccordingtoNumbersButton.Text = "Sort_Number";
            this.SortaccordingtoNumbersButton.UseVisualStyleBackColor = true;
            this.SortaccordingtoNumbersButton.Click += new System.EventHandler(this.SortaccordingtoNumbersButton_Click);
            // 
            // SortPbBtn
            // 
            this.SortPbBtn.Location = new System.Drawing.Point(506, 339);
            this.SortPbBtn.Name = "SortPbBtn";
            this.SortPbBtn.Size = new System.Drawing.Size(115, 23);
            this.SortPbBtn.TabIndex = 18;
            this.SortPbBtn.Text = "Sort_PublishedYear";
            this.SortPbBtn.UseVisualStyleBackColor = true;
            this.SortPbBtn.Click += new System.EventHandler(this.SortPbBtn_Click);
            // 
            // SortNameBtn
            // 
            this.SortNameBtn.Location = new System.Drawing.Point(425, 339);
            this.SortNameBtn.Name = "SortNameBtn";
            this.SortNameBtn.Size = new System.Drawing.Size(75, 23);
            this.SortNameBtn.TabIndex = 19;
            this.SortNameBtn.Text = "Sort_Name";
            this.SortNameBtn.UseVisualStyleBackColor = true;
            this.SortNameBtn.Click += new System.EventHandler(this.SortNameBtn_Click);
            // 
            // Tota
            // 
            this.Tota.AutoSize = true;
            this.Tota.Location = new System.Drawing.Point(124, 344);
            this.Tota.Name = "Tota";
            this.Tota.Size = new System.Drawing.Size(0, 13);
            this.Tota.TabIndex = 20;
            // 
            // TotalNumberLbl
            // 
            this.TotalNumberLbl.AutoSize = true;
            this.TotalNumberLbl.Location = new System.Drawing.Point(124, 344);
            this.TotalNumberLbl.Name = "TotalNumberLbl";
            this.TotalNumberLbl.Size = new System.Drawing.Size(0, 13);
            this.TotalNumberLbl.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.StatusTab.ResumeLayout(false);
            this.StatusTab.PerformLayout();
            this.BooksTab.ResumeLayout(false);
            this.BooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookYearNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitButton;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage StatusTab;
        private System.Windows.Forms.TabPage BooksTab;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Label bookpricelabel;
        private System.Windows.Forms.Label bookpublishyearlabel;
        private System.Windows.Forms.TextBox BookPriceTextBox;
        private System.Windows.Forms.NumericUpDown BookYearNumericUpdown;
        private System.Windows.Forms.Label bookauthorlabel;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox BookAuthorTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView MenListView;
        private System.Windows.Forms.ListView FemaleListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView CartStackListView;
        private System.Windows.Forms.Button AddBookToCartButton;
        private System.Windows.Forms.Button AddToFemaleQueue;
        private System.Windows.Forms.Button AddToMenQueue;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumberNumericUpDown;
        private System.Windows.Forms.Button GetFactureButton;
        private System.Windows.Forms.Button PopfromStackButton;
        private System.Windows.Forms.Label numberOfBooksLabel;
        private System.Windows.Forms.Button SortaccordingtoNumbersButton;
        private System.Windows.Forms.Button SortNameBtn;
        private System.Windows.Forms.Button SortPbBtn;
        private System.Windows.Forms.Label Tota;
        private System.Windows.Forms.Label TotalNumberLbl;
    }
}

