namespace levikSchedule
{
    partial class Form1
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
            addStudent = new Button();
            studentName = new TextBox();
            marks = new DataGridView();
            studentList = new ComboBox();
            removeStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)marks).BeginInit();
            SuspendLayout();
            // 
            // addStudent
            // 
            addStudent.Location = new Point(312, 416);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(131, 23);
            addStudent.TabIndex = 0;
            addStudent.Text = "Добавить студента";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // studentName
            // 
            studentName.Location = new Point(29, 416);
            studentName.Name = "studentName";
            studentName.Size = new Size(267, 23);
            studentName.TabIndex = 1;
            // 
            // marks
            // 
            marks.AllowUserToAddRows = false;
            marks.AllowUserToDeleteRows = false;
            marks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            marks.Location = new Point(351, 12);
            marks.Name = "marks";
            marks.RowTemplate.Height = 25;
            marks.Size = new Size(437, 242);
            marks.TabIndex = 2;
            marks.CellFormatting += marks_CellFormatting;
            // 
            // studentList
            // 
            studentList.FormattingEnabled = true;
            studentList.Location = new Point(12, 38);
            studentList.Name = "studentList";
            studentList.Size = new Size(317, 23);
            studentList.TabIndex = 3;
            studentList.SelectedValueChanged += studentList_SelectedValueChanged;
            // 
            // removeStudent
            // 
            removeStudent.Location = new Point(94, 86);
            removeStudent.Name = "removeStudent";
            removeStudent.Size = new Size(139, 23);
            removeStudent.TabIndex = 4;
            removeStudent.Text = "Отчислить студента";
            removeStudent.UseVisualStyleBackColor = true;
            removeStudent.Click += removeStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeStudent);
            Controls.Add(studentList);
            Controls.Add(marks);
            Controls.Add(studentName);
            Controls.Add(addStudent);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)marks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addStudent;
        private TextBox studentName;
        private DataGridView marks;
        private ComboBox studentList;
        private Button removeStudent;
    }
}