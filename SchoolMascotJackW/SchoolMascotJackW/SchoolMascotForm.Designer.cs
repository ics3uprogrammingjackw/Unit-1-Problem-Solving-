namespace SchoolMascotJackW
{
    partial class frmSchoolMascot
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMark = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStPius = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.mnuSchools.SuspendLayout();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(513, 24);
            this.mnuSchools.TabIndex = 1;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniMotherTeresa,
            this.mniStMark,
            this.mniStPius});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            this.mniSchools.Click += new System.EventHandler(this.schoolsToolStripMenuItem_Click);
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(152, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            this.mniMotherTeresa.Click += new System.EventHandler(this.mniMotherTeresa_Click);
            // 
            // mniStMark
            // 
            this.mniStMark.Name = "mniStMark";
            this.mniStMark.Size = new System.Drawing.Size(152, 22);
            this.mniStMark.Text = "St. Mark";
            this.mniStMark.Click += new System.EventHandler(this.mniStMark_Click);
            // 
            // mniStPius
            // 
            this.mniStPius.Name = "mniStPius";
            this.mniStPius.Size = new System.Drawing.Size(152, 22);
            this.mniStPius.Text = "St. Pius";
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblMascot);
            this.grbSchool.Controls.Add(this.lblSchool);
            this.grbSchool.Location = new System.Drawing.Point(65, 99);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(377, 202);
            this.grbSchool.TabIndex = 2;
            this.grbSchool.TabStop = false;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(150, 60);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(0, 13);
            this.lblSchool.TabIndex = 0;
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Location = new System.Drawing.Point(150, 129);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(0, 13);
            this.lblMascot.TabIndex = 1;
            this.lblMascot.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 369);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Jack W";
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
        private System.Windows.Forms.ToolStripMenuItem mniStMark;
        private System.Windows.Forms.ToolStripMenuItem mniStPius;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblSchool;
    }
}

