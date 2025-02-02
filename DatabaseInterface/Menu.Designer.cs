namespace DatabaseInterface
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            containerSelect = new FlowLayoutPanel();
            panelTabble = new Panel();
            buttonSelect = new Button();
            dataGridView1 = new DataGridView();
            buttonFetch = new Button();
            buttonDelete = new Button();
            buttonCommit = new Button();
            buttonSQL = new Button();
            buttonViews = new Button();
            panelViews = new Panel();
            containerViews = new FlowLayoutPanel();
            timerSelectDropDown = new System.Windows.Forms.Timer(components);
            timerViewsDropDown = new System.Windows.Forms.Timer(components);
            refresh = new System.Windows.Forms.Timer(components);
            containerSelect.SuspendLayout();
            panelTabble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelViews.SuspendLayout();
            containerViews.SuspendLayout();
            SuspendLayout();
            // 
            // containerSelect
            // 
            containerSelect.Controls.Add(panelTabble);
            containerSelect.Location = new Point(50, 50);
            containerSelect.Margin = new Padding(0);
            containerSelect.MaximumSize = new Size(150, 50);
            containerSelect.MinimumSize = new Size(150, 50);
            containerSelect.Name = "containerSelect";
            containerSelect.Size = new Size(150, 50);
            containerSelect.TabIndex = 0;
            // 
            // panelTabble
            // 
            panelTabble.Controls.Add(buttonSelect);
            panelTabble.Location = new Point(0, 0);
            panelTabble.Margin = new Padding(0);
            panelTabble.Name = "panelTabble";
            panelTabble.Size = new Size(150, 50);
            panelTabble.TabIndex = 1;
            // 
            // buttonSelect
            // 
            buttonSelect.BackColor = Color.FromArgb(167, 205, 199);
            buttonSelect.Dock = DockStyle.Fill;
            buttonSelect.FlatAppearance.BorderColor = Color.FromArgb(113, 174, 165);
            buttonSelect.FlatAppearance.BorderSize = 2;
            buttonSelect.FlatStyle = FlatStyle.Flat;
            buttonSelect.Font = new Font("Segoe UI", 13F);
            buttonSelect.Location = new Point(0, 0);
            buttonSelect.Margin = new Padding(0);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(150, 50);
            buttonSelect.TabIndex = 2;
            buttonSelect.Text = "SELECT";
            buttonSelect.UseVisualStyleBackColor = false;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(450, 50);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 570);
            dataGridView1.TabIndex = 0;
            // 
            // buttonFetch
            // 
            buttonFetch.BackColor = Color.FromArgb(137, 163, 194);
            buttonFetch.FlatAppearance.BorderColor = Color.FromArgb(84, 119, 163);
            buttonFetch.FlatAppearance.BorderSize = 2;
            buttonFetch.FlatStyle = FlatStyle.Flat;
            buttonFetch.Font = new Font("Segoe UI", 13F);
            buttonFetch.Location = new Point(250, 50);
            buttonFetch.Margin = new Padding(0);
            buttonFetch.Name = "buttonFetch";
            buttonFetch.Size = new Size(150, 50);
            buttonFetch.TabIndex = 1;
            buttonFetch.Text = "Show";
            buttonFetch.UseVisualStyleBackColor = false;
            buttonFetch.Click += buttonFetch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(226, 109, 92);
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(199, 55, 35);
            buttonDelete.FlatAppearance.BorderSize = 2;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 13F);
            buttonDelete.Location = new Point(250, 125);
            buttonDelete.Margin = new Padding(0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCommit
            // 
            buttonCommit.BackColor = Color.FromArgb(201, 203, 163);
            buttonCommit.FlatAppearance.BorderColor = Color.FromArgb(163, 166, 96);
            buttonCommit.FlatAppearance.BorderSize = 2;
            buttonCommit.FlatStyle = FlatStyle.Flat;
            buttonCommit.Font = new Font("Segoe UI", 13F);
            buttonCommit.ForeColor = SystemColors.ControlText;
            buttonCommit.Location = new Point(250, 200);
            buttonCommit.Margin = new Padding(0);
            buttonCommit.Name = "buttonCommit";
            buttonCommit.Size = new Size(150, 50);
            buttonCommit.TabIndex = 3;
            buttonCommit.Text = "Commit";
            buttonCommit.UseVisualStyleBackColor = false;
            buttonCommit.Click += buttonCommit_Click;
            // 
            // buttonSQL
            // 
            buttonSQL.BackColor = Color.FromArgb(253, 168, 83);
            buttonSQL.FlatAppearance.BorderColor = Color.FromArgb(248, 125, 3);
            buttonSQL.FlatAppearance.BorderSize = 2;
            buttonSQL.FlatStyle = FlatStyle.Flat;
            buttonSQL.Font = new Font("Segoe UI", 13F);
            buttonSQL.Location = new Point(250, 275);
            buttonSQL.Margin = new Padding(0);
            buttonSQL.Name = "buttonSQL";
            buttonSQL.Size = new Size(150, 50);
            buttonSQL.TabIndex = 4;
            buttonSQL.Text = "SQL";
            buttonSQL.UseVisualStyleBackColor = false;
            buttonSQL.Click += buttonSQL_Click;
            // 
            // buttonViews
            // 
            buttonViews.BackColor = Color.FromArgb(162, 146, 175);
            buttonViews.FlatAppearance.BorderColor = Color.FromArgb(120, 100, 136);
            buttonViews.FlatAppearance.BorderSize = 2;
            buttonViews.FlatStyle = FlatStyle.Flat;
            buttonViews.Font = new Font("Segoe UI", 13F);
            buttonViews.Location = new Point(0, 0);
            buttonViews.Margin = new Padding(0);
            buttonViews.Name = "buttonViews";
            buttonViews.Size = new Size(150, 50);
            buttonViews.TabIndex = 5;
            buttonViews.Text = "Views";
            buttonViews.UseVisualStyleBackColor = false;
            buttonViews.Click += buttonViews_Click;
            // 
            // panelViews
            // 
            panelViews.Controls.Add(buttonViews);
            panelViews.Location = new Point(0, 0);
            panelViews.Margin = new Padding(0);
            panelViews.Name = "panelViews";
            panelViews.Size = new Size(150, 50);
            panelViews.TabIndex = 6;
            // 
            // containerViews
            // 
            containerViews.Controls.Add(panelViews);
            containerViews.Location = new Point(250, 350);
            containerViews.Margin = new Padding(0);
            containerViews.MaximumSize = new Size(150, 50);
            containerViews.MinimumSize = new Size(150, 50);
            containerViews.Name = "containerViews";
            containerViews.Size = new Size(150, 50);
            containerViews.TabIndex = 7;
            // 
            // timerSelectDropDown
            // 
            timerSelectDropDown.Interval = 1;
            timerSelectDropDown.Tick += timerSelectDropDown_Tick;
            // 
            // timerViewsDropDown
            // 
            timerViewsDropDown.Interval = 1;
            timerViewsDropDown.Tick += timerViewsDropDown_Tick;
            // 
            // refresh
            // 
            refresh.Enabled = true;
            refresh.Interval = 1;
            refresh.Tick += refresh_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 204, 178);
            ClientSize = new Size(1264, 681);
            Controls.Add(containerViews);
            Controls.Add(buttonSQL);
            Controls.Add(buttonCommit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonFetch);
            Controls.Add(dataGridView1);
            Controls.Add(containerSelect);
            Name = "Menu";
            Text = "Menu";
            containerSelect.ResumeLayout(false);
            panelTabble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelViews.ResumeLayout(false);
            containerViews.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel containerSelect;
        private Panel panelTabble;
        private Button buttonSelect;
        private DataGridView dataGridView1;
        private Button buttonFetch;
        private Button buttonDelete;
        private Button buttonCommit;
        private Button buttonSQL;
        private Button buttonViews;
        private Panel panelViews;
        private FlowLayoutPanel containerViews;
        private System.Windows.Forms.Timer timerSelectDropDown;
        private System.Windows.Forms.Timer timerViewsDropDown;
        private System.Windows.Forms.Timer refresh;
    }
}
