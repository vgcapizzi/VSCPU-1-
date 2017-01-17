using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;



public partial class _Default : Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        string str = TextBox1.Text;
        char[] str1 = str.ToCharArray();
        byteObject input = new byteObject();
        //str = input.altValue(str);
        string str2 = input.toHex(str1);
        
        TextBox2.Text = str2;


        return;
    }
    class memCell
    {
        int[,] cell = new int[67, 67]; //mem cell 2d array 64 by 64
        for (int row = 0; row < 67; row++) //fill array by default with all 0
        {
            
            for(int col = 0; col > 67; col++)
            {
                cell[row,col] = 
            }
        }

    }

    class byteObject 
    {
        int dec;
        char[] bin = { '0', '0', '0', '0', ' ', '0', '0', '0', '0' };
        char[] hex = { '0', ' ', '0'};
        string machineCode;
        
        
        public string altValue(string assemble) //method assemble to bin with proper instrc bits
        {
            string input = assemble;
            switch(input)
            {
                case "ADD":
                    bin[0] = '0';
                    bin[1] = '0';
                    break;
                case "AND":
                    bin[0] = '0';
                    bin[1] = '1';
                    break;
                case "JMP":
                    bin[0] = '1';
                    bin[1] = '0';
                    break;
                case "INC":
                    bin[0] = '1';
                    bin[1] = '1';
                    break;
            }
            machineCode = new string(bin);
            return machineCode;
        }
        public string toHex(char[] bin) //method bin to hex
        {
            string input = new string(bin);
            string input1 = input.Substring(0,4);
            string input2 = input.Substring(5,4); 
            int hexValue1 = Convert.ToInt32(input1, 2);
            int hexValue2 = Convert.ToInt32(input2, 2);
            string output1 = hexValue1.ToString();
            string output2 = hexValue2.ToString();

            switch(output1)
            {
                case "10":
                    output1 = "A";
                    break;
                case "11":
                    output1 = "B";
                    break;
                case "12":
                    output1 = "C";
                    break;
                case "13":
                    output1 = "D";
                    break;
                case "14":
                    output1 = "E";
                    break;
                case "15":
                    output1 = "F";
                    break;
            }
            switch (output2)
            {
                case "10":
                    output2 = "A";
                    break;
                case "11":
                    output2 = "B";
                    break;
                case "12":
                    output2 = "C";
                    break;
                case "13":
                    output2 = "D";
                    break;
                case "14":
                    output2 = "E";
                    break;
                case "15":
                    output2 = "F";
                    break;
            }
            //could have done this better, prob dont need two case statements for this
            string output = output1 + " " + output2;
            return output;
        }
        
        //try catches for wrong input data
        /*public string toDec(char[] bin)    //method bin to dec
        {
            string input = new string(bin);
            int decValue = Convert.ToInt32(input, 2);
            string output = decValue.ToString();
            return output;
        }
         */
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

        
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}