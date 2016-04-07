namespace Othello_view
{
    partial class FOthello
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueurVsJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueurVsIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iAVsIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBTest = new System.Windows.Forms.Label();
            this.txbJoueur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7,
            this.col8});
            this.dgv.Location = new System.Drawing.Point(79, 27);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(480, 480);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_Paint);
            // 
            // col1
            // 
            this.col1.HeaderText = "1";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "2";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "3";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "4";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "5";
            this.col5.Name = "col5";
            // 
            // col6
            // 
            this.col6.HeaderText = "6";
            this.col6.Name = "col6";
            // 
            // col7
            // 
            this.col7.HeaderText = "7";
            this.col7.Name = "col7";
            // 
            // col8
            // 
            this.col8.HeaderText = "8";
            this.col8.Name = "col8";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(684, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joueurVsJoueurToolStripMenuItem,
            this.joueurVsIAToolStripMenuItem,
            this.iAVsIAToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // joueurVsJoueurToolStripMenuItem
            // 
            this.joueurVsJoueurToolStripMenuItem.Name = "joueurVsJoueurToolStripMenuItem";
            this.joueurVsJoueurToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.joueurVsJoueurToolStripMenuItem.Text = "Joueur vs Joueur";
            this.joueurVsJoueurToolStripMenuItem.Click += new System.EventHandler(this.joueurVsJoueurToolStripMenuItem_Click);
            // 
            // joueurVsIAToolStripMenuItem
            // 
            this.joueurVsIAToolStripMenuItem.Name = "joueurVsIAToolStripMenuItem";
            this.joueurVsIAToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.joueurVsIAToolStripMenuItem.Text = "Joueur vs IA";
            this.joueurVsIAToolStripMenuItem.Click += new System.EventHandler(this.joueurVsIAToolStripMenuItem_Click);
            // 
            // iAVsIAToolStripMenuItem
            // 
            this.iAVsIAToolStripMenuItem.Name = "iAVsIAToolStripMenuItem";
            this.iAVsIAToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.iAVsIAToolStripMenuItem.Text = "IA vs IA";
            this.iAVsIAToolStripMenuItem.Click += new System.EventHandler(this.iAVsIAToolStripMenuItem_Click);
            // 
            // LBTest
            // 
            this.LBTest.AutoSize = true;
            this.LBTest.Location = new System.Drawing.Point(113, 539);
            this.LBTest.Name = "LBTest";
            this.LBTest.Size = new System.Drawing.Size(35, 13);
            this.LBTest.TabIndex = 2;
            this.LBTest.Text = "label1";
            // 
            // txbJoueur
            // 
            this.txbJoueur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJoueur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbJoueur.Location = new System.Drawing.Point(256, 0);
            this.txbJoueur.Name = "txbJoueur";
            this.txbJoueur.Size = new System.Drawing.Size(145, 26);
            this.txbJoueur.TabIndex = 3;
            // 
            // FOthello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.txbJoueur);
            this.Controls.Add(this.LBTest);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FOthello";
            this.Text = "FOthello";
            this.Load += new System.EventHandler(this.FOthello_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewButtonColumn col1;
        private System.Windows.Forms.DataGridViewButtonColumn col2;
        private System.Windows.Forms.DataGridViewButtonColumn col3;
        private System.Windows.Forms.DataGridViewButtonColumn col4;
        private System.Windows.Forms.DataGridViewButtonColumn col5;
        private System.Windows.Forms.DataGridViewButtonColumn col6;
        private System.Windows.Forms.DataGridViewButtonColumn col7;
        private System.Windows.Forms.DataGridViewButtonColumn col8;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueurVsJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueurVsIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iAVsIAToolStripMenuItem;
        private System.Windows.Forms.Label LBTest;
        private System.Windows.Forms.TextBox txbJoueur;
    }
}