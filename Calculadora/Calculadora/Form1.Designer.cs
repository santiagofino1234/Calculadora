namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            txtDisplay2 = new TextBox();
            txtDisplay1 = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnIgual = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            button16 = new Button();
            btnComa = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 40);
            panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 37, 37);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(240, 0);
            btnMinimizar.Margin = new Padding(0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 40);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "\r\n";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(290, 0);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(50, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtDisplay2
            // 
            txtDisplay2.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay2.BorderStyle = BorderStyle.None;
            txtDisplay2.Dock = DockStyle.Top;
            txtDisplay2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay2.ForeColor = Color.White;
            txtDisplay2.Location = new Point(0, 40);
            txtDisplay2.Margin = new Padding(0);
            txtDisplay2.Multiline = true;
            txtDisplay2.Name = "txtDisplay2";
            txtDisplay2.Size = new Size(340, 30);
            txtDisplay2.TabIndex = 1;
            txtDisplay2.Text = "8493";
            txtDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDisplay1
            // 
            txtDisplay1.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay1.BorderStyle = BorderStyle.None;
            txtDisplay1.Dock = DockStyle.Top;
            txtDisplay1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay1.ForeColor = Color.White;
            txtDisplay1.Location = new Point(0, 70);
            txtDisplay1.Margin = new Padding(0);
            txtDisplay1.Multiline = true;
            txtDisplay1.Name = "txtDisplay1";
            txtDisplay1.Size = new Size(340, 58);
            txtDisplay1.TabIndex = 2;
            txtDisplay1.Text = "5784";
            txtDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.FromArgb(40, 40, 40);
            btnSumar.FlatAppearance.BorderSize = 0;
            btnSumar.FlatStyle = FlatStyle.Flat;
            btnSumar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSumar.Location = new Point(253, 293);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 45);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.FromArgb(40, 40, 40);
            btnRestar.FlatAppearance.BorderSize = 0;
            btnRestar.FlatStyle = FlatStyle.Flat;
            btnRestar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestar.Location = new Point(253, 242);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 45);
            btnRestar.TabIndex = 4;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.FromArgb(40, 40, 40);
            btnMultiplicar.FlatAppearance.BorderSize = 0;
            btnMultiplicar.FlatStyle = FlatStyle.Flat;
            btnMultiplicar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(253, 188);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 45);
            btnMultiplicar.TabIndex = 5;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = false;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.FromArgb(40, 40, 40);
            btnDividir.FlatAppearance.BorderSize = 0;
            btnDividir.FlatStyle = FlatStyle.Flat;
            btnDividir.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.Location = new Point(253, 137);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 45);
            btnDividir.TabIndex = 6;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(45, 45, 45);
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(172, 293);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 45);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(45, 45, 45);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(10, 137);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 45);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(45, 45, 45);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(91, 137);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 45);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(45, 45, 45);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(172, 137);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 45);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(45, 45, 45);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(10, 191);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 45);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(45, 45, 45);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(91, 191);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 45);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(45, 45, 45);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(172, 191);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 45);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(45, 45, 45);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(10, 242);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 45);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(45, 45, 45);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(91, 242);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 45);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(45, 45, 45);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(172, 242);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 45);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(45, 45, 45);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(91, 293);
            button16.Name = "button16";
            button16.Size = new Size(75, 45);
            button16.TabIndex = 18;
            button16.Text = "0";
            button16.UseVisualStyleBackColor = false;
            // 
            // btnComa
            // 
            btnComa.BackColor = Color.FromArgb(45, 45, 45);
            btnComa.FlatAppearance.BorderSize = 0;
            btnComa.FlatStyle = FlatStyle.Flat;
            btnComa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnComa.Location = new Point(10, 293);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(75, 45);
            btnComa.TabIndex = 19;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(340, 350);
            Controls.Add(btnComa);
            Controls.Add(button16);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnIgual);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtDisplay1);
            Controls.Add(txtDisplay2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(340, 350);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMinimizar;
        private Button btnCerrar;
        private TextBox txtDisplay2;
        private TextBox txtDisplay1;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnIgual;
        private Button button6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button button16;
        private Button btnComa;
    }
}