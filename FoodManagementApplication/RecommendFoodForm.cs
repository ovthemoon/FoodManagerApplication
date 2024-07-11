using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManagementApplication
{
    public partial class RecommendFoodForm : Form
    {
        private List<(Recipe recipe, int missingCount, List<IngredientMeasurement> missingIngredients)> recipeSuggestions
            =new List<(Recipe recipe, int missingCount, List<IngredientMeasurement> missingIngredients)>();
        private int currentRecipeIndex=-1;
        private RecipeForm recipeForm;

        public RecommendFoodForm(RecipeForm recipeForm)
        {
            InitializeComponent();
            this.recipeForm = recipeForm;
        }
        private void RecommendFoodForm_Load(object sender, EventArgs e)
        {
            //현재 등록된 레시피 / 재료를 기반으로 추천리스트 생성
            GenerateRecipeSuggestions();
            RecommendNextRecipe();
            //레시피 / 재료 변동시 List 재생성 필요
            Program.dummy.OnRecipeDataChanged += GenerateRecipeSuggestions;
            Program.dummy.OnIngredientDataChanged += GenerateRecipeSuggestions;
        }

        private void btn_Recommend_Click(object sender, EventArgs e)
        {
            RecommendNextRecipe();

        }
        private void GenerateRecipeSuggestions()
        {
            recipeSuggestions.Clear();
            foreach (var recipe in Program.dummy.Recipes.Values)
            {
                var missingIngredients = GetMissingIngredients(recipe);
                recipeSuggestions.Add((recipe, missingIngredients.Count, missingIngredients));
            }
            recipeSuggestions = recipeSuggestions.OrderBy(r => r.missingCount).ToList();
        }

        private void RecommendNextRecipe()
        {
            if (recipeSuggestions.Count == 0)
            {
                MessageBox.Show("추천할 레시피가 없습니다.");
                return;
            }
            else if (currentRecipeIndex + 1== recipeSuggestions.Count)
            {
                MessageBox.Show("더 이상 추천할 레시피가 없습니다.\n레시피를 추가하여 주세요.\n\n처음으로 돌아갑니다.");
            }
            currentRecipeIndex = (currentRecipeIndex + 1) % recipeSuggestions.Count;

            var recommendedRecipe = recipeSuggestions[currentRecipeIndex];
            DisplayRecipe(recommendedRecipe.recipe, recommendedRecipe.missingIngredients);
        }

        private void DisplayRecipe(Recipe recipe, List<IngredientMeasurement> missingIngredients)
        {
            listView_missingIngredients.Items.Clear();
            MessageBox.Show($"오늘의 레시피, \"{recipe.Name}\"을(를) 추천합니다!");
            label_RecipeName.Text = recipe.Name;
            if (missingIngredients.Count > 0)
            {
                foreach (var missing in missingIngredients)
                {
                    listView_missingIngredients.Items.Add(new ListViewItem(new string[]
                    {
                    missing.Name, missing.Quantity.ToString(), missing.Unit.ToString()
                    }));
                }
            }
            else
            {
                MessageBox.Show("모든 재료가 준비되어 있습니다!");
            }
        }

        private List<IngredientMeasurement> GetMissingIngredients(Recipe recipe)
        {
            var missingIngredients = new List<IngredientMeasurement>();

            foreach (var requiredIngredient in recipe.Ingredients)
            {
                var availableIngredient = Program.dummy.IngredientInventory.Values.FirstOrDefault(i =>
                i.Measurement.Name.Equals(requiredIngredient.Name));
                if (availableIngredient == null )
                {
                    missingIngredients.Add(requiredIngredient);
                }else if(availableIngredient.Measurement.Quantity < requiredIngredient.Quantity)
                {
                    requiredIngredient.Quantity -= availableIngredient.Measurement.Quantity;
                    missingIngredients.Add(requiredIngredient);
                }
            }

            return missingIngredients;
        }
        

        private void btn_ToRecipe_Click(object sender, EventArgs e)
        {
            string recipeName = label_RecipeName.Text;
            if (!string.IsNullOrEmpty(recipeName))
            {
                recipeForm.FocusRecipe(recipeName);
                recipeForm.Show();
                recipeForm.BringToFront(); // RecipeForm이 이미 열려있는 경우 최상위로 이동
            }
        }

        private void btn_ToShop_Click(object sender, EventArgs e)
        {
            IngredientForm ownerForm = this.Owner as IngredientForm;
            

            // shoppingForm이 null이면 새 인스턴스를 생성
            if (ownerForm.shoppingForm == null)
            {
                ownerForm.shoppingForm = new ShoppingForm();
            }
            ownerForm.shoppingForm.Show();
            ownerForm.shoppingForm.BringToFront();
            // listView_missingIngredients의 항목을 반복
            foreach (ListViewItem item in listView_missingIngredients.Items)
            {
                ListViewItem.ListViewSubItemCollection subItems = item.SubItems;

                // subItem[0]이 null이 아닌지 확인하고 ToString()을 호출
                if (subItems.Count > 0 && subItems[0] != null)
                {
                    ownerForm.shoppingForm.AddToShoppingList(subItems[0].Text);
                }
                else
                {
                    MessageBox.Show("장바구니에 넢을 아이템이 없습니다.");
                }
            }
        }

        private void RecommendFoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
