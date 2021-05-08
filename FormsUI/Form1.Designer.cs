
namespace FormsUI
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
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxChosenMovieUpdate = new System.Windows.Forms.TextBox();
            this.tbxAgeUpdate = new System.Windows.Forms.TextBox();
            this.tbxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.lblChosenMovieUpdate = new System.Windows.Forms.Label();
            this.lblAgeUpdate = new System.Windows.Forms.Label();
            this.lblLastNameUpdate = new System.Windows.Forms.Label();
            this.lblFirstNameUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxChosenMovieAdd = new System.Windows.Forms.TextBox();
            this.tbxAgeAdd = new System.Windows.Forms.TextBox();
            this.tbxLastNameAdd = new System.Windows.Forms.TextBox();
            this.tbxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.lblChosenMovieAdd = new System.Windows.Forms.Label();
            this.lblAgeAdd = new System.Windows.Forms.Label();
            this.lblLastNameAdd = new System.Windows.Forms.Label();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.tbxMaxAgeSearch = new System.Windows.Forms.GroupBox();
            this.gbxSearchByAge = new System.Windows.Forms.GroupBox();
            this.tbxMaxAgeSearching = new System.Windows.Forms.TextBox();
            this.tbxMinAgeSearching = new System.Windows.Forms.TextBox();
            this.lblMaxAgeSearch = new System.Windows.Forms.Label();
            this.lblMinAgeSearch = new System.Windows.Forms.Label();
            this.tbxChosenMovieSearch = new System.Windows.Forms.TextBox();
            this.lblChosenMovieSearch = new System.Windows.Forms.Label();
            this.tbxLastNameSearching = new System.Windows.Forms.TextBox();
            this.lblLastNameSearching = new System.Windows.Forms.Label();
            this.tbxFirstNameSearching = new System.Windows.Forms.TextBox();
            this.lblFirstNameSearching = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.tbxMaxAgeSearch.SuspendLayout();
            this.gbxSearchByAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.Size = new System.Drawing.Size(906, 203);
            this.dgwCustomers.TabIndex = 0;
            this.dgwCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomers_CellDoubleClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxCrud.Location = new System.Drawing.Point(12, 221);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(542, 301);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::FormsUI.Properties.Resources.checkmarksmallicon__2_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(418, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxChosenMovieUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAgeUpdate);
            this.gbxUpdate.Controls.Add(this.tbxLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxFirstNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblChosenMovieUpdate);
            this.gbxUpdate.Controls.Add(this.lblAgeUpdate);
            this.gbxUpdate.Controls.Add(this.lblLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblFirstNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(279, 26);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(257, 218);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "UPDATE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Image = global::FormsUI.Properties.Resources.checkmarksmallicon__2_;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(139, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 37);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxChosenMovieUpdate
            // 
            this.tbxChosenMovieUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChosenMovieUpdate.Location = new System.Drawing.Point(151, 131);
            this.tbxChosenMovieUpdate.Name = "tbxChosenMovieUpdate";
            this.tbxChosenMovieUpdate.Size = new System.Drawing.Size(91, 26);
            this.tbxChosenMovieUpdate.TabIndex = 7;
            // 
            // tbxAgeUpdate
            // 
            this.tbxAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAgeUpdate.Location = new System.Drawing.Point(151, 96);
            this.tbxAgeUpdate.Name = "tbxAgeUpdate";
            this.tbxAgeUpdate.Size = new System.Drawing.Size(91, 26);
            this.tbxAgeUpdate.TabIndex = 6;
            // 
            // tbxLastNameUpdate
            // 
            this.tbxLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastNameUpdate.Location = new System.Drawing.Point(151, 61);
            this.tbxLastNameUpdate.Name = "tbxLastNameUpdate";
            this.tbxLastNameUpdate.Size = new System.Drawing.Size(91, 26);
            this.tbxLastNameUpdate.TabIndex = 5;
            // 
            // tbxFirstNameUpdate
            // 
            this.tbxFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstNameUpdate.Location = new System.Drawing.Point(151, 26);
            this.tbxFirstNameUpdate.Name = "tbxFirstNameUpdate";
            this.tbxFirstNameUpdate.Size = new System.Drawing.Size(91, 26);
            this.tbxFirstNameUpdate.TabIndex = 4;
            // 
            // lblChosenMovieUpdate
            // 
            this.lblChosenMovieUpdate.AutoSize = true;
            this.lblChosenMovieUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChosenMovieUpdate.Location = new System.Drawing.Point(18, 131);
            this.lblChosenMovieUpdate.Name = "lblChosenMovieUpdate";
            this.lblChosenMovieUpdate.Size = new System.Drawing.Size(116, 20);
            this.lblChosenMovieUpdate.TabIndex = 3;
            this.lblChosenMovieUpdate.Text = "ChosenMovie";
            // 
            // lblAgeUpdate
            // 
            this.lblAgeUpdate.AutoSize = true;
            this.lblAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeUpdate.Location = new System.Drawing.Point(18, 99);
            this.lblAgeUpdate.Name = "lblAgeUpdate";
            this.lblAgeUpdate.Size = new System.Drawing.Size(41, 20);
            this.lblAgeUpdate.TabIndex = 2;
            this.lblAgeUpdate.Text = "Age";
            // 
            // lblLastNameUpdate
            // 
            this.lblLastNameUpdate.AutoSize = true;
            this.lblLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameUpdate.Location = new System.Drawing.Point(18, 67);
            this.lblLastNameUpdate.Name = "lblLastNameUpdate";
            this.lblLastNameUpdate.Size = new System.Drawing.Size(90, 20);
            this.lblLastNameUpdate.TabIndex = 1;
            this.lblLastNameUpdate.Text = "LastName";
            // 
            // lblFirstNameUpdate
            // 
            this.lblFirstNameUpdate.AutoSize = true;
            this.lblFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(18, 32);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(91, 20);
            this.lblFirstNameUpdate.TabIndex = 0;
            this.lblFirstNameUpdate.Text = "FirstName";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxChosenMovieAdd);
            this.gbxAdd.Controls.Add(this.tbxAgeAdd);
            this.gbxAdd.Controls.Add(this.tbxLastNameAdd);
            this.gbxAdd.Controls.Add(this.tbxFirstNameAdd);
            this.gbxAdd.Controls.Add(this.lblChosenMovieAdd);
            this.gbxAdd.Controls.Add(this.lblAgeAdd);
            this.gbxAdd.Controls.Add(this.lblLastNameAdd);
            this.gbxAdd.Controls.Add(this.lblFirstNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(6, 26);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(267, 218);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "ADD";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Image = global::FormsUI.Properties.Resources.checkmarksmallicon__2_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(168, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxChosenMovieAdd
            // 
            this.tbxChosenMovieAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxChosenMovieAdd.Location = new System.Drawing.Point(156, 131);
            this.tbxChosenMovieAdd.Name = "tbxChosenMovieAdd";
            this.tbxChosenMovieAdd.Size = new System.Drawing.Size(93, 26);
            this.tbxChosenMovieAdd.TabIndex = 7;
            // 
            // tbxAgeAdd
            // 
            this.tbxAgeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAgeAdd.Location = new System.Drawing.Point(156, 99);
            this.tbxAgeAdd.Name = "tbxAgeAdd";
            this.tbxAgeAdd.Size = new System.Drawing.Size(93, 26);
            this.tbxAgeAdd.TabIndex = 6;
            this.tbxAgeAdd.Text = " ";
            // 
            // tbxLastNameAdd
            // 
            this.tbxLastNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastNameAdd.Location = new System.Drawing.Point(156, 69);
            this.tbxLastNameAdd.Name = "tbxLastNameAdd";
            this.tbxLastNameAdd.Size = new System.Drawing.Size(93, 26);
            this.tbxLastNameAdd.TabIndex = 5;
            // 
            // tbxFirstNameAdd
            // 
            this.tbxFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstNameAdd.Location = new System.Drawing.Point(156, 29);
            this.tbxFirstNameAdd.Name = "tbxFirstNameAdd";
            this.tbxFirstNameAdd.Size = new System.Drawing.Size(93, 26);
            this.tbxFirstNameAdd.TabIndex = 4;
            // 
            // lblChosenMovieAdd
            // 
            this.lblChosenMovieAdd.AutoSize = true;
            this.lblChosenMovieAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChosenMovieAdd.Location = new System.Drawing.Point(17, 137);
            this.lblChosenMovieAdd.Name = "lblChosenMovieAdd";
            this.lblChosenMovieAdd.Size = new System.Drawing.Size(116, 20);
            this.lblChosenMovieAdd.TabIndex = 3;
            this.lblChosenMovieAdd.Text = "ChosenMovie";
            // 
            // lblAgeAdd
            // 
            this.lblAgeAdd.AutoSize = true;
            this.lblAgeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeAdd.Location = new System.Drawing.Point(17, 102);
            this.lblAgeAdd.Name = "lblAgeAdd";
            this.lblAgeAdd.Size = new System.Drawing.Size(41, 20);
            this.lblAgeAdd.TabIndex = 2;
            this.lblAgeAdd.Text = "Age";
            // 
            // lblLastNameAdd
            // 
            this.lblLastNameAdd.AutoSize = true;
            this.lblLastNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameAdd.Location = new System.Drawing.Point(17, 69);
            this.lblLastNameAdd.Name = "lblLastNameAdd";
            this.lblLastNameAdd.Size = new System.Drawing.Size(90, 20);
            this.lblLastNameAdd.TabIndex = 1;
            this.lblLastNameAdd.Text = "LastName";
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.AutoSize = true;
            this.lblFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameAdd.Location = new System.Drawing.Point(17, 32);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(91, 20);
            this.lblFirstNameAdd.TabIndex = 0;
            this.lblFirstNameAdd.Text = "FirstName";
            // 
            // tbxMaxAgeSearch
            // 
            this.tbxMaxAgeSearch.Controls.Add(this.gbxSearchByAge);
            this.tbxMaxAgeSearch.Controls.Add(this.tbxChosenMovieSearch);
            this.tbxMaxAgeSearch.Controls.Add(this.lblChosenMovieSearch);
            this.tbxMaxAgeSearch.Controls.Add(this.tbxLastNameSearching);
            this.tbxMaxAgeSearch.Controls.Add(this.lblLastNameSearching);
            this.tbxMaxAgeSearch.Controls.Add(this.tbxFirstNameSearching);
            this.tbxMaxAgeSearch.Controls.Add(this.lblFirstNameSearching);
            this.tbxMaxAgeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxMaxAgeSearch.Location = new System.Drawing.Point(560, 221);
            this.tbxMaxAgeSearch.Name = "tbxMaxAgeSearch";
            this.tbxMaxAgeSearch.Size = new System.Drawing.Size(358, 301);
            this.tbxMaxAgeSearch.TabIndex = 2;
            this.tbxMaxAgeSearch.TabStop = false;
            this.tbxMaxAgeSearch.Text = "Searching";
            this.tbxMaxAgeSearch.Visible = false;
            // 
            // gbxSearchByAge
            // 
            this.gbxSearchByAge.Controls.Add(this.tbxMaxAgeSearching);
            this.gbxSearchByAge.Controls.Add(this.tbxMinAgeSearching);
            this.gbxSearchByAge.Controls.Add(this.lblMaxAgeSearch);
            this.gbxSearchByAge.Controls.Add(this.lblMinAgeSearch);
            this.gbxSearchByAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearchByAge.Location = new System.Drawing.Point(11, 174);
            this.gbxSearchByAge.Name = "gbxSearchByAge";
            this.gbxSearchByAge.Size = new System.Drawing.Size(233, 111);
            this.gbxSearchByAge.TabIndex = 6;
            this.gbxSearchByAge.TabStop = false;
            this.gbxSearchByAge.Text = "Search By Age";
            // 
            // tbxMaxAgeSearching
            // 
            this.tbxMaxAgeSearching.Location = new System.Drawing.Point(121, 72);
            this.tbxMaxAgeSearching.Name = "tbxMaxAgeSearching";
            this.tbxMaxAgeSearching.Size = new System.Drawing.Size(63, 26);
            this.tbxMaxAgeSearching.TabIndex = 3;
            this.tbxMaxAgeSearching.TextChanged += new System.EventHandler(this.tbxMaxAgeSearching_TextChanged);
            // 
            // tbxMinAgeSearching
            // 
            this.tbxMinAgeSearching.Location = new System.Drawing.Point(121, 33);
            this.tbxMinAgeSearching.Name = "tbxMinAgeSearching";
            this.tbxMinAgeSearching.Size = new System.Drawing.Size(63, 26);
            this.tbxMinAgeSearching.TabIndex = 2;
            this.tbxMinAgeSearching.TextChanged += new System.EventHandler(this.tbxMinAgeSearching_TextChanged_1);
            // 
            // lblMaxAgeSearch
            // 
            this.lblMaxAgeSearch.AutoSize = true;
            this.lblMaxAgeSearch.Location = new System.Drawing.Point(18, 75);
            this.lblMaxAgeSearch.Name = "lblMaxAgeSearch";
            this.lblMaxAgeSearch.Size = new System.Drawing.Size(67, 20);
            this.lblMaxAgeSearch.TabIndex = 1;
            this.lblMaxAgeSearch.Text = "MaxAge";
            // 
            // lblMinAgeSearch
            // 
            this.lblMinAgeSearch.AutoSize = true;
            this.lblMinAgeSearch.Location = new System.Drawing.Point(18, 33);
            this.lblMinAgeSearch.Name = "lblMinAgeSearch";
            this.lblMinAgeSearch.Size = new System.Drawing.Size(63, 20);
            this.lblMinAgeSearch.TabIndex = 0;
            this.lblMinAgeSearch.Text = "MinAge";
            // 
            // tbxChosenMovieSearch
            // 
            this.tbxChosenMovieSearch.Location = new System.Drawing.Point(132, 121);
            this.tbxChosenMovieSearch.Name = "tbxChosenMovieSearch";
            this.tbxChosenMovieSearch.Size = new System.Drawing.Size(112, 27);
            this.tbxChosenMovieSearch.TabIndex = 5;
            this.tbxChosenMovieSearch.TextChanged += new System.EventHandler(this.tbxChosenMovieSearch_TextChanged);
            // 
            // lblChosenMovieSearch
            // 
            this.lblChosenMovieSearch.AutoSize = true;
            this.lblChosenMovieSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChosenMovieSearch.Location = new System.Drawing.Point(7, 129);
            this.lblChosenMovieSearch.Name = "lblChosenMovieSearch";
            this.lblChosenMovieSearch.Size = new System.Drawing.Size(119, 22);
            this.lblChosenMovieSearch.TabIndex = 4;
            this.lblChosenMovieSearch.Text = "ChosenMovie";
            // 
            // tbxLastNameSearching
            // 
            this.tbxLastNameSearching.Location = new System.Drawing.Point(132, 82);
            this.tbxLastNameSearching.Name = "tbxLastNameSearching";
            this.tbxLastNameSearching.Size = new System.Drawing.Size(112, 27);
            this.tbxLastNameSearching.TabIndex = 3;
            this.tbxLastNameSearching.TextChanged += new System.EventHandler(this.tbxLastNameSearching_TextChanged);
            // 
            // lblLastNameSearching
            // 
            this.lblLastNameSearching.AutoSize = true;
            this.lblLastNameSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameSearching.Location = new System.Drawing.Point(19, 87);
            this.lblLastNameSearching.Name = "lblLastNameSearching";
            this.lblLastNameSearching.Size = new System.Drawing.Size(91, 22);
            this.lblLastNameSearching.TabIndex = 2;
            this.lblLastNameSearching.Text = "LastName";
            // 
            // tbxFirstNameSearching
            // 
            this.tbxFirstNameSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstNameSearching.Location = new System.Drawing.Point(132, 40);
            this.tbxFirstNameSearching.Name = "tbxFirstNameSearching";
            this.tbxFirstNameSearching.Size = new System.Drawing.Size(112, 26);
            this.tbxFirstNameSearching.TabIndex = 1;
            this.tbxFirstNameSearching.TextChanged += new System.EventHandler(this.tbxFirstNameSearching_TextChanged);
            // 
            // lblFirstNameSearching
            // 
            this.lblFirstNameSearching.AutoSize = true;
            this.lblFirstNameSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameSearching.Location = new System.Drawing.Point(19, 44);
            this.lblFirstNameSearching.Name = "lblFirstNameSearching";
            this.lblFirstNameSearching.Size = new System.Drawing.Size(92, 22);
            this.lblFirstNameSearching.TabIndex = 0;
            this.lblFirstNameSearching.Text = "FirstName";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(930, 534);
            this.Controls.Add(this.tbxMaxAgeSearch);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwCustomers);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.tbxMaxAgeSearch.ResumeLayout(false);
            this.tbxMaxAgeSearch.PerformLayout();
            this.gbxSearchByAge.ResumeLayout(false);
            this.gbxSearchByAge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label lblChosenMovieAdd;
        private System.Windows.Forms.Label lblAgeAdd;
        private System.Windows.Forms.Label lblLastNameAdd;
        private System.Windows.Forms.Label lblFirstNameAdd;
        private System.Windows.Forms.TextBox tbxChosenMovieUpdate;
        private System.Windows.Forms.TextBox tbxAgeUpdate;
        private System.Windows.Forms.TextBox tbxLastNameUpdate;
        private System.Windows.Forms.TextBox tbxFirstNameUpdate;
        private System.Windows.Forms.Label lblChosenMovieUpdate;
        private System.Windows.Forms.Label lblAgeUpdate;
        private System.Windows.Forms.Label lblLastNameUpdate;
        private System.Windows.Forms.Label lblFirstNameUpdate;
        private System.Windows.Forms.TextBox tbxChosenMovieAdd;
        private System.Windows.Forms.TextBox tbxAgeAdd;
        private System.Windows.Forms.TextBox tbxLastNameAdd;
        private System.Windows.Forms.TextBox tbxFirstNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox tbxMaxAgeSearch;
        private System.Windows.Forms.TextBox tbxFirstNameSearching;
        private System.Windows.Forms.Label lblFirstNameSearching;
        private System.Windows.Forms.TextBox tbxLastNameSearching;
        private System.Windows.Forms.Label lblLastNameSearching;
        private System.Windows.Forms.TextBox tbxChosenMovieSearch;
        private System.Windows.Forms.Label lblChosenMovieSearch;
        private System.Windows.Forms.GroupBox gbxSearchByAge;
        private System.Windows.Forms.TextBox tbxMaxAgeSearching;
        private System.Windows.Forms.TextBox tbxMinAgeSearching;
        private System.Windows.Forms.Label lblMaxAgeSearch;
        private System.Windows.Forms.Label lblMinAgeSearch;
    }
}

