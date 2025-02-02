namespace DatabaseInterface
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTabel = new Label();
            SuspendLayout();
            // 
            // labelTabel
            // 
            labelTabel.Dock = DockStyle.Fill;
            labelTabel.Font = new Font("Segoe UI", 13F);
            labelTabel.Location = new Point(0, 0);
            labelTabel.Margin = new Padding(0);
            labelTabel.Name = "labelTabel";
            labelTabel.Size = new Size(148, 48);
            labelTabel.TabIndex = 0;
            labelTabel.Text = "table";
            labelTabel.TextAlign = ContentAlignment.MiddleCenter;
            labelTabel.Click += labelTabel_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 205, 199);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelTabel);
            Margin = new Padding(0);
            Name = "Item";
            Size = new Size(148, 48);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTabel;
    }
}
