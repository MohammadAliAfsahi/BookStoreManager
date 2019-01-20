using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;



namespace LibrarySystemManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Circularlist /*linked list*/
        {

            private string currentName;
            private string currentAuthor;
            private int currentYear;
            private double currentPrice;
            private int currentNumber;
            private Circularlist nextdata;
            private Circularlist last;
            public Circularlist()
            {
                currentName = null;
                currentAuthor = null;
                currentYear = 0;
                currentPrice = 0.0;
                currentNumber = 0;
                nextdata = this;
                last = null;
            }
            public Circularlist(string name, string author, int year, double price, int number)
            {
                currentName = name;
                currentAuthor = author;
                currentYear = year;
                currentPrice = price;
                currentNumber = number;
                nextdata = this;
                last = null;
            }
            public Circularlist Insdata(string name, string author, int year, double price, int number)
            {

                Circularlist node = new Circularlist(name, author, year, price, number);
                
                if (last == null)// empty list
                {
                    last = node;
                    node.nextdata = node;
                    
                }
                else
                {
                  

                    node.nextdata = last.nextdata;
                    last.nextdata = node;
                    last = node;
                   
                }
                return node;
            }
            public void Deldata(string name, int year, bool del)
            {
                Deldata(this, name, year, del);
            }
            public int Deldata(Circularlist node,string name, int year, bool del)
            {
                if (last == null)
                {
                    return 0;
                }
                //Circularlist node = this;
                for (node = last; node.nextdata != last; node = node.nextdata)
                {
                    if ((node.nextdata.currentName == name) && (node.nextdata.currentYear == year) && (del==true))
                    {
                        node.nextdata = node.nextdata.nextdata;
                        break;
                    }
                    else if ((node.nextdata.currentName == name) && (node.nextdata.currentYear == year) && del == false)
                    {
                        node.currentNumber--;
                        break;
                    }
                }
                if ((node.nextdata.currentName == name) && (node.nextdata.currentYear == year) && (del == true))
                {
                    if(node.nextdata==node)
                    {
                        System.Console.WriteLine("last node");
                        node.nextdata = null;
                        last = null;
                        node = null;        

                    }
                    else
                    {
                        System.Console.WriteLine(node.nextdata.currentName);
                        node.nextdata = node.nextdata.nextdata;
                        last = node.nextdata;
                        System.Console.WriteLine(node.nextdata.currentName);
                    }
                    
                }
                else if ((node.nextdata.currentName == name) && (node.nextdata.currentYear == year) && del == false)
                {
                    node.nextdata.currentNumber--;
                }
                return 1;
            }
            public bool Traverse(string book_name, int published_year, int numbers)
            {
                return Traverse(this, book_name, published_year, numbers);
            }
            public bool Traverse(Circularlist node, string book_name, int published_year, int numbers)
            {

                if (last == null)
                {
                    return false;
                }
                Circularlist snode = node;
                for (node = last; node.nextdata != last; node = node.nextdata)
                {
                    if (node.currentName == book_name && node.currentYear == published_year)
                    {
                        node.currentNumber += numbers;
                        return true;
                    }
                }
                if (node.currentName == book_name && node.currentYear == published_year)//for last because it didn't count
                {
                    node.currentNumber += numbers;
                    return true;
                }
                return false;
            }
            public DataTable Gnodes(DataTable booksGridView, bool add, Label number_of_books)
            {
                return Gnodes(this, booksGridView, add, number_of_books);
            }
            public DataTable Gnodes(Circularlist node, DataTable booksGridView, bool add, Label number_of_books)
            {
                if (node == null)
                    node = this;
                int count = 0;
                Circularlist snode = node;

                for (node = last; node.nextdata != last; node = node.nextdata)
                {
                    count++;
                }
                count++;
                if (add == true)
                {
                    booksGridView.Rows.Add(node.nextdata.currentName, node.nextdata.currentAuthor, node.nextdata.currentYear, node.nextdata.currentPrice, node.nextdata.currentNumber);
                }
                number_of_books.Text = (count).ToString();

                return booksGridView;
            }

            public DataTable SortNumber(DataTable booksGridView)
            {
                return SortNumber(this, booksGridView);
            }
            public DataTable SortNumber(Circularlist node, DataTable booksGridView)
            {
                if (last == null)
                {
                    return null;
                }
                Circularlist temp;
                Circularlist snode = node;

                Circularlist tempData = new Circularlist();
                if(false)
                {

                }
                //if (last == null)
                //{
                //    node.nextdata = node;
                //}
                else
                {
                    for (node = last; node.nextdata != last; node = node.nextdata)
                    {
                        for (Circularlist selection = node.nextdata; selection != last; selection = selection.nextdata)
                        {

                            if (node.currentNumber > selection.currentNumber)
                            {

                                tempData.currentName = node.currentName;
                                tempData.currentAuthor = node.currentAuthor;
                                tempData.currentPrice = node.currentPrice;
                                tempData.currentYear = node.currentYear;
                                tempData.currentNumber = node.currentNumber;

                                node.currentName = selection.currentName;
                                node.currentAuthor = selection.currentAuthor;
                                node.currentPrice = selection.currentPrice;
                                node.currentYear = selection.currentYear;
                                node.currentNumber = selection.currentNumber;

                                selection.currentName = tempData.currentName;
                                selection.currentAuthor = tempData.currentAuthor;
                                selection.currentPrice = tempData.currentPrice;
                                selection.currentYear = tempData.currentYear;
                                selection.currentNumber = tempData.currentNumber;
                            }
                        }//End of outer loop
                    }//End of sorting
                }
                for (node = last; node.nextdata != last; node = node.nextdata)
                {
                    booksGridView.Rows.Add(node.currentName, node.currentAuthor, node.currentYear, node.currentPrice, node.currentNumber);
                }
                booksGridView.Rows.Add(node.currentName, node.currentAuthor, node.currentYear, node.currentPrice, node.currentNumber);
                return booksGridView;

            }

            public DataTable SortPublishedYear(DataTable booksGridView)
            {
                return SortPublishedYear(this, booksGridView);
            }
            public DataTable SortPublishedYear(Circularlist node, DataTable booksGridView)
            {
                if (last == null)
                {
                    return null;
                }
                Circularlist temp;
                Circularlist snode = node;

                Circularlist tempData = new Circularlist();
                if (false)
                {

                }
                //if (node == null)
                //{
                //    node.nextdata = node;
                //}
                else
                {
                    for (node = last; node.nextdata != last; node = node.nextdata)
                    {
                        // start the selection from the index->next
                        for (Circularlist selection = node.nextdata; selection != last; selection = selection.nextdata)
                        {
                            if (node.currentYear > selection.currentYear)
                            {
                                tempData.currentName = node.currentName;
                                tempData.currentAuthor = node.currentAuthor;
                                tempData.currentPrice = node.currentPrice;
                                tempData.currentYear = node.currentYear;
                                tempData.currentNumber = node.currentNumber;

                                node.currentName = selection.currentName;
                                node.currentAuthor = selection.currentAuthor;
                                node.currentPrice = selection.currentPrice;
                                node.currentYear = selection.currentYear;
                                node.currentNumber = selection.currentNumber;

                                selection.currentName = tempData.currentName;
                                selection.currentAuthor = tempData.currentAuthor;
                                selection.currentPrice = tempData.currentPrice;
                                selection.currentYear = tempData.currentYear;
                                selection.currentNumber = tempData.currentNumber;
                            }
                        }//End of outer loop
                    }//End of sorting
                }
                for (node = last; node.nextdata != last; node = node.nextdata)
                {
                    booksGridView.Rows.Add(node.currentName, node.currentAuthor, node.currentYear, node.currentPrice, node.currentNumber);
                }
                booksGridView.Rows.Add(node.currentName, node.currentAuthor, node.currentYear, node.currentPrice, node.currentNumber);
                return booksGridView;

            }


            public DataTable SortName(DataTable booksGridView)
            {
                return SortName(this, booksGridView);
            }
            public DataTable SortName(Circularlist node, DataTable booksGridView)
            {
                if (last == null)
                {
                    return null;
                }
                Circularlist temp;
                Circularlist snode = node;

                Circularlist tempData = new Circularlist();
                if (false)
                {

                }
                //if (node == null)
                //{
                //    node.nextdata = node;
                //}
                else
                {
                    for (node = last; node.nextdata != last; node = node.nextdata)
                    {
                        // start the selection from the index->next
                        for (Circularlist selection = node.nextdata; selection != last; selection = selection.nextdata)
                        {
                            if (string.Compare(node.currentName, selection.currentName, true) > 0)
                            {
                                tempData.currentName = node.currentName;
                                tempData.currentAuthor = node.currentAuthor;
                                tempData.currentPrice = node.currentPrice;
                                tempData.currentYear = node.currentYear;
                                tempData.currentNumber = node.currentNumber;

                                node.currentName = selection.currentName;
                                node.currentAuthor = selection.currentAuthor;
                                node.currentPrice = selection.currentPrice;
                                node.currentYear = selection.currentYear;
                                node.currentNumber = selection.currentNumber;

                                selection.currentName = tempData.currentName;
                                selection.currentAuthor = tempData.currentAuthor;
                                selection.currentPrice = tempData.currentPrice;
                                selection.currentYear = tempData.currentYear;
                                selection.currentNumber = tempData.currentNumber;
                            }
                        }//End of outer loop
                    }//End of sorting
                }

                for (node = last; node.nextdata != last; node = node.nextdata)
                {
                    booksGridView.Rows.Add(node.currentName, node.currentAuthor, node.currentYear, node.currentPrice, node.currentNumber);
                }
                booksGridView.Rows.Add(node.currentName, node.currentAuthor, node.currentYear, node.currentPrice, node.currentNumber);
                return booksGridView;

            }

        }
        public class Node
        {
            public Node next;
            public int index;
            public string bookName;
            public double bookCost;
        }
        public class Stack
        {
            private Node head;
            private int myindex = -1;


            public int getIndex()
            {
                return myindex;
            }

            public void printAllNodes()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.index);
                    current = current.next;
                }
            }
            public Node Pindex(int position)
            {
                if (position < 0) return null;
                Node current = head;

                for (int i = 1; i <= position; i++)
                {
                    if (current.next == null)
                    {
                        return null;
                    }
                    current = current.next;
                }
                return current;
            }
            public void AddLast(string book, double cost)
            {
                myindex++;
                if (head == null)
                {
                    head = new Node();

                    head.index = myindex;
                    head.bookName = book;
                    head.bookCost = cost;
                    head.next = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.index = myindex;
                    toAdd.bookName = book;
                    toAdd.bookCost = cost;
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    current.next = toAdd;
                }
            }
            public void DeleteLast()
            {

                if (head == null) return;
                myindex--;
                Node current = head;
                Node current2 = head;
                if (head.next == null)
                {
                    head = null;
                    return;
                }
                while (current.next != null)
                {
                    if (current2.next.next != null)
                        current2 = current2.next;
                    current = current.next;
                }
                if (current2.next == current)
                {
                    current = null;
                    current2.next = null;
                }
            }
        }

        public class stacks
        {
            public stacks next;
            public int index;
            public Stack sabadKharid;
        }

        public class PQueue
        {
            private stacks front = null;
            private stacks rear = null;
            private int Numbers = -1;
            private int myindex = -1;

            public int getNumbers()
            {
                return Numbers;
            }

            public void PAdd(Stack data)
            {
                myindex++;
                Numbers++;
                if (front == null)
                {
                    front = new stacks();
                    front.index = myindex;
                    front.sabadKharid = data;
                    front.next = null;
                }
                else
                {
                    stacks toAdd = new stacks();
                    toAdd.index = myindex;
                    toAdd.sabadKharid = data;
                    stacks current = front;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = toAdd;
                    rear = toAdd;
                }
            }
            public void PDelete()
            {
                if (front == null) return;
                Numbers--;
                stacks current = front.next;

                if (front.next == null)
                {
                    front = null;
                    return;
                }
                front = null;
                front = current;
            }

            public stacks Pindex(int position)
            {
                if (position < 0) return null;
                stacks current = front;
                for (int i = 1; i <= position; i++)
                {
                    if (current.next == null)
                    {
                        System.Console.WriteLine(current.sabadKharid.Pindex(0));
                        return null;
                    }
                    current = current.next;

                }
                return current;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Circularlist node = new Circularlist();
        DataTable dTable = new DataTable();
        PQueue men = new PQueue();
        PQueue female = new PQueue();
        bool if_get_facture_is_clicked = false;
        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;userid=root;database=library;password=password";
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }


          

            try
            {
                //Display query  
                string Query = "select * from library.books;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);

                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;




                MyAdapter.Fill(dTable);


                for (int i = 0; i < dTable.Rows.Count; i++)
                {

                   
                    node.Insdata(dTable.Rows[i].ItemArray[0].ToString(), dTable.Rows[i].ItemArray[1].ToString()
                        , Int32.Parse(dTable.Rows[i].ItemArray[2].ToString())
                        , Convert.ToDouble(dTable.Rows[i].ItemArray[3].ToString()), Int32.Parse(dTable.Rows[i].ItemArray[4].ToString()));

                }
                bool flag = false;
                booksGridView.DataSource = node.Gnodes(dTable, flag, TotalNumberLbl); // here i have assign dTable object to the dataGridView1 object to display data.               
                                                                                      // MyConn2.Close();  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();


            MenListView.View = View.Details;
            MenListView.GridLines = true;
            MenListView.FullRowSelect = true;

            FemaleListView.View = View.Details;
            FemaleListView.GridLines = true;
            FemaleListView.FullRowSelect = true;

            CartStackListView.View = View.Details;
            CartStackListView.GridLines = true;
            CartStackListView.FullRowSelect = true;

            MenListView.Columns.Add("Person", 161);
            MenListView.Columns.Add("number", 161);

            FemaleListView.Columns.Add("Person", 161);
            FemaleListView.Columns.Add("number", 161);

            CartStackListView.Columns.Add("Name", 72);
            CartStackListView.Columns.Add("Price", 72);


            booksGridView.ReadOnly = true;
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            if (booksGridView.CurrentCell.RowIndex > -1)
            {
                int RowIndex = booksGridView.CurrentCell.RowIndex;

                string name = booksGridView.Rows[RowIndex].Cells["Name"].FormattedValue.ToString();

                int year = Int32.Parse(booksGridView.Rows[RowIndex].Cells["PublishYear"].FormattedValue.ToString());
                node.Deldata(name, year, true);
              
                booksGridView.Rows.RemoveAt(RowIndex);
               
                TotalNumberLbl.Text = (Int32.Parse(TotalNumberLbl.Text) - 1).ToString();
                try
                {
                    string MyConnection2 = "server=localhost;userid=root;database=library;password=password";
                    string Query = "delete from library.books where Name='" + name + "' AND PublishYear='" + year + "' ;";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            if (node.Traverse(this.BookNameTextBox.Text, Int32.Parse(this.BookYearNumericUpdown.Text), Int32.Parse(this.NumberNumericUpDown.Text)))
            {
                foreach (DataGridViewRow row in booksGridView.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().Equals(this.BookNameTextBox.Text) && row.Cells["PublishYear"].Value.ToString().Equals(this.BookYearNumericUpdown.Text))
                    {
                        rowIndex = row.Index;
                        int value = (int)booksGridView.Rows[rowIndex].Cells["Number"].Value;
                        booksGridView.Rows[rowIndex].Cells["Number"].Value = value + Int32.Parse(this.NumberNumericUpDown.Text);
                        row.Selected = true;
                        break;
                    }
                }
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "server=localhost;userid=root;database=library;password=password";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "update library.books set Name='" + this.BookNameTextBox.Text + "' ,Author='" + this.BookAuthorTextBox.Text + "',PublishYear='" + Int32.Parse(this.BookYearNumericUpdown.Text) + "',Price='" + Convert.ToDouble(this.BookPriceTextBox.Text) + "',Number=Number+'" + Int32.Parse(this.NumberNumericUpDown.Text) + "' where Name='" + this.BookNameTextBox.Text + "' and PublishYear='" + Int32.Parse(this.BookYearNumericUpdown.Text) + "' ;";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                node.Insdata(this.BookNameTextBox.Text, this.BookAuthorTextBox.Text, Int32.Parse(this.BookYearNumericUpdown.Text), Convert.ToDouble(this.BookPriceTextBox.Text), Int32.Parse(this.NumberNumericUpDown.Text));
                bool flag = true;//this flag is for avoiding repition in showing data in dtable 
                //if we don't consider this we have duplicated items showin in booklistgridview
                booksGridView.DataSource = node.Gnodes(dTable, flag, TotalNumberLbl);

                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "server=localhost;userid=root;database=library;password=password";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into library.books(Name,Author,PublishYear,Price,Number) values('" + this.BookNameTextBox.Text + "','" + this.BookAuthorTextBox.Text + "','" + Int32.Parse(this.BookYearNumericUpdown.Text) + "','" + Convert.ToDouble(this.BookPriceTextBox.Text) + "','" + Int32.Parse(this.NumberNumericUpDown.Text) + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                  
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddBookToCartButton_Click(object sender, EventArgs e)
        {
            if (if_get_facture_is_clicked)
            {
                CartStackListView.Items.Clear();
                if_get_facture_is_clicked = false;
            }
            ListViewItem item;
            string[] ar = new string[2];
          
            if (booksGridView.CurrentCell.RowIndex > -1)
            {
                int RowIndex = booksGridView.CurrentCell.RowIndex;

                string name = booksGridView.Rows[RowIndex].Cells["Name"].FormattedValue.ToString();
                int publishedYear = Int32.Parse(booksGridView.Rows[RowIndex].Cells["PublishYear"].FormattedValue.ToString());
                int price = Int32.Parse(booksGridView.Rows[RowIndex].Cells["Price"].FormattedValue.ToString());
                ar[0] = name;
                ar[1] = price.ToString();
                item = new ListViewItem(ar);
                CartStackListView.Items.Add(item);

                node.Deldata(name, publishedYear, false);
                int value = (int)booksGridView.Rows[RowIndex].Cells["Number"].Value;
                if (value == 1)
                {
                    booksGridView.Rows.RemoveAt(RowIndex);
                }
                else
                    booksGridView.Rows[RowIndex].Cells["Number"].Value = value - 1;
                try
                {
                    string MyConnection2 = "server=localhost;userid=root;database=library;password=password";
                    string Query = "update library.books set Number=Number-1  where Name='" + name + "' and PublishYear='" + Int32.Parse(this.BookYearNumericUpdown.Text) + "' ;";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                   
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void AddToMenQueue_Click(object sender, EventArgs e)
        {
            if (CartStackListView.Items.Count > 0)
            {


                ListViewItem row;
                Stack p = new Stack();
                string[] name = new string[2];
                foreach (ListViewItem item in CartStackListView.Items)
                {
                    p.AddLast(item.SubItems[0].Text.ToString(), Convert.ToDouble(item.SubItems[1].Text));
                }


                men.PAdd(p);

                name[0] = "Person";

                name[1] = Convert.ToString(men.getNumbers());



                row = new ListViewItem(name);
                MenListView.Items.Add(row);

                CartStackListView.Items.Clear();
            }
        }

        private void AddToFemaleQueue_Click(object sender, EventArgs e)
        {
            if (CartStackListView.Items.Count > 0)
            {
                ListViewItem row;
                Stack p = new Stack();
                string[] name = new string[2];
                foreach (ListViewItem item in CartStackListView.Items)
                {
                    p.AddLast(item.SubItems[0].Text, Convert.ToDouble(item.SubItems[1].Text));
                }



                female.PAdd(p);
                name[0] = "Person";

                name[1] = Convert.ToString(female.getNumbers());

                row = new ListViewItem(name);
                FemaleListView.Items.Add(row);

                CartStackListView.Items.Clear();
            }
        }

            bool Flag_Female = true;
            bool Flag_Male = true;
        private void GetFactureButton_Click(object sender, EventArgs e)
        {
            if_get_facture_is_clicked = true;
            CartStackListView.Items.Clear();
            string Male = "";
            string fem = "";
            double sum = 0.0;
            Stack p = new Stack();
            ListViewItem item;
            string[] list = new string[2];

            if ((MenListView.SelectedItems.Count > 0) && (Flag_Female==true))
            {
                
                
                Male = MenListView.SelectedItems[0].SubItems[1].Text;
               
                for (int i = 0; i <= men.Pindex(0).sabadKharid.getIndex(); i++)
                {
                    list[0] = men.Pindex(0).sabadKharid.Pindex(i).bookName;
                    list[1] = men.Pindex(0).sabadKharid.Pindex(i).bookCost.ToString();
                    sum += men.Pindex(0).sabadKharid.Pindex(i).bookCost;
                    item = new ListViewItem(list);
                    CartStackListView.Items.Add(item);
                }

            }
            else if (FemaleListView.SelectedItems.Count > 0 && Flag_Male==true)
            {
                
                fem = FemaleListView.SelectedItems[0].SubItems[1].Text;

                for (int i = 0; i <= female.Pindex(0).sabadKharid.getIndex(); i++)
                {
                    list[0] = female.Pindex(0).sabadKharid.Pindex(i).bookName;
                    list[1] = female.Pindex(0).sabadKharid.Pindex(i).bookCost.ToString();
                    sum += female.Pindex(0).sabadKharid.Pindex(i).bookCost;
                    item = new ListViewItem(list);
                    CartStackListView.Items.Add(item);

                }


            }

            TotalAmountLabel.Text = sum.ToString() + "$";
            sum = 0.0;


        }

        private void PopfromStackButton_Click(object sender, EventArgs e)
        {
            //pop from stack wich is our cart
            string Male = "";
            string fem = "";
            double sum = 0.0;
            Stack p = new Stack();
            ListViewItem item;
            string[] list = new string[2];
            int counter = 0;
            if (MenListView.SelectedItems.Count > 0 && Flag_Female==true)
            {
                Flag_Male = true;
                if (FemaleListView.Items.Count > 0)
                    Flag_Female = false;
                Male = MenListView.SelectedItems[0].SubItems[1].Text;

                while (CartStackListView.Items.Count != 0)
                {
                    CartStackListView.Items.RemoveAt(CartStackListView.Items.Count - 1);
                    men.Pindex(0).sabadKharid.DeleteLast();

                }
                men.PDelete();
                MenListView.Items.RemoveAt(0);

            }
            else if (FemaleListView.SelectedItems.Count > 0 && Flag_Male==true)
            {
                Flag_Female = true;
                if (MenListView.Items.Count > 0) 
                    Flag_Male = false;
                fem = FemaleListView.SelectedItems[0].SubItems[1].Text;

                while (CartStackListView.Items.Count != 0)
                {
                    CartStackListView.Items.RemoveAt(CartStackListView.Items.Count - 1);
                    female.Pindex(0).sabadKharid.DeleteLast();

                }
                female.PDelete();
                FemaleListView.Items.RemoveAt(0);

            }
            TotalAmountLabel.Text = "Total Cost";

        }

        private void SortaccordingtoNumbersButton_Click(object sender, EventArgs e)
        {
            booksGridView.DataSource = null;
            dTable.Clear();
            booksGridView.DataSource = node.SortNumber(dTable);
        }

        private void SortPbBtn_Click(object sender, EventArgs e)
        {
            booksGridView.DataSource = null;
            dTable.Clear();
            booksGridView.DataSource = node.SortPublishedYear(dTable);
        }

        private void SortNameBtn_Click(object sender, EventArgs e)
        {
            booksGridView.DataSource = null;
            dTable.Clear();
            booksGridView.DataSource = node.SortName(dTable);
        }


    }
}