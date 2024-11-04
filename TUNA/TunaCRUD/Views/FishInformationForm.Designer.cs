using System;
using System.Windows.Forms;

namespace TunaCRUD.Views
{
    partial class FishInformationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonf5 = new System.Windows.Forms.Button();
            this.buttonHold = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelGRN = new System.Windows.Forms.Label();
            this.labelTotalWeight = new System.Windows.Forms.Label();
            this.labelPcs = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeReceive = new System.Windows.Forms.DateTimePicker();
            this.txtNIC = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxReceived = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCollected = new System.Windows.Forms.RichTextBox();
            this.comboBoxSpecies = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeCatch = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGRNNumber = new System.Windows.Forms.RichTextBox();
            this.labelGRNno = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDhoniCode = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboVesselDown = new System.Windows.Forms.ComboBox();
            this.comboVesselTop = new System.Windows.Forms.ComboBox();
            this.labelVessel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWeightAdj = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFishNo = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewFish = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFish)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonf5);
            this.panel1.Controls.Add(this.buttonHold);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelGRN);
            this.panel1.Controls.Add(this.labelTotalWeight);
            this.panel1.Controls.Add(this.labelPcs);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 61);
            this.panel1.TabIndex = 0;
            // 
            // buttonf5
            // 
            this.buttonf5.BackColor = System.Drawing.Color.Green;
            this.buttonf5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonf5.Location = new System.Drawing.Point(1041, 12);
            this.buttonf5.Name = "buttonf5";
            this.buttonf5.Size = new System.Drawing.Size(110, 33);
            this.buttonf5.TabIndex = 7;
            this.buttonf5.Text = "Refresh";
            this.buttonf5.UseVisualStyleBackColor = false;
            // 
            // buttonHold
            // 
            this.buttonHold.BackColor = System.Drawing.Color.Yellow;
            this.buttonHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHold.Location = new System.Drawing.Point(948, 12);
            this.buttonHold.Name = "buttonHold";
            this.buttonHold.Size = new System.Drawing.Size(83, 33);
            this.buttonHold.TabIndex = 6;
            this.buttonHold.Text = "Hold";
            this.buttonHold.UseVisualStyleBackColor = false;
            this.buttonHold.Click += new System.EventHandler(this.buttonHold_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GRN001",
            "GRN002",
            "GRN003",
            "GRN004",
            "GRN005"});
            this.comboBox1.Location = new System.Drawing.Point(811, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // labelGRN
            // 
            this.labelGRN.AutoSize = true;
            this.labelGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGRN.Location = new System.Drawing.Point(733, 17);
            this.labelGRN.Name = "labelGRN";
            this.labelGRN.Size = new System.Drawing.Size(72, 29);
            this.labelGRN.TabIndex = 4;
            this.labelGRN.Text = "GRN:";
            // 
            // labelTotalWeight
            // 
            this.labelTotalWeight.AutoSize = true;
            this.labelTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalWeight.Location = new System.Drawing.Point(522, 16);
            this.labelTotalWeight.Name = "labelTotalWeight";
            this.labelTotalWeight.Size = new System.Drawing.Size(155, 29);
            this.labelTotalWeight.TabIndex = 3;
            this.labelTotalWeight.Text = "Total Weight:";
            // 
            // labelPcs
            // 
            this.labelPcs.AutoSize = true;
            this.labelPcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPcs.Location = new System.Drawing.Point(364, 16);
            this.labelPcs.Name = "labelPcs";
            this.labelPcs.Size = new System.Drawing.Size(64, 29);
            this.labelPcs.TabIndex = 2;
            this.labelPcs.Text = "PCs:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelStatus.Location = new System.Drawing.Point(161, 14);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(155, 31);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Connected";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(17, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 33);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NAME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimeReceive);
            this.panel2.Controls.Add(this.txtNIC);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBoxReceived);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtCollected);
            this.panel2.Controls.Add(this.comboBoxSpecies);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimeCatch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxMethod);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtGRNNumber);
            this.panel2.Controls.Add(this.labelGRNno);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 94);
            this.panel2.TabIndex = 1;
            // 
            // dateTimeReceive
            // 
            this.dateTimeReceive.CustomFormat = "dd/MM/yyyy";
            this.dateTimeReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeReceive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeReceive.Location = new System.Drawing.Point(579, 49);
            this.dateTimeReceive.Name = "dateTimeReceive";
            this.dateTimeReceive.Size = new System.Drawing.Size(104, 22);
            this.dateTimeReceive.TabIndex = 21;
            this.dateTimeReceive.Value = new System.DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(1046, 44);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(98, 30);
            this.txtNIC.TabIndex = 20;
            this.txtNIC.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1011, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "NIC";
            // 
            // comboBoxReceived
            // 
            this.comboBoxReceived.FormattingEnabled = true;
            this.comboBoxReceived.Items.AddRange(new object[] {
            "Supplier A",
            "Supplier B",
            "Supplier C",
            "Supplier D",
            "Supplier E"});
            this.comboBoxReceived.Location = new System.Drawing.Point(1046, 13);
            this.comboBoxReceived.Name = "comboBoxReceived";
            this.comboBoxReceived.Size = new System.Drawing.Size(98, 21);
            this.comboBoxReceived.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(953, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Received for";
            // 
            // txtCollected
            // 
            this.txtCollected.Location = new System.Drawing.Point(811, 44);
            this.txtCollected.Name = "txtCollected";
            this.txtCollected.Size = new System.Drawing.Size(121, 30);
            this.txtCollected.TabIndex = 16;
            this.txtCollected.Text = "";
            // 
            // comboBoxSpecies
            // 
            this.comboBoxSpecies.FormattingEnabled = true;
            this.comboBoxSpecies.Items.AddRange(new object[] {
            "Tuna",
            "Salmon",
            "Others"});
            this.comboBoxSpecies.Location = new System.Drawing.Point(811, 11);
            this.comboBoxSpecies.Name = "comboBoxSpecies";
            this.comboBoxSpecies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecies.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(721, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Collected by";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Species";
            // 
            // dateTimeCatch
            // 
            this.dateTimeCatch.CustomFormat = "dd/MM/yyyy";
            this.dateTimeCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCatch.Location = new System.Drawing.Point(579, 12);
            this.dateTimeCatch.Name = "dateTimeCatch";
            this.dateTimeCatch.Size = new System.Drawing.Size(104, 22);
            this.dateTimeCatch.TabIndex = 11;
            this.dateTimeCatch.Value = new System.DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Receiving Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Catch Date";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(320, 44);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(121, 30);
            this.txtArea.TabIndex = 8;
            this.txtArea.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Catch Area";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Net",
            "Line",
            "Trap",
            "Spear",
            "Rod and Reel"});
            this.comboBoxMethod.Location = new System.Drawing.Point(320, 15);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethod.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catching Method";
            // 
            // txtGRNNumber
            // 
            this.txtGRNNumber.Location = new System.Drawing.Point(14, 44);
            this.txtGRNNumber.Name = "txtGRNNumber";
            this.txtGRNNumber.Size = new System.Drawing.Size(163, 35);
            this.txtGRNNumber.TabIndex = 1;
            this.txtGRNNumber.Text = "";
            // 
            // labelGRNno
            // 
            this.labelGRNno.AutoSize = true;
            this.labelGRNno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGRNno.Location = new System.Drawing.Point(48, 18);
            this.labelGRNno.Name = "labelGRNno";
            this.labelGRNno.Size = new System.Drawing.Size(99, 18);
            this.labelGRNno.TabIndex = 0;
            this.labelGRNno.Text = "GRN Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtDhoniCode);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboVesselDown);
            this.panel3.Controls.Add(this.comboVesselTop);
            this.panel3.Controls.Add(this.labelVessel);
            this.panel3.Location = new System.Drawing.Point(12, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 119);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Finish Loading";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtDhoniCode
            // 
            this.txtDhoniCode.Location = new System.Drawing.Point(193, 65);
            this.txtDhoniCode.Name = "txtDhoniCode";
            this.txtDhoniCode.Size = new System.Drawing.Size(78, 33);
            this.txtDhoniCode.TabIndex = 9;
            this.txtDhoniCode.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Dhoni Code";
            // 
            // comboVesselDown
            // 
            this.comboVesselDown.FormattingEnabled = true;
            this.comboVesselDown.Items.AddRange(new object[] {
            "Vessel A",
            "Vessel B",
            "Vessel C",
            "Vessel D",
            "Vessel E"});
            this.comboVesselDown.Location = new System.Drawing.Point(23, 66);
            this.comboVesselDown.Name = "comboVesselDown";
            this.comboVesselDown.Size = new System.Drawing.Size(154, 21);
            this.comboVesselDown.TabIndex = 2;
            // 
            // comboVesselTop
            // 
            this.comboVesselTop.FormattingEnabled = true;
            this.comboVesselTop.Items.AddRange(new object[] {
            "Vessel A",
            "Vessel B",
            "Vessel C",
            "Vessel D",
            "Vessel E"});
            this.comboVesselTop.Location = new System.Drawing.Point(23, 25);
            this.comboVesselTop.Name = "comboVesselTop";
            this.comboVesselTop.Size = new System.Drawing.Size(154, 21);
            this.comboVesselTop.TabIndex = 1;
            // 
            // labelVessel
            // 
            this.labelVessel.AutoSize = true;
            this.labelVessel.Location = new System.Drawing.Point(24, 9);
            this.labelVessel.Name = "labelVessel";
            this.labelVessel.Size = new System.Drawing.Size(38, 13);
            this.labelVessel.TabIndex = 0;
            this.labelVessel.Text = "Vessel";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtWeightAdj);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.comboBoxGrade);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtWeight);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtFishNo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(473, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 119);
            this.panel4.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(593, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 62);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWeightAdj
            // 
            this.txtWeightAdj.Location = new System.Drawing.Point(487, 32);
            this.txtWeightAdj.Name = "txtWeightAdj";
            this.txtWeightAdj.Size = new System.Drawing.Size(94, 38);
            this.txtWeightAdj.TabIndex = 18;
            this.txtWeightAdj.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(485, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Weight Adj.";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxGrade.Location = new System.Drawing.Point(397, 35);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(54, 21);
            this.comboBoxGrade.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(394, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Grade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(326, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Stable";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(212, 32);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(159, 38);
            this.txtWeight.TabIndex = 11;
            this.txtWeight.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(208, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Weight";
            // 
            // txtFishNo
            // 
            this.txtFishNo.Location = new System.Drawing.Point(18, 32);
            this.txtFishNo.Name = "txtFishNo";
            this.txtFishNo.Size = new System.Drawing.Size(159, 38);
            this.txtFishNo.TabIndex = 9;
            this.txtFishNo.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fish No";
            // 
            // dataGridViewFish
            // 
            this.dataGridViewFish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFish.Location = new System.Drawing.Point(12, 304);
            this.dataGridViewFish.Name = "dataGridViewFish";
            this.dataGridViewFish.Size = new System.Drawing.Size(1154, 285);
            this.dataGridViewFish.TabIndex = 5;
            // 
            // FishInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 601);
            this.Controls.Add(this.dataGridViewFish);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FishInformationForm";
            this.Text = "FishInformationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTotalWeight;
        private System.Windows.Forms.Label labelPcs;
        private System.Windows.Forms.Label labelGRN;
        private System.Windows.Forms.Button buttonf5;
        private System.Windows.Forms.Button buttonHold;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtGRNNumber;
        private System.Windows.Forms.Label labelGRNno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtCollected;
        private System.Windows.Forms.ComboBox comboBoxSpecies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeCatch;
        private System.Windows.Forms.RichTextBox txtNIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxReceived;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtDhoniCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboVesselDown;
        private System.Windows.Forms.ComboBox comboVesselTop;
        private System.Windows.Forms.Label labelVessel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtFishNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtWeightAdj;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewFish;
        private System.Windows.Forms.DateTimePicker dateTimeReceive;
    }
}