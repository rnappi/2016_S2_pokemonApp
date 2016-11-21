namespace PokemonApp.Forms
{
    partial class AppStart
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
            this.btPokedex = new System.Windows.Forms.Button();
            this.btInventory = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btPokedex
            // 
            this.btPokedex.Location = new System.Drawing.Point(61, 136);
            this.btPokedex.Name = "btPokedex";
            this.btPokedex.Size = new System.Drawing.Size(160, 30);
            this.btPokedex.TabIndex = 0;
            this.btPokedex.Text = "Pokedéx";
            this.btPokedex.UseVisualStyleBackColor = true;
            this.btPokedex.Click += new System.EventHandler(this.btPokedex_Click);
            // 
            // btInventory
            // 
            this.btInventory.Location = new System.Drawing.Point(61, 172);
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(160, 30);
            this.btInventory.TabIndex = 2;
            this.btInventory.Text = "Inventário";
            this.btInventory.UseVisualStyleBackColor = true;
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(61, 208);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(160, 30);
            this.btAbout.TabIndex = 3;
            this.btAbout.Text = "Sobre";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PokemonApp.Properties.Resources.Pokemon_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 79);
            this.panel1.TabIndex = 4;
            // 
            // AppStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btInventory);
            this.Controls.Add(this.btPokedex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AppStart";
            this.Text = "AppStart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPokedex;
        private System.Windows.Forms.Button btInventory;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Panel panel1;
    }
}