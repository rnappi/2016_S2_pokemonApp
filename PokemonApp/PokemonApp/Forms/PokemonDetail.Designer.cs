namespace PokemonApp.Forms
{
    partial class PokemonDetail
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbSDefense = new System.Windows.Forms.Label();
            this.lbSAttack = new System.Windows.Forms.Label();
            this.lbDefense = new System.Windows.Forms.Label();
            this.lbAttack = new System.Windows.Forms.Label();
            this.lbHp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWeakness = new System.Windows.Forms.TextBox();
            this.tbSuperEffective = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbName.Location = new System.Drawing.Point(236, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(70, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbHeight.Location = new System.Drawing.Point(237, 45);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(35, 13);
            this.lbHeight.TabIndex = 2;
            this.lbHeight.Text = "Peso";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbWeight.Location = new System.Drawing.Point(237, 64);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(35, 13);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Peso";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSpeed);
            this.panel1.Controls.Add(this.lbSDefense);
            this.panel1.Controls.Add(this.lbSAttack);
            this.panel1.Controls.Add(this.lbDefense);
            this.panel1.Controls.Add(this.lbAttack);
            this.panel1.Controls.Add(this.lbHp);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(240, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 119);
            this.panel1.TabIndex = 4;
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(3, 100);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(41, 13);
            this.lbSpeed.TabIndex = 5;
            this.lbSpeed.Text = "label4";
            // 
            // lbSDefense
            // 
            this.lbSDefense.AutoSize = true;
            this.lbSDefense.Location = new System.Drawing.Point(3, 81);
            this.lbSDefense.Name = "lbSDefense";
            this.lbSDefense.Size = new System.Drawing.Size(41, 13);
            this.lbSDefense.TabIndex = 4;
            this.lbSDefense.Text = "label4";
            // 
            // lbSAttack
            // 
            this.lbSAttack.AutoSize = true;
            this.lbSAttack.Location = new System.Drawing.Point(3, 62);
            this.lbSAttack.Name = "lbSAttack";
            this.lbSAttack.Size = new System.Drawing.Size(41, 13);
            this.lbSAttack.TabIndex = 3;
            this.lbSAttack.Text = "label3";
            // 
            // lbDefense
            // 
            this.lbDefense.AutoSize = true;
            this.lbDefense.Location = new System.Drawing.Point(3, 43);
            this.lbDefense.Name = "lbDefense";
            this.lbDefense.Size = new System.Drawing.Size(41, 13);
            this.lbDefense.TabIndex = 2;
            this.lbDefense.Text = "label2";
            // 
            // lbAttack
            // 
            this.lbAttack.AutoSize = true;
            this.lbAttack.Location = new System.Drawing.Point(3, 24);
            this.lbAttack.Name = "lbAttack";
            this.lbAttack.Size = new System.Drawing.Size(41, 13);
            this.lbAttack.TabIndex = 1;
            this.lbAttack.Text = "label1";
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Location = new System.Drawing.Point(3, 5);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(41, 13);
            this.lbHp.TabIndex = 0;
            this.lbHp.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(415, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbType.Location = new System.Drawing.Point(415, 62);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(44, 17);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(415, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weakness";
            // 
            // tbWeakness
            // 
            this.tbWeakness.BackColor = System.Drawing.SystemColors.Control;
            this.tbWeakness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeakness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeakness.Location = new System.Drawing.Point(418, 110);
            this.tbWeakness.Multiline = true;
            this.tbWeakness.Name = "tbWeakness";
            this.tbWeakness.Size = new System.Drawing.Size(143, 38);
            this.tbWeakness.TabIndex = 11;
            this.tbWeakness.Text = "xxx";
            // 
            // tbSuperEffective
            // 
            this.tbSuperEffective.BackColor = System.Drawing.SystemColors.Control;
            this.tbSuperEffective.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSuperEffective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuperEffective.Location = new System.Drawing.Point(418, 172);
            this.tbSuperEffective.Multiline = true;
            this.tbSuperEffective.Name = "tbSuperEffective";
            this.tbSuperEffective.Size = new System.Drawing.Size(143, 39);
            this.tbSuperEffective.TabIndex = 13;
            this.tbSuperEffective.Text = "xxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(415, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Super Effective";
            // 
            // PokemonDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 224);
            this.Controls.Add(this.tbSuperEffective);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWeakness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbImage);
            this.Name = "PokemonDetail";
            this.Text = "PokemonDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHp;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbSDefense;
        private System.Windows.Forms.Label lbSAttack;
        private System.Windows.Forms.Label lbDefense;
        private System.Windows.Forms.Label lbAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWeakness;
        private System.Windows.Forms.TextBox tbSuperEffective;
        private System.Windows.Forms.Label label2;
    }
}