namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";

            }
        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Teck Weekly",
                Author = " John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }
        
        public class Ebook : Book
        {
            public string Format { get; set; }
            public int FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - {Format} ({FileSizeMB} MB)";
            }
        }

        
        public void ProcessBooks(Book[] books)
        {
            listBox1.Items.Clear();

            foreach (Book book in books)
            {
                
                string info = book.GetInfo();

                
                if (book is Magazine)
                    listBox1.Items.Add($"MAGAZINE: {info}");
                else if (book is Ebook)
                    listBox1.Items.Add($"E-BOOK: {info}");
                else if (book is AudioBook)
                    listBox1.Items.Add($"AUDIO BOOK: {info}");
                else
                    listBox1.Items.Add($"BOOK: {info}");
            }
        }

        
        private void btnProcessBooks_Click(object sender, EventArgs e)
        {
            Book[] bookCollection = new Book[]
    {
        new Book { Title = "The Great Novel", Author = "Jane Smith" },
        new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
        new Ebook { Title = "Digital Design", Author = "Alan Johnson", Format = "PDF", FileSizeMB = 12 },
        new AudioBook { Title = "Learning C#", Author = "Mark Wilson", Narrator = "Sarah Johnson", DurationHours = 8.5 },
        new AudioBook { Title = "Adventure Stories", Author = "Emily Brown", Narrator = "Michael Davis", DurationHours = 12.3 }
    };

            ProcessBooks(bookCollection);
        }
        public class AudioBook : Book
        {
            public double DurationHours { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Narrated by {Narrator} ({DurationHours:F1} hours)";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
