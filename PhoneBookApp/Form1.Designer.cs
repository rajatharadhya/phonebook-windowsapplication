namespace PhoneBookApp
{
    partial class MainFrm
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
            this.gpbxDetails = new System.Windows.Forms.GroupBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblHPhNo = new System.Windows.Forms.Label();
            this.txtbxHPhNo = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMPhNo = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtbxlEMail = new System.Windows.Forms.TextBox();
            this.txtbxMPhNo = new System.Windows.Forms.TextBox();
            this.txtbxSName = new System.Windows.Forms.TextBox();
            this.txtbxFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbxSearch = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxSearchSName = new System.Windows.Forms.TextBox();
            this.txtbxSearchFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxDetails
            // 
            this.gpbxDetails.Controls.Add(this.lblErrorMsg);
            this.gpbxDetails.Controls.Add(this.lblHPhNo);
            this.gpbxDetails.Controls.Add(this.txtbxHPhNo);
            this.gpbxDetails.Controls.Add(this.lblEMail);
            this.gpbxDetails.Controls.Add(this.btnReset);
            this.gpbxDetails.Controls.Add(this.btnAddNew);
            this.gpbxDetails.Controls.Add(this.lblMPhNo);
            this.gpbxDetails.Controls.Add(this.lblSName);
            this.gpbxDetails.Controls.Add(this.txtbxlEMail);
            this.gpbxDetails.Controls.Add(this.txtbxMPhNo);
            this.gpbxDetails.Controls.Add(this.txtbxSName);
            this.gpbxDetails.Controls.Add(this.txtbxFName);
            this.gpbxDetails.Controls.Add(this.lblFName);
            this.gpbxDetails.Location = new System.Drawing.Point(737, 48);
            this.gpbxDetails.Name = "gpbxDetails";
            this.gpbxDetails.Size = new System.Drawing.Size(343, 219);
            this.gpbxDetails.TabIndex = 1;
            this.gpbxDetails.TabStop = false;
            this.gpbxDetails.Text = "Add New";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(31, 16);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 8;
            // 
            // lblHPhNo
            // 
            this.lblHPhNo.AutoSize = true;
            this.lblHPhNo.Location = new System.Drawing.Point(27, 121);
            this.lblHPhNo.Name = "lblHPhNo";
            this.lblHPhNo.Size = new System.Drawing.Size(51, 13);
            this.lblHPhNo.TabIndex = 6;
            this.lblHPhNo.Text = "Home Ph";
            // 
            // txtbxHPhNo
            // 
            this.txtbxHPhNo.Location = new System.Drawing.Point(114, 118);
            this.txtbxHPhNo.Name = "txtbxHPhNo";
            this.txtbxHPhNo.Size = new System.Drawing.Size(201, 20);
            this.txtbxHPhNo.TabIndex = 4;
            this.txtbxHPhNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHPhNo_KeyPress);
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(26, 151);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(36, 13);
            this.lblEMail.TabIndex = 4;
            this.lblEMail.Text = "E-Mail";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(239, 180);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(30, 180);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblMPhNo
            // 
            this.lblMPhNo.AutoSize = true;
            this.lblMPhNo.Location = new System.Drawing.Point(26, 92);
            this.lblMPhNo.Name = "lblMPhNo";
            this.lblMPhNo.Size = new System.Drawing.Size(54, 13);
            this.lblMPhNo.TabIndex = 3;
            this.lblMPhNo.Text = "Mobile Ph";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(26, 66);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(75, 13);
            this.lblSName.TabIndex = 2;
            this.lblSName.Text = "Second Name";
            // 
            // txtbxlEMail
            // 
            this.txtbxlEMail.Location = new System.Drawing.Point(113, 148);
            this.txtbxlEMail.Name = "txtbxlEMail";
            this.txtbxlEMail.Size = new System.Drawing.Size(201, 20);
            this.txtbxlEMail.TabIndex = 5;
            // 
            // txtbxMPhNo
            // 
            this.txtbxMPhNo.Location = new System.Drawing.Point(113, 89);
            this.txtbxMPhNo.Name = "txtbxMPhNo";
            this.txtbxMPhNo.Size = new System.Drawing.Size(201, 20);
            this.txtbxMPhNo.TabIndex = 3;
            this.txtbxMPhNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMPhNo_KeyPress);
            // 
            // txtbxSName
            // 
            this.txtbxSName.Location = new System.Drawing.Point(113, 63);
            this.txtbxSName.Name = "txtbxSName";
            this.txtbxSName.Size = new System.Drawing.Size(201, 20);
            this.txtbxSName.TabIndex = 2;
            // 
            // txtbxFName
            // 
            this.txtbxFName.Location = new System.Drawing.Point(113, 32);
            this.txtbxFName.Name = "txtbxFName";
            this.txtbxFName.Size = new System.Drawing.Size(201, 20);
            this.txtbxFName.TabIndex = 1;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(26, 37);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(448, 422);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 9;
            this.btnClearList.Text = "Delete All";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(451, 352);
            this.dataGridView1.TabIndex = 4;
            // 
            // gpbxSearch
            // 
            this.gpbxSearch.Controls.Add(this.btnShowAll);
            this.gpbxSearch.Controls.Add(this.btnSearch);
            this.gpbxSearch.Controls.Add(this.label1);
            this.gpbxSearch.Controls.Add(this.txtbxSearchSName);
            this.gpbxSearch.Controls.Add(this.txtbxSearchFName);
            this.gpbxSearch.Controls.Add(this.label2);
            this.gpbxSearch.Location = new System.Drawing.Point(737, 330);
            this.gpbxSearch.Name = "gpbxSearch";
            this.gpbxSearch.Size = new System.Drawing.Size(343, 115);
            this.gpbxSearch.TabIndex = 10;
            this.gpbxSearch.TabStop = false;
            this.gpbxSearch.Text = "Search";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(239, 86);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(29, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Second Name";
            // 
            // txtbxSearchSName
            // 
            this.txtbxSearchSName.Location = new System.Drawing.Point(114, 56);
            this.txtbxSearchSName.Name = "txtbxSearchSName";
            this.txtbxSearchSName.Size = new System.Drawing.Size(201, 20);
            this.txtbxSearchSName.TabIndex = 6;
            // 
            // txtbxSearchFName
            // 
            this.txtbxSearchFName.Location = new System.Drawing.Point(114, 25);
            this.txtbxSearchFName.Name = "txtbxSearchFName";
            this.txtbxSearchFName.Size = new System.Drawing.Size(201, 20);
            this.txtbxSearchFName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert to PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(595, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 355);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(469, 48);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 355);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Check D drive for PDF file";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gpbxDetails);
            this.Name = "MainFrm";
            this.Text = "Phone Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.gpbxDetails.ResumeLayout(false);
            this.gpbxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbxSearch.ResumeLayout(false);
            this.gpbxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDetails;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblMPhNo;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.TextBox txtbxlEMail;
        private System.Windows.Forms.TextBox txtbxMPhNo;
        private System.Windows.Forms.TextBox txtbxSName;
        private System.Windows.Forms.TextBox txtbxFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHPhNo;
        private System.Windows.Forms.TextBox txtbxHPhNo;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbxSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxSearchSName;
        private System.Windows.Forms.TextBox txtbxSearchFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
    }
}

