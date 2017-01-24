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

        //System.Diagnostics.Debug.WriteLine("poop"); 
        string str = TextBox1.Text;
        
        char[] str1 = str.ToCharArray();
        byteObject input = new byteObject();
        str = input.altValue(str);
        cell1.Text = str;
        

        return;
    }
    class memClass
    {
        byteObject[] cell = new byteObject[64];
 

    }

    class byteObject 
    {

        char[] intrBin = {'0','0'};
      
        public string altValue(string assemble) //method assemble to bin with proper instrc bits
        {
            string instruc1 = assemble.Substring(0, 3);
            string hex1 = assemble.Substring(4,1);
            //max for hex vales is 3F need to create if for that
            int numVal1 = Int32.Parse(hex1);
            if (numVal1 > 3)
            {
                string warn = "First hex value is too high enter a max hex value of 3F";
                return warn;
            }
            else
            {
                
            }
            string hex2 = assemble.Substring(5);
            
            switch(instruc1)
            {
                case "ADD":
                    intrBin[0] = '0';
                    intrBin[1] = '0';
                    break;
                case "AND":
                    intrBin[0] = '0';
                    intrBin[1] = '1';
                    break;
                case "JMP":
                    intrBin[0] = '1';
                    intrBin[1] = '0';
                    break;
                case "INC":
                    intrBin[0] = '1';
                    intrBin[1] = '1';
                    break;
            }
            //[0,1,2,3,4,5]
            //[0-2 instr],[3 space],[4 hex1],[5 hex2]
            //2 bits for instruc, 6 bits for address
            //6 bits, 2 bits for first hex to bin, 4 bits for second hex to bin
            //intruc is properly converted to bin when its by itself
            //take Hex string convert to bin string

            //pad hex1 for 2 zeros
            long bit64 = Convert.ToInt64(hex1, 16);
            string addr1 = Convert.ToString(bit64, 2);
            int intVal1 = Int32.Parse(addr1);
            string edit1 = intVal1.ToString("00");
            
            //for hex2 value for 4 zeros
            long bit64_2 = Convert.ToInt64(hex2, 16);
            string addr2 = Convert.ToString(bit64_2, 2);
            int intVal2 = Int32.Parse(addr2);
            string edit2 = intVal2.ToString("0000");
            
            //bring all componets together in display 
            string assOut = new string(intrBin);
            string bitOutput = assOut + edit1 + " " + edit2;            
            return bitOutput;
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
       
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

        
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}