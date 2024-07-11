using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
public enum Unit
{
    t,
    T,
    컵,
    개,
    그램,
    킬로
}

class Database
{
    public delegate void DataChanged();
    public event DataChanged OnRecipeDataChanged;
    public event DataChanged OnIngredientDataChanged;
    public Dictionary<string, Recipe> Recipes = new Dictionary<string, Recipe>();
    public Dictionary<string, Ingredient> IngredientInventory { get; private set; } = new Dictionary<string, Ingredient>();

    public Dictionary<Recipe, CaloryInfo> CaloryInfos { get; private set; } = new Dictionary<Recipe, CaloryInfo>();
    private bool _isInitializing;
    public Database()
    {
        _isInitializing = true;
        //테스트용 데이터 생성
        //InitializeIngredients();
        //InitializeRecipes();
        //InitializeCaloryInfos();

        _isInitializing = false;
    }

    private void InitializeIngredients()
    {
        AddIngredient(DateTime.Now.AddDays(-10), new IngredientMeasurement("토마토", 200, Unit.그램));
        AddIngredient(DateTime.Now.AddDays(30), new IngredientMeasurement("파스타", 300, Unit.그램));
        AddIngredient(DateTime.Now.AddDays(5), new IngredientMeasurement("소고기", 500, Unit.그램));
        AddIngredient(DateTime.Now.AddDays(20), new IngredientMeasurement("치즈", 100, Unit.그램));
        AddIngredient(DateTime.Now.AddDays(7), new IngredientMeasurement("빵", 1, Unit.개));
        AddIngredient(DateTime.Now.AddDays(-60), new IngredientMeasurement("땅콩버터", 2, Unit.T));
        AddIngredient(DateTime.Now.AddDays(120), new IngredientMeasurement("젤리", 2, Unit.T));
        AddIngredient(DateTime.Now.AddDays(60), new IngredientMeasurement("쌀", 200, Unit.그램));
        AddIngredient(DateTime.Now.AddDays(30), new IngredientMeasurement("콩", 100, Unit.그램));
        AddIngredient(DateTime.Now.AddDays(7), new IngredientMeasurement("닭고기", 150, Unit.그램));
    }

    private void InitializeRecipes()
    {
        AddRecipe("라자냐", "1. 파스타를 끓는 물에 삶아주세요.\n\n" +
                            "2. 팬에 올리브 오일을 두르고 소고기를 볶다가 토마토 소스를 추가해 주세요.\n\n" +
                            "3. 베이킹 용기에 삶은 파스타를 깔고, 소고기 토마토 소스를 올리고, 치즈를 뿌립니다. 이 과정을 반복하여 층을 쌓아주세요.\n\n" +
                            "4. 예열된 오븐에서 180도에서 30분간 구워주세요. 치즈가 노릇하게 익으면 완성입니다.",
            new List<IngredientMeasurement>
            {
                new IngredientMeasurement("토마토", 200, Unit.그램),
                new IngredientMeasurement("파스타", 300, Unit.그램),
                new IngredientMeasurement("소고기", 500, Unit.그램),
                new IngredientMeasurement("치즈", 100, Unit.그램)
            });

        AddRecipe("땅콩버터와 젤리 샌드위치", "1. 빵 두 조각을 준비합니다.\n\n" +
                                      "2. 한쪽 빵에 땅콩버터를 바르고, 다른 쪽 빵에 젤리를 발라주세요.\n\n" +
                                      "3. 두 빵을 합쳐 샌드위치를 만듭니다. 원한다면 빵을 반으로 자를 수 있습니다.",
            new List<IngredientMeasurement>
            {
                new IngredientMeasurement("빵", 2, Unit.개),
                new IngredientMeasurement("땅콩버터", 2, Unit.T),
                new IngredientMeasurement("젤리", 2, Unit.T)
            });

        AddRecipe("치킨 부리토", "1. 밥과 콩을 미리 준비하여 따뜻하게 해둡니다.\n\n" +
                                "2. 닭고기를 작은 조각으로 썰어 팬에 구워주세요.\n\n" +
                                "3. 토르티야를 데워서 준비합니다.\n\n" +
                                "4. 데운 토르티야에 밥, 콩, 구운 닭고기를 차례로 넣고 말아주세요.\n\n" +
                                "5. 원한다면, 사워 크림이나 살사를 추가할 수 있습니다.",
            new List<IngredientMeasurement>
            {
                new IngredientMeasurement("쌀", 200, Unit.그램),
                new IngredientMeasurement("콩", 100, Unit.그램),
                new IngredientMeasurement("닭고기", 150, Unit.그램)
            });

        AddRecipe("볶음밥", "1. 팬에 올리브 오일을 두르고 쌀과 계란을 넣고 볶아주세요.\n\n" +
                            "2. 소고기와 야채를 추가하여 잘 볶아주세요.\n\n" +
                            "3. 간장을 추가하여 간을 맞춰주세요.",
            new List<IngredientMeasurement>
            {
                new IngredientMeasurement("쌀", 200, Unit.그램),
                new IngredientMeasurement("계란", 2, Unit.개),
                new IngredientMeasurement("소고기", 100, Unit.그램),
                new IngredientMeasurement("올리브 오일", 1, Unit.T)
            });

        AddRecipe("프렌치 토스트", "1. 계란과 우유를 섞어 계란물을 만드세요.\n\n" +
                                 "2. 빵을 계란물에 적셔주세요.\n\n" +
                                 "3. 팬에 버터를 녹이고 빵을 구워주세요.\n\n" +
                                 "4. 구운 빵에 설탕과 시럽을 뿌려주세요.",
            new List<IngredientMeasurement>
            {
                new IngredientMeasurement("계란", 2, Unit.개),
                new IngredientMeasurement("우유", 0.5f, Unit.컵),
                new IngredientMeasurement("빵", 4, Unit.개),
                new IngredientMeasurement("설탕", 2, Unit.T)
            });

        AddRecipe("샐러드", "1. 상추와 오이를 깨끗이 씻어주세요.\n\n" +
                           "2. 상추와 오이를 먹기 좋은 크기로 썰어주세요.\n\n" +
                           "3. 올리브 오일을 뿌려서 마무리하세요.",
            new List<IngredientMeasurement>
            {
                new IngredientMeasurement("상추", 100, Unit.그램),
                new IngredientMeasurement("오이", 1, Unit.개),
                new IngredientMeasurement("올리브 오일", 1, Unit.T)
            });
    }

    private void InitializeCaloryInfos()
    {
        AddCaloryInfo("라자냐", new CaloryInfo(800, 35, 50, 70));
        AddCaloryInfo("땅콩버터와 젤리 샌드위치", new CaloryInfo(400, 10, 20, 50));
        AddCaloryInfo("치킨 부리토", new CaloryInfo(600, 30, 20, 80));
        AddCaloryInfo("볶음밥", new CaloryInfo(700, 25, 15, 100));
        AddCaloryInfo("프렌치 토스트", new CaloryInfo(500, 10, 20, 60));
        AddCaloryInfo("샐러드", new CaloryInfo(200, 5, 5, 20));
    }
    public void AddCaloryInfo(string recipeName, CaloryInfo caloryInfo)
    {
        Recipe recipe = Recipes[recipeName];
        if (recipe != null)
        {
            CaloryInfos.Add(recipe, caloryInfo);
            caloryInfo.RecipeName= recipeName;
        }
    }
    public void AddIngredient(DateTime expirationDate, IngredientMeasurement measurement)
    {
        var ingredient = new Ingredient(expirationDate, measurement);
        string key = ingredient.GetUniqueKey();
        if (!_isInitializing)
        {
            if (IngredientInventory.ContainsKey(key))
            {
                DialogResult result = MessageBox.Show(
                    "이 재료는 이미 존재합니다. 재료 정보를 업데이트하시겠습니까?",
                    "재료 수정",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    IngredientInventory[key].Measurement = measurement;
                    MessageBox.Show("재료 수량이 업데이트되었습니다.");
                }
                else
                {
                    MessageBox.Show("재료 수량 업데이트가 취소되었습니다.");
                }
            }
            else
            {
                IngredientInventory.Add(key, ingredient);
                MessageBox.Show("재료가 추가되었습니다!");
            }
        }
        else
        {
            IngredientInventory.Add(key, ingredient);
        }

        OnIngredientDataChanged?.Invoke();
    }


    public void RemoveIngredient(string key)
    {
        if (IngredientInventory.ContainsKey(key))
        {
            IngredientInventory.Remove(key);
            OnIngredientDataChanged?.Invoke();
        }
    }


    public void AddRecipe(string name, string method, params IngredientMeasurement[] ingredients)
    {
        Recipe newRecipe = new Recipe(name, method, ingredients);
        RecipeCheck(name, newRecipe);
    }

    public void AddRecipe(string name, string method, List<IngredientMeasurement> ingredients)
    {
        Recipe newRecipe = new Recipe(name, method, ingredients);

        RecipeCheck(name,newRecipe);
    }

    private void RecipeCheck(string name,Recipe newRecipe)
    {
        if (!_isInitializing)
        {
            if (Recipes.ContainsKey(name))
            {
                DialogResult result = MessageBox.Show(
                    "이 레시피는 이미 존재합니다. 내용을 업데이트하시겠습니까?",
                    "레시피 수정",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Recipes.Remove(name);
                    Recipes.Add(name,newRecipe);
                    MessageBox.Show("레시피 내용이 업데이트되었습니다.");
                }
                else
                {
                    MessageBox.Show("레시피 내용 업데이트가 취소되었습니다.");
                }
            }
            else
            {
                Recipes.Add(name, newRecipe );
                MessageBox.Show("레시피가 추가되었습니다!");

            }
        }
        else
        {
            Recipes.Add(name, newRecipe);
        }

        OnRecipeDataChanged?.Invoke();
    }


    public void RemoveRecipe(string name)
    {
        
        if (Recipes.ContainsKey(name))
        {
            Recipes.Remove(name);
            MessageBox.Show("레시피가 삭제되었습니다.");
            OnRecipeDataChanged?.Invoke();
        }
        else
        {
            MessageBox.Show("해당 이름의 레시피를 찾을 수 없습니다.");
        }
    }

    public void LoadRecipeData(RecipeData recipeData)
    {
        if (recipeData != null)
        {
            if (recipeData.Recipes == null)
            {
                MessageBox.Show("잘못된 파일입니다. 레시피 데이터를 선택하여 주세요.", "파일 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Recipes.Clear();
            recipeData.Recipes.ForEach(recipe =>
            Recipes.Add(recipe.Name, recipe));
            OnRecipeDataChanged?.Invoke();
        }
    }

    public void LoadIngredientData(IngredientData ingredientData)
    {
        if (ingredientData != null)
        {
            if (ingredientData.Ingredients == null)
            {
                MessageBox.Show("잘못된 파일입니다. 재료 데이터를 선택하여 주세요.","파일 오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            IngredientInventory.Clear();
            

            ingredientData.Ingredients.ForEach(ingredient=> 
            IngredientInventory.Add(ingredient.GetUniqueKey(), ingredient));

            OnIngredientDataChanged?.Invoke();
        }
    }

    public void LoadCaloryData(CaloryData caloryData)
    {
        if (caloryData != null)
        {
            if (caloryData.CaloryInfos == null)
            {
                MessageBox.Show("잘못된 파일입니다. 영양정보 데이터를 선택하여 주세요.", "파일 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CaloryInfos.Clear();

            foreach (var caloryInfo in caloryData.CaloryInfos)
            {
                if(Recipes.TryGetValue(caloryInfo.RecipeName,out Recipe recipe))
                    CaloryInfos.Add(recipe, caloryInfo);
            }
        }
    }
}

