namespace лб_2_ООП
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
            textMatrix = new TextBox();
            textRows = new TextBox();
            textCols = new TextBox();
            labelRows = new Label();
            labelCols = new Label();
            labelMatrix = new Label();
            buttonCreate = new Button();
            buttonFill = new Button();
            buttonShow = new Button();
            buttonSubMatrix = new Button();
            SuspendLayout();
            // 
            // textMatrix
            // 
            textMatrix.Location = new Point(89, 69);
            textMatrix.Multiline = true;
            textMatrix.Name = "textMatrix";
            textMatrix.ReadOnly = true;
            textMatrix.ScrollBars = ScrollBars.Vertical;
            textMatrix.Size = new Size(286, 130);
            textMatrix.TabIndex = 0;
            textMatrix.TextChanged += textBox1_TextChanged;
            // 
            // textRows
            // 
            textRows.Location = new Point(155, 6);
            textRows.Name = "textRows";
            textRows.Size = new Size(100, 23);
            textRows.TabIndex = 2;
            // 
            // textCols
            // 
            textCols.Location = new Point(473, 11);
            textCols.Name = "textCols";
            textCols.Size = new Size(100, 23);
            textCols.TabIndex = 3;
            textCols.TextChanged += textBox4_TextChanged;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(56, 9);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(93, 15);
            labelRows.TabIndex = 4;
            labelRows.Text = "Кількість рядків";
            // 
            // labelCols
            // 
            labelCols.AutoSize = true;
            labelCols.Location = new Point(367, 14);
            labelCols.Name = "labelCols";
            labelCols.Size = new Size(100, 15);
            labelCols.TabIndex = 5;
            labelCols.Text = "Кільуість стопців";
            // 
            // labelMatrix
            // 
            labelMatrix.AutoSize = true;
            labelMatrix.Location = new Point(27, 124);
            labelMatrix.Name = "labelMatrix";
            labelMatrix.Size = new Size(56, 15);
            labelMatrix.TabIndex = 6;
            labelMatrix.Text = "Матриця";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(56, 229);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "Створити";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click_1;
            // 
            // buttonFill
            // 
            buttonFill.Location = new Point(155, 229);
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(75, 23);
            buttonFill.TabIndex = 8;
            buttonFill.Text = "Заповнити";
            buttonFill.UseVisualStyleBackColor = true;
            buttonFill.Click += buttonFill_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(253, 229);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(75, 46);
            buttonShow.TabIndex = 9;
            buttonShow.Text = "Показати всю";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonSubMatrix
            // 
            buttonSubMatrix.Location = new Point(357, 229);
            buttonSubMatrix.Name = "buttonSubMatrix";
            buttonSubMatrix.Size = new Size(93, 46);
            buttonSubMatrix.TabIndex = 10;
            buttonSubMatrix.Text = "Показати підматрицю";
            buttonSubMatrix.UseVisualStyleBackColor = true;
            buttonSubMatrix.Click += buttonSubMatrix_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSubMatrix);
            Controls.Add(buttonShow);
            Controls.Add(buttonFill);
            Controls.Add(buttonCreate);
            Controls.Add(labelMatrix);
            Controls.Add(labelCols);
            Controls.Add(labelRows);
            Controls.Add(textCols);
            Controls.Add(textRows);
            Controls.Add(textMatrix);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMatrix;
        private TextBox textRows;
        private TextBox textCols;
        private Label labelRows;
        private Label labelCols;
        private Label labelMatrix;
        private Button buttonCreate;
        private Button buttonFill;
        private Button buttonShow;
        private Button buttonSubMatrix;
    }
}
