namespace StudentsList
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
            this.dgwDeductedStudents = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeducted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDeduct = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeductedStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDeductedStudents
            // 
            this.dgwDeductedStudents.AllowUserToAddRows = false;
            this.dgwDeductedStudents.AllowUserToDeleteRows = false;
            this.dgwDeductedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDeductedStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Group,
            this.Subject,
            this.Mark,
            this.IsDeducted});
            this.dgwDeductedStudents.Location = new System.Drawing.Point(12, 40);
            this.dgwDeductedStudents.Name = "dgwDeductedStudents";
            this.dgwDeductedStudents.RowHeadersWidth = 51;
            this.dgwDeductedStudents.RowTemplate.Height = 24;
            this.dgwDeductedStudents.Size = new System.Drawing.Size(752, 296);
            this.dgwDeductedStudents.TabIndex = 12;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.MinimumWidth = 125;
            this.FullName.Name = "FullName";
            this.FullName.Width = 275;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 50;
            this.Group.Name = "Group";
            this.Group.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.MinimumWidth = 50;
            this.Subject.Name = "Subject";
            this.Subject.Width = 125;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Оценка";
            this.Mark.MinimumWidth = 25;
            this.Mark.Name = "Mark";
            this.Mark.Width = 75;
            // 
            // IsDeducted
            // 
            this.IsDeducted.HeaderText = "Отчислен";
            this.IsDeducted.MinimumWidth = 50;
            this.IsDeducted.Name = "IsDeducted";
            this.IsDeducted.ReadOnly = true;
            this.IsDeducted.Width = 75;
            // 
            // btDeduct
            // 
            this.btDeduct.Location = new System.Drawing.Point(539, 351);
            this.btDeduct.Name = "btDeduct";
            this.btDeduct.Size = new System.Drawing.Size(225, 43);
            this.btDeduct.TabIndex = 13;
            this.btDeduct.Text = "Отчислить  окончательно";
            this.btDeduct.UseVisualStyleBackColor = true;
            this.btDeduct.Click += new System.EventHandler(this.btDeduct_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(12, 354);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(117, 40);
            this.btReturn.TabIndex = 14;
            this.btReturn.Text = "Восстановить";
            this.toolTip2.SetToolTip(this.btReturn, "Восстановить студента");
            this.btReturn.UseMnemonic = false;
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 409);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btDeduct);
            this.Controls.Add(this.dgwDeductedStudents);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeductedStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDeductedStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeducted;
        private System.Windows.Forms.Button btDeduct;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}