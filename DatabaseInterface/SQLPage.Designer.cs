namespace DatabaseInterface
{
    partial class SQLPage
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
            buttonRunScript = new Button();
            sqlDataGridView = new DataGridView();
            sqlTextBox = new RichTextBox();
            buttonC = new Button();
            buttonD = new Button();
            ((System.ComponentModel.ISupportInitialize)sqlDataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonRunScript
            // 
            buttonRunScript.BackColor = Color.FromArgb(148, 187, 104);
            buttonRunScript.FlatAppearance.BorderColor = Color.FromArgb(103, 142, 64);
            buttonRunScript.FlatAppearance.BorderSize = 2;
            buttonRunScript.FlatStyle = FlatStyle.Flat;
            buttonRunScript.Font = new Font("Segoe UI", 13F);
            buttonRunScript.Location = new Point(50, 590);
            buttonRunScript.Name = "buttonRunScript";
            buttonRunScript.Size = new Size(350, 50);
            buttonRunScript.TabIndex = 0;
            buttonRunScript.Text = "Run Script";
            buttonRunScript.UseVisualStyleBackColor = false;
            buttonRunScript.Click += buttonRunScript_Click;
            // 
            // sqlDataGridView
            // 
            sqlDataGridView.BackgroundColor = Color.FromArgb(143, 173, 201);
            sqlDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sqlDataGridView.Location = new Point(450, 125);
            sqlDataGridView.Margin = new Padding(0);
            sqlDataGridView.Name = "sqlDataGridView";
            sqlDataGridView.Size = new Size(760, 440);
            sqlDataGridView.TabIndex = 1;
            // 
            // sqlTextBox
            // 
            sqlTextBox.BackColor = Color.FromArgb(254, 250, 224);
            sqlTextBox.Location = new Point(50, 125);
            sqlTextBox.Name = "sqlTextBox";
            sqlTextBox.Size = new Size(350, 440);
            sqlTextBox.TabIndex = 2;
            sqlTextBox.Text = "";
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(255, 230, 167);
            buttonC.FlatAppearance.BorderColor = Color.FromArgb(255, 207, 83);
            buttonC.FlatAppearance.BorderSize = 2;
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.Font = new Font("Segoe UI", 13F);
            buttonC.Location = new Point(50, 50);
            buttonC.Margin = new Padding(0);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(150, 50);
            buttonC.TabIndex = 3;
            buttonC.Text = "Point C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.FromArgb(255, 230, 167);
            buttonD.FlatAppearance.BorderColor = Color.FromArgb(255, 207, 83);
            buttonD.FlatAppearance.BorderSize = 2;
            buttonD.FlatStyle = FlatStyle.Flat;
            buttonD.Font = new Font("Segoe UI", 13F);
            buttonD.Location = new Point(250, 50);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(150, 50);
            buttonD.TabIndex = 4;
            buttonD.Text = "Point D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // SQLPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 172, 139);
            ClientSize = new Size(1264, 681);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(sqlTextBox);
            Controls.Add(sqlDataGridView);
            Controls.Add(buttonRunScript);
            Name = "SQLPage";
            Text = "SQLPage";
            ((System.ComponentModel.ISupportInitialize)sqlDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRunScript;
        private DataGridView sqlDataGridView;
        private RichTextBox sqlTextBox;
        private Button buttonC;
        private Button buttonD;
    }
}