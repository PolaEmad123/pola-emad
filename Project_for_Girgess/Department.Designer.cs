namespace Project_pola emad 
{
     partial class Department
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed;
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
        this.label8 = new System.Windows.Forms.Label();
        this.AddBtn = new System.Windows.Forms.Button();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.EditBtn = new System.Windows.Forms.Button();
        this.DeptList = new Guna.UI2.WinForms.Guna2DataGridView();
        this.DeptName = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label1 = new System.Windows.Forms.Label();
        this.panel1 = new System.Windows.Forms.Panel();
        this.label3 = new System.Windows.Forms.Label();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.pictureBox3 = new System.Windows.Forms.PictureBox();
        this.pictureBox4 = new System.Windows.Forms.PictureBox();
        this.pictureBox5 = new System.Windows.Forms.PictureBox();
        this.EmpPage = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.DeleteBtn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.DeptList)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
        this.SuspendLayout();
        // 
        // label8
        //
        this.label8.AutoSize = true;
        this.label8.BackColor = System.Drawing.Color.Teal;
        this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label8.ForeColor = System.Drawing.SystemColors.Control;
        this.label8.Location = new System.Drawing.Point(290, 25);
        this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(351, 22);
        this.label8.TabIndex = 22;
        this.label8.Text = "Employee System Managment Version 1.0";
        // 
        // AddBtn
        //
        this.AddBtn.BackColor = System.Drawing.Color.Teal;
        this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.AddBtn.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.AddBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
        this.AddBtn.Location = new System.Drawing.Point(12, 225);
        this.AddBtn.Name = "AddBtn";
        this.AddBtn.Size = new System.Drawing.Size(82, 33);
        this.AddBtn.TabIndex = 38;
        this.AddBtn.Text = "Add";
        this.AddBtn.UseVisualStyleBackColor = false;
        this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
        //
        // EditBtn
        // 
        this.EditBtn.BackColor = System.Drawing.Color.Teal;
        this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.EditBtn.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.EditBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
        this.EditBtn.Location = new System.Drawing.Point(129, 225);
        this.EditBtn.Name = "EditBtn";
        this.EditBtn.Size = new System.Drawing.Size(82, 33);
        this.EditBtn.TabIndex = 39;
        this.EditBtn.Text = "Update";
        this.EditBtn.UseVisualStyleBackColor = false;
        this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
        //
        // DeptList
        // 
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
        this.DeptList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.DeptList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.DeptList.ColumnHeadersHeight = 25;
        this.DeptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.DeptList.DefaultCellStyle = dataGridViewCellStyle3;
        this.DeptList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
        this.DeptList.Location = new System.Drawing.Point(230, 187);
        this.DeptList.Name = "DeptList";
        this.DeptList.RowHeadersVisible = false;
        this.DeptList.Size = new System.Drawing.Size(555, 178);
        this.DeptList.TabIndex = 37;
        this.DeptList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
        this.DeptList.ThemeStyle.AlternatingRowsStyle.Font = null;
        this.DeptList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
        this.DeptList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
        this.DeptList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
        this.DeptList.ThemeStyle.BackColor = System.Drawing.Color.White;
        this.DeptList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
        this.DeptList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
        this.DeptList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        this.DeptList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.DeptList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
        this.DeptList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        this.DeptList.ThemeStyle.HeaderStyle.Height = 25;
        this.DeptList.ThemeStyle.ReadOnly = false;
        this.DeptList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
        this.DeptList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        this.DeptList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.DeptList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Teal;
        this.DeptList.ThemeStyle.RowsStyle.Height = 22;
        this.DeptList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
        this.DeptList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
        this.DeptList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeptList_CellContentClick);
        //
        // DeptName
        // 
        this.DeptName.Location = new System.Drawing.Point(12, 187);
        this.DeptName.Name = "DeptName";
        this.DeptName.Size = new System.Drawing.Size(199, 20);
        this.DeptName.TabIndex = 26;
        //
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.BackColor = System.Drawing.Color.White;
        this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.ForeColor = System.Drawing.Color.Teal;
        this.label2.Location = new System.Drawing.Point(13, 156);
        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(118, 19);
        this.label2.TabIndex = 25;
        this.label2.Text = "Employee Name";
        //
        // pictureBox1
        //
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(12, 65);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(164, 78);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 24;
        this.pictureBox1.TabStop = false;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.BackColor = System.Drawing.Color.White;
        this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.ForeColor = System.Drawing.Color.Teal;
        this.label1.Location = new System.Drawing.Point(373, 121);
        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(177, 22);
        this.label1.TabIndex = 23;
        this.label1.Text = "Manage Department";
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.Teal;
        this.panel1.Controls.Add(this.label8);
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(920, 59);
        this.panel1.TabIndex = 22;
        //