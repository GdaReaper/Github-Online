using System.Data;

namespace NoteTaking_App
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            PreviousNotes.DataSource = notes;
        }

        private void title__Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Notebox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not A Valid Note"); }
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            Notebox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Note"] = Notebox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, Notebox.Text);
            }
            TitleBox.Text = "";
            Notebox.Text = "";
            editing = false;
        }

        private void PreviousNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Notebox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}