namespace FinalProject
{
    partial class AddGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.tbAgeRestriction = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listGroup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.providerAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorroviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorroviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age Restriction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(138, 21);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(100, 22);
            this.tbGroupName.TabIndex = 3;
            this.tbGroupName.Validating += new System.ComponentModel.CancelEventHandler(this.tbGroupName_Validating);
            this.tbGroupName.Validated += new System.EventHandler(this.tbGroupName_Validated);
            // 
            // tbAgeRestriction
            // 
            this.tbAgeRestriction.Location = new System.Drawing.Point(138, 59);
            this.tbAgeRestriction.Name = "tbAgeRestriction";
            this.tbAgeRestriction.Size = new System.Drawing.Size(100, 22);
            this.tbAgeRestriction.TabIndex = 4;
            this.tbAgeRestriction.Validating += new System.ComponentModel.CancelEventHandler(this.tbAgeRestriction_Validating);
            this.tbAgeRestriction.Validated += new System.EventHandler(this.tbAgeRestriction_Validated);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(138, 94);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 22);
            this.tbDescription.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.tbGroupName);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAgeRestriction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 164);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listGroup
            // 
            this.listGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listGroup.GridLines = true;
            this.listGroup.HideSelection = false;
            this.listGroup.Location = new System.Drawing.Point(310, 51);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(463, 304);
            this.listGroup.TabIndex = 7;
            this.listGroup.UseCompatibleStateImageBehavior = false;
            this.listGroup.View = System.Windows.Forms.View.Details;
            this.listGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listGroup_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 150;
            // 
            // providerAge
            // 
            this.providerAge.ContainerControl = this;
            // 
            // errorroviderName
            // 
            this.errorroviderName.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Right";
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(138, 129);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(100, 22);
            this.tbRight.TabIndex = 10;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rights";
            this.columnHeader4.Width = 150;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 380);
            this.Controls.Add(this.listGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorroviderName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.TextBox tbAgeRestriction;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listGroup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ErrorProvider providerAge;
        private System.Windows.Forms.ErrorProvider errorroviderName;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}