using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace Capstone_Book_Main
{
    public partial class BookManager : UserControl
    {
        string dbroute = "MyDB.sqlite";
        string file_path = "";
        Config configDialog = new Config();
        DataSet data = new DataSet();

        public class StringMeta
        {
            public string title;
            public string series;
            public string alternate_series;
            public string storyarc;
            public string seriesgroup;
            public List<string> genre;
            public string language;
            public string format;
            public string age_rating;
            public string blackandwhite;
            public string manga;
        }
        public class IntMeta
        {
            public int number;
            public int count;
            public int volume;
            public int alternate_number;
            public int alternate_count;
            public int year;
            public int month;
            public int day;
            public int page_count;
        }
        public class MakerMeta
        {
            public string writer;
            public string penciller;
            public string inker;
            public string colorist;
            public string letterer;
            public string cover_artist;
            public string editor;
            public string publisher;
            public string imprint;

        }

        public BookManager()
        {
            InitializeComponent();

            //이부분부터 지울것
            FileInfo fileInfo = new FileInfo(dbroute);

            if (fileInfo.Exists)
            {
                MessageBox.Show("DB 파일이 있습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Db_view();
            }
            else
            {
                MessageBox.Show("DB 파일이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //이부분까지 지울것

                Db_init(); // DB 생성/초기화

                FolderBrowserDialog dialog = new FolderBrowserDialog(); // 폴더 선택
                dialog.ShowDialog();
                file_path = dialog.SelectedPath;
                Properties.UserConfig.Default.Filepath = file_path;
                Properties.UserConfig.Default.Save();

                Db_regist(file_path); // DB에 파일 등록
                Db_view();
            }
        }

        bool canmodi = false;

        private void Db_init()
        {
            try
            {
                if (!System.IO.File.Exists(dbroute))
                {
                    SQLiteConnection.CreateFile(dbroute);
                }
                // 테이블 생성

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDB.sqlite;Version=3;");
                m_dbConnection.Open();


                string sql = "CREATE TABLE IF NOT EXISTS R_BOOK (id INTEGER PRIMARY KEY AUTOINCREMENT, file_name TEXT unique," +
                    "title TEXT, series TEXT, number INT, " +
                    "count INT, volume INT, alternate_series TEXT, " +
                    "alternate_number INT, storyarc TEXT, seriesgroup TEXT, " +
                    "alternate_count INT, year INT, month INT, DAY INT, " +
                    "writer TEXT, penciller TEXT, inker TEXT, colorist TEXT, " +
                    "Letterer TEXT, cover_artist TEXT, editor TEXT, publisher TEXT, " +
                    "imprint TEXT, genre TEXT, page_count INT, language TEXT, format TEXT, " +
                    "age_rating TEXT, blackandwhite BOOL, manga TEXT, booknumber INT);";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                m_dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Db_regist(string file_path) // 파일을 DB에 등록
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=MyDB.sqlite;Version=3;");

            string[] dirs = Directory.GetDirectories(file_path);
            string[] files = Directory.GetFiles(file_path);

            conn.Open();

            foreach (String file in files)
            {
                switch (Path.GetExtension(file))
                {
                    case ".cbz":
                    case ".cbr":
                    case ".zip":
                        string sql = "insert or ignore into R_BOOK (file_name) values ('" + Path.GetFileName(file) + "');";
                        SQLiteCommand command = new SQLiteCommand(sql, conn);
                        command.ExecuteNonQuery();
                        break;
                    default:
                        break;
                }

            }
            if (dirs.Length > 0)
            {
                foreach (string dir in dirs)
                {
                    Db_regist(dir);
                }
            }
            conn.Close();

            using (StreamWriter ConfigOut = new StreamWriter(@"Config.dat"))
            {
                ConfigOut.WriteLine("dbrout = " + dbroute);
            }
        }

        private void Db_view()
        {
            SQLiteConnection connStr = new SQLiteConnection("Data Source=MyDB.sqlite;Version=3;");

            using (var conn = new SQLiteConnection(connStr))
            {
                string query = "SELECT * FROM R_BOOK";

                var adpt = new SQLiteDataAdapter(query, connStr);
                adpt.Fill(data);
            }

            connStr.Open();
            string sql = "SELECT * FROM R_BOOK;";

            SQLiteCommand cmd = new SQLiteCommand(sql, connStr);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while ( rdr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = rdr["number"].ToString();
                item.SubItems.Add(rdr["title"].ToString());
                item.SubItems.Add(rdr["series"].ToString());
                item.SubItems.Add(rdr["writer"].ToString());
                item.SubItems.Add(rdr["penciller"].ToString());
                item.SubItems.Add(rdr["genre"].ToString());
                item.SubItems.Add(rdr["age_rating"].ToString());
                item.SubItems.Add(rdr["file_name"].ToString());
                listView1.Items.Add(item);
            }
            rdr.Close();
            connStr.Close();
       
        }
        private void CanmodiButton_Click(object sender, EventArgs e)
        {
            if (!canmodi)
            {
                CanmodiButton.Text = "저장";
                this.toolTip1.SetToolTip(this.CanmodiButton, "수정한 메타데이터를 저장합니다.");
                TitleBox.ReadOnly = false;
                SeriesBox.ReadOnly = false;
                NumberBox.ReadOnly = false;
                BookNumberBox.ReadOnly = false;
                CountBox.ReadOnly = false;
                VolumeBox.ReadOnly = false;
                AlternateSeriesBox.ReadOnly = false;
                StoryArcBox.ReadOnly = false;
                SeriesGroupBox.ReadOnly = false;
                YearBox.ReadOnly = false;
                MonthBox.ReadOnly = false;
                DayBox.ReadOnly = false;
                WriterBox.ReadOnly = false;
                PencillerBox.ReadOnly = false;
                InkerBox.ReadOnly = false;
                ColoristBox.ReadOnly = false;
                LettererBox.ReadOnly = false;
                CoverArtistBox.ReadOnly = false;
                EditorBox.ReadOnly = false;
                PublisherBox.ReadOnly = false;
                ImprintBox.ReadOnly = false;
                GenreBox.ReadOnly = false;
                PageCountBox.ReadOnly = false;
                LanguageBox.ReadOnly = false;
                AgeRatingBox.ReadOnly = false;
                IsBlackButton.Enabled = true;
                IsColorButton.Enabled = true;
            }
            else
            {
                CanmodiButton.Text = "수정";
                this.toolTip1.SetToolTip(this.CanmodiButton, "메타데이터를 수정 가능한 상태로 전환합니다.");
                TitleBox.ReadOnly = true;
                SeriesBox.ReadOnly = true;
                NumberBox.ReadOnly = true;
                BookNumberBox.ReadOnly = true;
                CountBox.ReadOnly = true;
                VolumeBox.ReadOnly = true;
                AlternateSeriesBox.ReadOnly = true;
                StoryArcBox.ReadOnly = true;
                SeriesGroupBox.ReadOnly = true;
                YearBox.ReadOnly = true;
                MonthBox.ReadOnly = true;
                DayBox.ReadOnly = true;
                WriterBox.ReadOnly = true;
                PencillerBox.ReadOnly = true;
                InkerBox.ReadOnly = true;
                ColoristBox.ReadOnly = true;
                LettererBox.ReadOnly = true;
                CoverArtistBox.ReadOnly = true;
                EditorBox.ReadOnly = true;
                PublisherBox.ReadOnly = true;
                ImprintBox.ReadOnly = true;
                GenreBox.ReadOnly = true;
                PageCountBox.ReadOnly = true;
                LanguageBox.ReadOnly = true;
                AgeRatingBox.ReadOnly = true;
                IsBlackButton.Enabled = false;
                IsColorButton.Enabled = false;
            }

            canmodi = !canmodi;
        }

        

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            ExtractAllButton.Visible = !ExtractAllButton.Visible;
            ExtractOneButton.Visible = !ExtractOneButton.Visible;
        }

        private void 옵션ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configDialog.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = data.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                TitleBox.Text = row["title"].ToString();
                SeriesBox.Text = row["series"].ToString();
                NumberBox.Text = row["number"].ToString();
                BookNumberBox.Text = row["booknumber"].ToString();
                CountBox.Text = row["count"].ToString();
                VolumeBox.Text = row["volume"].ToString();
                AlternateSeriesBox.Text = row["alternate_series"].ToString();
                StoryArcBox.Text = row["storyarc"].ToString();
                SeriesGroupBox.Text = row["seriesgroup"].ToString();
                YearBox.Text = row["year"].ToString();
                MonthBox.Text = row["month"].ToString();
                DayBox.Text = row["DAY"].ToString();
                WriterBox.Text = row["writer"].ToString();
                PencillerBox.Text = row["penciller"].ToString();
                InkerBox.Text = row["inker"].ToString();
                ColoristBox.Text = row["colorist"].ToString();
                LettererBox.Text = row["Letterer"].ToString();
                CoverArtistBox.Text = row["cover_artist"].ToString();
                EditorBox.Text = row["editor"].ToString();
                PublisherBox.Text = row["publisher"].ToString();
                ImprintBox.Text = row["imprint"].ToString();
                GenreBox.Text = row["genre"].ToString();
                PageCountBox.Text = row["page_count"].ToString();
                LanguageBox.Text = row["language"].ToString();
                AgeRatingBox.Text = row["age_rating"].ToString();
                if(row["blackandwhite"])
                    IsBlackButton.Checked = true;
                else
                    IsColorButton.Checked = true;
            }
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string path = Properties.UserConfig.Default.Filepath + @"\" + listView1.SelectedItems[0].SubItems[7].Text;
            System.Diagnostics.Process.Start(@"C:\Program Files\Honeyview\Honeyview.exe", path);
        }
    }

}
