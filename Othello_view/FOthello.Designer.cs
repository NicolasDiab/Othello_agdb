namespace Othello_view
{
    partial class FOthello
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueurVsJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueurVsIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueurVsIAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joueurVsJoueurToolStripMenuItem,
            this.joueurVsIAToolStripMenuItem,
            this.joueurVsIAToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // joueurVsJoueurToolStripMenuItem
            // 
            this.joueurVsJoueurToolStripMenuItem.Name = "joueurVsJoueurToolStripMenuItem";
            this.joueurVsJoueurToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.joueurVsJoueurToolStripMenuItem.Text = "Joueur vs Joueur";
            // 
            // joueurVsIAToolStripMenuItem
            // 
            this.joueurVsIAToolStripMenuItem.Name = "joueurVsIAToolStripMenuItem";
            this.joueurVsIAToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.joueurVsIAToolStripMenuItem.Text = "Joueur vs IA";
            // 
            // joueurVsIAToolStripMenuItem1
            // 
            this.joueurVsIAToolStripMenuItem1.Name = "joueurVsIAToolStripMenuItem1";
            this.joueurVsIAToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.joueurVsIAToolStripMenuItem1.Text = "Joueur vs IA";
            // 
            // FOthello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FOthello";
            this.Text = " Othello game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueurVsJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueurVsIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueurVsIAToolStripMenuItem1;
    }
}

