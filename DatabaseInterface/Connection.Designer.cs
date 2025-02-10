namespace DatabaseInterface
{
    partial class Connection
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
            ServerTextBox = new RichTextBox();
            DatabaseTextBox = new RichTextBox();
            UidTextBox = new RichTextBox();
            PasswordTextBox = new RichTextBox();
            buttonSERVER = new Button();
            buttonDATABASE = new Button();
            buttonUID = new Button();
            buttonPASSWORD = new Button();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // ServerTextBox
            // 
            ServerTextBox.Font = new Font("Segoe UI", 13F);
            ServerTextBox.Location = new Point(250, 50);
            ServerTextBox.Name = "ServerTextBox";
            ServerTextBox.Size = new Size(150, 50);
            ServerTextBox.TabIndex = 0;
            ServerTextBox.Text = "localhost";
            // 
            // DatabaseTextBox
            // 
            DatabaseTextBox.Font = new Font("Segoe UI", 13F);
            DatabaseTextBox.Location = new Point(250, 125);
            DatabaseTextBox.Name = "DatabaseTextBox";
            DatabaseTextBox.Size = new Size(150, 50);
            DatabaseTextBox.TabIndex = 1;
            DatabaseTextBox.Text = "proiectbd";
            // 
            // UidTextBox
            // 
            UidTextBox.Font = new Font("Segoe UI", 13F);
            UidTextBox.Location = new Point(250, 200);
            UidTextBox.Name = "UidTextBox";
            UidTextBox.Size = new Size(150, 50);
            UidTextBox.TabIndex = 2;
            UidTextBox.Text = "root";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 13F);
            PasswordTextBox.Location = new Point(250, 275);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(150, 50);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "123456";
            // 
            // buttonSERVER
            // 
            buttonSERVER.FlatAppearance.BorderSize = 0;
            buttonSERVER.FlatStyle = FlatStyle.Flat;
            buttonSERVER.Font = new Font("Segoe UI", 13F);
            buttonSERVER.Location = new Point(50, 50);
            buttonSERVER.Name = "buttonSERVER";
            buttonSERVER.Size = new Size(130, 50);
            buttonSERVER.TabIndex = 4;
            buttonSERVER.Text = "SERVER=";
            buttonSERVER.TextAlign = ContentAlignment.MiddleLeft;
            buttonSERVER.UseVisualStyleBackColor = true;
            buttonSERVER.Click += buttonSERVER_Click;
            // 
            // buttonDATABASE
            // 
            buttonDATABASE.FlatAppearance.BorderSize = 0;
            buttonDATABASE.FlatStyle = FlatStyle.Flat;
            buttonDATABASE.Font = new Font("Segoe UI", 13F);
            buttonDATABASE.Location = new Point(50, 125);
            buttonDATABASE.Name = "buttonDATABASE";
            buttonDATABASE.Size = new Size(130, 50);
            buttonDATABASE.TabIndex = 5;
            buttonDATABASE.Text = "DATABASE=";
            buttonDATABASE.TextAlign = ContentAlignment.MiddleLeft;
            buttonDATABASE.UseVisualStyleBackColor = true;
            buttonDATABASE.Click += buttonDATABASE_Click;
            // 
            // buttonUID
            // 
            buttonUID.FlatAppearance.BorderSize = 0;
            buttonUID.FlatStyle = FlatStyle.Flat;
            buttonUID.Font = new Font("Segoe UI", 13F);
            buttonUID.Location = new Point(50, 200);
            buttonUID.Name = "buttonUID";
            buttonUID.Size = new Size(130, 50);
            buttonUID.TabIndex = 6;
            buttonUID.Text = "UID=";
            buttonUID.TextAlign = ContentAlignment.MiddleLeft;
            buttonUID.UseVisualStyleBackColor = true;
            buttonUID.Click += buttonUID_Click;
            // 
            // buttonPASSWORD
            // 
            buttonPASSWORD.FlatAppearance.BorderSize = 0;
            buttonPASSWORD.FlatStyle = FlatStyle.Flat;
            buttonPASSWORD.Font = new Font("Segoe UI", 13F);
            buttonPASSWORD.Location = new Point(50, 275);
            buttonPASSWORD.Name = "buttonPASSWORD";
            buttonPASSWORD.Size = new Size(130, 50);
            buttonPASSWORD.TabIndex = 7;
            buttonPASSWORD.Text = "PASSWORD=";
            buttonPASSWORD.TextAlign = ContentAlignment.MiddleLeft;
            buttonPASSWORD.UseVisualStyleBackColor = true;
            buttonPASSWORD.Click += buttonPASSWORD_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(147, 193, 159);
            buttonSubmit.FlatAppearance.BorderColor = Color.FromArgb(92, 163, 111);
            buttonSubmit.FlatAppearance.BorderSize = 2;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 13F);
            buttonSubmit.Location = new Point(50, 350);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(350, 50);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // Connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 186, 138);
            ClientSize = new Size(454, 421);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonPASSWORD);
            Controls.Add(buttonUID);
            Controls.Add(buttonDATABASE);
            Controls.Add(buttonSERVER);
            Controls.Add(PasswordTextBox);
            Controls.Add(UidTextBox);
            Controls.Add(DatabaseTextBox);
            Controls.Add(ServerTextBox);
            Name = "Connection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox ServerTextBox;
        private RichTextBox DatabaseTextBox;
        private RichTextBox UidTextBox;
        private RichTextBox PasswordTextBox;
        private Button buttonSERVER;
        private Button buttonDATABASE;
        private Button buttonUID;
        private Button buttonPASSWORD;
        private Button buttonSubmit;
    }
}