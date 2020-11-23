namespace DBAccessDemo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbConnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbDisconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateParams = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbConnectMenuItem,
            this.dbDisconnectMenuItem});
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.dBToolStripMenuItem.Text = "DB";
            // 
            // dbConnectMenuItem
            // 
            this.dbConnectMenuItem.Name = "dbConnectMenuItem";
            this.dbConnectMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dbConnectMenuItem.Text = "Connect to DB";
            this.dbConnectMenuItem.Click += new System.EventHandler(this.dbConnectMenuItem_Click);
            // 
            // dbDisconnectMenuItem
            // 
            this.dbDisconnectMenuItem.Name = "dbDisconnectMenuItem";
            this.dbDisconnectMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dbDisconnectMenuItem.Text = "Disconnect from DB";
            this.dbDisconnectMenuItem.Click += new System.EventHandler(this.dbDisconnectMenuItem_Click);
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.Location = new System.Drawing.Point(39, 57);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(386, 121);
            this.lstCharacters.TabIndex = 1;
            // 
            // btnReadData
            // 
            this.btnReadData.Enabled = false;
            this.btnReadData.Location = new System.Drawing.Point(34, 225);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 23);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "Read Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(137, 225);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(75, 23);
            this.btnWriteData.TabIndex = 3;
            this.btnWriteData.Text = "Write Data";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateParams
            // 
            this.btnUpdateParams.Location = new System.Drawing.Point(152, 275);
            this.btnUpdateParams.Name = "btnUpdateParams";
            this.btnUpdateParams.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateParams.TabIndex = 6;
            this.btnUpdateParams.Text = "Update params";
            this.btnUpdateParams.UseVisualStyleBackColor = true;
            this.btnUpdateParams.Click += new System.EventHandler(this.btnUpdateParams_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Data grid example";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateParams);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnWriteData);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbConnectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbDisconnectMenuItem;
        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateParams;
        private System.Windows.Forms.Button button1;
    }
}

