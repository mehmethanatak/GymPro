namespace GymPro
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEqName = new System.Windows.Forms.TextBox();
            this.txtMuscle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDel = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(177, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(199, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Muscles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost:";
            // 
            // txtEqName
            // 
            this.txtEqName.Location = new System.Drawing.Point(308, 35);
            this.txtEqName.Name = "txtEqName";
            this.txtEqName.Size = new System.Drawing.Size(266, 27);
            this.txtEqName.TabIndex = 5;
            // 
            // txtMuscle
            // 
            this.txtMuscle.Location = new System.Drawing.Point(308, 258);
            this.txtMuscle.Name = "txtMuscle";
            this.txtMuscle.Size = new System.Drawing.Size(266, 27);
            this.txtMuscle.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(308, 108);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(266, 120);
            this.txtDesc.TabIndex = 7;
            this.txtDesc.Text = "";
            // 
            // dateTimePickerDel
            // 
            this.dateTimePickerDel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDel.Location = new System.Drawing.Point(308, 330);
            this.dateTimePickerDel.Name = "dateTimePickerDel";
            this.dateTimePickerDel.Size = new System.Drawing.Size(266, 27);
            this.dateTimePickerDel.TabIndex = 8;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(159, 388);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(266, 27);
            this.txtCost.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(308, 465);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(94, 29);
            this.btnRes.TabIndex = 11;
            this.btnRes.Text = "Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(453, 465);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(169, 29);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View Equipments";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(849, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 47);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete Equipment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(511, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Member ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMID
            // 
            this.txtMID.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMID.Location = new System.Drawing.Point(712, 389);
            this.txtMID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(163, 32);
            this.txtMID.TabIndex = 49;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(918, 533);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.dateTimePickerDel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtMuscle);
            this.Controls.Add(this.txtEqName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEqName;
        private TextBox txtMuscle;
        private RichTextBox txtDesc;
        private DateTimePicker dateTimePickerDel;
        private TextBox txtCost;
        private Button btnSave;
        private Button btnRes;
        private Button btnView;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox txtMID;
    }
}