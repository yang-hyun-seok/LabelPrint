using IniManager;
using Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrerPrint
{
    public partial class Form1 : Form
    {
        
        INIManager INISet = new INIManager(System.Windows.Forms.Application.StartupPath + @"\\Setup.ini");


        int L_UP_FN = 0;
        int L_UP_X = 0;
        int L_UP_Y = 0;

        int R_UP_FN = 0;
        int R_UP_X = 0;
        int R_UP_Y = 0;

        int L_DOWN_FN = 0;
        int L_DOWN_X = 0;
        int L_DOWN_Y = 0;

        int R_DOWN_FN = 0;
        int R_DOWN_X = 0;
        int R_DOWN_Y = 0;
        public Form1()
        {
            InitializeComponent();


            L_UP_FN = Convert.ToInt32(INISet.ReadValue("LEFT_UP", "L_UP_FN"));
            L_UP_X = Convert.ToInt32(INISet.ReadValue("LEFT_UP", "L_UP_X"));
            L_UP_Y = Convert.ToInt32(INISet.ReadValue("LEFT_UP", "L_UP_Y"));

            R_UP_FN = Convert.ToInt32(INISet.ReadValue("RIGHT_UP", "R_UP_FN"));
            R_UP_X = Convert.ToInt32(INISet.ReadValue("RIGHT_UP", "R_UP_X"));
            R_UP_Y = Convert.ToInt32(INISet.ReadValue("RIGHT_UP", "R_UP_Y"));

            L_DOWN_FN = Convert.ToInt32(INISet.ReadValue("LEFT_DOWN", "L_DOWN_FN"));
            L_DOWN_X = Convert.ToInt32(INISet.ReadValue("LEFT_DOWN", "L_DOWN_X"));
            L_DOWN_Y = Convert.ToInt32(INISet.ReadValue("LEFT_DOWN", "L_DOWN_Y"));

            R_DOWN_FN = Convert.ToInt32(INISet.ReadValue("RIGHT_DOWN", "R_DOWN_FN"));
            R_DOWN_X = Convert.ToInt32(INISet.ReadValue("RIGHT_DOWN", "R_DOWN_X"));
            R_DOWN_Y = Convert.ToInt32(INISet.ReadValue("RIGHT_DOWN", "R_DOWN_Y"));



            txt_L_UP_FN.Text = L_UP_FN.ToString();
            txt_L_UP_X.Text = L_UP_X.ToString();
            txt_L_UP_Y.Text = L_UP_Y.ToString();

            txt_R_UP_FN.Text = R_UP_FN.ToString();
            txt_R_UP_X.Text = R_UP_X.ToString();
            txt_R_UP_Y.Text = R_UP_Y.ToString();

            txt_L_DOWN_FN.Text = L_DOWN_FN.ToString();
            txt_L_DOWN_X.Text = L_DOWN_X.ToString();
            txt_L_DOWN_Y.Text = L_DOWN_Y.ToString();

            txt_R_DOWN_FN.Text = R_DOWN_FN.ToString();
            txt_R_DOWN_X.Text = R_DOWN_X.ToString();
            txt_R_DOWN_Y.Text = R_DOWN_Y.ToString();





        }



        /// <summary>바코드 출력</summary>
        private string getbarcode()
        {

            // string FONT_NAME = "AAAAA.FNT";
            string FONT_NAME = INISet.ReadValue("FONT", "FONT");

            

            string line = txt_line.Text.ToUpper();
            string carrier = txtCarrier.Text.ToUpper();
            string point = txtPoint.Text.ToUpper();
            string disp = txtdisp.Text.ToUpper();



            string BarCode = string.Empty;

            BarCode = "^XA";  // 시작
            BarCode = BarCode + "^SEE:UHANGUL.DAT^FS";   // 바코드 한글 처리
            BarCode = BarCode + "^CW1,E:" + FONT_NAME + "^CI26^FS";    // 폰트 
            BarCode = BarCode + "\r\n^LH0,0";         // 기준점



            BarCode = BarCode + $"\r\n^A1N,{txt_L_UP_FN.Text},{txt_L_UP_FN.Text}";  //크기
            BarCode = BarCode + $"\r\n^FO{txt_L_UP_X.Text},{txt_L_UP_Y.Text}";  //위치
            BarCode = BarCode + $"\r\n^FD{line}^FS";   // 내용 표시
            BarCode = BarCode + $"\r\n^A1N,{txt_R_UP_FN.Text},{txt_R_UP_FN.Text}";  //크기
            BarCode = BarCode + $"\r\n^FO{txt_R_UP_X.Text},{txt_R_UP_Y.Text}";  //위치
            BarCode = BarCode + $"\r\n^FD{carrier}^FS";   // 내용 표시
            BarCode = BarCode + $"\r\n^A1N,{txt_L_DOWN_FN.Text},{txt_L_DOWN_FN.Text}";  //크기
            BarCode = BarCode + $"\r\n^FO{txt_L_DOWN_X.Text},{txt_L_DOWN_Y.Text}";  //위치
            BarCode = BarCode + $"\r\n^FD{point}^FS";   // 내용 표시
            BarCode = BarCode + $"\r\n^A1N,{txt_R_DOWN_FN.Text},{txt_R_DOWN_FN.Text}";  //크기
            BarCode = BarCode + $"\r\n^FO{txt_R_DOWN_X.Text},{txt_R_DOWN_Y.Text}";  //위치
            BarCode = BarCode + $"\r\n^FD{disp}^FS";   // 내용 표시

            BarCode = BarCode + "\r\n^XZ";



            INISet.WriteValue("LEFT_UP", "L_UP_FN", txt_L_UP_FN.Text);
            INISet.WriteValue("LEFT_UP", "L_UP_X", txt_L_UP_X.Text);
            INISet.WriteValue("LEFT_UP", "L_UP_Y", txt_L_UP_Y.Text);

            INISet.WriteValue("RIGHT_UP", "R_UP_FN", txt_R_UP_FN.Text);
            INISet.WriteValue("RIGHT_UP", "R_UP_X", txt_R_UP_X.Text);
            INISet.WriteValue("RIGHT_UP", "R_UP_Y", txt_R_UP_Y.Text);

            INISet.WriteValue("LEFT_DOWN", "L_DOWN_FN", txt_L_DOWN_FN.Text);
            INISet.WriteValue("LEFT_DOWN", "L_DOWN_X", txt_L_DOWN_X.Text);
            INISet.WriteValue("LEFT_DOWN", "L_DOWN_Y", txt_L_DOWN_Y.Text);

            INISet.WriteValue("RIGHT_DOWN", "R_DOWN_FN", txt_R_DOWN_FN.Text);
            INISet.WriteValue("RIGHT_DOWN", "R_DOWN_X", txt_R_DOWN_X.Text);
            INISet.WriteValue("RIGHT_DOWN", "R_DOWN_Y", txt_R_DOWN_Y.Text);

            

            return BarCode;

      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 프린트 다이얼로그 선언
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();

            // 바코드String을 가져온다
            string BarCode = getbarcode();

            // 바코드 출력
            if (!(RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, BarCode)))
            {
                MessageBox.Show("에러!!!");
            }
            else
            {

            }
        }
    }
}
