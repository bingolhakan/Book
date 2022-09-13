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
            this.buttonCatDelete.Location = new System.Drawing.Point(188, 285);
            this.buttonCatDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCatDelete.Name = "buttonCatDelete";
            this.buttonCatDelete.Size = new System.Drawing.Size(82, 31);
            this.buttonCatDelete.TabIndex = 12;
            this.buttonCatDelete.Text = "Delete";
            this.buttonCatDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCatUpdate
            // 
            this.buttonCatUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCatUpdate.Location = new System.Drawing.Point(101, 285);
            this.buttonCatUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCatUpdate.Name = "buttonCatUpdate";
            this.buttonCatUpdate.Size = new System.Drawing.Size(82, 31);
            this.buttonCatUpdate.TabIndex = 11;
            this.buttonCatUpdate.Text = "Update";
            this.buttonCatUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonCatInsert
            // 
            this.buttonCatInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCatInsert.Location = new System.Drawing.Point(13, 285);
            this.buttonCatInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCatInsert.Name = "buttonCatInsert";
            this.buttonCatInsert.Size = new System.Drawing.Size(82, 31);
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
            this.groupBoxCat.Location = new System.Drawing.Point(13, 22);
            this.groupBoxCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCat.Name = "groupBoxCat";
            this.groupBoxCat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCat.Size = new System.Drawing.Size(676, 68);
            this.groupBoxCat.TabIndex = 9;
            this.groupBoxCat.TabStop = false;
            this.groupBoxCat.Text = "Categories";
            // 
            // textBoxCatID
            // 
            this.textBoxCatID.Location = new System.Drawing.Point(97, 27);
            this.textBoxCatID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCatID.Name = "textBoxCatID";
            this.textBoxCatID.Size = new System.Drawing.Size(73, 29);
            this.textBoxCatID.TabIndex = 5;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(215, 29);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(52, 21);
            this.labelCatName.TabIndex = 4;
            this.labelCatName.Text = "Name";
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(301, 25);
            this.textBoxCatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(323, 29);
            this.textBoxCatName.TabIndex = 3;
            // 
            // labelCatID
            // 
            this.labelCatID.AutoSize = true;
            this.labelCatID.Location = new System.Drawing.Point(27, 29);
            this.labelCatID.Name = "labelCatID";
            this.labelCatID.Size = new System.Drawing.Size(25, 21);
            this.labelCatID.TabIndex = 1;
            this.labelCatID.Text = "ID";
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(10, 94);
            this.dataGridViewCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersWidth = 51;
            this.dataGridViewCat.RowTemplate.Height = 29;
            this.dataGridViewCat.Size = new System.Drawing.Size(679, 181);
            this.dataGridViewCat.TabIndex = 8;
            // 
            // FCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonCatDelete);
            this.Controls.Add(this.buttonCatUpdate);
            this.Controls.Add(this.buttonCatInsert);
            this.Controls.Add(this.groupBoxCat);
            this.Controls.Add(this.dataGridViewCat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FCategories";
            this.Text = "Categories";
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