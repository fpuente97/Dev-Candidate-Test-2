namespace Dev_Candidate_Test_2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmps = new System.Windows.Forms.DataGridView();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnFilter = new System.Windows.Forms.Button();
            this.bttnDateDesc = new System.Windows.Forms.RadioButton();
            this.bttnDateAsc = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmps
            // 
            this.dgvEmps.AllowUserToAddRows = false;
            this.dgvEmps.AllowUserToDeleteRows = false;
            this.dgvEmps.AllowUserToResizeColumns = false;
            this.dgvEmps.AllowUserToResizeRows = false;
            this.dgvEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmps.Location = new System.Drawing.Point(15, 134);
            this.dgvEmps.MultiSelect = false;
            this.dgvEmps.Name = "dgvEmps";
            this.dgvEmps.RowHeadersVisible = false;
            this.dgvEmps.RowTemplate.Height = 25;
            this.dgvEmps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmps.Size = new System.Drawing.Size(614, 299);
            this.dgvEmps.TabIndex = 0;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(14, 13);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(614, 23);
            this.bttnAdd.TabIndex = 7;
            this.bttnAdd.Text = "Add Employee";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(14, 42);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(614, 23);
            this.bttnEdit.TabIndex = 15;
            this.bttnEdit.Text = "Edit Selection";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 23);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filter by Name";
            // 
            // bttnFilter
            // 
            this.bttnFilter.Location = new System.Drawing.Point(339, 94);
            this.bttnFilter.Name = "bttnFilter";
            this.bttnFilter.Size = new System.Drawing.Size(75, 23);
            this.bttnFilter.TabIndex = 18;
            this.bttnFilter.Text = "Filter";
            this.bttnFilter.UseVisualStyleBackColor = true;
            this.bttnFilter.Click += new System.EventHandler(this.bttnFilter_Click);
            // 
            // bttnDateDesc
            // 
            this.bttnDateDesc.AutoSize = true;
            this.bttnDateDesc.Location = new System.Drawing.Point(527, 96);
            this.bttnDateDesc.Name = "bttnDateDesc";
            this.bttnDateDesc.Size = new System.Drawing.Size(87, 19);
            this.bttnDateDesc.TabIndex = 19;
            this.bttnDateDesc.TabStop = true;
            this.bttnDateDesc.Text = "Descending";
            this.bttnDateDesc.UseVisualStyleBackColor = true;
            this.bttnDateDesc.Click += new System.EventHandler(this.bttnDateDesc_Click);
            // 
            // bttnDateAsc
            // 
            this.bttnDateAsc.AutoSize = true;
            this.bttnDateAsc.Location = new System.Drawing.Point(440, 96);
            this.bttnDateAsc.Name = "bttnDateAsc";
            this.bttnDateAsc.Size = new System.Drawing.Size(81, 19);
            this.bttnDateAsc.TabIndex = 20;
            this.bttnDateAsc.TabStop = true;
            this.bttnDateAsc.Text = "Ascending";
            this.bttnDateAsc.UseVisualStyleBackColor = true;
            this.bttnDateAsc.Click += new System.EventHandler(this.bttnDateAsc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order by Born Date";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnDateAsc);
            this.Controls.Add(this.bttnDateDesc);
            this.Controls.Add(this.bttnFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.dgvEmps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Employees List";
            this.Activated += new System.EventHandler(this.Main_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvEmps;
        private Button bttnAdd;
        private Button bttnEdit;
        private TextBox txtName;
        private Label label1;
        private Button bttnFilter;
        private RadioButton bttnDateDesc;
        private RadioButton bttnDateAsc;
        private Label label2;
    }
}