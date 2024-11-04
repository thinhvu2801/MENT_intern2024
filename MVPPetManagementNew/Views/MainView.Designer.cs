
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace CRUDWinFormsMVP.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnPetFood = new System.Windows.Forms.Button();
            this.btnVets = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 565);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Clinic";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnPets);
            this.panel2.Controls.Add(this.btnEquipment);
            this.panel2.Controls.Add(this.btnPetFood);
            this.panel2.Controls.Add(this.btnVets);
            this.panel2.Controls.Add(this.btnOwner);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 449);
            this.panel2.TabIndex = 3;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 353);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(233, 41);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnPets
            // 
            this.btnPets.FlatAppearance.BorderSize = 0;
            this.btnPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnPets.Image = ((System.Drawing.Image)(resources.GetObject("btnPets.Image")));
            this.btnPets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPets.Location = new System.Drawing.Point(0, 48);
            this.btnPets.Text = "Pets";
            this.btnPets.Name = "btnPets";
            this.btnPets.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnPets.Size = new System.Drawing.Size(233, 41);
            this.btnPets.TabIndex = 0;
            this.btnPets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPets.UseVisualStyleBackColor = false;
            this.btnPets.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btnEquipment
            // 
            this.btnEquipment.FlatAppearance.BorderSize = 0;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipment.Image")));
            this.btnEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.Location = new System.Drawing.Point(0, 223);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEquipment.Size = new System.Drawing.Size(233, 41);
            this.btnEquipment.TabIndex = 8;
            this.btnEquipment.Text = "Equipments";
            this.btnEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEquipment.UseVisualStyleBackColor = false;
            // 
            // btnPetFood
            // 
            this.btnPetFood.FlatAppearance.BorderSize = 0;
            this.btnPetFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnPetFood.Image = ((System.Drawing.Image)(resources.GetObject("btnPetFood.Image")));
            this.btnPetFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPetFood.Location = new System.Drawing.Point(0, 180);
            this.btnPetFood.Name = "btnPetFood";
            this.btnPetFood.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnPetFood.Size = new System.Drawing.Size(233, 41);
            this.btnPetFood.TabIndex = 7;
            this.btnPetFood.Text = "Pet Food";
            this.btnPetFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPetFood.UseVisualStyleBackColor = false;
            // 
            // btnVets
            // 
            this.btnVets.FlatAppearance.BorderSize = 0;
            this.btnVets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnVets.Image = ((System.Drawing.Image)(resources.GetObject("btnVets.Image")));
            this.btnVets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVets.Location = new System.Drawing.Point(0, 138);
            this.btnVets.Name = "btnVets";
            this.btnVets.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnVets.Size = new System.Drawing.Size(233, 41);
            this.btnVets.TabIndex = 5;
            this.btnVets.Text = "Vets";
            this.btnVets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVets.UseVisualStyleBackColor = false;
            // 
            // btnOwner
            // 
            this.btnOwner.FlatAppearance.BorderSize = 0;
            this.btnOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnOwner.Image = ((System.Drawing.Image)(resources.GetObject("btnOwner.Image")));
            this.btnOwner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOwner.Location = new System.Drawing.Point(0, 95);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnOwner.Size = new System.Drawing.Size(233, 41);
            this.btnOwner.TabIndex = 4;
            this.btnOwner.Text = "Owner";
            this.btnOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOwner.UseVisualStyleBackColor = false;
            // 
            // logoPic
            // 
            this.logoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(107, 110);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 1;
            this.logoPic.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 565);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnPetFood;
        private System.Windows.Forms.Button btnVets;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPets;
    }
}
