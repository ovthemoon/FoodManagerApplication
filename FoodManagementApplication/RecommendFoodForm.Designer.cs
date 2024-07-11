namespace FoodManagementApplication
{
    partial class RecommendFoodForm
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
            this.listView_missingIngredients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label_RecipeName = new System.Windows.Forms.Label();
            this.btn_Recommend = new System.Windows.Forms.Button();
            this.btn_ToRecipe = new System.Windows.Forms.Button();
            this.btn_ToShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "부족한 재료 리스트";
            // 
            // listView_missingIngredients
            // 
            this.listView_missingIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader7});
            this.listView_missingIngredients.FullRowSelect = true;
            this.listView_missingIngredients.GridLines = true;
            this.listView_missingIngredients.HideSelection = false;
            this.listView_missingIngredients.Location = new System.Drawing.Point(34, 86);
            this.listView_missingIngredients.Name = "listView_missingIngredients";
            this.listView_missingIngredients.Size = new System.Drawing.Size(389, 167);
            this.listView_missingIngredients.TabIndex = 17;
            this.listView_missingIngredients.UseCompatibleStateImageBehavior = false;
            this.listView_missingIngredients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "재료 이름";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "용량 / 수량";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "계량 단위";
            this.columnHeader7.Width = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "레시피 이름";
            // 
            // label_RecipeName
            // 
            this.label_RecipeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecipeName.Location = new System.Drawing.Point(107, 15);
            this.label_RecipeName.Name = "label_RecipeName";
            this.label_RecipeName.Size = new System.Drawing.Size(257, 24);
            this.label_RecipeName.TabIndex = 0;
            this.label_RecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Recommend
            // 
            this.btn_Recommend.Location = new System.Drawing.Point(153, 279);
            this.btn_Recommend.Name = "btn_Recommend";
            this.btn_Recommend.Size = new System.Drawing.Size(159, 143);
            this.btn_Recommend.TabIndex = 18;
            this.btn_Recommend.Text = "다른 음식 추천해줘!";
            this.btn_Recommend.UseVisualStyleBackColor = true;
            this.btn_Recommend.Click += new System.EventHandler(this.btn_Recommend_Click);
            // 
            // btn_ToRecipe
            // 
            this.btn_ToRecipe.Location = new System.Drawing.Point(34, 279);
            this.btn_ToRecipe.Name = "btn_ToRecipe";
            this.btn_ToRecipe.Size = new System.Drawing.Size(64, 143);
            this.btn_ToRecipe.TabIndex = 18;
            this.btn_ToRecipe.Text = "레시피 \r\n\r\n창으로";
            this.btn_ToRecipe.UseVisualStyleBackColor = true;
            this.btn_ToRecipe.Click += new System.EventHandler(this.btn_ToRecipe_Click);
            // 
            // btn_ToShop
            // 
            this.btn_ToShop.Location = new System.Drawing.Point(359, 279);
            this.btn_ToShop.Name = "btn_ToShop";
            this.btn_ToShop.Size = new System.Drawing.Size(64, 143);
            this.btn_ToShop.TabIndex = 18;
            this.btn_ToShop.Text = "장바구니 \r\n\r\n연결";
            this.btn_ToShop.UseVisualStyleBackColor = true;
            this.btn_ToShop.Click += new System.EventHandler(this.btn_ToShop_Click);
            // 
            // RecommendFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btn_ToShop);
            this.Controls.Add(this.btn_ToRecipe);
            this.Controls.Add(this.btn_Recommend);
            this.Controls.Add(this.listView_missingIngredients);
            this.Controls.Add(this.label_RecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecommendFoodForm";
            this.Text = "음식 추천 창";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecommendFoodForm_FormClosing);
            this.Load += new System.EventHandler(this.RecommendFoodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_missingIngredients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_RecipeName;
        private System.Windows.Forms.Button btn_Recommend;
        private System.Windows.Forms.Button btn_ToRecipe;
        private System.Windows.Forms.Button btn_ToShop;
    }
}