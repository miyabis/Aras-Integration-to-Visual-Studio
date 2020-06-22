using System.Windows.Forms;

namespace ArasMenu
{
    partial class MethodSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodSelectionForm));
            this.nameQryBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.methodNameLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.codeQryBox = new System.Windows.Forms.TextBox();
            this.methodCodeLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.lockCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nameQryBox
            // 
            this.nameQryBox.Location = new System.Drawing.Point(38, 52);
            this.nameQryBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameQryBox.Name = "nameQryBox";
            this.nameQryBox.Size = new System.Drawing.Size(197, 19);
            this.nameQryBox.TabIndex = 0;
            this.nameQryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameQryBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(547, 82);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 25);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(547, 470);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(101, 22);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "&Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // methodNameLabel
            // 
            this.methodNameLabel.AutoSize = true;
            this.methodNameLabel.Location = new System.Drawing.Point(35, 28);
            this.methodNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.methodNameLabel.Name = "methodNameLabel";
            this.methodNameLabel.Size = new System.Drawing.Size(77, 12);
            this.methodNameLabel.TabIndex = 4;
            this.methodNameLabel.Text = "Method Name:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(35, 115);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(126, 12);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Method Search Results:";
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(38, 146);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(2);
            this.resultGrid.MultiSelect = false;
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowTemplate.Height = 31;
            this.resultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultGrid.Size = new System.Drawing.Size(611, 304);
            this.resultGrid.TabIndex = 6;
            // 
            // codeQryBox
            // 
            this.codeQryBox.Location = new System.Drawing.Point(383, 52);
            this.codeQryBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeQryBox.Name = "codeQryBox";
            this.codeQryBox.Size = new System.Drawing.Size(267, 19);
            this.codeQryBox.TabIndex = 7;
            this.codeQryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeQryBox_KeyDown);
            // 
            // methodCodeLabel
            // 
            this.methodCodeLabel.AutoSize = true;
            this.methodCodeLabel.Location = new System.Drawing.Point(380, 28);
            this.methodCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.methodCodeLabel.Name = "methodCodeLabel";
            this.methodCodeLabel.Size = new System.Drawing.Size(74, 12);
            this.methodCodeLabel.TabIndex = 8;
            this.methodCodeLabel.Text = "Method Code:";
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.ItemHeight = 12;
            this.typeBox.Items.AddRange(new object[] {
            "All",
            "C#",
            "JavaScript"});
            this.typeBox.Location = new System.Drawing.Point(254, 52);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(110, 20);
            this.typeBox.TabIndex = 9;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(251, 28);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(73, 12);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Method Type:";
            // 
            // lockCheck
            // 
            this.lockCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lockCheck.AutoSize = true;
            this.lockCheck.Location = new System.Drawing.Point(38, 474);
            this.lockCheck.Margin = new System.Windows.Forms.Padding(2);
            this.lockCheck.Name = "lockCheck";
            this.lockCheck.Size = new System.Drawing.Size(137, 16);
            this.lockCheck.TabIndex = 11;
            this.lockCheck.Text = "&Lock Method On Open";
            this.lockCheck.UseVisualStyleBackColor = true;
            // 
            // MethodSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 508);
            this.Controls.Add(this.lockCheck);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.methodCodeLabel);
            this.Controls.Add(this.codeQryBox);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.methodNameLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameQryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MethodSelectionForm";
            this.Text = "Open Method";
            this.Load += new System.EventHandler(this.MethodSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameQryBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label methodNameLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.TextBox codeQryBox;
        private System.Windows.Forms.Label methodCodeLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label typeLabel;
        private CheckBox lockCheck;
    }
}