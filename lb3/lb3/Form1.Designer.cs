namespace lb3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.prodAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.prodDataSet1 = new lb3.prodDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"H:\\БГУИР 672302\\C#\\lb3\\db.mdb\"";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT id,datebuy,nameprod,cost\r\nFROM prod";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `prod` (`datebuy`, `nameprod`, `cost`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("datebuy", System.Data.OleDb.OleDbType.Date, 0, "datebuy"),
            new System.Data.OleDb.OleDbParameter("nameprod", System.Data.OleDb.OleDbType.VarWChar, 0, "nameprod"),
            new System.Data.OleDb.OleDbParameter("cost", System.Data.OleDb.OleDbType.Integer, 0, "cost")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("datebuy", System.Data.OleDb.OleDbType.Date, 0, "datebuy"),
            new System.Data.OleDb.OleDbParameter("nameprod", System.Data.OleDb.OleDbType.VarWChar, 0, "nameprod"),
            new System.Data.OleDb.OleDbParameter("cost", System.Data.OleDb.OleDbType.Integer, 0, "cost"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_datebuy", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "datebuy", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_datebuy", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "datebuy", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nameprod", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nameprod", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nameprod", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nameprod", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cost", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cost", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `prod` WHERE ((`id` = ?) AND ((? = 1 AND `datebuy` IS NULL) OR (`date" +
    "buy` = ?)) AND ((? = 1 AND `nameprod` IS NULL) OR (`nameprod` = ?)) AND ((? = 1 " +
    "AND `cost` IS NULL) OR (`cost` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_datebuy", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "datebuy", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_datebuy", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "datebuy", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nameprod", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nameprod", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nameprod", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nameprod", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cost", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cost", System.Data.DataRowVersion.Original, null)});
            // 
            // prodAdapter
            // 
            this.prodAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.prodAdapter.InsertCommand = this.oleDbInsertCommand1;
            this.prodAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.prodAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "prod", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("datebuy", "datebuy"),
                        new System.Data.Common.DataColumnMapping("nameprod", "nameprod"),
                        new System.Data.Common.DataColumnMapping("cost", "cost")})});
            this.prodAdapter.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // prodDataSet1
            // 
            this.prodDataSet1.DataSetName = "prodDataSet";
            this.prodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datebuyDataGridViewTextBoxColumn,
            this.nameprodDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // prodDataSet1BindingSource
            // 
            this.prodDataSet1BindingSource.DataSource = this.prodDataSet1;
            this.prodDataSet1BindingSource.Position = 0;
            // 
            // prodBindingSource
            // 
            this.prodBindingSource.DataMember = "prod";
            this.prodBindingSource.DataSource = this.prodDataSet1BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // datebuyDataGridViewTextBoxColumn
            // 
            this.datebuyDataGridViewTextBoxColumn.DataPropertyName = "datebuy";
            this.datebuyDataGridViewTextBoxColumn.HeaderText = "datebuy";
            this.datebuyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datebuyDataGridViewTextBoxColumn.Name = "datebuyDataGridViewTextBoxColumn";
            this.datebuyDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameprodDataGridViewTextBoxColumn
            // 
            this.nameprodDataGridViewTextBoxColumn.DataPropertyName = "nameprod";
            this.nameprodDataGridViewTextBoxColumn.HeaderText = "nameprod";
            this.nameprodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameprodDataGridViewTextBoxColumn.Name = "nameprodDataGridViewTextBoxColumn";
            this.nameprodDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(47, 239);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(155, 239);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(264, 239);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(367, 239);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(75, 23);
            this.btn_excel.TabIndex = 4;
            this.btn_excel.Text = "To excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.Btn_excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 315);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter prodAdapter;
        private prodDataSet prodDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prodBindingSource;
        private System.Windows.Forms.BindingSource prodDataSet1BindingSource;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_excel;
    }
}

