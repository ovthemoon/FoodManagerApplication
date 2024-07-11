namespace FoodManagementApplication
{
    partial class IngredientForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_recommendFood = new System.Windows.Forms.Button();
            this.btn_removeIng = new System.Windows.Forms.Button();
            this.btn_checkRecipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_deleteExpiredIngAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_registerIng = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.textBox_IngName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_calculateKal = new System.Windows.Forms.Button();
            this.btn_ToShop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재료불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영양정보불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.재료데이터저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피데이터저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영양정보데이터저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_recommendFood
            // 
            this.btn_recommendFood.Location = new System.Drawing.Point(388, 260);
            this.btn_recommendFood.Name = "btn_recommendFood";
            this.btn_recommendFood.Size = new System.Drawing.Size(140, 63);
            this.btn_recommendFood.TabIndex = 4;
            this.btn_recommendFood.Text = "요리 추천 받기";
            this.btn_recommendFood.UseVisualStyleBackColor = true;
            this.btn_recommendFood.Click += new System.EventHandler(this.btn_recommendFood_Click);
            // 
            // btn_removeIng
            // 
            this.btn_removeIng.Location = new System.Drawing.Point(195, 549);
            this.btn_removeIng.Name = "btn_removeIng";
            this.btn_removeIng.Size = new System.Drawing.Size(141, 50);
            this.btn_removeIng.TabIndex = 6;
            this.btn_removeIng.Text = "재료 삭제하기";
            this.btn_removeIng.UseVisualStyleBackColor = true;
            this.btn_removeIng.Click += new System.EventHandler(this.btn_removeIng_Click);
            // 
            // btn_checkRecipe
            // 
            this.btn_checkRecipe.Location = new System.Drawing.Point(388, 411);
            this.btn_checkRecipe.Name = "btn_checkRecipe";
            this.btn_checkRecipe.Size = new System.Drawing.Size(140, 63);
            this.btn_checkRecipe.TabIndex = 7;
            this.btn_checkRecipe.Text = "레시피 창 열기";
            this.btn_checkRecipe.UseVisualStyleBackColor = true;
            this.btn_checkRecipe.Click += new System.EventHandler(this.btn_checkRecipe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "재료 항목";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 167);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "재료 이름";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "유통기한";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "용량 / 수량";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "계량 단위";
            this.columnHeader4.Width = 91;
            // 
            // btn_deleteExpiredIngAll
            // 
            this.btn_deleteExpiredIngAll.Location = new System.Drawing.Point(402, 24);
            this.btn_deleteExpiredIngAll.Name = "btn_deleteExpiredIngAll";
            this.btn_deleteExpiredIngAll.Size = new System.Drawing.Size(127, 34);
            this.btn_deleteExpiredIngAll.TabIndex = 6;
            this.btn_deleteExpiredIngAll.Text = "유통기한 지난 재료 삭제하기";
            this.btn_deleteExpiredIngAll.UseVisualStyleBackColor = true;
            this.btn_deleteExpiredIngAll.Click += new System.EventHandler(this.btn_deleteExpiredIngAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btn_registerIng
            // 
            this.btn_registerIng.Location = new System.Drawing.Point(30, 549);
            this.btn_registerIng.Name = "btn_registerIng";
            this.btn_registerIng.Size = new System.Drawing.Size(141, 50);
            this.btn_registerIng.TabIndex = 14;
            this.btn_registerIng.Text = "재료 등록/\r\n수정하기";
            this.btn_registerIng.UseVisualStyleBackColor = true;
            this.btn_registerIng.Click += new System.EventHandler(this.btn_registering_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(37, 382);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(29, 12);
            this.unitLabel.TabIndex = 13;
            this.unitLabel.Text = "수량";
            // 
            // textBox_IngName
            // 
            this.textBox_IngName.Location = new System.Drawing.Point(37, 273);
            this.textBox_IngName.Name = "textBox_IngName";
            this.textBox_IngName.Size = new System.Drawing.Size(264, 21);
            this.textBox_IngName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "재료 이름";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(37, 462);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(120, 21);
            this.domainUpDown1.TabIndex = 17;
            this.domainUpDown1.Text = "**계량 단위**";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "유통기한";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "계량 단위";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(37, 397);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(120, 21);
            this.textBox_Count.TabIndex = 12;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(391, 549);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(141, 50);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "입력란 초기화";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_calculateKal
            // 
            this.btn_calculateKal.Location = new System.Drawing.Point(388, 333);
            this.btn_calculateKal.Name = "btn_calculateKal";
            this.btn_calculateKal.Size = new System.Drawing.Size(140, 63);
            this.btn_calculateKal.TabIndex = 26;
            this.btn_calculateKal.Text = "영양정보 계산하기";
            this.btn_calculateKal.UseVisualStyleBackColor = true;
            this.btn_calculateKal.Click += new System.EventHandler(this.btn_calculateKal_Click);
            // 
            // btn_ToShop
            // 
            this.btn_ToShop.Location = new System.Drawing.Point(388, 480);
            this.btn_ToShop.Name = "btn_ToShop";
            this.btn_ToShop.Size = new System.Drawing.Size(140, 63);
            this.btn_ToShop.TabIndex = 27;
            this.btn_ToShop.Text = "장바구니 열기";
            this.btn_ToShop.UseVisualStyleBackColor = true;
            this.btn_ToShop.Click += new System.EventHandler(this.btn_ToShop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재료불러오기ToolStripMenuItem,
            this.레시피불러오기ToolStripMenuItem,
            this.영양정보불러오기ToolStripMenuItem,
            this.재료데이터저장하기ToolStripMenuItem,
            this.레시피데이터저장하기ToolStripMenuItem,
            this.영양정보데이터저장하기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 재료불러오기ToolStripMenuItem
            // 
            this.재료불러오기ToolStripMenuItem.Name = "재료불러오기ToolStripMenuItem";
            this.재료불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.재료불러오기ToolStripMenuItem.Text = "재료 불러오기";
            this.재료불러오기ToolStripMenuItem.Click += new System.EventHandler(this.재료불러오기ToolStripMenuItem_Click);
            // 
            // 레시피불러오기ToolStripMenuItem
            // 
            this.레시피불러오기ToolStripMenuItem.Name = "레시피불러오기ToolStripMenuItem";
            this.레시피불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.레시피불러오기ToolStripMenuItem.Text = "레시피 불러오기";
            this.레시피불러오기ToolStripMenuItem.Click += new System.EventHandler(this.레시피불러오기ToolStripMenuItem_Click);
            // 
            // 영양정보불러오기ToolStripMenuItem
            // 
            this.영양정보불러오기ToolStripMenuItem.Name = "영양정보불러오기ToolStripMenuItem";
            this.영양정보불러오기ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.영양정보불러오기ToolStripMenuItem.Text = "영양정보 불러오기";
            this.영양정보불러오기ToolStripMenuItem.Click += new System.EventHandler(this.영양정보불러오기ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 재료데이터저장하기ToolStripMenuItem
            // 
            this.재료데이터저장하기ToolStripMenuItem.Name = "재료데이터저장하기ToolStripMenuItem";
            this.재료데이터저장하기ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.재료데이터저장하기ToolStripMenuItem.Text = "재료 데이터 저장하기";
            this.재료데이터저장하기ToolStripMenuItem.Click += new System.EventHandler(this.재료데이터저장하기ToolStripMenuItem_Click);
            // 
            // 레시피데이터저장하기ToolStripMenuItem
            // 
            this.레시피데이터저장하기ToolStripMenuItem.Name = "레시피데이터저장하기ToolStripMenuItem";
            this.레시피데이터저장하기ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.레시피데이터저장하기ToolStripMenuItem.Text = "레시피 데이터 저장하기";
            this.레시피데이터저장하기ToolStripMenuItem.Click += new System.EventHandler(this.레시피데이터저장하기ToolStripMenuItem_Click);
            // 
            // 영양정보데이터저장하기ToolStripMenuItem
            // 
            this.영양정보데이터저장하기ToolStripMenuItem.Name = "영양정보데이터저장하기ToolStripMenuItem";
            this.영양정보데이터저장하기ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.영양정보데이터저장하기ToolStripMenuItem.Text = "영양정보 데이터 저장하기";
            this.영양정보데이터저장하기ToolStripMenuItem.Click += new System.EventHandler(this.영양정보데이터저장하기ToolStripMenuItem_Click);
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 611);
            this.Controls.Add(this.btn_ToShop);
            this.Controls.Add(this.btn_calculateKal);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_registerIng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_IngName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_checkRecipe);
            this.Controls.Add(this.btn_deleteExpiredIngAll);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_removeIng);
            this.Controls.Add(this.btn_recommendFood);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IngredientForm";
            this.Text = "재료 창";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_recommendFood;
        private System.Windows.Forms.Button btn_removeIng;
        private System.Windows.Forms.Button btn_checkRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_deleteExpiredIngAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_registerIng;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox textBox_IngName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_calculateKal;
        private System.Windows.Forms.Button btn_ToShop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재료불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영양정보불러오기ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 재료데이터저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피데이터저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영양정보데이터저장하기ToolStripMenuItem;
    }
}

