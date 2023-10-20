namespace HW1___StudentInfo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.datagridRecords = new System.Windows.Forms.DataGridView();
            this.buttonRecords = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textExpectedGrad = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.textProgram = new System.Windows.Forms.TextBox();
            this.labelExpectedGrad = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._StudentInfo___HW1DataSet = new HW1___StudentInfo._StudentInfo___HW1DataSet();
            this.studentInfoHW1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expecGradYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.labelDunwoody = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.textSearch2 = new System.Windows.Forms.TextBox();
            this.buttonRecords2 = new System.Windows.Forms.Button();
            this.datagridRecords2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._StudentInfo___HW1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoHW1DataSetBindingSource)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRecords2)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.Location = new System.Drawing.Point(239, 69);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(171, 103);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(96, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(171, 139);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgram.Location = new System.Drawing.Point(190, 176);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(76, 20);
            this.labelProgram.TabIndex = 3;
            this.labelProgram.Text = "Program";
            // 
            // datagridRecords
            // 
            this.datagridRecords.AutoGenerateColumns = false;
            this.datagridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.expecGradYearDataGridViewTextBoxColumn});
            this.datagridRecords.DataMember = "StudentInfo";
            this.datagridRecords.DataSource = this.studentInfoHW1DataSetBindingSource;
            this.datagridRecords.Location = new System.Drawing.Point(135, 389);
            this.datagridRecords.Name = "datagridRecords";
            this.datagridRecords.Size = new System.Drawing.Size(540, 157);
            this.datagridRecords.TabIndex = 5;
            this.datagridRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridRecords_CellContentClick);
            // 
            // buttonRecords
            // 
            this.buttonRecords.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRecords.Location = new System.Drawing.Point(335, 564);
            this.buttonRecords.Name = "buttonRecords";
            this.buttonRecords.Size = new System.Drawing.Size(160, 39);
            this.buttonRecords.TabIndex = 6;
            this.buttonRecords.Text = "Display all records";
            this.buttonRecords.UseVisualStyleBackColor = false;
            this.buttonRecords.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Maroon;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInsert.Location = new System.Drawing.Point(243, 280);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 33);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdate.Location = new System.Drawing.Point(383, 280);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 33);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(515, 280);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 33);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(287, 69);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(303, 20);
            this.textID.TabIndex = 11;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(287, 103);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(303, 20);
            this.textFirstName.TabIndex = 12;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(287, 141);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(303, 20);
            this.textLastName.TabIndex = 13;
            // 
            // textExpectedGrad
            // 
            this.textExpectedGrad.Location = new System.Drawing.Point(287, 217);
            this.textExpectedGrad.Multiline = true;
            this.textExpectedGrad.Name = "textExpectedGrad";
            this.textExpectedGrad.Size = new System.Drawing.Size(303, 20);
            this.textExpectedGrad.TabIndex = 14;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(192, 350);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(398, 20);
            this.textSearch.TabIndex = 15;
            // 
            // textProgram
            // 
            this.textProgram.Location = new System.Drawing.Point(287, 178);
            this.textProgram.Name = "textProgram";
            this.textProgram.Size = new System.Drawing.Size(303, 20);
            this.textProgram.TabIndex = 16;
            // 
            // labelExpectedGrad
            // 
            this.labelExpectedGrad.AutoSize = true;
            this.labelExpectedGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpectedGrad.Location = new System.Drawing.Point(95, 215);
            this.labelExpectedGrad.Name = "labelExpectedGrad";
            this.labelExpectedGrad.Size = new System.Drawing.Size(172, 20);
            this.labelExpectedGrad.TabIndex = 17;
            this.labelExpectedGrad.Text = "Expected Grad Year";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.Location = new System.Drawing.Point(610, 345);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 29);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // _StudentInfo___HW1DataSet
            // 
            this._StudentInfo___HW1DataSet.DataSetName = "_StudentInfo___HW1DataSet";
            this._StudentInfo___HW1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoHW1DataSetBindingSource
            // 
            this.studentInfoHW1DataSetBindingSource.DataSource = this._StudentInfo___HW1DataSet;
            this.studentInfoHW1DataSetBindingSource.Position = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // expecGradYearDataGridViewTextBoxColumn
            // 
            this.expecGradYearDataGridViewTextBoxColumn.DataPropertyName = "Expec_Grad_Year";
            this.expecGradYearDataGridViewTextBoxColumn.HeaderText = "Expec_Grad_Year";
            this.expecGradYearDataGridViewTextBoxColumn.Name = "expecGradYearDataGridViewTextBoxColumn";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkRed;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout.Location = new System.Drawing.Point(663, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(92, 33);
            this.buttonLogout.TabIndex = 21;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.buttonLogin);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.buttonSearch2);
            this.LoginPanel.Controls.Add(this.textSearch2);
            this.LoginPanel.Controls.Add(this.buttonRecords2);
            this.LoginPanel.Controls.Add(this.datagridRecords2);
            this.LoginPanel.Controls.Add(this.labelDunwoody);
            this.LoginPanel.Location = new System.Drawing.Point(2, -8);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(769, 654);
            this.LoginPanel.TabIndex = 22;
            // 
            // labelDunwoody
            // 
            this.labelDunwoody.AutoSize = true;
            this.labelDunwoody.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDunwoody.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDunwoody.Location = new System.Drawing.Point(116, 110);
            this.labelDunwoody.Name = "labelDunwoody";
            this.labelDunwoody.Size = new System.Drawing.Size(544, 37);
            this.labelDunwoody.TabIndex = 27;
            this.labelDunwoody.Text = "Dunwoody College of Technology";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkRed;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Location = new System.Drawing.Point(194, 429);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(160, 39);
            this.buttonLogin.TabIndex = 33;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 51);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch2.Location = new System.Drawing.Point(578, 199);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(87, 29);
            this.buttonSearch2.TabIndex = 31;
            this.buttonSearch2.Text = "Search";
            this.buttonSearch2.UseVisualStyleBackColor = false;
            // 
            // textSearch2
            // 
            this.textSearch2.Location = new System.Drawing.Point(160, 204);
            this.textSearch2.Name = "textSearch2";
            this.textSearch2.Size = new System.Drawing.Size(398, 20);
            this.textSearch2.TabIndex = 30;
            // 
            // buttonRecords2
            // 
            this.buttonRecords2.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRecords2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecords2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRecords2.Location = new System.Drawing.Point(388, 429);
            this.buttonRecords2.Name = "buttonRecords2";
            this.buttonRecords2.Size = new System.Drawing.Size(160, 39);
            this.buttonRecords2.TabIndex = 29;
            this.buttonRecords2.Text = "Display all records";
            this.buttonRecords2.UseVisualStyleBackColor = false;
            // 
            // datagridRecords2
            // 
            this.datagridRecords2.AutoGenerateColumns = false;
            this.datagridRecords2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRecords2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.datagridRecords2.DataMember = "StudentInfo";
            this.datagridRecords2.DataSource = this.studentInfoHW1DataSetBindingSource;
            this.datagridRecords2.Location = new System.Drawing.Point(103, 243);
            this.datagridRecords2.Name = "datagridRecords2";
            this.datagridRecords2.Size = new System.Drawing.Size(540, 157);
            this.datagridRecords2.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn4.HeaderText = "Program";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Expec_Grad_Year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Expec_Grad_Year";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(767, 628);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelExpectedGrad);
            this.Controls.Add(this.textProgram);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.textExpectedGrad);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonRecords);
            this.Controls.Add(this.datagridRecords);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.ID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._StudentInfo___HW1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoHW1DataSetBindingSource)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRecords2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.DataGridView datagridRecords;
        private System.Windows.Forms.Button buttonRecords;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textExpectedGrad;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.TextBox textProgram;
        private System.Windows.Forms.Label labelExpectedGrad;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expecGradYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentInfoHW1DataSetBindingSource;
        private _StudentInfo___HW1DataSet _StudentInfo___HW1DataSet;
        private System.Windows.Forms.Button buttonLogout;
        public System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.TextBox textSearch2;
        private System.Windows.Forms.Button buttonRecords2;
        private System.Windows.Forms.DataGridView datagridRecords2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label labelDunwoody;
    }
}