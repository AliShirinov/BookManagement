using BookManagementSystem.Data;
using BookManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class MainForm : Form
    {
        public ArrayList genres;
        public MainForm()
        {

           genres = new ArrayList()
            {
                new Genre(){
                    Id = 1,
                    Name = "Detective"
                },
                 new Genre(){
                    Id = 2,
                    Name = "Romantic"
                },
                 new Genre()
                 {
                     Id = 3,
                     Name = "Tragedy"
                 }

            };

            Book book = new Book()
            { 
                Id = 1,
                Name = "Tehlike Oyunlar",
                Author = "Oguz Atay",
                Price = 35,
                PageCount = 724,
                PublishDate = DateTime.Now,
                Genre = (Genre)genres[0]

            };
            BookDb.Add(book);
            InitializeComponent();
            FillSelect();
            FillDataGridView();
        }

        public void FillSelect()
        {
            cmbx_genre.DataSource = genres;
            cmbx_genre.DisplayMember = "Name";
        }


        public void FillDataGridView()
        {
          ArrayList books =  BookDb.GetAllBooks();

            foreach (Book book in books)
            {
                dataGridView1.Rows.Add(book.Name, book.Author, book.Genre.Name, book.Price+ " " + "AZN" , book.PublishDate, book.PageCount);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(this);
            Session.form = this;
            this.Hide();
            testForm.ShowDialog();
            
        }
    }
}
