
namespace URL
{
    partial class MainForm
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
            this.urlField = new System.Windows.Forms.TextBox();
            this.urlButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.protokolLabel = new System.Windows.Forms.Label();
            this.protocolText = new System.Windows.Forms.Label();
            this.hostText = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.Label();
            this.pytLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // urlField
            // 
            this.urlField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urlField.Location = new System.Drawing.Point(37, 192);
            this.urlField.Name = "urlField";
            this.urlField.Size = new System.Drawing.Size(485, 41);
            this.urlField.TabIndex = 0;
            // 
            // urlButton
            // 
            this.urlButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.urlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urlButton.Location = new System.Drawing.Point(529, 192);
            this.urlButton.Name = "urlButton";
            this.urlButton.Size = new System.Drawing.Size(142, 41);
            this.urlButton.TabIndex = 1;
            this.urlButton.Text = "Разделить";
            this.urlButton.UseVisualStyleBackColor = false;
            this.urlButton.Click += new System.EventHandler(this.urlButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(232, 134);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(217, 36);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Введите URL:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::URL.Properties.Resources.document;
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // protokolLabel
            // 
            this.protokolLabel.AutoSize = true;
            this.protokolLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.protokolLabel.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protokolLabel.Location = new System.Drawing.Point(32, 270);
            this.protokolLabel.Name = "protokolLabel";
            this.protokolLabel.Size = new System.Drawing.Size(124, 25);
            this.protokolLabel.TabIndex = 4;
            this.protokolLabel.Text = "Протокол:";
            // 
            // protocolText
            // 
            this.protocolText.AutoSize = true;
            this.protocolText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.protocolText.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolText.Location = new System.Drawing.Point(162, 270);
            this.protocolText.Name = "protocolText";
            this.protocolText.Size = new System.Drawing.Size(0, 25);
            this.protocolText.TabIndex = 5;
            // 
            // hostText
            // 
            this.hostText.AutoSize = true;
            this.hostText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hostText.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostText.Location = new System.Drawing.Point(106, 312);
            this.hostText.Name = "hostText";
            this.hostText.Size = new System.Drawing.Size(0, 25);
            this.hostText.TabIndex = 7;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hostLabel.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostLabel.Location = new System.Drawing.Point(32, 312);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(68, 25);
            this.hostLabel.TabIndex = 6;
            this.hostLabel.Text = "Хост:";
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.portText.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portText.Location = new System.Drawing.Point(106, 352);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(0, 25);
            this.portText.TabIndex = 9;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.portLabel.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLabel.Location = new System.Drawing.Point(32, 352);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(74, 25);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Порт:";
            // 
            // pathText
            // 
            this.pathText.AutoSize = true;
            this.pathText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pathText.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathText.Location = new System.Drawing.Point(162, 392);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(0, 25);
            this.pathText.TabIndex = 11;
            // 
            // pytLabel
            // 
            this.pytLabel.AutoSize = true;
            this.pytLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pytLabel.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pytLabel.Location = new System.Drawing.Point(32, 392);
            this.pytLabel.Name = "pytLabel";
            this.pytLabel.Size = new System.Drawing.Size(124, 25);
            this.pytLabel.TabIndex = 10;
            this.pytLabel.Text = "URL-путь:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::URL.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.pytLabel);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.hostText);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.protocolText);
            this.Controls.Add(this.protokolLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.urlButton);
            this.Controls.Add(this.urlField);
            this.Name = "MainForm";
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlField;
        private System.Windows.Forms.Button urlButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label protokolLabel;
        private System.Windows.Forms.Label protocolText;
        private System.Windows.Forms.Label hostText;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label portText;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label pathText;
        private System.Windows.Forms.Label pytLabel;
    }
}