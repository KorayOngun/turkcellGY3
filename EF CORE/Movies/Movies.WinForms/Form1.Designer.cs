namespace Movies.WinForms
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            dataGridViewMovies = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btn_removePlayer = new Button();
            buttonGetAllMovies = new Button();
            buttonNewMovie = new Button();
            buttonPlayers = new Button();
            buttonDirector = new Button();
            btn_removePlayerAsync = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewMovies);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btn_removePlayerAsync);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(btn_removePlayer);
            splitContainer1.Panel2.Controls.Add(buttonGetAllMovies);
            splitContainer1.Panel2.Controls.Add(buttonNewMovie);
            splitContainer1.Panel2.Controls.Add(buttonPlayers);
            splitContainer1.Panel2.Controls.Add(buttonDirector);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1082, 554);
            splitContainer1.SplitterDistance = 360;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Dock = DockStyle.Fill;
            dataGridViewMovies.Location = new Point(0, 0);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowTemplate.Height = 25;
            dataGridViewMovies.Size = new Size(1078, 356);
            dataGridViewMovies.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 73);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 8;
            label2.Text = "Filmden silinecek oyuncu ıd";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Film Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(682, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(682, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // btn_removePlayer
            // 
            btn_removePlayer.Location = new Point(779, 153);
            btn_removePlayer.Name = "btn_removePlayer";
            btn_removePlayer.Size = new Size(100, 23);
            btn_removePlayer.TabIndex = 4;
            btn_removePlayer.Text = "oyuncu sil";
            btn_removePlayer.UseVisualStyleBackColor = true;
            btn_removePlayer.Click += btn_removePlayer_Click;
            // 
            // buttonGetAllMovies
            // 
            buttonGetAllMovies.Location = new Point(51, 11);
            buttonGetAllMovies.Name = "buttonGetAllMovies";
            buttonGetAllMovies.Size = new Size(194, 23);
            buttonGetAllMovies.TabIndex = 3;
            buttonGetAllMovies.Text = "Filmleri Getir";
            buttonGetAllMovies.UseVisualStyleBackColor = true;
            buttonGetAllMovies.Click += buttonGetAllMovies_Click;
            // 
            // buttonNewMovie
            // 
            buttonNewMovie.Location = new Point(51, 104);
            buttonNewMovie.Name = "buttonNewMovie";
            buttonNewMovie.Size = new Size(194, 23);
            buttonNewMovie.TabIndex = 2;
            buttonNewMovie.Text = "Yeni Film Ekle";
            buttonNewMovie.UseVisualStyleBackColor = true;
            buttonNewMovie.Click += buttonNewMovie_Click;
            // 
            // buttonPlayers
            // 
            buttonPlayers.Location = new Point(52, 69);
            buttonPlayers.Name = "buttonPlayers";
            buttonPlayers.Size = new Size(193, 23);
            buttonPlayers.TabIndex = 1;
            buttonPlayers.Text = "Oyuncu İşlemleri";
            buttonPlayers.UseVisualStyleBackColor = true;
            buttonPlayers.Click += buttonPlayers_Click;
            // 
            // buttonDirector
            // 
            buttonDirector.Location = new Point(52, 40);
            buttonDirector.Name = "buttonDirector";
            buttonDirector.Size = new Size(193, 23);
            buttonDirector.TabIndex = 0;
            buttonDirector.Text = "Yönetmen İşlemleri";
            buttonDirector.UseVisualStyleBackColor = true;
            buttonDirector.Click += buttonDirector_Click;
            // 
            // btn_removePlayerAsync
            // 
            btn_removePlayerAsync.Location = new Point(564, 153);
            btn_removePlayerAsync.Name = "btn_removePlayerAsync";
            btn_removePlayerAsync.Size = new Size(157, 23);
            btn_removePlayerAsync.TabIndex = 9;
            btn_removePlayerAsync.Text = "oyuncu sil async";
            btn_removePlayerAsync.UseVisualStyleBackColor = true;
            btn_removePlayerAsync.Click += btn_removePlayerAsync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 554);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewMovies;
        private Button buttonPlayers;
        private Button buttonDirector;
        private Button buttonGetAllMovies;
        private Button buttonNewMovie;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btn_removePlayer;
        private Button btn_removePlayerAsync;
    }
}