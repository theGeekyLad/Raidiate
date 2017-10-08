namespace Raidiate
{
    partial class radiate
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
            System.Windows.Forms.Button formatButton;
            System.Windows.Forms.Button eraseButton;
            System.Windows.Forms.Button partitionButton;
            System.Windows.Forms.Button diskButton;
            System.Windows.Forms.Button filesystemButton;
            System.Windows.Forms.Button removeButton;
            System.Windows.Forms.Button assignButton;
            System.Windows.Forms.Button rescanButton;
            System.Windows.Forms.Button partitionCreateButton;
            System.Windows.Forms.Button spannedButton;
            System.Windows.Forms.Button stripedButton;
            this.diskControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.diskInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.diskComboBox = new System.Windows.Forms.ComboBox();
            this.diskSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.partitionLabel = new System.Windows.Forms.Label();
            this.diskLabel = new System.Windows.Forms.Label();
            this.partitionComboBox = new System.Windows.Forms.ComboBox();
            this.driveLetterControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.diskMergeControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.unequallySizedLabel = new System.Windows.Forms.Label();
            this.equallySizedLabel = new System.Windows.Forms.Label();
            formatButton = new System.Windows.Forms.Button();
            eraseButton = new System.Windows.Forms.Button();
            partitionButton = new System.Windows.Forms.Button();
            diskButton = new System.Windows.Forms.Button();
            filesystemButton = new System.Windows.Forms.Button();
            removeButton = new System.Windows.Forms.Button();
            assignButton = new System.Windows.Forms.Button();
            rescanButton = new System.Windows.Forms.Button();
            partitionCreateButton = new System.Windows.Forms.Button();
            spannedButton = new System.Windows.Forms.Button();
            stripedButton = new System.Windows.Forms.Button();
            this.diskControlsGroupBox.SuspendLayout();
            this.diskInfoGroupBox.SuspendLayout();
            this.diskSelectionGroupBox.SuspendLayout();
            this.driveLetterControlsGroupBox.SuspendLayout();
            this.diskMergeControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatButton
            // 
            formatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            formatButton.Location = new System.Drawing.Point(54, 59);
            formatButton.Name = "formatButton";
            formatButton.Size = new System.Drawing.Size(125, 23);
            formatButton.TabIndex = 0;
            formatButton.Text = "Format";
            formatButton.UseVisualStyleBackColor = true;
            // 
            // eraseButton
            // 
            eraseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            eraseButton.Location = new System.Drawing.Point(54, 88);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new System.Drawing.Size(125, 23);
            eraseButton.TabIndex = 0;
            eraseButton.Text = "Erase";
            eraseButton.UseVisualStyleBackColor = true;
            // 
            // partitionButton
            // 
            partitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            partitionButton.Location = new System.Drawing.Point(55, 64);
            partitionButton.Name = "partitionButton";
            partitionButton.Size = new System.Drawing.Size(125, 23);
            partitionButton.TabIndex = 0;
            partitionButton.Text = "Partition";
            partitionButton.UseVisualStyleBackColor = true;
            // 
            // diskButton
            // 
            diskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            diskButton.Location = new System.Drawing.Point(55, 35);
            diskButton.Name = "diskButton";
            diskButton.Size = new System.Drawing.Size(125, 23);
            diskButton.TabIndex = 0;
            diskButton.Text = "Disk";
            diskButton.UseVisualStyleBackColor = true;
            // 
            // filesystemButton
            // 
            filesystemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            filesystemButton.Location = new System.Drawing.Point(55, 93);
            filesystemButton.Name = "filesystemButton";
            filesystemButton.Size = new System.Drawing.Size(125, 23);
            filesystemButton.TabIndex = 0;
            filesystemButton.Text = "Filesystem";
            filesystemButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            removeButton.Location = new System.Drawing.Point(55, 62);
            removeButton.Name = "removeButton";
            removeButton.Size = new System.Drawing.Size(125, 23);
            removeButton.TabIndex = 0;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // assignButton
            // 
            assignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            assignButton.Location = new System.Drawing.Point(55, 33);
            assignButton.Name = "assignButton";
            assignButton.Size = new System.Drawing.Size(125, 23);
            assignButton.TabIndex = 0;
            assignButton.Text = "Assign";
            assignButton.UseVisualStyleBackColor = true;
            // 
            // rescanButton
            // 
            rescanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            rescanButton.Location = new System.Drawing.Point(77, 149);
            rescanButton.Name = "rescanButton";
            rescanButton.Size = new System.Drawing.Size(92, 23);
            rescanButton.TabIndex = 0;
            rescanButton.Text = "Rescan";
            rescanButton.UseVisualStyleBackColor = true;
            rescanButton.Click += new System.EventHandler(this.rescanButton_Click);
            // 
            // partitionCreateButton
            // 
            partitionCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            partitionCreateButton.Location = new System.Drawing.Point(55, 30);
            partitionCreateButton.Name = "partitionCreateButton";
            partitionCreateButton.Size = new System.Drawing.Size(125, 23);
            partitionCreateButton.TabIndex = 0;
            partitionCreateButton.Text = "Partition";
            partitionCreateButton.UseVisualStyleBackColor = true;
            // 
            // spannedButton
            // 
            spannedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            spannedButton.Location = new System.Drawing.Point(55, 112);
            spannedButton.Name = "spannedButton";
            spannedButton.Size = new System.Drawing.Size(125, 23);
            spannedButton.TabIndex = 0;
            spannedButton.Text = "Spanned";
            spannedButton.UseVisualStyleBackColor = true;
            // 
            // stripedButton
            // 
            stripedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            stripedButton.Location = new System.Drawing.Point(55, 56);
            stripedButton.Name = "stripedButton";
            stripedButton.Size = new System.Drawing.Size(125, 23);
            stripedButton.TabIndex = 0;
            stripedButton.Text = "Striped";
            stripedButton.UseVisualStyleBackColor = true;
            // 
            // diskControlsGroupBox
            // 
            this.diskControlsGroupBox.Controls.Add(partitionCreateButton);
            this.diskControlsGroupBox.Controls.Add(eraseButton);
            this.diskControlsGroupBox.Controls.Add(formatButton);
            this.diskControlsGroupBox.Location = new System.Drawing.Point(257, 243);
            this.diskControlsGroupBox.Name = "diskControlsGroupBox";
            this.diskControlsGroupBox.Size = new System.Drawing.Size(234, 141);
            this.diskControlsGroupBox.TabIndex = 0;
            this.diskControlsGroupBox.TabStop = false;
            this.diskControlsGroupBox.Text = "Disk Controls";
            // 
            // diskInfoGroupBox
            // 
            this.diskInfoGroupBox.Controls.Add(filesystemButton);
            this.diskInfoGroupBox.Controls.Add(partitionButton);
            this.diskInfoGroupBox.Controls.Add(diskButton);
            this.diskInfoGroupBox.Location = new System.Drawing.Point(17, 243);
            this.diskInfoGroupBox.Name = "diskInfoGroupBox";
            this.diskInfoGroupBox.Size = new System.Drawing.Size(234, 141);
            this.diskInfoGroupBox.TabIndex = 0;
            this.diskInfoGroupBox.TabStop = false;
            this.diskInfoGroupBox.Text = "Disk Information";
            // 
            // diskComboBox
            // 
            this.diskComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diskComboBox.FormattingEnabled = true;
            this.diskComboBox.Location = new System.Drawing.Point(77, 68);
            this.diskComboBox.Name = "diskComboBox";
            this.diskComboBox.Size = new System.Drawing.Size(309, 24);
            this.diskComboBox.TabIndex = 1;
            this.diskComboBox.SelectedIndexChanged += new System.EventHandler(this.diskComboBox_SelectedIndexChanged);
            // 
            // diskSelectionGroupBox
            // 
            this.diskSelectionGroupBox.Controls.Add(this.partitionLabel);
            this.diskSelectionGroupBox.Controls.Add(this.diskLabel);
            this.diskSelectionGroupBox.Controls.Add(rescanButton);
            this.diskSelectionGroupBox.Controls.Add(this.partitionComboBox);
            this.diskSelectionGroupBox.Controls.Add(this.diskComboBox);
            this.diskSelectionGroupBox.Location = new System.Drawing.Point(17, 13);
            this.diskSelectionGroupBox.Name = "diskSelectionGroupBox";
            this.diskSelectionGroupBox.Size = new System.Drawing.Size(474, 224);
            this.diskSelectionGroupBox.TabIndex = 2;
            this.diskSelectionGroupBox.TabStop = false;
            this.diskSelectionGroupBox.Text = "Disk Selection";
            // 
            // partitionLabel
            // 
            this.partitionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.partitionLabel.AutoSize = true;
            this.partitionLabel.Location = new System.Drawing.Point(74, 95);
            this.partitionLabel.Name = "partitionLabel";
            this.partitionLabel.Size = new System.Drawing.Size(60, 17);
            this.partitionLabel.TabIndex = 0;
            this.partitionLabel.Text = "Partition";
            // 
            // diskLabel
            // 
            this.diskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diskLabel.AutoSize = true;
            this.diskLabel.Location = new System.Drawing.Point(74, 48);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(35, 17);
            this.diskLabel.TabIndex = 0;
            this.diskLabel.Text = "Disk";
            // 
            // partitionComboBox
            // 
            this.partitionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.partitionComboBox.FormattingEnabled = true;
            this.partitionComboBox.Location = new System.Drawing.Point(77, 119);
            this.partitionComboBox.Name = "partitionComboBox";
            this.partitionComboBox.Size = new System.Drawing.Size(121, 24);
            this.partitionComboBox.TabIndex = 1;
            // 
            // driveLetterControlsGroupBox
            // 
            this.driveLetterControlsGroupBox.Controls.Add(removeButton);
            this.driveLetterControlsGroupBox.Controls.Add(assignButton);
            this.driveLetterControlsGroupBox.Location = new System.Drawing.Point(258, 390);
            this.driveLetterControlsGroupBox.Name = "driveLetterControlsGroupBox";
            this.driveLetterControlsGroupBox.Size = new System.Drawing.Size(234, 113);
            this.driveLetterControlsGroupBox.TabIndex = 0;
            this.driveLetterControlsGroupBox.TabStop = false;
            this.driveLetterControlsGroupBox.Text = "Drive Letter Controls";
            // 
            // diskMergeControlsGroupBox
            // 
            this.diskMergeControlsGroupBox.Controls.Add(spannedButton);
            this.diskMergeControlsGroupBox.Controls.Add(stripedButton);
            this.diskMergeControlsGroupBox.Controls.Add(this.unequallySizedLabel);
            this.diskMergeControlsGroupBox.Controls.Add(this.equallySizedLabel);
            this.diskMergeControlsGroupBox.Location = new System.Drawing.Point(17, 390);
            this.diskMergeControlsGroupBox.Name = "diskMergeControlsGroupBox";
            this.diskMergeControlsGroupBox.Size = new System.Drawing.Size(234, 163);
            this.diskMergeControlsGroupBox.TabIndex = 0;
            this.diskMergeControlsGroupBox.TabStop = false;
            this.diskMergeControlsGroupBox.Text = "Disk Merge Controls";
            // 
            // unequallySizedLabel
            // 
            this.unequallySizedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unequallySizedLabel.AutoSize = true;
            this.unequallySizedLabel.Location = new System.Drawing.Point(52, 92);
            this.unequallySizedLabel.Name = "unequallySizedLabel";
            this.unequallySizedLabel.Size = new System.Drawing.Size(110, 17);
            this.unequallySizedLabel.TabIndex = 0;
            this.unequallySizedLabel.Text = "Unequally Sized";
            // 
            // equallySizedLabel
            // 
            this.equallySizedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.equallySizedLabel.AutoSize = true;
            this.equallySizedLabel.Location = new System.Drawing.Point(52, 36);
            this.equallySizedLabel.Name = "equallySizedLabel";
            this.equallySizedLabel.Size = new System.Drawing.Size(93, 17);
            this.equallySizedLabel.TabIndex = 0;
            this.equallySizedLabel.Text = "Equally Sized";
            // 
            // radiate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(505, 574);
            this.Controls.Add(this.diskSelectionGroupBox);
            this.Controls.Add(this.diskInfoGroupBox);
            this.Controls.Add(this.diskMergeControlsGroupBox);
            this.Controls.Add(this.driveLetterControlsGroupBox);
            this.Controls.Add(this.diskControlsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "radiate";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Raidiate";
            this.diskControlsGroupBox.ResumeLayout(false);
            this.diskInfoGroupBox.ResumeLayout(false);
            this.diskSelectionGroupBox.ResumeLayout(false);
            this.diskSelectionGroupBox.PerformLayout();
            this.driveLetterControlsGroupBox.ResumeLayout(false);
            this.diskMergeControlsGroupBox.ResumeLayout(false);
            this.diskMergeControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox diskControlsGroupBox;
        private System.Windows.Forms.GroupBox diskInfoGroupBox;
        private System.Windows.Forms.ComboBox diskComboBox;
        private System.Windows.Forms.GroupBox diskSelectionGroupBox;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.Label partitionLabel;
        private System.Windows.Forms.ComboBox partitionComboBox;
        private System.Windows.Forms.GroupBox driveLetterControlsGroupBox;
        private System.Windows.Forms.GroupBox diskMergeControlsGroupBox;
        private System.Windows.Forms.Label unequallySizedLabel;
        private System.Windows.Forms.Label equallySizedLabel;
    }
}

