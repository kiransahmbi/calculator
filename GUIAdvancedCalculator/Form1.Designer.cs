namespace GUIAdvancedCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.numberZero = new System.Windows.Forms.Button();
            this.equalOperator = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.numberOne = new System.Windows.Forms.Button();
            this.plusOperator = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.minusOperator = new System.Windows.Forms.Button();
            this.numberNine = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.numberSeven = new System.Windows.Forms.Button();
            this.mutiplyOperator = new System.Windows.Forms.Button();
            this.divideOperator = new System.Windows.Forms.Button();
            this.flipOperator = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.memoryRecall = new System.Windows.Forms.Button();
            this.memoryMinus = new System.Windows.Forms.Button();
            this.memoryClear = new System.Windows.Forms.Button();
            this.memoryAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.decimalPoint, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.numberZero, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.equalOperator, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberThree, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberTwo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberOne, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.plusOperator, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberSix, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberFive, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberFour, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minusOperator, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberNine, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberEight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberSeven, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mutiplyOperator, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.divideOperator, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flipOperator, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.memoryRecall, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoryMinus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoryClear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoryAdd, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 103);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // decimalPoint
            // 
            this.decimalPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.decimalPoint.Location = new System.Drawing.Point(304, 473);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(145, 93);
            this.decimalPoint.TabIndex = 22;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = true;
            this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
            // 
            // numberZero
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numberZero, 2);
            this.numberZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberZero.Location = new System.Drawing.Point(4, 473);
            this.numberZero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberZero.Name = "numberZero";
            this.numberZero.Size = new System.Drawing.Size(292, 93);
            this.numberZero.TabIndex = 20;
            this.numberZero.Text = "0";
            this.numberZero.UseVisualStyleBackColor = true;
            this.numberZero.Click += new System.EventHandler(this.numberZero_Click);
            // 
            // equalOperator
            // 
            this.equalOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.equalOperator.Location = new System.Drawing.Point(457, 379);
            this.equalOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.equalOperator.Name = "equalOperator";
            this.tableLayoutPanel1.SetRowSpan(this.equalOperator, 2);
            this.equalOperator.Size = new System.Drawing.Size(142, 187);
            this.equalOperator.TabIndex = 19;
            this.equalOperator.Text = "=";
            this.equalOperator.UseVisualStyleBackColor = true;
            this.equalOperator.Click += new System.EventHandler(this.equalOperator_Click);
            // 
            // numberThree
            // 
            this.numberThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberThree.Location = new System.Drawing.Point(304, 379);
            this.numberThree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(145, 84);
            this.numberThree.TabIndex = 18;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = true;
            this.numberThree.Click += new System.EventHandler(this.numberThree_Click);
            // 
            // numberTwo
            // 
            this.numberTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberTwo.Location = new System.Drawing.Point(148, 379);
            this.numberTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(148, 84);
            this.numberTwo.TabIndex = 17;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = true;
            this.numberTwo.Click += new System.EventHandler(this.numberTwo_Click);
            // 
            // numberOne
            // 
            this.numberOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberOne.Location = new System.Drawing.Point(4, 379);
            this.numberOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(136, 84);
            this.numberOne.TabIndex = 16;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = true;
            this.numberOne.Click += new System.EventHandler(this.numberOne_Click);
            // 
            // plusOperator
            // 
            this.plusOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plusOperator.Location = new System.Drawing.Point(457, 285);
            this.plusOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plusOperator.Name = "plusOperator";
            this.plusOperator.Size = new System.Drawing.Size(142, 84);
            this.plusOperator.TabIndex = 15;
            this.plusOperator.Text = "+";
            this.plusOperator.UseVisualStyleBackColor = true;
            this.plusOperator.Click += new System.EventHandler(this.plusOperator_Click);
            // 
            // numberSix
            // 
            this.numberSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberSix.Location = new System.Drawing.Point(304, 285);
            this.numberSix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(145, 84);
            this.numberSix.TabIndex = 14;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = true;
            this.numberSix.Click += new System.EventHandler(this.numberSix_Click);
            // 
            // numberFive
            // 
            this.numberFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberFive.Location = new System.Drawing.Point(148, 285);
            this.numberFive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(148, 84);
            this.numberFive.TabIndex = 13;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = true;
            this.numberFive.Click += new System.EventHandler(this.numberFive_Click);
            // 
            // numberFour
            // 
            this.numberFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberFour.Location = new System.Drawing.Point(4, 285);
            this.numberFour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(136, 84);
            this.numberFour.TabIndex = 12;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = true;
            this.numberFour.Click += new System.EventHandler(this.numberFour_Click);
            // 
            // minusOperator
            // 
            this.minusOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minusOperator.Location = new System.Drawing.Point(457, 191);
            this.minusOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minusOperator.Name = "minusOperator";
            this.minusOperator.Size = new System.Drawing.Size(142, 84);
            this.minusOperator.TabIndex = 11;
            this.minusOperator.Text = "-";
            this.minusOperator.UseVisualStyleBackColor = true;
            this.minusOperator.Click += new System.EventHandler(this.minusOperator_Click);
            // 
            // numberNine
            // 
            this.numberNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberNine.Location = new System.Drawing.Point(304, 191);
            this.numberNine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberNine.Name = "numberNine";
            this.numberNine.Size = new System.Drawing.Size(145, 84);
            this.numberNine.TabIndex = 10;
            this.numberNine.Text = "9";
            this.numberNine.UseVisualStyleBackColor = true;
            this.numberNine.Click += new System.EventHandler(this.numberNine_Click);
            // 
            // numberEight
            // 
            this.numberEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberEight.Location = new System.Drawing.Point(148, 191);
            this.numberEight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(148, 84);
            this.numberEight.TabIndex = 9;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = true;
            this.numberEight.Click += new System.EventHandler(this.numberEight_Click);
            // 
            // numberSeven
            // 
            this.numberSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberSeven.Location = new System.Drawing.Point(4, 191);
            this.numberSeven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(136, 84);
            this.numberSeven.TabIndex = 8;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = true;
            this.numberSeven.Click += new System.EventHandler(this.numberSeven_Click);
            // 
            // mutiplyOperator
            // 
            this.mutiplyOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mutiplyOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mutiplyOperator.Location = new System.Drawing.Point(457, 92);
            this.mutiplyOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mutiplyOperator.Name = "mutiplyOperator";
            this.mutiplyOperator.Size = new System.Drawing.Size(142, 89);
            this.mutiplyOperator.TabIndex = 7;
            this.mutiplyOperator.Text = "x";
            this.mutiplyOperator.UseVisualStyleBackColor = true;
            this.mutiplyOperator.Click += new System.EventHandler(this.mutiplyOperator_Click);
            // 
            // divideOperator
            // 
            this.divideOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.divideOperator.Location = new System.Drawing.Point(304, 92);
            this.divideOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.divideOperator.Name = "divideOperator";
            this.divideOperator.Size = new System.Drawing.Size(145, 89);
            this.divideOperator.TabIndex = 6;
            this.divideOperator.Text = "/";
            this.divideOperator.UseVisualStyleBackColor = true;
            this.divideOperator.Click += new System.EventHandler(this.divideOperator_Click);
            // 
            // flipOperator
            // 
            this.flipOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flipOperator.Location = new System.Drawing.Point(148, 92);
            this.flipOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flipOperator.Name = "flipOperator";
            this.flipOperator.Size = new System.Drawing.Size(148, 89);
            this.flipOperator.TabIndex = 5;
            this.flipOperator.Text = "+/-";
            this.flipOperator.UseVisualStyleBackColor = true;
            this.flipOperator.Click += new System.EventHandler(this.flipOperator_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(4, 92);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 89);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "CA";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // memoryRecall
            // 
            this.memoryRecall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memoryRecall.Location = new System.Drawing.Point(457, 5);
            this.memoryRecall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memoryRecall.Name = "memoryRecall";
            this.memoryRecall.Size = new System.Drawing.Size(142, 77);
            this.memoryRecall.TabIndex = 3;
            this.memoryRecall.Text = "MR";
            this.memoryRecall.UseVisualStyleBackColor = true;
            this.memoryRecall.Click += new System.EventHandler(this.memoryRecall_Click);
            // 
            // memoryMinus
            // 
            this.memoryMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memoryMinus.Location = new System.Drawing.Point(304, 5);
            this.memoryMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memoryMinus.Name = "memoryMinus";
            this.memoryMinus.Size = new System.Drawing.Size(145, 77);
            this.memoryMinus.TabIndex = 2;
            this.memoryMinus.Text = "M-";
            this.memoryMinus.UseVisualStyleBackColor = true;
            this.memoryMinus.Click += new System.EventHandler(this.memoryMinus_Click);
            // 
            // memoryClear
            // 
            this.memoryClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memoryClear.Location = new System.Drawing.Point(4, 5);
            this.memoryClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memoryClear.Name = "memoryClear";
            this.memoryClear.Size = new System.Drawing.Size(136, 77);
            this.memoryClear.TabIndex = 0;
            this.memoryClear.Text = "MC";
            this.memoryClear.UseVisualStyleBackColor = true;
            this.memoryClear.Click += new System.EventHandler(this.memoryClear_Click);
            // 
            // memoryAdd
            // 
            this.memoryAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memoryAdd.Location = new System.Drawing.Point(148, 5);
            this.memoryAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memoryAdd.Name = "memoryAdd";
            this.memoryAdd.Size = new System.Drawing.Size(148, 77);
            this.memoryAdd.TabIndex = 1;
            this.memoryAdd.Text = "M+";
            this.memoryAdd.UseVisualStyleBackColor = true;
            this.memoryAdd.Click += new System.EventHandler(this.memoryAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS PGothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(601, 57);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += form1_KeyPress;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button numberZero;
        private System.Windows.Forms.Button equalOperator;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.Button plusOperator;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button minusOperator;
        private System.Windows.Forms.Button numberNine;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button mutiplyOperator;
        private System.Windows.Forms.Button divideOperator;
        private System.Windows.Forms.Button flipOperator;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button memoryRecall;
        private System.Windows.Forms.Button memoryMinus;
        private System.Windows.Forms.Button memoryClear;
        private System.Windows.Forms.Button memoryAdd;
        private System.Windows.Forms.TextBox textBox1;
    }
}

