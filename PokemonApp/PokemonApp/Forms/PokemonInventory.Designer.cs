namespace PokemonApp.Forms
{
    partial class PokemonInventory
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
            this.lpPokemons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lpPokemons
            // 
            this.lpPokemons.AutoScroll = true;
            this.lpPokemons.Location = new System.Drawing.Point(11, 11);
            this.lpPokemons.Margin = new System.Windows.Forms.Padding(2);
            this.lpPokemons.Name = "lpPokemons";
            this.lpPokemons.Size = new System.Drawing.Size(773, 449);
            this.lpPokemons.TabIndex = 1;
            // 
            // PokemonInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.lpPokemons);
            this.Name = "PokemonInventory";
            this.Text = "PokemonInventory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel lpPokemons;
    }
}