using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;
namespace Login_UI_design
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MicronConfig config = new MicronConfig()
            {
                DatabaseName = "login_demo"
            };
            MicronDbContext.AddConnectionSetup(config); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        //public static string CalculateMD5Hash(string input)
        //{
        //    MD5 md5 = System.Security.Cryptography.MD5.Create();
        //    byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
        //    byte[] hash = md5.ComputeHash(inputBytes);

        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        sb.Append(hash[i].ToString("X2")); 
        //    }
        //    return sb.ToString();
        //}
        
    }
}
