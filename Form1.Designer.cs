namespace StudentsList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btInFileSelect = new System.Windows.Forms.Button();
            this.tbInFileName = new System.Windows.Forms.TextBox();
            this.tbOutFileName = new System.Windows.Forms.TextBox();
            this.btOutFileSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialogIn = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOut = new System.Windows.Forms.SaveFileDialog();
            this.cbRestoreState = new System.Windows.Forms.CheckBox();
            this.cbCyclicScrolling = new System.Windows.Forms.CheckBox();
            this.cbEnableDuplicateName = new System.Windows.Forms.CheckBox();
            this.cbShowDeducted = new System.Windows.Forms.CheckBox();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClear = new System.Windows.Forms.Button();
            this.btFirstRecord = new System.Windows.Forms.Button();
            this.btPrevRecord = new System.Windows.Forms.Button();
            this.btNextRecord = new System.Windows.Forms.Button();
            this.btLastRecord = new System.Windows.Forms.Button();
            this.btCreateRecord = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btDeduct = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "F&ile";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "L&oad";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDeletedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showDeletedToolStripMenuItem
            // 
            this.showDeletedToolStripMenuItem.Name = "showDeletedToolStripMenuItem";
            this.showDeletedToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.showDeletedToolStripMenuItem.Text = "Show deducted";
            this.showDeletedToolStripMenuItem.Click += new System.EventHandler(this.showDeletedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "In";
            // 
            // btInFileSelect
            // 
            this.btInFileSelect.Location = new System.Drawing.Point(489, 54);
            this.btInFileSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btInFileSelect.Name = "btInFileSelect";
            this.btInFileSelect.Size = new System.Drawing.Size(100, 28);
            this.btInFileSelect.TabIndex = 2;
            this.btInFileSelect.Text = "...";
            this.btInFileSelect.UseVisualStyleBackColor = true;
            this.btInFileSelect.Click += new System.EventHandler(this.btInFileSelect_Click);
            // 
            // tbInFileName
            // 
            this.tbInFileName.Location = new System.Drawing.Point(172, 59);
            this.tbInFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbInFileName.Name = "tbInFileName";
            this.tbInFileName.Size = new System.Drawing.Size(288, 22);
            this.tbInFileName.TabIndex = 3;
            // 
            // tbOutFileName
            // 
            this.tbOutFileName.Location = new System.Drawing.Point(172, 102);
            this.tbOutFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutFileName.Name = "tbOutFileName";
            this.tbOutFileName.Size = new System.Drawing.Size(288, 22);
            this.tbOutFileName.TabIndex = 6;
            // 
            // btOutFileSelect
            // 
            this.btOutFileSelect.Location = new System.Drawing.Point(489, 97);
            this.btOutFileSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btOutFileSelect.Name = "btOutFileSelect";
            this.btOutFileSelect.Size = new System.Drawing.Size(100, 28);
            this.btOutFileSelect.TabIndex = 5;
            this.btOutFileSelect.Text = "...";
            this.btOutFileSelect.UseVisualStyleBackColor = true;
            this.btOutFileSelect.Click += new System.EventHandler(this.btOutFileSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Out";
            // 
            // openFileDialogIn
            // 
            this.openFileDialogIn.FileName = "openFileDialog1";
            this.openFileDialogIn.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogIn_FileOk);
            // 
            // saveFileDialogOut
            // 
            this.saveFileDialogOut.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogOut_FileOk);
            // 
            // cbRestoreState
            // 
            this.cbRestoreState.AutoSize = true;
            this.cbRestoreState.Location = new System.Drawing.Point(60, 364);
            this.cbRestoreState.Name = "cbRestoreState";
            this.cbRestoreState.Size = new System.Drawing.Size(217, 21);
            this.cbRestoreState.TabIndex = 7;
            this.cbRestoreState.Text = "Восстанавливать состояние";
            this.cbRestoreState.UseVisualStyleBackColor = true;
            // 
            // cbCyclicScrolling
            // 
            this.cbCyclicScrolling.AutoSize = true;
            this.cbCyclicScrolling.Location = new System.Drawing.Point(60, 401);
            this.cbCyclicScrolling.Name = "cbCyclicScrolling";
            this.cbCyclicScrolling.Size = new System.Drawing.Size(239, 21);
            this.cbCyclicScrolling.TabIndex = 8;
            this.cbCyclicScrolling.Text = "Циклическая прокрутка списка";
            this.cbCyclicScrolling.UseVisualStyleBackColor = true;
            // 
            // cbEnableDuplicateName
            // 
            this.cbEnableDuplicateName.AutoSize = true;
            this.cbEnableDuplicateName.Location = new System.Drawing.Point(60, 440);
            this.cbEnableDuplicateName.Name = "cbEnableDuplicateName";
            this.cbEnableDuplicateName.Size = new System.Drawing.Size(251, 21);
            this.cbEnableDuplicateName.TabIndex = 9;
            this.cbEnableDuplicateName.Text = "Разрешить одинаковые фамилии";
            this.cbEnableDuplicateName.UseVisualStyleBackColor = true;
            // 
            // cbShowDeducted
            // 
            this.cbShowDeducted.AutoSize = true;
            this.cbShowDeducted.Location = new System.Drawing.Point(60, 478);
            this.cbShowDeducted.Name = "cbShowDeducted";
            this.cbShowDeducted.Size = new System.Drawing.Size(199, 21);
            this.cbShowDeducted.TabIndex = 10;
            this.cbShowDeducted.Text = "Показывать отчисленных";
            this.cbShowDeducted.UseVisualStyleBackColor = true;
            // 
            // dgwStudents
            // 
            this.dgwStudents.AllowUserToAddRows = false;
            this.dgwStudents.AllowUserToDeleteRows = false;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Group,
            this.Subject,
            this.Mark});
            this.dgwStudents.Location = new System.Drawing.Point(12, 147);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(940, 150);
            this.dgwStudents.TabIndex = 11;
            this.dgwStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellValueChanged);
            this.dgwStudents.SelectionChanged += new System.EventHandler(this.dgwStudents_SelectionChanged);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.MinimumWidth = 125;
            this.FullName.Name = "FullName";
            this.FullName.Width = 250;
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
            this.Subject.MinimumWidth = 100;
            this.Subject.Name = "Subject";
            this.Subject.Width = 125;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Оценка";
            this.Mark.MinimumWidth = 50;
            this.Mark.Name = "Mark";
            this.Mark.Width = 125;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(958, 151);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(83, 38);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btFirstRecord
            // 
            this.btFirstRecord.Location = new System.Drawing.Point(367, 317);
            this.btFirstRecord.Name = "btFirstRecord";
            this.btFirstRecord.Size = new System.Drawing.Size(61, 35);
            this.btFirstRecord.TabIndex = 13;
            this.btFirstRecord.Text = "<<";
            this.btFirstRecord.UseVisualStyleBackColor = true;
            this.btFirstRecord.Click += new System.EventHandler(this.btFirstRecord_Click);
            // 
            // btPrevRecord
            // 
            this.btPrevRecord.Location = new System.Drawing.Point(434, 317);
            this.btPrevRecord.Name = "btPrevRecord";
            this.btPrevRecord.Size = new System.Drawing.Size(61, 35);
            this.btPrevRecord.TabIndex = 14;
            this.btPrevRecord.Text = "<";
            this.btPrevRecord.UseVisualStyleBackColor = true;
            this.btPrevRecord.Click += new System.EventHandler(this.btPrevRecord_Click);
            // 
            // btNextRecord
            // 
            this.btNextRecord.Location = new System.Drawing.Point(501, 317);
            this.btNextRecord.Name = "btNextRecord";
            this.btNextRecord.Size = new System.Drawing.Size(61, 35);
            this.btNextRecord.TabIndex = 15;
            this.btNextRecord.Text = ">";
            this.btNextRecord.UseVisualStyleBackColor = true;
            this.btNextRecord.Click += new System.EventHandler(this.btNextRecord_Click);
            // 
            // btLastRecord
            // 
            this.btLastRecord.Location = new System.Drawing.Point(568, 317);
            this.btLastRecord.Name = "btLastRecord";
            this.btLastRecord.Size = new System.Drawing.Size(61, 35);
            this.btLastRecord.TabIndex = 16;
            this.btLastRecord.Text = ">>";
            this.btLastRecord.UseVisualStyleBackColor = true;
            this.btLastRecord.Click += new System.EventHandler(this.btLastRecord_Click);
            // 
            // btCreateRecord
            // 
            this.btCreateRecord.Location = new System.Drawing.Point(864, 317);
            this.btCreateRecord.Name = "btCreateRecord";
            this.btCreateRecord.Size = new System.Drawing.Size(88, 34);
            this.btCreateRecord.TabIndex = 17;
            this.btCreateRecord.Text = "Добавить";
            this.btCreateRecord.UseVisualStyleBackColor = true;
            this.btCreateRecord.Click += new System.EventHandler(this.btCreateRecord_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentsList.Student);
            // 
            // btDeduct
            // 
            this.btDeduct.Location = new System.Drawing.Point(963, 317);
            this.btDeduct.Name = "btDeduct";
            this.btDeduct.Size = new System.Drawing.Size(92, 33);
            this.btDeduct.TabIndex = 18;
            this.btDeduct.Text = "Отчислить";
            this.btDeduct.UseVisualStyleBackColor = true;
            this.btDeduct.Click += new System.EventHandler(this.btDeduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btDeduct);
            this.Controls.Add(this.btCreateRecord);
            this.Controls.Add(this.btLastRecord);
            this.Controls.Add(this.btNextRecord);
            this.Controls.Add(this.btPrevRecord);
            this.Controls.Add(this.btFirstRecord);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.dgwStudents);
            this.Controls.Add(this.cbShowDeducted);
            this.Controls.Add(this.cbEnableDuplicateName);
            this.Controls.Add(this.cbCyclicScrolling);
            this.Controls.Add(this.cbRestoreState);
            this.Controls.Add(this.tbOutFileName);
            this.Controls.Add(this.btOutFileSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInFileName);
            this.Controls.Add(this.btInFileSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDeletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInFileSelect;
        private System.Windows.Forms.TextBox tbInFileName;
        private System.Windows.Forms.TextBox tbOutFileName;
        private System.Windows.Forms.Button btOutFileSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialogIn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOut;
        private System.Windows.Forms.CheckBox cbRestoreState;
        private System.Windows.Forms.CheckBox cbCyclicScrolling;
        private System.Windows.Forms.CheckBox cbEnableDuplicateName;
        private System.Windows.Forms.CheckBox cbShowDeducted;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btFirstRecord;
        private System.Windows.Forms.Button btPrevRecord;
        private System.Windows.Forms.Button btNextRecord;
        private System.Windows.Forms.Button btLastRecord;
        private System.Windows.Forms.Button btCreateRecord;
        private System.Windows.Forms.Button btDeduct;
    }
}

