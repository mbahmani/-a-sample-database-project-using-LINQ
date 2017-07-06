namespace WindowsFormsApplication13
{
    partial class frEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txrow = new System.Windows.Forms.TextBox();
            this.txname = new System.Windows.Forms.TextBox();
            this.txfamily = new System.Windows.Forms.TextBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family";
            // 
            // txrow
            // 
            this.txrow.Location = new System.Drawing.Point(170, 58);
            this.txrow.Name = "txrow";
            this.txrow.Size = new System.Drawing.Size(100, 20);
            this.txrow.TabIndex = 3;
            this.txrow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txname
            // 
            this.txname.Location = new System.Drawing.Point(170, 108);
            this.txname.Name = "txname";
            this.txname.Size = new System.Drawing.Size(329, 20);
            this.txname.TabIndex = 4;
            this.txname.TextChanged += new System.EventHandler(this.txname_TextChanged);
            // 
            // txfamily
            // 
            this.txfamily.Location = new System.Drawing.Point(170, 157);
            this.txfamily.Name = "txfamily";
            this.txfamily.Size = new System.Drawing.Size(329, 20);
            this.txfamily.TabIndex = 5;
            this.txfamily.Text = "B";
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(288, 286);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(415, 286);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 7;
            this.btcancel.Text = "cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // frEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 341);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.txfamily);
            this.Controls.Add(this.txname);
            this.Controls.Add(this.txrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frEdit";
            this.Text = "frEdit";
            this.Load += new System.EventHandler(this.frEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btcancel;
        public System.Windows.Forms.TextBox txrow;
        public System.Windows.Forms.TextBox txname;
        public System.Windows.Forms.TextBox txfamily;
    }
}