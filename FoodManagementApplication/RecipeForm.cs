using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace FoodManagementApplication
{
    public partial class RecipeForm : Form
    {
        public RecipeForm()
        {
            InitializeComponent();
        }


        private void RecipeForm_Load(object sender, EventArgs e)
        {
            Program.dummy.OnRecipeDataChanged += PrintRecipeList;
            Text = "레시피 창";

            PrintRecipeList();
            foreach (var item in Enum.GetValues(typeof(Unit)))
            {
                domainUpDown1.Items.Add(item);
            }
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView_Recipes.SelectedItems.Count > 0)
            {
                DisplayRecipeDetails(listView_Recipes.SelectedItems[0]);
            }
        }

        private void DisplayRecipeDetails(ListViewItem item)
        {
            ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
            string recipeName = subItem[0].Text;
            //선택된 데이터를 Dictionary에서 찾아 각각의 데이터 포맷에 맞게 삽입
            if (Program.dummy.Recipes.TryGetValue(recipeName,out Recipe selectedRecipe))
            {
                textBox_RecipeName.Text = selectedRecipe.Name;
                listView_Ingredients.Items.Clear();
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    listView_Ingredients.Items.Add(ListAdd(ingredient));
                }
                textBox_Method.Text = selectedRecipe.Method.Replace("\n", Environment.NewLine);
            }
        }
        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_RecipeName.Text))
            {
                MessageBox.Show("레시피 이름이 누락되었습니다.", "레시피 누락 오류");
                textBox_RecipeName.Focus();
                return;
            }
            if (listView_Recipes.Items.Count <= 0)
            {
                MessageBox.Show("재료가 없습니다.", "재료 누락 오류");
                textBox_IngredientName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Method.Text))
            {
                MessageBox.Show("조리 방법이 없습니다.", "조리방법 누락 오류");
                textBox_Method.Focus();
                return;
            }

            string name = textBox_RecipeName.Text;
            List<IngredientMeasurement> ingredients = new List<IngredientMeasurement>();
            foreach (ListViewItem item in listView_Ingredients.Items)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                string ingName = subItem[0].Text;
                if (!float.TryParse(subItem[1].Text, out float count))
                {
                    MessageBox.Show("수량이 잘못되었습니다.", "단위 오류");
                    return;
                }
                if (!Enum.TryParse(subItem[2].Text, out Unit unit))
                {
                    MessageBox.Show("단위가 잘못되었습니다.", "단위 오류");
                    return;
                }
                
                ingredients.Add(new IngredientMeasurement(ingName, count, unit));
            }
            string method = textBox_Method.Text;

            Program.dummy.AddRecipe(name, method, ingredients);
            ClearAll();
        }

        private void btn_AddIng_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_IngredientName.Text))
            {
                MessageBox.Show("재료 이름이 누락되었습니다.", "재료 이름 누락 오류");
                textBox_IngredientName.Focus();
                return;
            }
            if (!Enum.TryParse(domainUpDown1.Text, out Unit unit))
            {
                MessageBox.Show("단위를 올바르게 선택하세요.", "계량 단위 누락 오류");
                domainUpDown1.Focus();
                return;
            }
            if (!int.TryParse(textBox_Count.Text, out int quantity))
            {
                MessageBox.Show("수량을 올바르게 입력하세요.", "수량 오류");
                textBox_Count.Focus();
                return;
            }

            listView_Ingredients.Items.Add(new ListViewItem(new string[] {
                textBox_IngredientName.Text,
                quantity.ToString(),
                unit.ToString() }));
            ClearIng();
        }

        private void btn_RemoveIng_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Ingredients.SelectedItems)
            {
                listView_Ingredients.Items.Remove(item);
            }
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; 
            this.Hide();
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            //계량 단위 설정에 따른 label Change
            switch (domainUpDown1.SelectedItem)
            {
                case Unit.컵:
                case Unit.개:
                    unitLabel.Text = "수량";
                    break;
                default:
                    unitLabel.Text = "용량";
                    break;
            }
        }

        private void btn_RemoveRecipe_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Recipes.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;

                string recipeName = subItem[0].Text;

                if (Program.dummy.Recipes.ContainsKey(recipeName))
                {
                    // 재료를 딕셔너리에서 제거함
                    Program.dummy.RemoveRecipe(recipeName);
                }
            }

            ClearAll();
        }
        void PrintRecipeList()
        {
            listView_Recipes.Items.Clear();
            foreach (var recipe in Program.dummy.Recipes)
            {
                listView_Recipes.Items.Add(ListAdd(recipe.Key, recipe.Value));
            }
        }
        private ListViewItem ListAdd(string name,Recipe recipe)
        {

            string imText = string.Empty;
            foreach (var item in recipe.Ingredients)
            {
                imText += item.ToString() + ", ";
            }

            return new ListViewItem(new string[] { name, imText, recipe.Method });
        }
        private ListViewItem ListAdd(IngredientMeasurement ingredient)
        {
            return new ListViewItem(new string[] { ingredient.Name, ingredient.Quantity.ToString(), ingredient.Unit.ToString() });
        }
        private void ClearAll()
        {
            textBox_RecipeName.Clear();
            textBox_Method.Clear();
            listView_Ingredients.Items.Clear();
            textBox_IngredientName.Clear();
            textBox_Count.Clear();
            domainUpDown1.SelectedIndex = 0;
        }
        private void ClearIng()
        {
            textBox_IngredientName.Clear();
            textBox_Count.Clear();
            domainUpDown1.SelectedIndex = 0;
        }
        public void FocusRecipe(string recipeName)//음식 추천 폼에서 레시피 폼으로 연결되며 실행
        {
            //전체 포커스 해제
            foreach (ListViewItem item in listView_Recipes.Items)
            {
                item.Selected = false;
                item.Focused = false;
            }

            // 추천된 레시피를 포커스
            foreach (ListViewItem item in listView_Recipes.Items)
            {
                if (item.Text == recipeName)
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    listView_Recipes.Select();
                    DisplayRecipeDetails(item);
                    break;
                }
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        => ClearAll();

        private void btn_ResetIng_Click(object sender, EventArgs e)
        => ClearIng();

        
    }
}
