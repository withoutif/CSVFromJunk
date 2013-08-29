namespace CSVFromJunkData
{
    partial class Container
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.openFileDialogSource = new System.Windows.Forms.OpenFileDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbCols = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.lblDelim = new System.Windows.Forms.Label();
            this.rbNewLine = new System.Windows.Forms.RadioButton();
            this.rbTabs = new System.Windows.Forms.RadioButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.chRemove = new System.Windows.Forms.CheckBox();
            this.chRemoveComma = new System.Windows.Forms.CheckBox();
            this.chFormat = new System.Windows.Forms.CheckBox();
            this.cbSpaces = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(8, 10);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(100, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source File";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.Location = new System.Drawing.Point(8, 49);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(123, 20);
            this.lblDest.TabIndex = 1;
            this.lblDest.Text = "Save Location";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(179, 10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(277, 20);
            this.txtSource.TabIndex = 7;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(180, 49);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(277, 20);
            this.txtDestination.TabIndex = 8;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(471, 6);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(88, 26);
            this.btnSource.TabIndex = 9;
            this.btnSource.Text = "Browse";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(471, 47);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(88, 26);
            this.btnDestination.TabIndex = 10;
            this.btnDestination.Text = "Browse";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // openFileDialogSource
            // 
            this.openFileDialogSource.FileName = "openFileDialog1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(451, 387);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 26);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Build me a CSV!";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbCols
            // 
            this.lbCols.AutoSize = true;
            this.lbCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCols.Location = new System.Drawing.Point(8, 137);
            this.lbCols.Name = "lbCols";
            this.lbCols.Size = new System.Drawing.Size(166, 20);
            this.lbCols.TabIndex = 13;
            this.lbCols.Text = "Number of Columns";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(180, 139);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(62, 20);
            this.txtCols.TabIndex = 14;
            // 
            // lblDelim
            // 
            this.lblDelim.AutoSize = true;
            this.lblDelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelim.Location = new System.Drawing.Point(8, 191);
            this.lblDelim.Name = "lblDelim";
            this.lblDelim.Size = new System.Drawing.Size(172, 20);
            this.lblDelim.TabIndex = 15;
            this.lblDelim.Text = "My data is delimited:";
            // 
            // rbNewLine
            // 
            this.rbNewLine.AutoSize = true;
            this.rbNewLine.Checked = true;
            this.rbNewLine.Location = new System.Drawing.Point(26, 223);
            this.rbNewLine.Name = "rbNewLine";
            this.rbNewLine.Size = new System.Drawing.Size(148, 17);
            this.rbNewLine.TabIndex = 16;
            this.rbNewLine.TabStop = true;
            this.rbNewLine.Text = "Each item is on a new line";
            this.rbNewLine.UseVisualStyleBackColor = true;
            // 
            // rbTabs
            // 
            this.rbTabs.AutoSize = true;
            this.rbTabs.Location = new System.Drawing.Point(239, 223);
            this.rbTabs.Name = "rbTabs";
            this.rbTabs.Size = new System.Drawing.Size(251, 17);
            this.rbTabs.TabIndex = 17;
            this.rbTabs.Text = "Each line is a single row - items are tab delimited";
            this.rbTabs.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(8, 93);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(89, 20);
            this.lblFileName.TabIndex = 18;
            this.lblFileName.Text = "File Name";
            this.lblFileName.UseMnemonic = false;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(180, 95);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(277, 20);
            this.txtFilename.TabIndex = 19;
            this.txtFilename.Text = "outputFile";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(8, 259);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(76, 20);
            this.lblOptions.TabIndex = 20;
            this.lblOptions.Text = "Options:";
            // 
            // chRemove
            // 
            this.chRemove.AutoSize = true;
            this.chRemove.Location = new System.Drawing.Point(51, 300);
            this.chRemove.Name = "chRemove";
            this.chRemove.Size = new System.Drawing.Size(153, 17);
            this.chRemove.TabIndex = 21;
            this.chRemove.Text = "Remove non-comma chars";
            this.chRemove.UseVisualStyleBackColor = true;
            // 
            // chRemoveComma
            // 
            this.chRemoveComma.AutoSize = true;
            this.chRemoveComma.Location = new System.Drawing.Point(219, 300);
            this.chRemoveComma.Name = "chRemoveComma";
            this.chRemoveComma.Size = new System.Drawing.Size(108, 17);
            this.chRemoveComma.TabIndex = 22;
            this.chRemoveComma.Text = "Remove commas";
            this.chRemoveComma.UseVisualStyleBackColor = true;
            // 
            // chFormat
            // 
            this.chFormat.AutoSize = true;
            this.chFormat.Location = new System.Drawing.Point(345, 300);
            this.chFormat.Name = "chFormat";
            this.chFormat.Size = new System.Drawing.Size(152, 17);
            this.chFormat.TabIndex = 23;
            this.chFormat.Text = "Format all values as strings";
            this.chFormat.UseVisualStyleBackColor = true;
            // 
            // cbSpaces
            // 
            this.cbSpaces.AutoSize = true;
            this.cbSpaces.Location = new System.Drawing.Point(51, 338);
            this.cbSpaces.Name = "cbSpaces";
            this.cbSpaces.Size = new System.Drawing.Size(214, 17);
            this.cbSpaces.TabIndex = 24;
            this.cbSpaces.Text = "Items are seperated by spaces, not tabs";
            this.cbSpaces.UseVisualStyleBackColor = true;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 425);
            this.Controls.Add(this.cbSpaces);
            this.Controls.Add(this.chFormat);
            this.Controls.Add(this.chRemoveComma);
            this.Controls.Add(this.chRemove);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.rbTabs);
            this.Controls.Add(this.rbNewLine);
            this.Controls.Add(this.lblDelim);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.lbCols);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblSource);
            this.Name = "Container";
            this.Text = "Convert Junk Data to CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.OpenFileDialog openFileDialogSource;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbCols;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label lblDelim;
        private System.Windows.Forms.RadioButton rbNewLine;
        private System.Windows.Forms.RadioButton rbTabs;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.CheckBox chRemove;
        private System.Windows.Forms.CheckBox chRemoveComma;
        private System.Windows.Forms.CheckBox chFormat;
        private System.Windows.Forms.CheckBox cbSpaces;

    }
}

