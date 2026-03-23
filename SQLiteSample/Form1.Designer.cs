namespace SQLiteSample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnect = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCount = new System.Windows.Forms.Button();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.textBoxGr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btByFaculty = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btChooseDb = new System.Windows.Forms.Button();
            this.btByGroup = new System.Windows.Forms.Button();
            this.btReadAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(652, 157);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(652, 186);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(652, 216);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(652, 246);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(75, 23);
            this.btCount.TabIndex = 3;
            this.btCount.Text = "Count";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(45, 86);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(100, 20);
            this.textBoxFio.TabIndex = 4;
            // 
            // textBoxGr
            // 
            this.textBoxGr.Location = new System.Drawing.Point(151, 86);
            this.textBoxGr.Name = "textBoxGr";
            this.textBoxGr.Size = new System.Drawing.Size(100, 20);
            this.textBoxGr.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Группа";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 280);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(652, 41);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btByFaculty
            // 
            this.btByFaculty.Location = new System.Drawing.Point(522, 41);
            this.btByFaculty.Name = "btByFaculty";
            this.btByFaculty.Size = new System.Drawing.Size(102, 23);
            this.btByFaculty.TabIndex = 11;
            this.btByFaculty.Text = "По факультету";
            this.btByFaculty.UseVisualStyleBackColor = true;
            this.btByFaculty.Click += new System.EventHandler(this.btByFaculty_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(652, 12);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btChooseDb
            // 
            this.btChooseDb.Location = new System.Drawing.Point(522, 12);
            this.btChooseDb.Name = "btChooseDb";
            this.btChooseDb.Size = new System.Drawing.Size(102, 23);
            this.btChooseDb.TabIndex = 9;
            this.btChooseDb.Text = "Выбрать БД";
            this.btChooseDb.UseVisualStyleBackColor = true;
            this.btChooseDb.Click += new System.EventHandler(this.btChooseDb_Click);
            // 
            // btByGroup
            // 
            this.btByGroup.Location = new System.Drawing.Point(652, 70);
            this.btByGroup.Name = "btByGroup";
            this.btByGroup.Size = new System.Drawing.Size(94, 23);
            this.btByGroup.TabIndex = 14;
            this.btByGroup.Text = "По группе";
            this.btByGroup.UseVisualStyleBackColor = true;
            this.btByGroup.Click += new System.EventHandler(this.btByGroup_Click);
            // 
            // btReadAll
            // 
            this.btReadAll.Location = new System.Drawing.Point(522, 70);
            this.btReadAll.Name = "btReadAll";
            this.btReadAll.Size = new System.Drawing.Size(102, 23);
            this.btReadAll.TabIndex = 13;
            this.btReadAll.Text = "Все студенты";
            this.btReadAll.UseVisualStyleBackColor = true;
            this.btReadAll.Click += new System.EventHandler(this.btReadAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Факультет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(391, 86);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(100, 20);
            this.textBoxFaculty.TabIndex = 16;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(285, 86);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btByGroup);
            this.Controls.Add(this.btReadAll);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btByFaculty);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btChooseDb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGr);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.btCount);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.TextBox textBoxGr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btByFaculty;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btChooseDb;
        private System.Windows.Forms.Button btByGroup;
        private System.Windows.Forms.Button btReadAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.TextBox textBoxId;
    }
}

