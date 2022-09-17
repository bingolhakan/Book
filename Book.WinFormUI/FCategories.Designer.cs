namespace Book.WinFormUI
{
    partial class FCategories
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
            this.buttonCatDelete = new System.Windows.Forms.Button();
            this.buttonCatUpdate = new System.Windows.Forms.Button();
            this.buttonCatInsert = new System.Windows.Forms.Button();
            this.groupBoxCat = new System.Windows.Forms.GroupBox();
            this.textBoxCatID = new System.Windows.Forms.TextBox();
            this.labelCatName = new System.Windows.Forms.Label();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.labelCatID = new System.Windows.Forms.Label();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.groupBoxCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCatDelete
            // 
            this.buttonCatDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCatDelete.Location = new System.Drawing.Point(215, 380);
            this.buttonCatDelete.Name = "buttonCatDelete";
            this.buttonCatDelete.Size = new System.Drawing.Size(94, 41);
            this.buttonCatDelete.TabIndex = 12;
            this.buttonCatDelete.Text = "Delete";
            this.buttonCatDelete.UseVisualStyleBackColor = true;
            this.buttonCatDelete.Click += new System.EventHandler(this.buttonCatDelete_Click);
            // 
            // buttonCatUpdate
            // 
            this.buttonCatUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCatUpdate.Location = new System.Drawing.Point(115, 380);
            this.buttonCatUpdate.Name = "buttonCatUpdate";
            this.buttonCatUpdate.Size = new System.Drawing.Size(94, 41);
            this.buttonCatUpdate.TabIndex = 11;
            this.buttonCatUpdate.Text = "Update";
            this.buttonCatUpdate.UseVisualStyleBackColor = true;
            this.buttonCatUpdate.Click += new System.EventHandler(this.buttonCatUpdate_Click);
            // 
            // buttonCatInsert
            // 
            this.buttonCatInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCatInsert.Location = new System.Drawing.Point(15, 380);
            this.buttonCatInsert.Name = "buttonCatInsert";
            this.buttonCatInsert.Size = new System.Drawing.Size(94, 41);
            this.buttonCatInsert.TabIndex = 10;
            this.buttonCatInsert.Text = "Insert";
            this.buttonCatInsert.UseVisualStyleBackColor = true;
            this.buttonCatInsert.Click += new System.EventHandler(this.buttonCatInsert_Click);
            // 
            // groupBoxCat
            // 
            this.groupBoxCat.Controls.Add(this.textBoxCatID);
            this.groupBoxCat.Controls.Add(this.labelCatName);
            this.groupBoxCat.Controls.Add(this.textBoxCatName);
            this.groupBoxCat.Controls.Add(this.labelCatID);
            this.groupBoxCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCat.Location = new System.Drawing.Point(15, 29);
            this.groupBoxCat.Name = "groupBoxCat";
            this.groupBoxCat.Size = new System.Drawing.Size(773, 91);
            this.groupBoxCat.TabIndex = 9;
            this.groupBoxCat.TabStop = false;
            this.groupBoxCat.Text = "Categories";
            // 
            // textBoxCatID
            // 
            this.textBoxCatID.Location = new System.Drawing.Point(111, 36);
            this.textBoxCatID.Name = "textBoxCatID";
            this.textBoxCatID.Size = new System.Drawing.Size(83, 34);
            this.textBoxCatID.TabIndex = 5;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(246, 39);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(64, 28);
            this.labelCatName.TabIndex = 4;
            this.labelCatName.Text = "Name";
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(344, 33);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(369, 34);
            this.textBoxCatName.TabIndex = 3;
            this.textBoxCatName.TextChanged += new System.EventHandler(this.textBoxCatName_TextChanged);
            // 
            // labelCatID
            // 
            this.labelCatID.AutoSize = true;
            this.labelCatID.Location = new System.Drawing.Point(31, 39);
            this.labelCatID.Name = "labelCatID";
            this.labelCatID.Size = new System.Drawing.Size(31, 28);
            this.labelCatID.TabIndex = 1;
            this.labelCatID.Text = "ID";
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(11, 125);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersWidth = 51;
            this.dataGridViewCat.RowTemplate.Height = 29;
            this.dataGridViewCat.Size = new System.Drawing.Size(776, 241);
            this.dataGridViewCat.TabIndex = 8;
            this.dataGridViewCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCat_CellClick);
            this.dataGridViewCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCat_CellContentClick);
            // 
            // FCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonCatDelete);
            this.Controls.Add(this.buttonCatUpdate);
            this.Controls.Add(this.buttonCatInsert);
            this.Controls.Add(this.groupBoxCat);
            this.Controls.Add(this.dataGridViewCat);
            this.Name = "FCategories";
            this.Text = "Categories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCategories_FormClosed);
            this.Load += new System.EventHandler(this.FCategories_Load);
            this.groupBoxCat.ResumeLayout(false);
            this.groupBoxCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCatDelete;
        private Button buttonCatUpdate;
        private Button buttonCatInsert;
        private GroupBox groupBoxCat;
        private TextBox textBoxCatID;
        private Label labelCatName;
        private TextBox textBoxCatName;
        private Label labelCatID;
        private DataGridView dataGridViewCat;
    }
}