namespace WindowsFormsApplication13
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
            this.components = new System.ComponentModel.Container();
            this.btsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txrow = new System.Windows.Forms.TextBox();
            this.txname = new System.Windows.Forms.TextBox();
            this.txfamily = new System.Windows.Forms.TextBox();
            this.gvtable1 = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydb1DataSet = new WindowsFormsApplication13.mydb1DataSet();
            this.table1TableAdapter = new WindowsFormsApplication13.mydb1DataSetTableAdapters.Table1TableAdapter();
            this.btdelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txfamilysearch = new System.Windows.Forms.TextBox();
            this.btclose = new System.Windows.Forms.Button();
            this.btcount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txcount = new System.Windows.Forms.TextBox();
            this.cballname = new System.Windows.Forms.ComboBox();
            this.btshowname = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txshart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvtable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydb1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btsave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsave.Location = new System.Drawing.Point(14, 407);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 0;
            this.btsave.Text = "save";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "family";
            // 
            // txrow
            // 
            this.txrow.Location = new System.Drawing.Point(104, 165);
            this.txrow.Name = "txrow";
            this.txrow.Size = new System.Drawing.Size(100, 20);
            this.txrow.TabIndex = 4;
            // 
            // txname
            // 
            this.txname.Location = new System.Drawing.Point(104, 201);
            this.txname.Name = "txname";
            this.txname.Size = new System.Drawing.Size(346, 20);
            this.txname.TabIndex = 5;
            // 
            // txfamily
            // 
            this.txfamily.Location = new System.Drawing.Point(104, 249);
            this.txfamily.Name = "txfamily";
            this.txfamily.Size = new System.Drawing.Size(346, 20);
            this.txfamily.TabIndex = 6;
            // 
            // gvtable1
            // 
            this.gvtable1.AllowUserToAddRows = false;
            this.gvtable1.AllowUserToDeleteRows = false;
            this.gvtable1.AutoGenerateColumns = false;
            this.gvtable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvtable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.name,
            this.family});
            this.gvtable1.DataSource = this.table1BindingSource;
            this.gvtable1.Location = new System.Drawing.Point(12, 3);
            this.gvtable1.Name = "gvtable1";
            this.gvtable1.RowHeadersVisible = false;
            this.gvtable1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvtable1.Size = new System.Drawing.Size(587, 150);
            this.gvtable1.TabIndex = 7;
            this.gvtable1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvtable1_DoubleClick);
            // 
            // row
            // 
            this.row.DataPropertyName = "row";
            this.row.HeaderText = "row";
            this.row.Name = "row";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "family";
            this.family.Name = "family";
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.mydb1DataSet;
            // 
            // mydb1DataSet
            // 
            this.mydb1DataSet.DataSetName = "mydb1DataSet";
            this.mydb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btdelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btdelete.Location = new System.Drawing.Point(114, 407);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 8;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search Family";
            // 
            // txfamilysearch
            // 
            this.txfamilysearch.Location = new System.Drawing.Point(748, 71);
            this.txfamilysearch.Name = "txfamilysearch";
            this.txfamilysearch.Size = new System.Drawing.Size(100, 20);
            this.txfamilysearch.TabIndex = 10;
            this.txfamilysearch.TextChanged += new System.EventHandler(this.txfamilysearch_TextChanged);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btclose.ForeColor = System.Drawing.SystemColors.Control;
            this.btclose.Location = new System.Drawing.Point(247, 407);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(75, 23);
            this.btclose.TabIndex = 11;
            this.btclose.Text = "close";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btcount
            // 
            this.btcount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btcount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btcount.Location = new System.Drawing.Point(375, 407);
            this.btcount.Name = "btcount";
            this.btcount.Size = new System.Drawing.Size(75, 23);
            this.btcount.TabIndex = 13;
            this.btcount.Text = "count";
            this.btcount.UseVisualStyleBackColor = false;
            this.btcount.Click += new System.EventHandler(this.btcount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "count";
            // 
            // txcount
            // 
            this.txcount.Location = new System.Drawing.Point(748, 6);
            this.txcount.Name = "txcount";
            this.txcount.Size = new System.Drawing.Size(100, 20);
            this.txcount.TabIndex = 15;
            // 
            // cballname
            // 
            this.cballname.FormattingEnabled = true;
            this.cballname.Location = new System.Drawing.Point(748, 137);
            this.cballname.Name = "cballname";
            this.cballname.Size = new System.Drawing.Size(121, 21);
            this.cballname.TabIndex = 16;
            // 
            // btshowname
            // 
            this.btshowname.BackColor = System.Drawing.SystemColors.Highlight;
            this.btshowname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btshowname.Location = new System.Drawing.Point(524, 407);
            this.btshowname.Name = "btshowname";
            this.btshowname.Size = new System.Drawing.Size(75, 23);
            this.btshowname.TabIndex = 17;
            this.btshowname.Text = "show name";
            this.btshowname.UseVisualStyleBackColor = false;
            this.btshowname.Click += new System.EventHandler(this.btshowname_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "show query";
            // 
            // txshart
            // 
            this.txshart.Location = new System.Drawing.Point(748, 37);
            this.txshart.Name = "txshart";
            this.txshart.Size = new System.Drawing.Size(100, 20);
            this.txshart.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "count with shart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1014, 479);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txshart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btshowname);
            this.Controls.Add(this.cballname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txfamilysearch);
            this.Controls.Add(this.txcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btcount);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.gvtable1);
            this.Controls.Add(this.txfamily);
            this.Controls.Add(this.txname);
            this.Controls.Add(this.txrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsave);
            this.Name = "Form1";
            this.Text = " a sample database project using LINQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvtable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydb1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txrow;
        private System.Windows.Forms.TextBox txname;
        private System.Windows.Forms.TextBox txfamily;
        private System.Windows.Forms.DataGridView gvtable1;
        private mydb1DataSet mydb1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private mydb1DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txfamilysearch;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txcount;
        private System.Windows.Forms.ComboBox cballname;
        private System.Windows.Forms.Button btshowname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txshart;
        private System.Windows.Forms.Label label7;
    }
}