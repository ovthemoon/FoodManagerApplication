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
    public partial class ShoppingForm : Form
    {
        public List<string> ShoppingList = new List<string>();
        string baseUrl = "https://www.coupang.com/np/search?component=&q=";
        public ShoppingForm()
        {
            InitializeComponent();
        }
        private void PrintSavedList()
        {
            listBox1.Items.Clear();
            foreach (var item in ShoppingList)
            {
                listBox1.Items.Add(item);
            }
        }

        public void AddToShoppingList(string name)
        {
            string item = $"{baseUrl}{name}";
            if (!ShoppingList.Contains(item))  // 중복 항목 방지
            {
                ShoppingList.Add(item);
                listBox1.Items.Add(item);  // 리스트 박스에도 추가
            }
            else
            {
                MessageBox.Show("이미 추가된 항목입니다.", "중복 항목 오류");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("텍스트를 입력해주세요", "텍스트 누락 오류");
                textBox1.Focus();
                return;
            }
            AddToShoppingList(textBox1.Text);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var selectedItems = listBox1.SelectedItems.Cast<string>().ToList();
            foreach (var item in selectedItems)
            {
                listBox1.Items.Remove(item);
                ShoppingList.Remove(item);  // 쇼핑 리스트에서도 제거
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("장바구니를 초기화 하시겠습니까?", "장바구니 초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                ShoppingList.Clear();  // 쇼핑 리스트도 초기화
            }
        }

        private void ShoppingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            PrintSavedList();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string url = listBox1.Items[index].ToString();
                Process.Start(url);  // 브라우저에서 링크 열기
            }
        }
    }
}
