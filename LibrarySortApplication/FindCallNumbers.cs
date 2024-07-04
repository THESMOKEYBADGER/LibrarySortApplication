using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace LibrarySortApplication
{
    public partial class FindCallNumbers : Form
    {
        static Random rnd = new Random();
        List<Node> correctGuess;
        List<Node> firstOptions;
        List<Node> secondOptions;
        List<Node> thirdOptions;



        public FindCallNumbers()
        {

            InitializeComponent();
            Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

            String txtFilePath = @"C:\Users\User\Desktop\Library Sort Application Part 2 Gabe\LibrarySortApplication\CallNumbersList\CallNumbersNew.txt";
            string[] fileData = File.ReadAllLines(txtFilePath);
            createNodes(fileData);
            Console.WriteLine();



        }

        private void FindCallNumbers_Load(object sender, EventArgs e)
        {

            fillButtons();

        }

        // creates tree root
        public Node root = new Node("Root", "000");


        // creates tree nodes
        public class Node
        {
            public string desciption;
            public string code;
            public List<Node> children;

            public Node(string desc, string code)
            {
                desciption = desc;
                children = new List<Node>();
                this.code = code;
            }
        }


        // checks levels of items in dewey list
        public int countSpaces(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; ++i)
            {
                if (line[i] == ' ') count++;
                else break;
            }
            return count;
        }


        // removes call number from all items
        public string formatDescription(string desc)
        {
            string temp = desc.Trim();
            return temp.Substring(4);
        }


        // gets call number to attach to node
        public string getCode(string desc)
        {
            string temp = desc.Trim();
            return temp.Substring(0, 4);
        }


        /// <summary>
        /// creates all correct guesses 
        /// creates random incorrect call numbers 
        /// stores all values in a dictionary to be stored in combo box
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<Node>> getValid()
        {
            int f = rnd.Next(root.children.Count);
            Node firstNode = root.children[f];
            int s = rnd.Next(firstNode.children.Count);

            Node secondNode = firstNode.children[s];
            int t = rnd.Next(secondNode.children.Count);

            Node thirdNode = secondNode.children[t];
            List<Node> correct = new List<Node>();

            correct.Add(firstNode);
            correct.Add(secondNode);
            correct.Add(thirdNode);
            Dictionary<string, List<Node>> dict = new Dictionary<string, List<Node>>();
            dict.Add("Correct", correct);
            List<Node> first = new List<Node>();
            List<Node> second = new List<Node>();
            List<Node> third = new List<Node>();

            int count = 0;
            List<int> chosen = new List<int>();
            // Get first level
            while (count < 3)
            {
                int index = rnd.Next(root.children.Count);
                if (index == f || chosen.Contains(index)) continue;
                Node node = root.children[index];
                first.Add(node);
                chosen.Add(index);
                count++;
            }
            count = 0;
            chosen = new List<int>();
            List<string> chosen1 = new List<string>();
            // Get second level
            while (count < 3)
            {
                int rootIndex = rnd.Next(root.children.Count);
                int index = rnd.Next(root.children[rootIndex].children.Count);
                Node node = root.children[rootIndex].children[index];
                if (index == s || chosen1.Contains(node.code)) continue;

                second.Add(node);
                chosen1.Add(node.code);
                count++;
            }
            count = 0;
            chosen = new List<int>();
            List<string> chosen2 = new List<string>();
            // Get third level
            while (count < 3)
            {
                int rootIndex = rnd.Next(root.children.Count);
                Node fNode = root.children[rootIndex];
                int secondIndex = rnd.Next(fNode.children.Count);
                int index = rnd.Next(fNode.children[secondIndex].children.Count);
                Node node = fNode.children[secondIndex].children[index];
                if (index == s || chosen2.Contains(node.code)) continue;
                third.Add(node);
                chosen2.Add(node.code);
                count++;
            }

            dict.Add("First", first);
            dict.Add("Second", second);
            dict.Add("Third", third);


            return dict;
        }

        // generates the tree from the uploaded file
        public void createNodes(string[] list)
        {
            Node newNode = null;
            Node childNode = null;
            for (int i = 0; i < list.Length; ++i)
            {
                if (list[i].Length == 0) continue;
                int count = countSpaces(list[i]);

                if (count == 0)
                {
                    if (newNode != null) root.children.Add(newNode);
                    newNode = new Node(formatDescription(list[i]), getCode(list[i]));

                }
                else if (count == 2)
                {
                    childNode = new Node(formatDescription(list[i]), getCode(list[i]));
                    newNode.children.Add(childNode);
                }
                else if (count == 4)
                {
                    Node leafNode = new Node(formatDescription(list[i]), getCode(list[i]));
                    childNode.children.Add(leafNode);
                }
            }





        }


        // assigns the dictionary to combobox items
        public void fillButtons()
        {
            Dictionary<string, List<Node>> temp = getValid();
            temp.TryGetValue("Correct", out correctGuess);
            temp.TryGetValue("First", out firstOptions);
            temp.TryGetValue("Second", out secondOptions);
            temp.TryGetValue("Third", out thirdOptions);

            Question.Text = correctGuess[2].desciption;
            cmbLevel1.Items.Clear();
            cmbLevel2.Items.Clear();
            cmbLevel3.Items.Clear();
            firstOptions.Add(correctGuess[0]);
            secondOptions.Add(correctGuess[1]);
            thirdOptions.Add(correctGuess[2]);


            // rearrange combobox items in order of the code
            firstOptions = firstOptions.OrderBy(n => n.code).ToList();
            secondOptions = secondOptions.OrderBy(n => n.code).ToList();
            thirdOptions = thirdOptions.OrderBy(n => n.code).ToList();

            for (int i = 0; i < firstOptions.Count; ++i)
            {
                Node node = firstOptions[i];
                //level1.Add(node.code + " " + node.desciption);
                cmbLevel1.Items.Add(node.code + " " + node.desciption);
            }
            for (int i = 0; i < secondOptions.Count; ++i)
            {
                Node node = secondOptions[i];
                // level2.Add(node.code + " " + node.desciption);
                cmbLevel2.Items.Add(node.code + " " + node.desciption);

            }
            for (int i = 0; i < thirdOptions.Count; ++i)
            {
                Node node = thirdOptions[i];
                cmbLevel3.Items.Add(node.code);
            }



        }


        // checks if level 1 selected item is correct
        private void btnLvlCheck1_Click(object sender, EventArgs e)
        {
            if (cmbLevel1.SelectedItem.Equals(correctGuess[0].code + " " + correctGuess[0].desciption))
            {

                DialogResult result = MessageBox.Show("SHEW NICE", "CLICK YES TO CONTINUE OR NO TO RETRY", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    tabControl1.SelectedIndex = 1;

                }
                else if (result == DialogResult.No)
                {
                    refresh();
                }

            }
            else
            {
                MessageBox.Show("INCORRECT GUESS");


                refresh();

            }
        }

        // checks if level 2 selected item is correct
        private void btnLvlCheck2_Click(object sender, EventArgs e)
        {
            if (cmbLevel2.SelectedItem.Equals(correctGuess[1].code + " " + correctGuess[1].desciption))
            {
                DialogResult result = MessageBox.Show("YES! That's Right", "CLICK YES TO CONTINUE OR NO TO RETRY", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tabControl1.SelectedIndex = 2;

                }
                else if (result == DialogResult.No)
                {
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("INCORRECT GUESS");
                refresh();

            }
        }

        // checks if level 3 selected item is correct
        private void btnLvlCheck3_Click(object sender, EventArgs e)
        {
            if (cmbLevel3.SelectedItem.Equals(correctGuess[2].code))
            {
                DialogResult result = MessageBox.Show("AMAZING YOU DID IT", "CLICK YES TO CONTINUE OR NO TO RETRY", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    tabControl1.SelectedIndex = 2;

                }
                else if (result == DialogResult.No)
                {
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("INCORRECT GUESS");
                refresh();

            }
        }
        // refresh game
        public void refresh()
        {
            this.Hide();
            FindCallNumbers fn = new FindCallNumbers();
            fn.ShowDialog();
        }

    }
}
