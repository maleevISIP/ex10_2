namespace _10._2
{
    partial class formMain
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPoschitat = new System.Windows.Forms.Button();
            this.tbStorona1_1 = new System.Windows.Forms.TextBox();
            this.tbStorona2_1 = new System.Windows.Forms.TextBox();
            this.tbStorona3_1 = new System.Windows.Forms.TextBox();
            this.tbStorona1_2 = new System.Windows.Forms.TextBox();
            this.tbStorona2_2 = new System.Windows.Forms.TextBox();
            this.tbStorona3_2 = new System.Windows.Forms.TextBox();
            this.lblStorona1_1 = new System.Windows.Forms.Label();
            this.lblStorona2_1 = new System.Windows.Forms.Label();
            this.lblStorona3_1 = new System.Windows.Forms.Label();
            this.lblStorona1_2 = new System.Windows.Forms.Label();
            this.lblStorona2_2 = new System.Windows.Forms.Label();
            this.lblStorona3_2 = new System.Windows.Forms.Label();
            this.lblTreug2 = new System.Windows.Forms.Label();
            this.lblTreug1 = new System.Windows.Forms.Label();
            this.lblOtvet = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(12, 285);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(122, 23);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Поменять цвет фона";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPoschitat
            // 
            this.btnPoschitat.Enabled = false;
            this.btnPoschitat.Location = new System.Drawing.Point(140, 285);
            this.btnPoschitat.Name = "btnPoschitat";
            this.btnPoschitat.Size = new System.Drawing.Size(73, 23);
            this.btnPoschitat.TabIndex = 2;
            this.btnPoschitat.Text = "Посчитать";
            this.btnPoschitat.UseVisualStyleBackColor = true;
            this.btnPoschitat.Click += new System.EventHandler(this.btnPoschitat_Click);
            // 
            // tbStorona1_1
            // 
            this.tbStorona1_1.Location = new System.Drawing.Point(86, 38);
            this.tbStorona1_1.Name = "tbStorona1_1";
            this.tbStorona1_1.Size = new System.Drawing.Size(79, 20);
            this.tbStorona1_1.TabIndex = 3;
            this.tbStorona1_1.TextChanged += new System.EventHandler(this.tbStorona1_1_TextChanged);
            this.tbStorona1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStorona_KeyPress);
            // 
            // tbStorona2_1
            // 
            this.tbStorona2_1.Location = new System.Drawing.Point(86, 64);
            this.tbStorona2_1.Name = "tbStorona2_1";
            this.tbStorona2_1.Size = new System.Drawing.Size(79, 20);
            this.tbStorona2_1.TabIndex = 4;
            this.tbStorona2_1.TextChanged += new System.EventHandler(this.tbStorona2_1_TextChanged);
            this.tbStorona2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStorona_KeyPress);
            // 
            // tbStorona3_1
            // 
            this.tbStorona3_1.Location = new System.Drawing.Point(86, 90);
            this.tbStorona3_1.Name = "tbStorona3_1";
            this.tbStorona3_1.Size = new System.Drawing.Size(79, 20);
            this.tbStorona3_1.TabIndex = 5;
            this.tbStorona3_1.TextChanged += new System.EventHandler(this.tbStorona3_1_TextChanged);
            this.tbStorona3_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStorona_KeyPress);
            // 
            // tbStorona1_2
            // 
            this.tbStorona1_2.Location = new System.Drawing.Point(290, 38);
            this.tbStorona1_2.Name = "tbStorona1_2";
            this.tbStorona1_2.Size = new System.Drawing.Size(79, 20);
            this.tbStorona1_2.TabIndex = 6;
            this.tbStorona1_2.TextChanged += new System.EventHandler(this.tbStorona1_2_TextChanged);
            this.tbStorona1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStorona_KeyPress);
            // 
            // tbStorona2_2
            // 
            this.tbStorona2_2.Location = new System.Drawing.Point(290, 64);
            this.tbStorona2_2.Name = "tbStorona2_2";
            this.tbStorona2_2.Size = new System.Drawing.Size(79, 20);
            this.tbStorona2_2.TabIndex = 7;
            this.tbStorona2_2.TextChanged += new System.EventHandler(this.tbStorona2_2_TextChanged);
            this.tbStorona2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStorona_KeyPress);
            // 
            // tbStorona3_2
            // 
            this.tbStorona3_2.Location = new System.Drawing.Point(290, 90);
            this.tbStorona3_2.Name = "tbStorona3_2";
            this.tbStorona3_2.Size = new System.Drawing.Size(79, 20);
            this.tbStorona3_2.TabIndex = 8;
            this.tbStorona3_2.TextChanged += new System.EventHandler(this.tbStorona3_2_TextChanged);
            this.tbStorona3_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStorona_KeyPress);
            // 
            // lblStorona1_1
            // 
            this.lblStorona1_1.AutoSize = true;
            this.lblStorona1_1.Location = new System.Drawing.Point(12, 41);
            this.lblStorona1_1.Name = "lblStorona1_1";
            this.lblStorona1_1.Size = new System.Drawing.Size(58, 13);
            this.lblStorona1_1.TabIndex = 9;
            this.lblStorona1_1.Text = "Сторона 1";
            // 
            // lblStorona2_1
            // 
            this.lblStorona2_1.AutoSize = true;
            this.lblStorona2_1.Location = new System.Drawing.Point(12, 67);
            this.lblStorona2_1.Name = "lblStorona2_1";
            this.lblStorona2_1.Size = new System.Drawing.Size(58, 13);
            this.lblStorona2_1.TabIndex = 10;
            this.lblStorona2_1.Text = "Сторона 2";
            // 
            // lblStorona3_1
            // 
            this.lblStorona3_1.AutoSize = true;
            this.lblStorona3_1.Location = new System.Drawing.Point(12, 93);
            this.lblStorona3_1.Name = "lblStorona3_1";
            this.lblStorona3_1.Size = new System.Drawing.Size(58, 13);
            this.lblStorona3_1.TabIndex = 11;
            this.lblStorona3_1.Text = "Сторона 3";
            // 
            // lblStorona1_2
            // 
            this.lblStorona1_2.AutoSize = true;
            this.lblStorona1_2.Location = new System.Drawing.Point(208, 41);
            this.lblStorona1_2.Name = "lblStorona1_2";
            this.lblStorona1_2.Size = new System.Drawing.Size(58, 13);
            this.lblStorona1_2.TabIndex = 12;
            this.lblStorona1_2.Text = "Сторона 1";
            // 
            // lblStorona2_2
            // 
            this.lblStorona2_2.AutoSize = true;
            this.lblStorona2_2.Location = new System.Drawing.Point(208, 67);
            this.lblStorona2_2.Name = "lblStorona2_2";
            this.lblStorona2_2.Size = new System.Drawing.Size(58, 13);
            this.lblStorona2_2.TabIndex = 13;
            this.lblStorona2_2.Text = "Сторона 2";
            // 
            // lblStorona3_2
            // 
            this.lblStorona3_2.AutoSize = true;
            this.lblStorona3_2.Location = new System.Drawing.Point(208, 93);
            this.lblStorona3_2.Name = "lblStorona3_2";
            this.lblStorona3_2.Size = new System.Drawing.Size(58, 13);
            this.lblStorona3_2.TabIndex = 14;
            this.lblStorona3_2.Text = "Сторона 3";
            // 
            // lblTreug2
            // 
            this.lblTreug2.AutoSize = true;
            this.lblTreug2.Location = new System.Drawing.Point(250, 9);
            this.lblTreug2.Name = "lblTreug2";
            this.lblTreug2.Size = new System.Drawing.Size(81, 13);
            this.lblTreug2.TabIndex = 15;
            this.lblTreug2.Text = "Треугольник 2";
            // 
            // lblTreug1
            // 
            this.lblTreug1.AutoSize = true;
            this.lblTreug1.Location = new System.Drawing.Point(53, 9);
            this.lblTreug1.Name = "lblTreug1";
            this.lblTreug1.Size = new System.Drawing.Size(81, 13);
            this.lblTreug1.TabIndex = 16;
            this.lblTreug1.Text = "Треугольник 1";
            // 
            // lblOtvet
            // 
            this.lblOtvet.AutoSize = true;
            this.lblOtvet.Location = new System.Drawing.Point(41, 192);
            this.lblOtvet.Name = "lblOtvet";
            this.lblOtvet.Size = new System.Drawing.Size(0, 13);
            this.lblOtvet.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(381, 320);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOtvet);
            this.Controls.Add(this.lblTreug1);
            this.Controls.Add(this.lblTreug2);
            this.Controls.Add(this.lblStorona3_2);
            this.Controls.Add(this.lblStorona2_2);
            this.Controls.Add(this.lblStorona1_2);
            this.Controls.Add(this.lblStorona3_1);
            this.Controls.Add(this.lblStorona2_1);
            this.Controls.Add(this.lblStorona1_1);
            this.Controls.Add(this.tbStorona3_2);
            this.Controls.Add(this.tbStorona2_2);
            this.Controls.Add(this.tbStorona1_2);
            this.Controls.Add(this.tbStorona3_1);
            this.Controls.Add(this.tbStorona2_1);
            this.Controls.Add(this.tbStorona1_1);
            this.Controls.Add(this.btnPoschitat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.Text = "Сравнение площадей треугольников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPoschitat;
        private System.Windows.Forms.TextBox tbStorona1_1;
        private System.Windows.Forms.TextBox tbStorona2_1;
        private System.Windows.Forms.TextBox tbStorona3_1;
        private System.Windows.Forms.TextBox tbStorona1_2;
        private System.Windows.Forms.TextBox tbStorona2_2;
        private System.Windows.Forms.TextBox tbStorona3_2;
        private System.Windows.Forms.Label lblStorona1_1;
        private System.Windows.Forms.Label lblStorona2_1;
        private System.Windows.Forms.Label lblStorona3_1;
        private System.Windows.Forms.Label lblStorona1_2;
        private System.Windows.Forms.Label lblStorona2_2;
        private System.Windows.Forms.Label lblStorona3_2;
        private System.Windows.Forms.Label lblTreug2;
        private System.Windows.Forms.Label lblTreug1;
        private System.Windows.Forms.Label lblOtvet;
        private System.Windows.Forms.Button btnClear;
    }
}

