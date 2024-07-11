using FoodManagementApplication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FoodManagementApplication
{
    internal static class Program
    {
        public static Database dummy;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dummy = new Database();

            Application.Run(new IngredientForm());

        }
    }
}
