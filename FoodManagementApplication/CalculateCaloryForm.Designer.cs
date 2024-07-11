namespace FoodManagementApplication
{
    partial class CalculateCaloryForm
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
            this.textBox_Calory = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Protein = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Fat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Carbo = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_RemoveCal = new System.Windows.Forms.Button();
            this.btn_AddCal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label_TotalCalory = new System.Windows.Forms.Label();
            this.btn_SaveCalInfo = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "레시피 선택";
            // 
            // textBox_Calory
            // 
            this.textBox_Calory.Location = new System.Drawing.Point(417, 128);
            this.textBox_Calory.Name = "textBox_Calory";
            this.textBox_Calory.Size = new System.Drawing.Size(169, 21);
            this.textBox_Calory.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "**요리 선택**";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "칼로리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "단백질";
            // 
            // textBox_Protein
            // 
            this.textBox_Protein.Location = new System.Drawing.Point(414, 164);
            this.textBox_Protein.Name = "textBox_Protein";
            this.textBox_Protein.Size = new System.Drawing.Size(169, 21);
            this.textBox_Protein.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "지방";
            // 
            // textBox_Fat
            // 
            this.textBox_Fat.Location = new System.Drawing.Point(414, 204);
            this.textBox_Fat.Name = "textBox_Fat";
            this.textBox_Fat.Size = new System.Drawing.Size(169, 21);
            this.textBox_Fat.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "탄수화물";
            // 
            // textBox_Carbo
            // 
            this.textBox_Carbo.Location = new System.Drawing.Point(414, 244);
            this.textBox_Carbo.Name = "textBox_Carbo";
            this.textBox_Carbo.Size = new System.Drawing.Size(169, 21);
            this.textBox_Carbo.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 213);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "요리 이름";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "칼로리";
            this.columnHeader2.Width = 132;
            // 
            // btn_RemoveCal
            // 
            this.btn_RemoveCal.Location = new System.Drawing.Point(340, 194);
            this.btn_RemoveCal.Name = "btn_RemoveCal";
            this.btn_RemoveCal.Size = new System.Drawing.Size(30, 30);
            this.btn_RemoveCal.TabIndex = 26;
            this.btn_RemoveCal.Text = ">";
            this.btn_RemoveCal.UseVisualStyleBackColor = true;
            this.btn_RemoveCal.Click += new System.EventHandler(this.btn_RemoveCal_Click);
            // 
            // btn_AddCal
            // 
            this.btn_AddCal.Location = new System.Drawing.Point(340, 129);
            this.btn_AddCal.Name = "btn_AddCal";
            this.btn_AddCal.Size = new System.Drawing.Size(30, 30);
            this.btn_AddCal.TabIndex = 25;
            this.btn_AddCal.Text = "<";
            this.btn_AddCal.UseVisualStyleBackColor = true;
            this.btn_AddCal.Click += new System.EventHandler(this.btn_AddCal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "하루 섭취량 :";
            // 
            // label_TotalCalory
            // 
            this.label_TotalCalory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TotalCalory.Location = new System.Drawing.Point(142, 299);
            this.label_TotalCalory.Name = "label_TotalCalory";
            this.label_TotalCalory.Size = new System.Drawing.Size(172, 33);
            this.label_TotalCalory.TabIndex = 27;
            this.label_TotalCalory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SaveCalInfo
            // 
            this.btn_SaveCalInfo.Location = new System.Drawing.Point(417, 299);
            this.btn_SaveCalInfo.Name = "btn_SaveCalInfo";
            this.btn_SaveCalInfo.Size = new System.Drawing.Size(169, 37);
            this.btn_SaveCalInfo.TabIndex = 28;
            this.btn_SaveCalInfo.Text = "영양 정보 저장";
            this.btn_SaveCalInfo.UseVisualStyleBackColor = true;
            this.btn_SaveCalInfo.Click += new System.EventHandler(this.btn_SaveCalInfo_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(130, 26);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(453, 21);
            this.textBox_Search.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "영양정보 검색";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(589, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 40);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "영양정보 검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(294, -254);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(398, 21);
            this.textBox6.TabIndex = 29;
            // 
            // CalculateCaloryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 348);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.btn_SaveCalInfo);
            this.Controls.Add(this.label_TotalCalory);
            this.Controls.Add(this.btn_RemoveCal);
            this.Controls.Add(this.btn_AddCal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_Carbo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Fat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Protein);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Calory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "CalculateCaloryForm";
            this.Text = "영양 정보 계산";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculateCaloryForm_FormClosing);
            this.Load += new System.EventHandler(this.CalculateCaloryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Calory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Protein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Fat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Carbo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_RemoveCal;
        private System.Windows.Forms.Button btn_AddCal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_TotalCalory;
        private System.Windows.Forms.Button btn_SaveCalInfo;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox textBox6;
    }
}