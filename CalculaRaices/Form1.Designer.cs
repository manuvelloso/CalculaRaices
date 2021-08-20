
namespace CalculaRaices
{
    partial class Raices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lB = new System.Windows.Forms.Label();
            this.lC = new System.Windows.Forms.Label();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.lA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lEquation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 68);
            this.panel1.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTitle.Location = new System.Drawing.Point(25, 15);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(327, 36);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "CALCULADORA DE RAICES";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(105, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB.Location = new System.Drawing.Point(65, 193);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(34, 19);
            this.lB.TabIndex = 5;
            this.lB.Text = "B =";
            // 
            // lC
            // 
            this.lC.AutoSize = true;
            this.lC.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lC.Location = new System.Drawing.Point(66, 231);
            this.lC.Name = "lC";
            this.lC.Size = new System.Drawing.Size(34, 19);
            this.lC.TabIndex = 7;
            this.lC.Text = "C =";
            // 
            // txt_C
            // 
            this.txt_C.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_C.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_C.Location = new System.Drawing.Point(105, 231);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(197, 20);
            this.txt_C.TabIndex = 17;
            // 
            // txt_B
            // 
            this.txt_B.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_B.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_B.Location = new System.Drawing.Point(105, 193);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(197, 20);
            this.txt_B.TabIndex = 16;
            // 
            // txt_A
            // 
            this.txt_A.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_A.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_A.Location = new System.Drawing.Point(105, 153);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(197, 20);
            this.txt_A.TabIndex = 15;
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lA.Location = new System.Drawing.Point(65, 154);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(35, 19);
            this.lA.TabIndex = 1;
            this.lA.Text = "A =";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 256);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(308, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 256);
            this.panel3.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(200, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lEquation
            // 
            this.lEquation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.lEquation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEquation.Location = new System.Drawing.Point(67, 99);
            this.lEquation.Name = "lEquation";
            this.lEquation.Size = new System.Drawing.Size(235, 31);
            this.lEquation.TabIndex = 19;
            this.lEquation.Text = "Ax² + Bx + C";
            this.lEquation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Raices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(377, 324);
            this.Controls.Add(this.lEquation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.lC);
            this.Controls.Add(this.lA);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Raices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculaRaices";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.Label lC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lEquation;
    }
}

