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
            this.difficultéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.txbJoueur = new System.Windows.Forms.TextBox();
            this.txbScoreBlack = new System.Windows.Forms.TextBox();
            this.txbScoreBlue = new System.Windows.Forms.TextBox();
            this.btnSurrend = new System.Windows.Forms.Button();
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
            this.dgv.Location = new System.Drawing.Point(74, 32);
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
            this.optionToolStripMenuItem,
            this.difficultéToolStripMenuItem});
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
            this.joueurVsIAToolStripMenuItem});
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
            // difficultéToolStripMenuItem
            // 
            this.difficultéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.difficultéToolStripMenuItem.Name = "difficultéToolStripMenuItem";
            this.difficultéToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.difficultéToolStripMenuItem.Text = "Difficulté";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.eventSetDifficulty);
            // 
            // txbJoueur
            // 
            this.txbJoueur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJoueur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbJoueur.Location = new System.Drawing.Point(256, 0);
            this.txbJoueur.Name = "txbJoueur";
            this.txbJoueur.ReadOnly = true;
            this.txbJoueur.Size = new System.Drawing.Size(145, 26);
            this.txbJoueur.TabIndex = 3;
            // 
            // txbScoreBlack
            // 
            this.txbScoreBlack.BackColor = System.Drawing.Color.Gray;
            this.txbScoreBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbScoreBlack.ForeColor = System.Drawing.Color.Black;
            this.txbScoreBlack.Location = new System.Drawing.Point(560, 160);
            this.txbScoreBlack.Name = "txbScoreBlack";
            this.txbScoreBlack.ReadOnly = true;
            this.txbScoreBlack.Size = new System.Drawing.Size(124, 26);
            this.txbScoreBlack.TabIndex = 4;
            // 
            // txbScoreBlue
            // 
            this.txbScoreBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbScoreBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbScoreBlue.ForeColor = System.Drawing.Color.Blue;
            this.txbScoreBlue.Location = new System.Drawing.Point(560, 114);
            this.txbScoreBlue.Name = "txbScoreBlue";
            this.txbScoreBlue.ReadOnly = true;
            this.txbScoreBlue.Size = new System.Drawing.Size(124, 26);
            this.txbScoreBlue.TabIndex = 5;
            // 
            // btnSurrend
            // 
            this.btnSurrend.BackColor = System.Drawing.Color.Red;
            this.btnSurrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSurrend.Location = new System.Drawing.Point(256, 513);
            this.btnSurrend.Name = "btnSurrend";
            this.btnSurrend.Size = new System.Drawing.Size(140, 36);
            this.btnSurrend.TabIndex = 6;
            this.btnSurrend.Text = "Abandonner";
            this.btnSurrend.UseVisualStyleBackColor = false;
            this.btnSurrend.Click += new System.EventHandler(this.btnSurrend_Click);
            // 
            // FOthello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnSurrend);
            this.Controls.Add(this.txbScoreBlue);
            this.Controls.Add(this.txbScoreBlack);
            this.Controls.Add(this.txbJoueur);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
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
        private System.Windows.Forms.TextBox txbJoueur;
        private System.Windows.Forms.TextBox txbScoreBlack;
        private System.Windows.Forms.TextBox txbScoreBlue;
        private System.Windows.Forms.Button btnSurrend;
        private System.Windows.Forms.ToolStripMenuItem difficultéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
    }
}