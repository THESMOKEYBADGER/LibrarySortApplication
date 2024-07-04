using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySortApplication
{
    
    public partial class MatchColumns : Form
    {
        Random random = new Random();
        List<String> correctGuesses;
        List<int> correctGuesses2;

        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        Dictionary<String, int> dictionary2 = new Dictionary<string, int>();

        public MatchColumns()
        {
            InitializeComponent();
            correctGuesses = new List<string>();
            correctGuesses2 = new List<int>();

            RandomizeOutput();
        }


        public void RandomizeOutput()
        {
            Random rnd = new Random();
            int rand = rnd.Next(2);

            if (rand == 1)
            {
                GuessTopic();
            }
            else
            {
                GuessCode();
            }

        }


        // start new game button click 
        private void button1_Click(object sender, EventArgs e)
        {
            RandomizeOutput();
        }

        // guess the call number to match the description methods
        public void GuessCode()
        {
            BTNDescCheck.Visible = false;

            Dewey_Decimal_System_Load();
            PopulateComboBox();
        }

        // guess the description that matches the call number
        public void GuessTopic()
        {

            onClickCheck.Visible = false;
            Dewey_Decimal_System_Load2();
            PopulateDescComboBox();
        }


        // gamification feature check score

        private void onClickCheck_Click_1(object sender, EventArgs e)
        {
            onCheckClick();
            if (correctGuesses.Count == 1)
            {
                star1.Visible = true; 
            }
            if (correctGuesses.Count == 2)
            {
                star1.Visible = true;
                star2.Visible = true;
            }
            if (correctGuesses.Count == 3)
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
            }
            if (correctGuesses.Count == 4)
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
            }
            else
            {
                star1.Visible = false;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
            }

            
            DialogResult result =  MessageBox.Show("Score: " + correctGuesses.Count + "/4", "Well done Do you want to play again?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                star1.Visible = false;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
                this.Close();
                RandomizeOutput();
            }
            else if (result == DialogResult.No)
            {
                this.Close(); 
            }
        }

        private void BTNDescCheck_Click_1(object sender, EventArgs e)
        {
            onCheckClick2();
            if (correctGuesses.Count == 1)
            {
                star1.Visible = true;
            }
            if (correctGuesses.Count == 2)
            {
                star1.Visible = true;
                star2.Visible = true;
            }
            if (correctGuesses.Count == 3)
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
            }
            if (correctGuesses.Count == 4)
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
            }
            else
            {
                star1.Visible = false;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
            }


            DialogResult result = MessageBox.Show("Score: " + correctGuesses.Count + "/4", "Well done Do you want to continue?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                star1.Visible = false;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
                this.Close();
                RandomizeOutput();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }

        }
        

        /// -----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// match call number to descriptions methods
        /// </summary>
        /// 


        // CREATE DICTIONARY OF CALL NUMBERS AND DESCRIPTIONS
        private void Dewey_Decimal_System_Load()
        {



            dictionary.Add(000, "Art");
            dictionary.Add(100, "Philosiphy");
            dictionary.Add(200, "Sport");
            dictionary.Add(300, "Biology");
            dictionary.Add(400, "Physics");
            dictionary.Add(500, "Mathematics");
            dictionary.Add(600, "Computer Science");
            dictionary.Add(700, "Design");
            dictionary.Add(800, "Fiction");
            dictionary.Add(900, "History");

        }




        // populate combo box method with dictionary items

        private void PopulateComboBox()
        {
            List<int> keyList = new List<int>(this.dictionary.Keys);



            var shuffled = keyList.OrderBy(_ => random.Next()).ToList();

            for (int i = 0; i < 7; i++)
            {
                comboBox1.Items.Add(shuffled[i]);
                comboBox2.Items.Add(shuffled[i]);
                comboBox3.Items.Add(shuffled[i]);
                comboBox4.Items.Add(shuffled[i]);

            }

            // assign values to column 2
            label5.Text = shuffled[0].ToString();
            label6.Text = shuffled[1].ToString();
            label7.Text = shuffled[2].ToString();
            label8.Text = shuffled[3].ToString();
            label9.Text = shuffled[4].ToString();
            label10.Text = shuffled[5].ToString();
            label11.Text = shuffled[6].ToString();


            AssignQuestionsCol1();
            //getKeys();

        }


        // assign questions from randomly generated possible answers
        public void AssignQuestionsCol1()
        {
            int key1 = Int32.Parse(label5.Text);
            int key2 = Int32.Parse(label6.Text);
            int key3 = Int32.Parse(label7.Text);
            int key4 = Int32.Parse(label8.Text);
            int key5 = Int32.Parse(label9.Text);
            int key6 = Int32.Parse(label10.Text);
            int key7 = Int32.Parse(label11.Text);


            List<String> valueList = new List<String>();

            String dictValue1;
            dictionary.TryGetValue(key1, out dictValue1);
            valueList.Add(dictValue1);

            String dictValue2;
            dictionary.TryGetValue(key2, out dictValue2);
            valueList.Add(dictValue2);

            String dictValue3;
            dictionary.TryGetValue(key3, out dictValue3);
            valueList.Add(dictValue3);

            String dictValue4;
            dictionary.TryGetValue(key4, out dictValue4);
            valueList.Add(dictValue4);

            String dictValue5;
            dictionary.TryGetValue(key5, out dictValue5);
            valueList.Add(dictValue5);

            String dictValue6;
            dictionary.TryGetValue(key6, out dictValue6);
            valueList.Add(dictValue6);

            String dictValue7;
            dictionary.TryGetValue(key7, out dictValue7);
            valueList.Add(dictValue7);


            var shuffledQ = valueList.OrderBy(_ => random.Next()).ToList();

            //Console.WriteLine(shuffledQ.Count);


            label1.Text = shuffledQ[0];
            label2.Text = shuffledQ[1];
            label3.Text = shuffledQ[2];
            label4.Text = shuffledQ[3];




        }



        public void onCheckClick()
        {
            if (comboBox1.Text.Length != 0) getKeys(comboBox1, label1);
            if (comboBox2.Text.Length != 0) getKeys(comboBox2, label2);
            if (comboBox3.Text.Length != 0) getKeys(comboBox3, label3);
            if (comboBox4.Text.Length != 0) getKeys(comboBox4, label4);
        }



        //checking algorithm
        public void getKeys(ComboBox comboBox, Label label)
        {
            int key1 = Int32.Parse(comboBox.Text);

            string value;
            bool hasValue = dictionary.TryGetValue(key1, out value);

            if (hasValue && value.Equals(label.Text) && !correctGuesses.Contains(label.Text))
            {
                correctGuesses.Add(label.Text);
            }
        }





        /// <summary>
        /// END match call number to descriptions methods
        /// </summary>
        /// -----------------------------------------------------------------------------------------------------------------------------------------------------------------------




        /// <summary>
        /// START match descriptions to call numbers
        /// </summary>
        /// -----------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void Dewey_Decimal_System_Load2()
        {



            dictionary2.Add("Art", 000);
            dictionary2.Add("Philosiphy", 100);
            dictionary2.Add("Sports", 200);
            dictionary2.Add("Biology", 300);
            dictionary2.Add("Physics", 400);
            dictionary2.Add("Mathematics", 500);
            dictionary2.Add("Computer Science", 600);
            dictionary2.Add("Design", 700);
            dictionary2.Add("Fiction", 800);
            dictionary2.Add("History", 900);

        }


        private void PopulateDescComboBox()
        {
            List<string> keyList2 = new List<string>(this.dictionary2.Keys);



            var shuffled2 = keyList2.OrderBy(_ => random.Next()).ToList();

            for (int i = 0; i < 7; i++)
            {
                comboBox1.Items.Add(shuffled2[i]);
                comboBox2.Items.Add(shuffled2[i]);
                comboBox3.Items.Add(shuffled2[i]);
                comboBox4.Items.Add(shuffled2[i]);

            }

            // assign values to column 2
            label5.Text = shuffled2[0];
            label6.Text = shuffled2[1];
            label7.Text = shuffled2[2];
            label8.Text = shuffled2[3];
            label9.Text = shuffled2[4];
            label10.Text = shuffled2[5];
            label11.Text = shuffled2[6];


            AssignDescQuestionsCol1();


        }

        public void AssignDescQuestionsCol1()
        {
            string key1 = label5.Text;
            string key2 = label6.Text;
            string key3 = label7.Text;
            string key4 = label8.Text;
            string key5 = label9.Text;
            string key6 = label10.Text;
            string key7 = label11.Text;


            List<int> valueList = new List<int>();

            //dsiplays descriptions

            int dictValue1;
            dictionary2.TryGetValue(key1, out dictValue1);
            valueList.Add(dictValue1);

            int dictValue2;
            dictionary2.TryGetValue(key2, out dictValue2);
            valueList.Add(dictValue2);

            int dictValue3;
            dictionary2.TryGetValue(key3, out dictValue3);
            valueList.Add(dictValue3);

            int dictValue4;
            dictionary2.TryGetValue(key4, out dictValue4);
            valueList.Add(dictValue4);

            int dictValue5;
            dictionary2.TryGetValue(key5, out dictValue5);
            valueList.Add(dictValue5);

            int dictValue6;
            dictionary2.TryGetValue(key6, out dictValue6);
            valueList.Add(dictValue6);

            int dictValue7;
            dictionary2.TryGetValue(key7, out dictValue7);
            valueList.Add(dictValue7);


            var shuffledQ = valueList.OrderBy(_ => random.Next()).ToList();

            //Console.WriteLine(shuffledQ.Count);


            label1.Text = shuffledQ[0].ToString();
            label2.Text = shuffledQ[1].ToString();
            label3.Text = shuffledQ[2].ToString();
            label4.Text = shuffledQ[3].ToString();




        }







        //checking algorithm
        public void getDescKeys(ComboBox comboBox, Label label)
        {
            String key1 = comboBox.Text;

            int value;
            bool hasValue = dictionary2.TryGetValue(key1, out value);

            if (hasValue && value.Equals(Int32.Parse(label.Text)) && !correctGuesses2.Contains(Int32.Parse(label.Text)))
            {
                correctGuesses2.Add(Int32.Parse(label.Text));
            }
        }


        public void onCheckClick2()
        {
            if (comboBox1.Text.Length != 0) getDescKeys(comboBox1, label1);
            if (comboBox2.Text.Length != 0) getDescKeys(comboBox2, label2);
            if (comboBox3.Text.Length != 0) getDescKeys(comboBox3, label3);
            if (comboBox4.Text.Length != 0) getDescKeys(comboBox4, label4);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
