using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQGUI
{
    public partial class Form1 : Form
    {
        List<Food> FoodList;
        public Form1()
        {
            InitializeComponent();
            Loadfood();
        }

        void Loadfood()
        {
            FoodList = new List<Food>();
            FoodList.Add(new Food("Dú dê nướng", "50000"));
            FoodList.Add(new Food("Dú heo nướng", "40000"));
            FoodList.Add(new Food("thịt dê nướng", "80000"));
            FoodList.Add(new Food("thịt heo nướng", "60000"));

            cbData.DataSource = FoodList;
            cbData.DisplayMember = "Name";



        }
        public class Food
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string price;
            public string Price
            {
                get { return price; }
                set { price = value; }
            }

            public Food() { }
            public Food(string name, string price)
            {
                this.Name = name;
                this.Price = price;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Food> result = new List<Food>();
            //Duyệt từng phần tử trong FoodList với txbKey.Text nếu giống thì add vào cbResult
            /*
            foreach (Food item in FoodList)
            {
                if (item.Name==txbKey.Text)
                {
                    result.Add(item);
                }
            }
            cbResult.DataSource = result;
            cbResult.DisplayMember = "Name";
            */

            // List<Food> result 2 là các giá tiền trong  FoodList 
            var result2 = FoodList.Select(item => item.Price).ToList();
            cbResult.DataSource = result2;
            cbResult.DisplayMember = "Name";

            //Lấy ra 1 thằng thỏa mãn
            //VD: var result2 = FoodList.Select(item => item.Price).SingleOrDefault();

            //Bỏ qua 2 thằng lấy 2 thằng
            //VD:  var result2 = FoodList.skip(2).Take(2).ToLiST();


        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
