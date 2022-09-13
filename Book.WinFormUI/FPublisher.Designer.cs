namespace Book.WinFormUI
{
    partial class FPublisher
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
            this.textBoxPubName = new System.Windows.Forms.TextBox();
            this.buttonPubDelete = new System.Windows.Forms.Button();
            this.buttonPubUpdate = new System.Windows.Forms.Button();
            this.buttonPubInsert = new System.Windows.Forms.Button();
            this.groupBoxPub = new System.Windows.Forms.GroupBox();
            this.textBoxPubID = new System.Windows.Forms.TextBox();
            this.labelPubName = new System.Windows.Forms.Label();
            this.labelPubID = new System.Windows.Forms.Label();
            this.dataGridViewPub = new System.Windows.Forms.DataGridView();
            this.groupBoxPub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPubName
            // 
            this.textBoxPubName.Location = new System.Drawing.Point(344, 33);
            this.textBoxPubName.Name = "textBoxPubName";
            this.textBoxPubName.Size = new System.Drawing.Size(369, 34);
            this.textBoxPubName.TabIndex = 3;
            // 
            // buttonPubDelete
            // 
            this.buttonPubDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPubDelete.Location = new System.Drawing.Point(214, 365);
            this.buttonPubDelete.Name = "buttonPubDelete";
            this.buttonPubDelete.Size = new System.Drawing.Size(94, 41);
            this.buttonPubDelete.TabIndex = 17;
            this.buttonPubDelete.Text = "Delete";
            this.buttonPubDelete.UseVisualStyleBackColor = true;
            // 
            // buttonPubUpdate
            // 
            this.buttonPubUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPubUpdate.Location = new System.Drawing.Point(114, 365);
            this.buttonPubUpdate.Name = "buttonPubUpdate";
            this.buttonPubUpdate.Size = new System.Drawing.Size(94, 41);
            this.buttonPubUpdate.TabIndex = 16;
            this.buttonPubUpdate.Text = "Update";
            this.buttonPubUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonPubInsert
            // 
            this.buttonPubInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPubInsert.Location = new System.Drawing.Point(14, 365);
            this.buttonPubInsert.Name = "buttonPubInsert";
            this.buttonPubInsert.Size = new System.Drawing.Size(94, 41);
            this.buttonPubInsert.TabIndex = 15;
            this.buttonPubInsert.Text = "Insert";
            this.buttonPubInsert.UseVisualStyleBackColor = true;
            this.buttonPubInsert.Click += new System.EventHandler(this.buttonPubInsert_Click);
            // 
            // groupBoxPub
            // 
            this.groupBoxPub.Controls.Add(this.textBoxPubID);
            this.groupBoxPub.Controls.Add(this.labelPubName);
            this.groupBoxPub.Controls.Add(this.textBoxPubName);
            this.groupBoxPub.Controls.Add(this.labelPubID);
            this.groupBoxPub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPub.Location = new System.Drawing.Point(14, 15);
            this.groupBoxPub.Name = "groupBoxPub";
            this.groupBoxPub.Size = new System.Drawing.Size(773, 91);
            this.groupBoxPub.TabIndex = 14;
            this.groupBoxPub.TabStop = false;
            this.groupBoxPub.Text = "Publishers";
            // 
            // textBoxPubID
            // 
            this.textBoxPubID.Location = new System.Drawing.Point(111, 36);
            this.textBoxPubID.Name = "textBoxPubID";
            this.textBoxPubID.Size = new System.Drawing.Size(83, 34);
            this.textBoxPubID.TabIndex = 5;
            // 
            // labelPubName
            // 
            this.labelPubName.AutoSize = true;
            this.labelPubName.Location = new System.Drawing.Point(246, 37);
            this.labelPubName.Name = "labelPubName";
            this.labelPubName.Size = new System.Drawing.Size(64, 28);
            this.labelPubName.TabIndex = 4;
            this.labelPubName.Text = "Name";
            // 
            // labelPubID
            // 
            this.labelPubID.AutoSize = true;
            this.labelPubID.Location = new System.Drawing.Point(31, 37);
            this.labelPubID.Name = "labelPubID";
            this.labelPubID.Size = new System.Drawing.Size(31, 28);
            this.labelPubID.TabIndex = 1;
            this.labelPubID.Text = "ID";
            // 
            // dataGridViewPub
            // 
            this.dataGridViewPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPub.Location = new System.Drawing.Point(10, 111);
            this.dataGridViewPub.Name = "dataGridViewPub";
            this.dataGridViewPub.RowHeadersWidth = 51;
            this.dataGridViewPub.RowTemplate.Height = 29;
            this.dataGridViewPub.Size = new System.Drawing.Size(776, 241);
            this.dataGridViewPub.TabIndex = 13;
            // 
            // FPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 419);
            this.Controls.Add(this.buttonPubDelete);
            this.Controls.Add(this.buttonPubUpdate);
            this.Controls.Add(this.buttonPubInsert);
            this.Controls.Add(this.groupBoxPub);
            this.Controls.Add(this.dataGridViewPub);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FPublisher";
            this.Text = "FPublisher";
            this.Load += new System.EventHandler(this.FPublisher_Load);
            this.groupBoxPub.ResumeLayout(false);
            this.groupBoxPub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxPubName;
        private Button buttonPubDelete;
        private Button buttonPubUpdate;
        private Button buttonPubInsert;
        private GroupBox groupBoxPub;
        private TextBox textBoxPubID;
        private Label labelPubName;
        private Label labelPubID;
        private DataGridView dataGridViewPub;
    }
}