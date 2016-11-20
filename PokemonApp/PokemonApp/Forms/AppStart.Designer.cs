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
            this.SuspendLayout();
            // 
            // btPokedex
            // 
            this.btPokedex.Location = new System.Drawing.Point(60, 79);
            this.btPokedex.Name = "btPokedex";
            this.btPokedex.Size = new System.Drawing.Size(160, 30);
            this.btPokedex.TabIndex = 0;
            this.btPokedex.Text = "Pokedéx";
            this.btPokedex.UseVisualStyleBackColor = true;
            this.btPokedex.Click += new System.EventHandler(this.btPokedex_Click);
            // 
            // btInventory
            // 
            this.btInventory.Location = new System.Drawing.Point(60, 115);
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(160, 30);
            this.btInventory.TabIndex = 2;
            this.btInventory.Text = "Inventário";
            this.btInventory.UseVisualStyleBackColor = true;
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(60, 151);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(160, 30);
            this.btAbout.TabIndex = 3;
            this.btAbout.Text = "Sobre";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // AppStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}