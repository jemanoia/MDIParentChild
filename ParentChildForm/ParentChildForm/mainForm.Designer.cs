namespace ParentChildForm
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnFacebook = new MetroFramework.Controls.MetroLink();
            this.btnTwitter = new MetroFramework.Controls.MetroLink();
            this.btnInstagram = new MetroFramework.Controls.MetroLink();
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.btnInstagram);
            this.pnlMenu.Controls.Add(this.btnTwitter);
            this.pnlMenu.Controls.Add(this.btnFacebook);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(206, 382);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.Black;
            this.btnFacebook.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnFacebook.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnFacebook.ForeColor = System.Drawing.Color.White;
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacebook.ImageSize = 70;
            this.btnFacebook.Location = new System.Drawing.Point(3, 43);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnFacebook.NoFocusImage")));
            this.btnFacebook.Size = new System.Drawing.Size(200, 46);
            this.btnFacebook.TabIndex = 0;
            this.btnFacebook.Text = "Facebook";
            this.btnFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacebook.UseCustomBackColor = true;
            this.btnFacebook.UseCustomForeColor = true;
            this.btnFacebook.UseSelectable = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.Black;
            this.btnTwitter.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnTwitter.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnTwitter.ForeColor = System.Drawing.Color.White;
            this.btnTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitter.Image")));
            this.btnTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwitter.ImageSize = 70;
            this.btnTwitter.Location = new System.Drawing.Point(3, 95);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnTwitter.NoFocusImage")));
            this.btnTwitter.Size = new System.Drawing.Size(200, 46);
            this.btnTwitter.TabIndex = 1;
            this.btnTwitter.Text = "Twitter";
            this.btnTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTwitter.UseCustomBackColor = true;
            this.btnTwitter.UseCustomForeColor = true;
            this.btnTwitter.UseSelectable = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackColor = System.Drawing.Color.Black;
            this.btnInstagram.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnInstagram.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnInstagram.ForeColor = System.Drawing.Color.White;
            this.btnInstagram.Image = ((System.Drawing.Image)(resources.GetObject("btnInstagram.Image")));
            this.btnInstagram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstagram.ImageSize = 70;
            this.btnInstagram.Location = new System.Drawing.Point(3, 147);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnInstagram.NoFocusImage")));
            this.btnInstagram.Size = new System.Drawing.Size(200, 46);
            this.btnInstagram.TabIndex = 2;
            this.btnInstagram.Text = "Instagram";
            this.btnInstagram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstagram.UseCustomBackColor = true;
            this.btnInstagram.UseCustomForeColor = true;
            this.btnInstagram.UseSelectable = true;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnExit.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = 45;
            this.btnExit.Location = new System.Drawing.Point(641, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnExit.NoFocusImage")));
            this.btnExit.Size = new System.Drawing.Size(87, 70);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(740, 382);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private MetroFramework.Controls.MetroLink btnFacebook;
        private MetroFramework.Controls.MetroLink btnInstagram;
        private MetroFramework.Controls.MetroLink btnTwitter;
        private MetroFramework.Controls.MetroLink btnExit;
    }
}

