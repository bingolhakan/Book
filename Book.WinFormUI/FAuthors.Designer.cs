namespace Book.WinFormUI
{
    partial class FAuthors
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
            this.buttonAutDelete = new System.Windows.Forms.Button();
            this.buttonAutUpdate = new System.Windows.Forms.Button();
            this.buttonAutInsert = new System.Windows.Forms.Button();
            this.groupBoxAut = new System.Windows.Forms.GroupBox();
            this.textBoxAutID = new System.Windows.Forms.TextBox();
            this.labelAutName = new System.Windows.Forms.Label();
            this.textBoxAutName = new System.Windows.Forms.TextBox();
            this.labelAutID = new System.Windows.Forms.Label();
            this.dataGridViewAut = new System.Windows.Forms.DataGridView();
            this.groupBoxAut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAut)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAutDelete
            // 
            this.buttonAutDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAutDelete.Location = new System.Drawing.Point(214, 365);
            this.buttonAutDelete.Name = "buttonAutDelete";
            this.buttonAutDelete.Size = new System.Drawing.Size(94, 41);
            this.buttonAutDelete.TabIndex = 17;
            this.buttonAutDelete.Text = "Delete";
            this.buttonAutDelete.UseVisualStyleBackColor = true;
            this.buttonAutDelete.Click += new System.EventHandler(this.buttonAutDelete_Click);
            // 
            // buttonAutUpdate
            // 
            this.buttonAutUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAutUpdate.Location = new System.Drawing.Point(114, 365);
            this.buttonAutUpdate.Name = "buttonAutUpdate";
            this.buttonAutUpdate.Size = new System.Drawing.Size(94, 41);
            this.buttonAutUpdate.TabIndex = 16;
            this.buttonAutUpdate.Text = "Update";
            this.buttonAutUpdate.UseVisualStyleBackColor = true;
            this.buttonAutUpdate.Click += new System.EventHandler(this.buttonAutUpdate_Click);
            // 
            // buttonAutInsert
            // 
            this.buttonAutInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAutInsert.Location = new System.Drawing.Point(14, 365);
            this.buttonAutInsert.Name = "buttonAutInsert";
            this.buttonAutInsert.Size = new System.Drawing.Size(94, 41);
            this.buttonAutInsert.TabIndex = 15;
            this.buttonAutInsert.Text = "Insert";
            this.buttonAutInsert.UseVisualStyleBackColor = true;
            this.buttonAutInsert.Click += new System.EventHandler(this.buttonAutInsert_Click);
            // 
            // groupBoxAut
            // 
            this.groupBoxAut.Controls.Add(this.textBoxAutID);
            this.groupBoxAut.Controls.Add(this.labelAutName);
            this.groupBoxAut.Controls.Add(this.textBoxAutName);
            this.groupBoxAut.Controls.Add(this.labelAutID);
            this.groupBoxAut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAut.Location = new System.Drawing.Point(14, 15);
            this.groupBoxAut.Name = "groupBoxAut";
            this.groupBoxAut.Size = new System.Drawing.Size(773, 91);
            this.groupBoxAut.TabIndex = 14;
            this.groupBoxAut.TabStop = false;
            this.groupBoxAut.Text = "Authors";
            this.groupBoxAut.Enter += new System.EventHandler(this.groupBoxAut_Enter);
            // 
            // textBoxAutID
            // 
            this.textBoxAutID.Location = new System.Drawing.Point(111, 36);
            this.textBoxAutID.Name = "textBoxAutID";
            this.textBoxAutID.Size = new System.Drawing.Size(83, 34);
            this.textBoxAutID.TabIndex = 5;
            // 
            // labelAutName
            // 
            this.labelAutName.AutoSize = true;
            this.labelAutName.Location = new System.Drawing.Point(246, 37);
            this.labelAutName.Name = "labelAutName";
            this.labelAutName.Size = new System.Drawing.Size(64, 28);
            this.labelAutName.TabIndex = 4;
            this.labelAutName.Text = "Name";
            // 
            // textBoxAutName
            // 
            this.textBoxAutName.Location = new System.Drawing.Point(344, 33);
            this.textBoxAutName.Name = "textBoxAutName";
            this.textBoxAutName.Size = new System.Drawing.Size(369, 34);
            this.textBoxAutName.TabIndex = 3;
            this.textBoxAutName.TextChanged += new System.EventHandler(this.textBoxAutName_TextChanged);
            // 
            // labelAutID
            // 
            this.labelAutID.AutoSize = true;
            this.labelAutID.Location = new System.Drawing.Point(31, 37);
            this.labelAutID.Name = "labelAutID";
            this.labelAutID.Size = new System.Drawing.Size(31, 28);
            this.labelAutID.TabIndex = 1;
            this.labelAutID.Text = "ID";
            // 
            // dataGridViewAut
            // 
            this.dataGridViewAut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAut.Location = new System.Drawing.Point(10, 111);
            this.dataGridViewAut.Name = "dataGridViewAut";
            this.dataGridViewAut.RowHeadersWidth = 51;
            this.dataGridViewAut.RowTemplate.Height = 29;
            this.dataGridViewAut.Size = new System.Drawing.Size(776, 241);
            this.dataGridViewAut.TabIndex = 13;
            this.dataGridViewAut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAut_CellClick);
            this.dataGridViewAut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAut_CellContentClick);
            // 
            // FAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 425);
            this.Controls.Add(this.buttonAutDelete);
            this.Controls.Add(this.buttonAutUpdate);
            this.Controls.Add(this.buttonAutInsert);
            this.Controls.Add(this.groupBoxAut);
            this.Controls.Add(this.dataGridViewAut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FAuthors";
            this.Text = "FAuthors";
            this.Load += new System.EventHandler(this.FAuthors_Load);
            this.groupBoxAut.ResumeLayout(false);
            this.groupBoxAut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAutDelete;
        private Button buttonAutUpdate;
        private Button buttonAutInsert;
        private GroupBox groupBoxAut;
        private TextBox textBoxAutID;
        private Label labelAutName;
        private TextBox textBoxAutName;
        private Label labelAutID;
        private DataGridView dataGridViewAut;
    }
}