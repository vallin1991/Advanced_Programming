namespace PolyShelter
{
    partial class Form1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSterilized = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedigree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccine3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(306, 49);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 19);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(325, 311);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(56, 19);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petName,
            this.petType,
            this.petPhoto,
            this.color,
            this.gender,
            this.isSterilized,
            this.pedigree,
            this.date_Entry,
            this.vaccine1,
            this.vaccine2,
            this.vaccine3});
            this.patientDataGridView.Location = new System.Drawing.Point(12, 101);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(346, 182);
            this.patientDataGridView.TabIndex = 9;
            // 
            // datePicker2
            // 
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker2.Location = new System.Drawing.Point(192, 49);
            this.datePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(86, 20);
            this.datePicker2.TabIndex = 8;
            // 
            // datePicker1
            // 
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker1.Location = new System.Drawing.Point(86, 48);
            this.datePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(88, 20);
            this.datePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Official Report";
            // 
            // petName
            // 
            this.petName.HeaderText = "Pet Name";
            this.petName.Name = "petName";
            this.petName.ReadOnly = true;
            // 
            // petType
            // 
            this.petType.HeaderText = "Pet Type";
            this.petType.Name = "petType";
            this.petType.ReadOnly = true;
            // 
            // petPhoto
            // 
            this.petPhoto.HeaderText = "Pet Photo";
            this.petPhoto.Name = "petPhoto";
            this.petPhoto.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // isSterilized
            // 
            this.isSterilized.HeaderText = "IsSterilized";
            this.isSterilized.Name = "isSterilized";
            this.isSterilized.ReadOnly = true;
            // 
            // pedigree
            // 
            this.pedigree.HeaderText = "Pedigree";
            this.pedigree.Name = "pedigree";
            this.pedigree.ReadOnly = true;
            // 
            // date_Entry
            // 
            this.date_Entry.HeaderText = "Date Entry";
            this.date_Entry.Name = "date_Entry";
            this.date_Entry.ReadOnly = true;
            // 
            // vaccine1
            // 
            this.vaccine1.HeaderText = "Vaccine1";
            this.vaccine1.Name = "vaccine1";
            this.vaccine1.ReadOnly = true;
            // 
            // vaccine2
            // 
            this.vaccine2.HeaderText = "Vaccine2";
            this.vaccine2.Name = "vaccine2";
            this.vaccine2.ReadOnly = true;
            // 
            // vaccine3
            // 
            this.vaccine3.HeaderText = "Vaccine3";
            this.vaccine3.Name = "vaccine3";
            this.vaccine3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 358);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.datePicker2);
            this.Controls.Add(this.datePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn petName;
        private System.Windows.Forms.DataGridViewTextBoxColumn petType;
        private System.Windows.Forms.DataGridViewTextBoxColumn petPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn isSterilized;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedigree;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_Entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccine3;
    }
}