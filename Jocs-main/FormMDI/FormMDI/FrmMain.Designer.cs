namespace FormMDI
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.pedraPaperTisoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elPenjatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedraPaperTisoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.finestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horitzontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organitzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.pedraPaperTisoraToolStripMenuItem,
            this.finestresToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.finestresToolStripMenuItem;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(900, 28);
            this.mnuMain.TabIndex = 1;
            // 
            // pedraPaperTisoraToolStripMenuItem
            // 
            this.pedraPaperTisoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elPenjatToolStripMenuItem,
            this.toolStripSeparator1,
            this.pedraPaperTisoraToolStripMenuItem1});
            this.pedraPaperTisoraToolStripMenuItem.Name = "pedraPaperTisoraToolStripMenuItem";
            this.pedraPaperTisoraToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.pedraPaperTisoraToolStripMenuItem.Text = "&Jocs";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.generalToolStripMenuItem.Text = "&General";
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sortirToolStripMenuItem.Text = "&Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // elPenjatToolStripMenuItem
            // 
            this.elPenjatToolStripMenuItem.Name = "elPenjatToolStripMenuItem";
            this.elPenjatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elPenjatToolStripMenuItem.Text = "El Pen&jat";
            this.elPenjatToolStripMenuItem.Click += new System.EventHandler(this.elPenjatToolStripMenuItem_Click);
            // 
            // pedraPaperTisoraToolStripMenuItem1
            // 
            this.pedraPaperTisoraToolStripMenuItem1.Name = "pedraPaperTisoraToolStripMenuItem1";
            this.pedraPaperTisoraToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pedraPaperTisoraToolStripMenuItem1.Text = "&Pedra-Paper-Tisora";
            this.pedraPaperTisoraToolStripMenuItem1.Click += new System.EventHandler(this.pedraPaperTisoraToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // finestresToolStripMenuItem
            // 
            this.finestresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horitzontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.cascadaToolStripMenuItem,
            this.organitzarToolStripMenuItem});
            this.finestresToolStripMenuItem.Name = "finestresToolStripMenuItem";
            this.finestresToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.finestresToolStripMenuItem.Text = "&Finestres";
            // 
            // horitzontalToolStripMenuItem
            // 
            this.horitzontalToolStripMenuItem.Name = "horitzontalToolStripMenuItem";
            this.horitzontalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.horitzontalToolStripMenuItem.Text = "&Horitzontal";
            this.horitzontalToolStripMenuItem.Click += new System.EventHandler(this.horitzontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verticalToolStripMenuItem.Text = "&Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cascadaToolStripMenuItem.Text = "&Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // organitzarToolStripMenuItem
            // 
            this.organitzarToolStripMenuItem.Name = "organitzarToolStripMenuItem";
            this.organitzarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.organitzarToolStripMenuItem.Text = "&Organitzar";
            this.organitzarToolStripMenuItem.Click += new System.EventHandler(this.organitzarToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "GitHub - FormMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedraPaperTisoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elPenjatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pedraPaperTisoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finestresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horitzontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organitzarToolStripMenuItem;
    }
}

