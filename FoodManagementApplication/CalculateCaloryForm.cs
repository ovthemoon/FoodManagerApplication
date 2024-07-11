using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FoodManagementApplication
{
    public partial class CalculateCaloryForm : Form
    {
        string urlBase = "https://www.google.com/search?q=";
        public CalculateCaloryForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.dummy.Recipes.TryGetValue(comboBox1.SelectedItem.ToString(),out Recipe recipe))
            {
                if (Program.dummy.CaloryInfos.TryGetValue(recipe,out CaloryInfo caloryInfo))
                {
                    textBox_Calory.Text = caloryInfo.Calories.ToString();
                    textBox_Protein.Text = caloryInfo.Protein.ToString();
                    textBox_Fat.Text = caloryInfo.Fat.ToString();
                    textBox_Carbo.Text = caloryInfo.Carbohydrates.ToString();
                }
                else
                {
                    MessageBox.Show("영양정보가 없습니다. 직접 입력해주세요 :)","영양정보 누락");
                }
            }
            else
            {
                MessageBox.Show("잘못된 레시피를 선택하였습니다.");
            }
        }

        private void CalculateCaloryForm_Load(object sender, EventArgs e)
        {
            SetRecipeComboBox();
            Program.dummy.OnRecipeDataChanged += SetRecipeComboBox;

        }
        public void SetRecipeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var item in Program.dummy.Recipes.Keys)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void btn_AddCal_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("레시피를 선택해주세요.");
               return;
            }
            if (string.IsNullOrEmpty(textBox_Calory.Text))
            {
                MessageBox.Show("칼로리가 누락되었습니다.");
                return;
            }
            string name=comboBox1.SelectedItem.ToString();
            string cal = textBox_Calory.Text;
            listView1.Items.Add(new ListViewItem(new string[]
            {
                name, cal
            }));
            GetTotalCal();
        }

        private void btn_RemoveCal_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            GetTotalCal();
        }

        private void btn_SaveCalInfo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_Calory.Text, out int calory))
            {
                MessageBox.Show("⚠️ 칼로리 정보가 비어있습니다.");
                textBox_Calory.Focus();
                return ;
            }

            if (!int.TryParse(textBox_Protein.Text, out int protein))
            {
                MessageBox.Show("⚠️ 단백질 정보가 비어있습니다.");
                textBox_Protein.Focus();
                return ;
            }

            if (!int.TryParse(textBox_Fat.Text, out int fat))
            {
                MessageBox.Show("⚠️ 지방 정보가 비어있습니다.");
                textBox_Fat.Focus();
                return ;
            }

            if (!int.TryParse(textBox_Carbo.Text, out int carbohydrates))
            {
                MessageBox.Show("⚠️ 탄수화물 정보가 비어있습니다.");
                textBox_Carbo.Focus();
                return ;
            }

            if (Program.dummy.Recipes.TryGetValue(comboBox1.SelectedItem.ToString(), out Recipe recipe))
            {
                if (Program.dummy.CaloryInfos.TryGetValue(recipe, out CaloryInfo caloryInfo))
                {
                    caloryInfo.Calories = calory;
                    caloryInfo.Protein = protein;
                    caloryInfo.Fat = fat;
                    caloryInfo.Carbohydrates = carbohydrates;
                }
                else
                {
                    Program.dummy.CaloryInfos.Add(recipe, new CaloryInfo(
                    calory,
                    protein,
                    fat,
                    carbohydrates));
                }
                
                MessageBox.Show("영양 정보가 저장되었습니다.");
            }

        }
        private void GetTotalCal()
        {
            int totalCal = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                totalCal += int.Parse(subItem[1].Text);
            }
            label_TotalCalory.Text = totalCal.ToString();
        }

        private void CalculateCaloryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //닫혀서 사라지는것 방지
            e.Cancel = true;
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_Search.Text))
            {
                MessageBox.Show("검색 내용을 입력해주세요.");
                textBox_Search.Focus();
                return;
            }
            Process.Start($"{urlBase}{textBox_Search.Text}영양정보");
        }
    }
}
