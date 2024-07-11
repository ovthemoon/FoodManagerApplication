using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;



namespace FoodManagementApplication
{
    public partial class IngredientForm : Form
    {
        //폼은 기준 폼인ingredient 폼에서 관리
        RecipeForm recipeForm; 
        CalculateCaloryForm calForm;
        RecommendFoodForm recomFoodForm;
        public ShoppingForm shoppingForm;
        public IngredientForm()
        {
            InitializeComponent();
        }
       
        private void btn_registering_Click(object sender, EventArgs e)
        {
            if (textBox_IngName.Text.Equals(""))
            {
                MessageBox.Show("재료 이름을 작성해주세요", "재료 이름 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBox_Count.Text, out int quantity))
            {
                MessageBox.Show("수량을 올바르게 입력하세요.");
                return;
            }
            if (!Enum.TryParse(domainUpDown1.Text, out Unit unit))
            {
                MessageBox.Show("단위를 올바르게 선택하세요.");
                return;
            }
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("선택한 날짜가 잘못되었습니다.", "날짜 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //재료 저장(중복 여부 체크는 Database에서 진행)
            Program.dummy.AddIngredient(dateTimePicker1.Value,
                new IngredientMeasurement(
                    textBox_IngName.Text,
                    int.Parse(textBox_Count.Text),
                    unit));
            Clear();
        }
       
        

        private void btn_checkRecipe_Click(object sender, EventArgs e)
        {
            if (recipeForm == null)
            {
                recipeForm = new RecipeForm();
                
            }
            recipeForm.BringToFront();
            recipeForm.Show();
        }

        private void btn_recommendFood_Click(object sender, EventArgs e)
        {
            if (recomFoodForm == null)
            {
                recomFoodForm = new RecommendFoodForm(recipeForm);
               this.AddOwnedForm(recomFoodForm);
            }
            recomFoodForm.Show();
            recomFoodForm.BringToFront();
        }
        private void btn_calculateKal_Click(object sender, EventArgs e)
        {
            if (calForm == null)
            {
                calForm = new CalculateCaloryForm();
            }
            calForm.Show();
            calForm.BringToFront();
        }
        public void btn_ToShop_Click(object sender, EventArgs e)
        {
            if (shoppingForm == null)
            {
                shoppingForm = new ShoppingForm();
                this.AddOwnedForm(shoppingForm);
            }
            shoppingForm.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //데이터 변동시 발생되는 이벤트에 의해 갱신되도록 설정
            Program.dummy.OnIngredientDataChanged += PrintIngredientList;
            //사용되는 폼 초기화
            StartPosition = FormStartPosition.Manual; 
            Location = new Point(1000, 100);
            Text = "재료 창";
            MessageBox.Show("음식 관리 프로그램에 오신 것을 환영합니다.");
            AlertExpiredIngredient();
            
            recipeForm = new RecipeForm();
            recipeForm.StartPosition = FormStartPosition.Manual;
            recipeForm.Location = new Point(200, 100);
            recipeForm.Show();

            //게량단위 초기화
            foreach (var item in Enum.GetValues(typeof(Unit)))
            {
                domainUpDown1.Items.Add(item);
            }
            PrintIngredientList();
        }

        private void btn_removeIng_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;

                string ingredientName = subItem[0].Text;
                string date = subItem[1].Text;
                var ingredient = Program.dummy.IngredientInventory.Keys.FirstOrDefault(i=>
                i.Equals($"{ingredientName}_{date}"));
                if (ingredient != null)
                {
                    // 재료를 딕셔너리에서 제거함
                    Program.dummy.RemoveIngredient(ingredient);
                }
            }

        }
        
        private void listView1_ColumnClick(object o, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == SortOrder.Ascending)
            {
                listView1.Sorting = SortOrder.Descending;
            }
            else
            {
                listView1.Sorting = SortOrder.Ascending;
            }
            //ListViewItemComparator를 통해서 정렬기준 설정
            listView1.ListViewItemSorter = new ListViewItemComparator(e.Column, listView1.Sorting);
            listView1.Sort();
        }
        

        private void btn_deleteExpiredIngAll_Click(object sender, EventArgs e)
        {
            //제거할 재료 리스트업
            var keysToRemove = Program.dummy.IngredientInventory
                       .Where(item => item.Value.ExpirationTime < DateTime.Now)
                       .Select(item => item.Key)
                       .ToList();
            if (keysToRemove.Count == 0)
            {
                MessageBox.Show("유통기한이 지난 재료가 없습니다.");
                return;
            }
            DialogResult result = MessageBox.Show("유통기한 지난 재료를 삭제하시겠습니까?", "재료 삭제",
                           MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result== DialogResult.No)
            {
                return;
            }
            
            string text = string.Empty;
            foreach (var key in keysToRemove)
            {
                text += $"{key}\n";
                Program.dummy.RemoveIngredient(key);
            }
            MessageBox.Show($"{text}위 재료를 삭제하였습니다.", "삭제 완료");
            
        }
       
        //아이템 클릭시 재료 정보 세팅
        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                string ingName = subItem[0].Text;
                string date= subItem[1].Text;
                string count= subItem[2].Text;
                string unit = subItem[3].Text;

                textBox_IngName.Text = ingName;
                dateTimePicker1.Value = DateTime.Parse(date);
                textBox_Count.Text = count;
                // 계량 단위 표시
                for (int i = 0; i < domainUpDown1.Items.Count; i++)
                {
                    if (domainUpDown1.Items[i].ToString() == unit)
                    {
                        domainUpDown1.SelectedIndex = i;
                        break;
                    }
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다.");
            e.Cancel = false;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
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

        private void btn_Reset_Click(object sender, EventArgs e)
        => Clear();

        

        private void 재료불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(out IngredientData data);
            Program.dummy.LoadIngredientData(data);
        }

        private void 레시피불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(out RecipeData data);
            Program.dummy.LoadRecipeData(data);
        }
        private void 영양정보불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(out CaloryData data);
            Program.dummy.LoadCaloryData(data);
        }
        private void 재료데이터저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //데이터 저장을 위해 IngredientInventory에 있는 데이터 내용을 DataSaveFormat으로 변경
            var data = new IngredientData
            {
                Ingredients = Program.dummy.IngredientInventory.Values.ToList()
            };
            SaveData(data);
        }
        

        private void 레시피데이터저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //데이터 저장을 위해 Recipes 있는 데이터 내용을 DataSaveFormat으로 변경
            var data = new RecipeData
            {
                Recipes = Program.dummy.Recipes.Values.ToList()
            };
            SaveData(data);
        }

        private void 영양정보데이터저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //데이터 저장을 위해 CaloryInfos 있는 데이터 내용을 DataSaveFormat으로 변경
            var data = new CaloryData
            {
                CaloryInfos = Program.dummy.CaloryInfos.Values.ToList()
            };
            SaveData(data);
        }

       
        private void SaveData<T>(T data) where T : IData//IData를 상속하는 DataSaveFormat을 받아 저장
        {
            saveFileDialog1.Filter = "JSON Files|*.json";
            saveFileDialog1.Title = $"{data} 저장";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 파일 경로 가져오기
                string filePath = saveFileDialog1.FileName;
                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
                // JSON 데이터 저장 메서드 호출
            }
        }
        
        private void LoadData<T>(out T data) where T : class, IData//IData를 상속하는 DataSaveFormat을 반환.(class로 제한을 추가한것은 null처리를 위해서)
        {
            openFileDialog1.Filter = "JSON Files|*.json";
            openFileDialog1.Title = "Open a JSON File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("파일을 찾을 수 없습니다.");
                    data = null;
                    return;
                }

                if (Path.GetExtension(filePath).ToLower() != ".json")
                {
                    MessageBox.Show("JSON 파일 형식이 아닙니다.");
                    data = null;
                    return;
                }

                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    data = JsonSerializer.Deserialize<T>(jsonString);

                    if (data == null)
                    {
                        throw new Exception("파일 내용을 읽을 수 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"파일을 로드하는 중 오류가 발생했습니다: {ex.Message}");
                    data = null;
                }
            }
            else
            {
                data = null;
            }
        }
        void PrintIngredientList()
        {
            listView1.Items.Clear();
            foreach (var item in Program.dummy.IngredientInventory)
            {
                IngredientMeasurement ingredientMeasurement = item.Value.Measurement;
                var listViewItem = ListAdd(
                    ingredientMeasurement.Name,
                    item.Value.ExpirationTime,
                    ingredientMeasurement.Unit,
                    ingredientMeasurement.Quantity.ToString());

                listView1.Items.Add(listViewItem);
            }
        }
        
        private void AlertExpiredIngredient()//유통기한이 지났거나 임박한 재료 알림
        {
            string alert1 = "";
            string alert2 = "";
            foreach (var item in Program.dummy.IngredientInventory)
            {
                if (item.Value.ExpirationTime < DateTime.Now)
                {
                    alert1 += $"{item.Value.Measurement.Name}\n";
                }
                else if (item.Value.ExpirationTime < DateTime.Now.AddDays(3))
                {
                    alert2 += $"{item.Value.Measurement.Name}\n";
                }
            }
            if (!String.IsNullOrEmpty(alert1))
            {
                alert1 += "위 재료들의 유통기한이 지나 폐기처리 해야 합니다.";
                MessageBox.Show(alert1, "유통기한 초과", MessageBoxButtons.OK);
            }
            if (!String.IsNullOrEmpty(alert2))
            {
                alert2 += "위 재료들의 유통기한이 3일 남았습니다. ";
                MessageBox.Show(alert2, "유통기한 초과 임박", MessageBoxButtons.OK);
            }
        }
        private ListViewItem ListAdd(string name, DateTime date, Unit unit, string count)
        {
            return new ListViewItem(new string[] { name, date.ToShortDateString(), count, unit.ToString() });
        }
        private void Clear()
        {
            textBox_IngName.Clear();
            domainUpDown1.SelectedIndex = 0;
            textBox_Count.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
