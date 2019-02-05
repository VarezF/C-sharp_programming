/// <summary>
/// Driver for program, opens a textbox populated with outputs from Strat1, Strat2 and Strat3
/// All of the above find the number of unique integers within a list
/// </summary>

namespace HW2
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            List<int> randList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 10000; i++)
            {
                randList.Add(rand.Next(20001));
            }

            Strat1 firstMethod = new Strat1(randList);
            Strat2 secondMethod = new Strat2(randList);
            Strat3 thirdMethod = new Strat3(randList);

            this.textBox1.AppendText("1.) Hashset method: " + firstMethod.GetSize() + " distinct numbers  \r\n");
            this.textBox1.AppendText("     Time complexity = insertion + find_size\r\n"
                + "       --Where insertion time into hashtable is O(n)  (1 insert/element in input)\r\n"
                + "         and find_size is O(1)\r\n"
                + "     Thus, time complexity = O(n) + O(1)\r\n"
                + "                                        = O(n)\r\n");
            this.textBox1.AppendText("     Memory complexity = O(n) " +
                "(one element in hashtable for each element of the input, assuming list of fully distinct integers\r\n");

            this.textBox1.AppendText("\r\n2.) O(1) storage method: " + secondMethod.GetUniqueInt() +
                " distinct numbers\r\n");
            this.textBox1.AppendText("     time complexity = O(n^2)\r\n"
                 + "      (each element is compared with other elements in the list, resulting in n^2 comparisons)\r\n");
            this.textBox1.AppendText("     Memory complexity = O(1) as specified in requirements and are independent of the size of input\r\n");

            this.textBox1.AppendText("\r\n3.) Sorting method: " + thirdMethod.GetUniquInt() + " distinct numbers  \r\n");
            this.textBox1.AppendText("     Time complexity = O(n)  (Algorithm performs n comparisons)\r\n");
            this.textBox1.AppendText("     Memory complexity = O(1) as specified in requirements and are independent of the size of input\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
