namespace AddressTest
{
    partial class EditForm
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
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listBoxCC = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonAddTo = new System.Windows.Forms.Button();
            this.buttonAddCC = new System.Windows.Forms.Button();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.buttonResolveAll = new System.Windows.Forms.Button();
            this.buttonDelete1stCC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.Location = new System.Drawing.Point(12, 35);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(342, 95);
            this.listBoxTo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(279, 396);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listBoxCC
            // 
            this.listBoxCC.FormattingEnabled = true;
            this.listBoxCC.Location = new System.Drawing.Point(12, 201);
            this.listBoxCC.Name = "listBoxCC";
            this.listBoxCC.Size = new System.Drawing.Size(342, 95);
            this.listBoxCC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CC";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(12, 138);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(239, 20);
            this.textBoxTo.TabIndex = 5;
            // 
            // buttonAddTo
            // 
            this.buttonAddTo.Location = new System.Drawing.Point(279, 135);
            this.buttonAddTo.Name = "buttonAddTo";
            this.buttonAddTo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTo.TabIndex = 6;
            this.buttonAddTo.Text = "Add to";
            this.buttonAddTo.UseVisualStyleBackColor = true;
            this.buttonAddTo.Click += new System.EventHandler(this.buttonAddTo_Click);
            // 
            // buttonAddCC
            // 
            this.buttonAddCC.Location = new System.Drawing.Point(279, 301);
            this.buttonAddCC.Name = "buttonAddCC";
            this.buttonAddCC.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCC.TabIndex = 8;
            this.buttonAddCC.Text = "Add cc";
            this.buttonAddCC.UseVisualStyleBackColor = true;
            this.buttonAddCC.Click += new System.EventHandler(this.buttonAddCC_Click);
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(12, 304);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(239, 20);
            this.textBoxCC.TabIndex = 7;
            // 
            // buttonResolveAll
            // 
            this.buttonResolveAll.Location = new System.Drawing.Point(12, 396);
            this.buttonResolveAll.Name = "buttonResolveAll";
            this.buttonResolveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonResolveAll.TabIndex = 10;
            this.buttonResolveAll.Text = "Resolve All Participants";
            this.buttonResolveAll.UseVisualStyleBackColor = true;
            this.buttonResolveAll.Click += new System.EventHandler(this.buttonResolveAll_Click);
            // 
            // buttonDelete1stCC
            // 
            this.buttonDelete1stCC.Location = new System.Drawing.Point(279, 175);
            this.buttonDelete1stCC.Name = "buttonDelete1stCC";
            this.buttonDelete1stCC.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete1stCC.TabIndex = 11;
            this.buttonDelete1stCC.Text = "Delete 1st";
            this.buttonDelete1stCC.UseVisualStyleBackColor = true;
            this.buttonDelete1stCC.Click += new System.EventHandler(this.buttonDelete1stCC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete 1st";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDeleteFirstTo_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete1stCC);
            this.Controls.Add(this.buttonResolveAll);
            this.Controls.Add(this.buttonAddCC);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.buttonAddTo);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCC);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTo);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListBox listBoxCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonAddTo;
        private System.Windows.Forms.Button buttonAddCC;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.Button buttonResolveAll;
        private System.Windows.Forms.Button buttonDelete1stCC;
        private System.Windows.Forms.Button button1;
    }
}