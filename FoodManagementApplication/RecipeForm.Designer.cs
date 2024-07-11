namespace FoodManagementApplication
{
    partial class RecipeForm
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
            this.listView_Recipes = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_registerReci = new System.Windows.Forms.Button();
            this.textBox_RecipeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Method = new System.Windows.Forms.TextBox();
            this.listView_Ingredients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_RemoveIng = new System.Windows.Forms.Button();
            this.btn_AddIng = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.unitLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.textBox_IngredientName = new System.Windows.Forms.TextBox();
            this.btn_RemoveRecipe = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_ResetIng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Recipes
            // 
            this.listView_Recipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Recipes.FullRowSelect = true;
            this.listView_Recipes.GridLines = true;
            this.listView_Recipes.HideSelection = false;
            this.listView_Recipes.Location = new System.Drawing.Point(12, 28);
            this.listView_Recipes.Name = "listView_Recipes";
            this.listView_Recipes.Size = new System.Drawing.Size(564, 180);
            this.listView_Recipes.TabIndex = 12;
            this.listView_Recipes.UseCompatibleStateImageBehavior = false;
            this.listView_Recipes.View = System.Windows.Forms.View.Details;
            this.listView_Recipes.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "레시피 이름";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "필요 재료";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "조리 방법";
            this.columnHeader6.Width = 302;
            // 
            // btn_registerReci
            // 
            this.btn_registerReci.Location = new System.Drawing.Point(14, 664);
            this.btn_registerReci.Name = "btn_registerReci";
            this.btn_registerReci.Size = new System.Drawing.Size(140, 63);
            this.btn_registerReci.TabIndex = 13;
            this.btn_registerReci.Text = "레시피 등록/\r\n수정하기";
            this.btn_registerReci.UseVisualStyleBackColor = true;
            this.btn_registerReci.Click += new System.EventHandler(this.btn_AddRecipe_Click);
            // 
            // textBox_RecipeName
            // 
            this.textBox_RecipeName.Location = new System.Drawing.Point(12, 257);
            this.textBox_RecipeName.Name = "textBox_RecipeName";
            this.textBox_RecipeName.Size = new System.Drawing.Size(183, 21);
            this.textBox_RecipeName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "레시피 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "레시피 정보 창";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "필요 재료";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "조리 방법";
            // 
            // textBox_Method
            // 
            this.textBox_Method.Location = new System.Drawing.Point(12, 513);
            this.textBox_Method.Multiline = true;
            this.textBox_Method.Name = "textBox_Method";
            this.textBox_Method.Size = new System.Drawing.Size(482, 133);
            this.textBox_Method.TabIndex = 14;
            // 
            // listView_Ingredients
            // 
            this.listView_Ingredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader7});
            this.listView_Ingredients.FullRowSelect = true;
            this.listView_Ingredients.GridLines = true;
            this.listView_Ingredients.HideSelection = false;
            this.listView_Ingredients.Location = new System.Drawing.Point(12, 313);
            this.listView_Ingredients.Name = "listView_Ingredients";
            this.listView_Ingredients.Size = new System.Drawing.Size(330, 167);
            this.listView_Ingredients.TabIndex = 16;
            this.listView_Ingredients.UseCompatibleStateImageBehavior = false;
            this.listView_Ingredients.View = System.Windows.Forms.View.Details;
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
            // btn_RemoveIng
            // 
            this.btn_RemoveIng.Location = new System.Drawing.Point(349, 414);
            this.btn_RemoveIng.Name = "btn_RemoveIng";
            this.btn_RemoveIng.Size = new System.Drawing.Size(30, 30);
            this.btn_RemoveIng.TabIndex = 24;
            this.btn_RemoveIng.Text = ">";
            this.btn_RemoveIng.UseVisualStyleBackColor = true;
            this.btn_RemoveIng.Click += new System.EventHandler(this.btn_RemoveIng_Click);
            // 
            // btn_AddIng
            // 
            this.btn_AddIng.Location = new System.Drawing.Point(349, 349);
            this.btn_AddIng.Name = "btn_AddIng";
            this.btn_AddIng.Size = new System.Drawing.Size(30, 30);
            this.btn_AddIng.TabIndex = 23;
            this.btn_AddIng.Text = "<";
            this.btn_AddIng.UseVisualStyleBackColor = true;
            this.btn_AddIng.Click += new System.EventHandler(this.btn_AddIng_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(477, 389);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(120, 21);
            this.domainUpDown1.TabIndex = 22;
            this.domainUpDown1.Text = "**계량 단위**";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(426, 432);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(29, 12);
            this.unitLabel.TabIndex = 19;
            this.unitLabel.Text = "수량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "계량 단위";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "재료 이름";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(477, 429);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(120, 21);
            this.textBox_Count.TabIndex = 17;
            // 
            // textBox_IngredientName
            // 
            this.textBox_IngredientName.Location = new System.Drawing.Point(477, 349);
            this.textBox_IngredientName.Name = "textBox_IngredientName";
            this.textBox_IngredientName.Size = new System.Drawing.Size(120, 21);
            this.textBox_IngredientName.TabIndex = 18;
            // 
            // btn_RemoveRecipe
            // 
            this.btn_RemoveRecipe.Location = new System.Drawing.Point(160, 664);
            this.btn_RemoveRecipe.Name = "btn_RemoveRecipe";
            this.btn_RemoveRecipe.Size = new System.Drawing.Size(140, 63);
            this.btn_RemoveRecipe.TabIndex = 13;
            this.btn_RemoveRecipe.Text = "레시피 삭제하기";
            this.btn_RemoveRecipe.UseVisualStyleBackColor = true;
            this.btn_RemoveRecipe.Click += new System.EventHandler(this.btn_RemoveRecipe_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(457, 664);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(140, 63);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "입력란 초기화";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_ResetIng
            // 
            this.btn_ResetIng.Location = new System.Drawing.Point(477, 456);
            this.btn_ResetIng.Name = "btn_ResetIng";
            this.btn_ResetIng.Size = new System.Drawing.Size(120, 31);
            this.btn_ResetIng.TabIndex = 13;
            this.btn_ResetIng.Text = "재료 입력란 초기화";
            this.btn_ResetIng.UseVisualStyleBackColor = true;
            this.btn_ResetIng.Click += new System.EventHandler(this.btn_ResetIng_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 751);
            this.Controls.Add(this.btn_RemoveIng);
            this.Controls.Add(this.btn_AddIng);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_IngredientName);
            this.Controls.Add(this.listView_Ingredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Method);
            this.Controls.Add(this.textBox_RecipeName);
            this.Controls.Add(this.btn_ResetIng);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_RemoveRecipe);
            this.Controls.Add(this.btn_registerReci);
            this.Controls.Add(this.listView_Recipes);
            this.Name = "RecipeForm";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Recipes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_registerReci;
        private System.Windows.Forms.TextBox textBox_RecipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Method;
        private System.Windows.Forms.ListView listView_Ingredients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_RemoveIng;
        private System.Windows.Forms.Button btn_AddIng;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.TextBox textBox_IngredientName;
        private System.Windows.Forms.Button btn_RemoveRecipe;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_ResetIng;
    }
}