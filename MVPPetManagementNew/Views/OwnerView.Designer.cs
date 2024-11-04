namespace MVPPetManagement.Views
{
    partial class OwnerView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerView));
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblOwnerAddress = new System.Windows.Forms.Label();
            this.txtOwnerAddress = new System.Windows.Forms.TextBox();
            this.lblOwnerPhone = new System.Windows.Forms.Label();
            this.txtOwnerPhone = new System.Windows.Forms.TextBox();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.btnToggleTheme = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnLkn = new System.Windows.Forms.Button();
            this.bthIns = new System.Windows.Forms.Button();
            this.btnFb = new System.Windows.Forms.Button();
            this.btnGm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOwnerName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOwnerName.Location = new System.Drawing.Point(361, 54);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(100, 16);
            this.lblOwnerName.TabIndex = 0;
            this.lblOwnerName.Text = "Owner Name:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.BackColor = System.Drawing.Color.LightYellow;
            this.txtOwnerName.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtOwnerName.Location = new System.Drawing.Point(481, 54);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.ReadOnly = true;
            this.txtOwnerName.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerName.TabIndex = 1;
            // 
            // lblOwnerAddress
            // 
            this.lblOwnerAddress.AutoSize = true;
            this.lblOwnerAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOwnerAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOwnerAddress.Location = new System.Drawing.Point(361, 94);
            this.lblOwnerAddress.Name = "lblOwnerAddress";
            this.lblOwnerAddress.Size = new System.Drawing.Size(118, 16);
            this.lblOwnerAddress.TabIndex = 2;
            this.lblOwnerAddress.Text = "Owner Address:";
            // 
            // txtOwnerAddress
            // 
            this.txtOwnerAddress.BackColor = System.Drawing.Color.LightYellow;
            this.txtOwnerAddress.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtOwnerAddress.Location = new System.Drawing.Point(481, 94);
            this.txtOwnerAddress.Name = "txtOwnerAddress";
            this.txtOwnerAddress.ReadOnly = true;
            this.txtOwnerAddress.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerAddress.TabIndex = 3;
            // 
            // lblOwnerPhone
            // 
            this.lblOwnerPhone.AutoSize = true;
            this.lblOwnerPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOwnerPhone.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOwnerPhone.Location = new System.Drawing.Point(361, 134);
            this.lblOwnerPhone.Name = "lblOwnerPhone";
            this.lblOwnerPhone.Size = new System.Drawing.Size(106, 16);
            this.lblOwnerPhone.TabIndex = 4;
            this.lblOwnerPhone.Text = "Owner Phone:";
            // 
            // txtOwnerPhone
            // 
            this.txtOwnerPhone.BackColor = System.Drawing.Color.LightYellow;
            this.txtOwnerPhone.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtOwnerPhone.Location = new System.Drawing.Point(481, 134);
            this.txtOwnerPhone.Name = "txtOwnerPhone";
            this.txtOwnerPhone.ReadOnly = true;
            this.txtOwnerPhone.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerPhone.TabIndex = 5;
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.avatarBox.Location = new System.Drawing.Point(50, 50);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(200, 200);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarBox.TabIndex = 6;
            this.avatarBox.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.Location = new System.Drawing.Point(50, 260);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(200, 23);
            this.btnChangeAvatar.TabIndex = 7;
            this.btnChangeAvatar.Text = "Change Avatar";
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.BtnChangeAvatar_Click);
            // 
            // btnToggleTheme
            // 
            this.btnToggleTheme.Location = new System.Drawing.Point(50, 300);
            this.btnToggleTheme.Name = "btnToggleTheme";
            this.btnToggleTheme.Size = new System.Drawing.Size(200, 23);
            this.btnToggleTheme.TabIndex = 8;
            this.btnToggleTheme.Text = "Toggle Dark/Light Theme";
            this.btnToggleTheme.UseVisualStyleBackColor = true;
            this.btnToggleTheme.Click += new System.EventHandler(this.BtnToggleTheme_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(413, 260);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(200, 23);
            this.btnChangeInfo.TabIndex = 9;
            this.btnChangeInfo.Text = "Change Information";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.BtnChangeInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(767, 471);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnGithub
            // 
            this.btnGithub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGithub.BackgroundImage")));
            this.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGithub.Location = new System.Drawing.Point(364, 186);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(66, 49);
            this.btnGithub.TabIndex = 11;
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnLkn
            // 
            this.btnLkn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLkn.BackgroundImage")));
            this.btnLkn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLkn.Location = new System.Drawing.Point(445, 186);
            this.btnLkn.Name = "btnLkn";
            this.btnLkn.Size = new System.Drawing.Size(66, 49);
            this.btnLkn.TabIndex = 11;
            this.btnLkn.UseVisualStyleBackColor = true;
            this.btnLkn.Click += new System.EventHandler(this.btnLkn_Click);
            // 
            // bthIns
            // 
            this.bthIns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthIns.BackgroundImage")));
            this.bthIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bthIns.Location = new System.Drawing.Point(530, 186);
            this.bthIns.Name = "bthIns";
            this.bthIns.Size = new System.Drawing.Size(66, 49);
            this.bthIns.TabIndex = 11;
            this.bthIns.UseVisualStyleBackColor = true;
            this.bthIns.Click += new System.EventHandler(this.bthIns_Click);
            // 
            // btnFb
            // 
            this.btnFb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFb.BackgroundImage")));
            this.btnFb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFb.Location = new System.Drawing.Point(615, 186);
            this.btnFb.Name = "btnFb";
            this.btnFb.Size = new System.Drawing.Size(66, 49);
            this.btnFb.TabIndex = 11;
            this.btnFb.UseVisualStyleBackColor = true;
            this.btnFb.Click += new System.EventHandler(this.btnFb_Click);
            // 
            // btnGm
            // 
            this.btnGm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGm.BackgroundImage")));
            this.btnGm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGm.Location = new System.Drawing.Point(701, 186);
            this.btnGm.Name = "btnGm";
            this.btnGm.Size = new System.Drawing.Size(66, 49);
            this.btnGm.TabIndex = 11;
            this.btnGm.UseVisualStyleBackColor = true;
            this.btnGm.Click += new System.EventHandler(this.btnGm_Click);
            // 
            // OwnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(854, 506);
            this.Controls.Add(this.btnGm);
            this.Controls.Add(this.btnFb);
            this.Controls.Add(this.bthIns);
            this.Controls.Add(this.btnLkn);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnToggleTheme);
            this.Controls.Add(this.btnChangeAvatar);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.txtOwnerPhone);
            this.Controls.Add(this.lblOwnerPhone);
            this.Controls.Add(this.txtOwnerAddress);
            this.Controls.Add(this.lblOwnerAddress);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwnerName);
            this.Name = "OwnerView";
            this.Text = "Owner Details";
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblOwnerAddress;
        private System.Windows.Forms.TextBox txtOwnerAddress;
        private System.Windows.Forms.Label lblOwnerPhone;
        private System.Windows.Forms.TextBox txtOwnerPhone;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.Button btnToggleTheme;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnLkn;
        private System.Windows.Forms.Button bthIns;
        private System.Windows.Forms.Button btnFb;
        private System.Windows.Forms.Button btnGm;
    }
}
