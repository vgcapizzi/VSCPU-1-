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

        System.Diagnostics.Debug.WriteLine("poop"); //cant write to screen for some reason
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

        char[] intrBin = {'0','0','0','0','0','0','0','0'};
      
        public string altValue(string assemble) //method assemble to bin with proper instrc bits
        {
            
            switch(assemble)
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
            
            string str1 = assemble.Substring(4, 1); //take Hex string convert to bin string, THIS LINE BREAKS EVERTHING & IDK WHYYY
            /*
            long bit64 = Convert.ToInt64(str1, 16);
            //Console.WriteLine("pop"); cant print to screen for some reason
            string addr1 = Convert.ToString(bit64, 2);
            char[] addrArr1 = addr1.ToCharArray(); //bin string to hex array
            //Console.WriteLine(addr1); cant print to screen for some reason
            
            for (int i = 2; i <= 3; i++) //put data in master array
            {
                intrBin[i] = addrArr1[i];
            }
            string str2 = assemble.Substring(5); 
            long bit64_2 = Convert.ToInt64(str1, 16);
            //Console.WriteLine(str1);
            //couldnt get it to work with strings, now im trying it with char array then i will convert to string for return
            string addr2 = Convert.ToString(bit64_2, 2);
            Console.WriteLine(addr2.Length);
            char[] addrArr2 = addr2.ToCharArray();
            //Console.WriteLine(addr2); 
            
            for (int i = 4; i <= 7; i++)
            {
                intrBin[i] = addrArr2[i];
            }
            */
            string bitOutput = new string(intrBin);
          
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