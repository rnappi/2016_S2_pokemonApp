namespace PokemonApp.Forms
{
    partial class PokemonAttack
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
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAttack
            // 
            this.tbAttack.Location = new System.Drawing.Point(13, 13);
            this.tbAttack.Multiline = true;
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(259, 237);
            this.tbAttack.TabIndex = 0;
            // 
            // PokemonAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbAttack);
            this.Name = "PokemonAttack";
            this.Text = "PokemonAttack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAttack;
    }
}