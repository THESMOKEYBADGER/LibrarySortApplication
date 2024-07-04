using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Timers;

namespace LibrarySortApplication
{
    /// <summary>
    /// GABRIEL ROBBERTZE ST10082248
    /// PROG POE PART 1
    /// </summary>
    public partial class SortList : Window
    {
        // TIMER IMPLEMENTATION
        private Stopwatch _stopWatch;
        private Timer _timer;
        private const string StartTimer = "00:00:00";
        private Boolean sorted = false;

        ///RANDOM NUMBER GENERATOR 
        private Random ran = new Random();

        public SortList()
        {
            InitializeComponent();
            timerDisplay.Text = StartTimer;

            _stopWatch = new Stopwatch();
            _timer = new Timer(interval: 1000);

            _timer.Elapsed += OnTimerElapse;
        }

        private void OnTimerElapse(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() => timerDisplay.Text = _stopWatch.Elapsed.ToString(format: @"hh\:mm\:ss"));
        }

        private void Timer_BTN(object sender, RoutedEventArgs e)
        {
            _stopWatch.Start();
            _timer.Start();
        }

        // STRING LIST TO HOLD CALL NUMBERS
        List<string> dewey = new List<string>();

        // STRING LIST TO HOLD LSIT BOX 2 ITEMS
        private List<String> LB2_items = new List<string>();

        // STRING LIST TO HOLD USER ORDER
        List<string> newList = new List<string>();

        // STRING LIST TO COMPARE ORDERED LIST TO
        List<String> sortedListLB2 = new List<string>();

        // BUTTON CLICK EVENT THAT SHOWS THE THE USER THE SORTED LIST IN LISTBOX 2
        private void sortListBTN_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            List<ListBoxItem> items = new List<ListBoxItem>();

            sortedListLB2 = LB2_items.OrderBy(x => rand.Next()).ToList();
            sortList(sortedListLB2);
            sorted = true;

            for (int i = 0; i < LB2_items.Count; ++i)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = sortedListLB2[i];
                items.Add(item);
            }
            LB2.Items.Clear();
            for (int i = 0; i < items.Count; ++i)
            {
                ListBoxItem listItem = items.ElementAt(i);
                LB2.Items.Add(listItem);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------//

        // BUBBLE SORT
        // METHOD TO SORT LIST INTO ASCENDING ORDER. 
        private void sortList(List<String> list)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = i + 1; j < list.Count; ++j)
                {
                    int num1 = int.Parse(list.ElementAt(i).Substring(0, 3));
                    int num2 = int.Parse(list.ElementAt(j).Substring(0, 3));

                    if (num2 < num1)
                    {
                        String temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------

        // NEW RANDOM ORDER LIST IN LIST BOX 1. 
        private void setupLB1Items()
        {
            // ASSIGNS LIST ITEMS TO LIST BOX 1
            List<ListBoxItem> items = new List<ListBoxItem>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 };
            Random rand = new Random();

            // RANDOMIZE LIST. 
            newList = dewey.OrderBy(x => rand.Next()).ToList();

            for (int i = 0; i < 10; ++i)
            {
                ListBoxItem item = items.ElementAt(i);
                String content = newList.ElementAt(i);
                item.Content = content;
            }
        }

        // CHECK IF LIST IS ORDERED. 
        private void checkList_BTN(object sender, RoutedEventArgs e)
        {
            if (sorted)
            {
                // STOP TIMER AND RECORD
                _stopWatch.Stop();
                _timer.Stop();
                String timeDisp = timerDisplay.Text;

                MessageBox.Show("Woo Hoo! You sorted the books in " + timeDisp + "!", "Congratulations", MessageBoxButton.OK);
            }

            else
            {
                MessageBox.Show("The books dont seem to be in the right order", "Try Again", MessageBoxButton.OK);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------//


        /// METHOD TO GENERATE RANDOM ITEMS

        // GENERATE RANDOM DEWEY DECIMALS
        public void DeweyDecimal()
        {
            String randomDewey;
            List<string> Genre = new List<String>() { "000", "100", "200", "300", "400", "500", "600", "700", "800", "900" };

            // GENRATING RANDOM DEWEY DECIMALS AND 
            for (int i = 0; i < 10; i++)
            {
                int a = ran.Next(99);
                randomDewey = Genre[i] + "." + a + "." + getRandom();
                dewey.Add(randomDewey);
            }
            // METHOD CALL TO RANDOMIZE ORDER OF ASSIGNMENT TO THE LIST BOX
            setupLB1Items();
        }

        // CHECKING IF ITEM ALREADY IN LIST 
        private int existsInList(List<String> list, String value)
        {
            int result = -1;

            for (int i = 0; i < list.Count; ++i)
            {
                if (list.ElementAt(i).Equals(value)) result = i;
            }
            return result;
        }


        // GENERATE RANDOM AUTHOR INITIALS. 
        private String getRandom()
        {
            String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = 3;
            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                Console.WriteLine("Random integer: " + a);
                random = random + b.ElementAt(a);
            }
            return random;
        }

        // END OF GENERATE RANDOM DEWEY DECIMALS

        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------///

        /// METHOD TO FACILITATE DRAGGING ITEMS BETWEEN LISTBOXES

        private void LB1_Drop(object sender, DragEventArgs e)
        {
            // 'e.Data.GetData()' IS CAST AS A LISTBOX ITEM IF != NULL THEN CODE WILL EXECUTE
            if (e.Data.GetData(DataFormats.FileDrop) is ListBoxItem listItem)
            {
                LB1.Items.Add(listItem);
                LB2_items.Remove((String)listItem.Content);
            }
        }



        private void LB2_Drop(object sender, DragEventArgs e)
        {
            // 'e.Data.GetData()' IS CAST AS A LISTBOX ITEM IF != NULL THEN CODE WILL EXECUTE
            if (e.Data.GetData(DataFormats.FileDrop) is ListBoxItem listItem)
            {
                // ADDING LSITBOX 1 ITEMS INTO LIST BOX 2
                LB2.Items.Add(listItem);

                int index = existsInList(LB2_items, (String)listItem.Content);

                if (index == -1)
                {
                    LB2_items.Add((String)listItem.Content);
                    sorted = false;
                }
                else
                {
                    LB2_items.Remove((String)listItem.Content);
                    LB2_items.Add((String)listItem.Content);
                    sorted = false;
                }
            }
        }


        // FACILITATES DRAGGING FROM LIST BOX 1
        private void LB1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mPos = e.GetPosition(null);

            if (e.LeftButton == MouseButtonState.Pressed &&
                Math.Abs(mPos.X) > SystemParameters.MinimumHorizontalDragDistance &&
                Math.Abs(mPos.Y) > SystemParameters.MinimumVerticalDragDistance)
            {
                try
                {
                    // SELECTED ITEM IS FETCHED
                    ListBoxItem selectedItem = (ListBoxItem)LB1.SelectedItem;
                    // MUST BE REMOVED BEFORE ADDING TO A DIFFERENT LIST
                    LB1.Items.Remove(selectedItem);

                    // DRAG DROP

                    DragDrop.DoDragDrop(this, new DataObject(DataFormats.FileDrop, selectedItem), DragDropEffects.Copy);

                    // CHECK IF LIST BOX ITEM IS IN A LISTBOX 
                    // STOP THE DRAGGED ITEM FROM DISSAPEARING IF NOT DROPPED IN A LISTBOX

                    if (selectedItem.Parent == null)
                    {
                        LB1.Items.Add(selectedItem);
                    }
                }
                catch { }
            }
        }

        // FACILITATES DRAGGING FROM LIST BOX 2
        private void LB2_MouseMove(object sender, MouseEventArgs e)
        {
            Point mPos = e.GetPosition(null);

            if (e.LeftButton == MouseButtonState.Pressed &&
                Math.Abs(mPos.X) > SystemParameters.MinimumHorizontalDragDistance &&
                Math.Abs(mPos.Y) > SystemParameters.MinimumVerticalDragDistance)
            {
                try
                {
                    // SELECTED ITEM IS FETCHED
                    ListBoxItem selectedItem = (ListBoxItem)LB2.SelectedItem;
                    // MUST BE REMOVED BEFORE ADDING TO A DIFFERENT LIST
                    LB2.Items.Remove(selectedItem);

                    // DRAG DROP

                    DragDrop.DoDragDrop(this, new DataObject(DataFormats.FileDrop, selectedItem), DragDropEffects.Copy);

                    // CHECK IF LIST BOX ITEM IS IN A LISTBOX 
                    // STOP THE DRAGGED ITEM FROM DISSAPEARING IF NOT DROPPED IN A LISTBOX

                    if (selectedItem.Parent == null)
                    {
                        LB2.Items.Add(selectedItem);
                    }
                }
                catch { }
            }
        }
    }
}
