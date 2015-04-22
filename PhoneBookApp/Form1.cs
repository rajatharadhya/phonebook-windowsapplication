using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PhoneBookApp
{
    public partial class MainFrm : Form
    {
        BindingList<Person> myList = new BindingList<Person>();
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            if (txtbxFName.Text == "" || txtbxSName.Text == "" || txtbxMPhNo.Text == "" || txtbxHPhNo.Text == "")
                lblErrorMsg.Text = " Incomplete data to add new user.Please check data and try again";
            else
            {
                myList.Add(new Person(txtbxFName.Text, txtbxSName.Text, txtbxMPhNo.Text, txtbxHPhNo.Text, txtbxlEMail.Text));
                lblErrorMsg.Text = "";
            }
           
            dataGridView1.DataSource = myList;
            listBox1.DataSource = myList;
            listBox1.DisplayMember = "FName";
            listBox2.DataSource = myList;
            listBox2.DisplayMember = "LName";
            txtbxFName.Clear();
            txtbxSName.Clear();
            txtbxMPhNo.Clear();
            txtbxHPhNo.Clear();
            txtbxlEMail.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbxFName.Text = txtbxHPhNo.Text = txtbxlEMail.Text = txtbxMPhNo.Text = txtbxSName.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0)
              myList.RemoveAt(dataGridView1.Rows.IndexOf(dataGridView1.SelectedRows[0]));
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
           DialogResult WarningMsg =  MessageBox.Show("All Friends will be deleted... Are you Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           if (WarningMsg == System.Windows.Forms.DialogResult.Yes)
           {
               while (myList.Count > 0)
                   myList.RemoveAt(0);
           }
        }

        private void Serialize()
        {
            try
            {
                XmlSerializer SerialKiller = new XmlSerializer(myList.GetType());
                string CurrentPath=Directory.GetCurrentDirectory();
                Stream Cauvery = new FileStream(CurrentPath+"\\DataStore.XML", FileMode.Create);
               // for (int i = 0; i < myList.Count; i++)
                    SerialKiller.Serialize(Cauvery, myList);

                Cauvery.Close();
            }
            catch (Exception)
            { }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

            try
            {
                string CurrentPath = Directory.GetCurrentDirectory();

                if (File.Exists(CurrentPath + "\\DataStore.XML"))
                {
                    using (TextReader reader = new StreamReader(CurrentPath + "\\DataStore.XML"))
                    {
                        myList = (BindingList<Person>)(new XmlSerializer(myList.GetType())).Deserialize(reader);
                     
                        if (myList.Count >0)
                            dataGridView1.DataSource = myList;
                    }
                }
            }
            catch (Exception)
            {}
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingList<Person> SearchList = new BindingList<Person>();

            foreach (Person Curr in myList)
            {
                if (Curr.FName == txtbxSearchFName.Text && Curr.LName == txtbxSearchSName.Text)
                    SearchList.Add(Curr);
            }
            if (SearchList.Count > 0)
                dataGridView1.DataSource = SearchList;
        }

        private void txtbxMPhNo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtbxMPhNo_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtbxMPhNo_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidatePhone(e.KeyChar))
                e.Handled = e.KeyChar != (char) Keys.Back;
        }

        private bool ValidatePhone(char inp)
        {
            if (char.IsNumber(inp) || inp == '-' || inp == '(' || inp == ')')
                return true;
            else 
                return false;
        }

        private void txtbxHPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidatePhone(e.KeyChar))
                e.Handled = e.KeyChar != (char)Keys.Back;
        }
        
        private void button1_Click(object sender, EventArgs e)
                   
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"D:\Test.pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));

            }
            table.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                    }
                }
            }
            
            doc.Add(table);
            doc.Close();
        }
    
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        
        
    }
}

