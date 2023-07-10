using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using PRNProject.Models;
using PRNProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRNProject
{
    public partial class Form1 : Form
    {
        DataTable table;
        NoteRepository notesRepository;
        PRNProjectContext db = new PRNProjectContext();
        List<Note> notes = new List<Note>();
        UsersReposistory UsersReposistory;
        Note Note = new Note();
        int EmpId = 0;
        String usernames = Login.UserSession.Username;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            SetDataInGridView(Login.UserSession.UserID);

            ClearData();


        }
        public void SetDataInGridView(int UserId)
        {
            dataGridView1.AutoGenerateColumns = false;
            var userNotes = db.Notes.Where(n => n.UserId == Login.UserSession.UserID).ToList();
            dataGridView1.DataSource = userNotes;
            
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        public void ClearData()
        {
            txtTitle.Text = txtMessage.Text = string.Empty;
            bttDelete.Enabled = false;
            EmpId = 0;
        }
        private void bttSave_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();

            newNote.Title = txtTitle.Text.Trim();
            newNote.Message = txtMessage.Text.Trim();
            newNote.UserId = Login.UserSession.UserID;

            if (EmpId > 0)
            {
                newNote.NoteId = EmpId;
                var existingNote = db.Notes.Local.FirstOrDefault(n => n.NoteId == EmpId);
                if (existingNote != null)
                {
                    db.Entry(existingNote).State = EntityState.Detached;
                }

                db.Notes.Attach(newNote); // Attach the newNote entity to the context
                db.Entry(newNote).State = EntityState.Modified;
            }
            else
            {
                notesRepository = new NoteRepository();
                notesRepository.Add(newNote);
                //db.Notes.Add(newNote);
            }
            db.SaveChanges();

            SetDataInGridView(Login.UserSession.UserID);
            MessageBox.Show("Record Save Successfully");
            ClearData();
        }


        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Notes.Remove(Note);
                db.SaveChanges();
                SetDataInGridView(Login.UserSession.UserID);
                MessageBox.Show("Record Deleted Successfully");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                EmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["NoteId"].Value);
                Note = db.Notes.Where(x => x.NoteId == EmpId).FirstOrDefault();
                txtMessage.Text = Note.Message;
                txtTitle.Text = Note.Title;

            }
            bttDelete.Enabled = true;
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            lbUsername.Text = usernames;
        }

        private void lbMarkDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frmHome = new Form3();
            frmHome.ShowDialog();
        }

        private void lbPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frmHome = new Form2();
            frmHome.ShowDialog();
        }

        private void lbMusic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frmHome = new Music_Player();
            frmHome.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frmHome = new Pomodoro();
            frmHome.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Profile();
            frmHome.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Login();
            frmHome.ShowDialog();
        }
    }
}