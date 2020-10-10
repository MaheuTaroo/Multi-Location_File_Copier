namespace Multi_location_File_Copier
{
    partial class FileCopier
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
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnFileAdd = new System.Windows.Forms.Button();
            this.btnFileRem = new System.Windows.Forms.Button();
            this.btnFileClear = new System.Windows.Forms.Button();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.gbLocations = new System.Windows.Forms.GroupBox();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.btnLocClear = new System.Windows.Forms.Button();
            this.btnLocAdd = new System.Windows.Forms.Button();
            this.btnLocRem = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.gbFiles.SuspendLayout();
            this.gbLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.HorizontalScrollbar = true;
            this.lbFiles.Location = new System.Drawing.Point(6, 19);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(220, 316);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbClick);
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Location = new System.Drawing.Point(19, 341);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(75, 23);
            this.btnFileAdd.TabIndex = 1;
            this.btnFileAdd.Text = "Add";
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // btnFileRem
            // 
            this.btnFileRem.Location = new System.Drawing.Point(133, 341);
            this.btnFileRem.Name = "btnFileRem";
            this.btnFileRem.Size = new System.Drawing.Size(75, 23);
            this.btnFileRem.TabIndex = 2;
            this.btnFileRem.Text = "Remove";
            this.btnFileRem.UseVisualStyleBackColor = true;
            this.btnFileRem.Click += new System.EventHandler(this.btnFileRem_Click);
            // 
            // btnFileClear
            // 
            this.btnFileClear.Location = new System.Drawing.Point(75, 370);
            this.btnFileClear.Name = "btnFileClear";
            this.btnFileClear.Size = new System.Drawing.Size(75, 23);
            this.btnFileClear.TabIndex = 3;
            this.btnFileClear.Text = "Clear";
            this.btnFileClear.UseVisualStyleBackColor = true;
            this.btnFileClear.Click += new System.EventHandler(this.btnFileClear_Click);
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.lbFiles);
            this.gbFiles.Controls.Add(this.btnFileClear);
            this.gbFiles.Controls.Add(this.btnFileAdd);
            this.gbFiles.Controls.Add(this.btnFileRem);
            this.gbFiles.Location = new System.Drawing.Point(12, 12);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(232, 402);
            this.gbFiles.TabIndex = 4;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // gbLocations
            // 
            this.gbLocations.Controls.Add(this.lbLocations);
            this.gbLocations.Controls.Add(this.btnLocClear);
            this.gbLocations.Controls.Add(this.btnLocAdd);
            this.gbLocations.Controls.Add(this.btnLocRem);
            this.gbLocations.Location = new System.Drawing.Point(261, 12);
            this.gbLocations.Name = "gbLocations";
            this.gbLocations.Size = new System.Drawing.Size(232, 402);
            this.gbLocations.TabIndex = 5;
            this.gbLocations.TabStop = false;
            this.gbLocations.Text = "Locations";
            // 
            // lbLocations
            // 
            this.lbLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLocations.FormattingEnabled = true;
            this.lbLocations.HorizontalScrollbar = true;
            this.lbLocations.Location = new System.Drawing.Point(6, 19);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(220, 316);
            this.lbLocations.TabIndex = 0;
            this.lbLocations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbClick);
            // 
            // btnLocClear
            // 
            this.btnLocClear.Location = new System.Drawing.Point(77, 370);
            this.btnLocClear.Name = "btnLocClear";
            this.btnLocClear.Size = new System.Drawing.Size(75, 23);
            this.btnLocClear.TabIndex = 3;
            this.btnLocClear.Text = "Clear";
            this.btnLocClear.UseVisualStyleBackColor = true;
            this.btnLocClear.Click += new System.EventHandler(this.btnLocClear_Click);
            // 
            // btnLocAdd
            // 
            this.btnLocAdd.Location = new System.Drawing.Point(21, 341);
            this.btnLocAdd.Name = "btnLocAdd";
            this.btnLocAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLocAdd.TabIndex = 1;
            this.btnLocAdd.Text = "Add";
            this.btnLocAdd.UseVisualStyleBackColor = true;
            this.btnLocAdd.Click += new System.EventHandler(this.btnLocAdd_Click);
            // 
            // btnLocRem
            // 
            this.btnLocRem.Location = new System.Drawing.Point(135, 341);
            this.btnLocRem.Name = "btnLocRem";
            this.btnLocRem.Size = new System.Drawing.Size(75, 23);
            this.btnLocRem.TabIndex = 2;
            this.btnLocRem.Text = "Remove";
            this.btnLocRem.UseVisualStyleBackColor = true;
            this.btnLocRem.Click += new System.EventHandler(this.btnLocRem_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(169, 420);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.FileSubmit);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(261, 420);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.FileSubmit);
            // 
            // FileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 448);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.gbLocations);
            this.Controls.Add(this.gbFiles);
            this.MaximizeBox = false;
            this.Name = "FileCopier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-location File Copier";
            this.gbFiles.ResumeLayout(false);
            this.gbLocations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnFileAdd;
        private System.Windows.Forms.Button btnFileRem;
        private System.Windows.Forms.Button btnFileClear;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.GroupBox gbLocations;
        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.Button btnLocClear;
        private System.Windows.Forms.Button btnLocAdd;
        private System.Windows.Forms.Button btnLocRem;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
    }
}

