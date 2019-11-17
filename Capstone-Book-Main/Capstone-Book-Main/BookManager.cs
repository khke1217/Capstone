using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.IO.Compression;

namespace Capstone_Book_Main
{
    public partial class BookManager : UserControl
    {
        string dbroute = "MyDB.sqlite";
        string file_path = "";
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
                    "title TEXT, series TEXT, number INT, book_number INT, " +
                    "count INT, volume INT, alternate_series TEXT, " +
                    "alternate_number INT, storyarc TEXT, series_group TEXT, " +
                    "alternate_count INT, year INT, month INT, day INT, " +
                    "writer TEXT, penciller TEXT, inker TEXT, colorist TEXT, " +
                    "Letterer TEXT, cover_artist TEXT, editor TEXT, publisher TEXT, " +
                    "imprint TEXT, genre TEXT, page_count INT, language TEXT, format TEXT, " +
                    "age_rating TEXT, black_and_white BOOL, manga TEXT, library TEXT);";

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

                item.Text = rdr["id"].ToString();
                item.SubItems.Add(rdr["file_name"].ToString());
                item.SubItems.Add(rdr["title"].ToString());
                item.SubItems.Add(rdr["series"].ToString());
                item.SubItems.Add(rdr["number"].ToString());
                item.SubItems.Add(rdr["book_number"].ToString());
                item.SubItems.Add(rdr["count"].ToString());
                item.SubItems.Add(rdr["volume"].ToString());
                item.SubItems.Add(rdr["alternate_series"].ToString());
                item.SubItems.Add(rdr["alternate_number"].ToString());
                item.SubItems.Add(rdr["storyarc"].ToString());
                item.SubItems.Add(rdr["series_group"].ToString());
                item.SubItems.Add(rdr["alternate_count"].ToString());
                item.SubItems.Add(rdr["year"].ToString());
                item.SubItems.Add(rdr["month"].ToString());
                item.SubItems.Add(rdr["day"].ToString());
                item.SubItems.Add(rdr["writer"].ToString());
                item.SubItems.Add(rdr["penciller"].ToString());
                item.SubItems.Add(rdr["inker"].ToString());
                item.SubItems.Add(rdr["colorist"].ToString());
                item.SubItems.Add(rdr["letterer"].ToString());
                item.SubItems.Add(rdr["cover_artist"].ToString());
                item.SubItems.Add(rdr["editor"].ToString());
                item.SubItems.Add(rdr["publisher"].ToString());
                item.SubItems.Add(rdr["imprint"].ToString());
                item.SubItems.Add(rdr["genre"].ToString());
                item.SubItems.Add(rdr["page_count"].ToString());
                item.SubItems.Add(rdr["language"].ToString());
                item.SubItems.Add(rdr["format"].ToString());
                item.SubItems.Add(rdr["age_rating"].ToString());
                item.SubItems.Add(rdr["black_and_white"].ToString());
                item.SubItems.Add(rdr["manga"].ToString());
                item.SubItems.Add(rdr["library"].ToString());

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
            OriginDelBox.Visible = !OriginDelBox.Visible;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            SeriesBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            NumberBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            BookNumberBox.Text = listView1.SelectedItems[0].SubItems[5].Text;
            CountBox.Text = listView1.SelectedItems[0].SubItems[6].Text;
            VolumeBox.Text = listView1.SelectedItems[0].SubItems[7].Text;
            AlternateSeriesBox.Text = listView1.SelectedItems[0].SubItems[8].Text;
            StoryArcBox.Text = listView1.SelectedItems[0].SubItems[10].Text;
            SeriesGroupBox.Text = listView1.SelectedItems[0].SubItems[11].Text;
            YearBox.Text = listView1.SelectedItems[0].SubItems[13].Text;
            MonthBox.Text = listView1.SelectedItems[0].SubItems[14].Text;
            DayBox.Text = listView1.SelectedItems[0].SubItems[15].Text;
            WriterBox.Text = listView1.SelectedItems[0].SubItems[16].Text;
            PencillerBox.Text = listView1.SelectedItems[0].SubItems[17].Text;
            InkerBox.Text = listView1.SelectedItems[0].SubItems[18].Text;
            ColoristBox.Text = listView1.SelectedItems[0].SubItems[19].Text;
            LettererBox.Text = listView1.SelectedItems[0].SubItems[20].Text;
            CoverArtistBox.Text = listView1.SelectedItems[0].SubItems[21].Text;
            EditorBox.Text = listView1.SelectedItems[0].SubItems[22].Text;
            PublisherBox.Text = listView1.SelectedItems[0].SubItems[23].Text;
            ImprintBox.Text = listView1.SelectedItems[0].SubItems[24].Text;
            GenreBox.Text = listView1.SelectedItems[0].SubItems[25].Text;
            PageCountBox.Text = listView1.SelectedItems[0].SubItems[26].Text;
            LanguageBox.Text = listView1.SelectedItems[0].SubItems[27].Text;
            AgeRatingBox.Text = listView1.SelectedItems[0].SubItems[29].Text;

            if (listView1.SelectedItems[0].SubItems[30].Text == "B")
            {
                IsBlackButton.Checked = true;
                IsColorButton.Checked = false;
            }

            else
            {
                IsBlackButton.Checked = false;
                IsColorButton.Checked = true;
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            string path = Properties.UserConfig.Default.Filepath + @"\" + listView1.SelectedItems[0].SubItems[7].Text;
            System.Diagnostics.Process.Start(@"C:\Program Files\Honeyview\Honeyview.exe", path);
        }

        private void ExtractAllButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ExtractOneButton_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();
            //string startPath = dialog.SelectedPath;
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = "zip";
            fd.Filter = "압축파일 (*.zip; *.cbz)| *.zip; *.cbz";
            fd.ShowDialog();
            string zipPath = fd.FileName;
            ZipFile.ExtractToDirectory(zipPath, Directory.GetParent(zipPath) + "\\temp");
            string startPath = Directory.GetParent(zipPath) + "\\temp";
            CreateCBZ(startPath);
        }

        private void CreateCBZ(string startPath)
        {
            ZipFile.CreateFromDirectory(startPath, startPath + ".cbz");
        }
    }

}
