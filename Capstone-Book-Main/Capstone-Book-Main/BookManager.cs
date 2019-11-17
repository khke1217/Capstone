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
using System.Xml;
using System.Xml.Linq;

namespace Capstone_Book_Main
{
    public partial class BookManager : UserControl
    {
        string dbroute;
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
            dbroute = Properties.UserConfig.Default.path + "\\db.sqlite";
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
                Properties.UserConfig.Default.path = file_path;
                Properties.UserConfig.Default.Save();
                dbroute = file_path + "\\db.sqlite";

                Db_regist(file_path); // DB에 파일 등록
                Db_view();
            }
        }

        bool canmodi = false;

        private void Db_init()
        {
            try
            {
                if (!File.Exists(dbroute))
                {
                    SQLiteConnection.CreateFile(dbroute);
                }
                // 테이블 생성

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + dbroute + ";Version=3;");
                m_dbConnection.Open();


                string sql = "CREATE TABLE IF NOT EXISTS R_BOOK (id INTEGER PRIMARY KEY AUTOINCREMENT, file_name TEXT unique," +
                    "title TEXT, series TEXT, number INT, book_number INT, " +
                    "count INT, volume INT, alternate_series TEXT, " +
                    "alternate_number INT, storyarc TEXT, series_group TEXT, " +
                    "alternate_count INT, year INT, month INT, day INT, " +
                    "writer TEXT, penciller TEXT, inker TEXT, colorist TEXT, " +
                    "Letterer TEXT, cover_artist TEXT, editor TEXT, publisher TEXT, " +
                    "imprint TEXT, genre TEXT, page_count INT, language TEXT, format TEXT, " +
                    "age_rating TEXT, black_and_white TEXT, manga TEXT, library TEXT, file_path TEXT);";

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

            SQLiteConnection conn = new SQLiteConnection("Data Source="+dbroute+";Version=3;");

            string[] dirs = Directory.GetDirectories(file_path);
            string[] files = Directory.GetFiles(file_path);

            conn.Open();

            foreach (String file in files)
            {
                string f_path = Path.GetFullPath(file);
                string sql = null;
                SQLiteCommand command;
                switch (Path.GetExtension(file))
                {
                    case ".cbz":
                        XDocument xdoc = readZipFile(file);
                        IEnumerable<XElement> metas = xdoc.Elements();
                        foreach (var meta in metas)
                        {
                            sql = "insert or ignore into R_BOOK " +
                                            "(file_name, file_path, title, series, number, book_number, count, volume, alternate_series, alternate_number, storyarc, " +
                                            "series_group, alternate_count, year, month, day, writer, penciller, inker, colorist, Letterer, cover_artist, editor, " +
                                            "publisher , imprint, genre, page_count, language, format, age_rating, black_and_white, manga) values ('" +
                                            Path.GetFileName(file) + "', '" + f_path + "', '" + meta.Element("Title").Value + "', '" + meta.Element("Series").Value +
                                            "', '" + meta.Element("Number").Value + "', '" + meta.Element("BookNumber").Value + "', '" + meta.Element("Count").Value +
                                            "', '" + meta.Element("Volume").Value + "', '" + meta.Element("AlternateSeries").Value + "', '" + meta.Element("AlternateNumber").Value +
                                            "', '" + meta.Element("StoryArc").Value + "', '" + meta.Element("SeriesGroup").Value + "', '" + meta.Element("AlternateCount").Value +
                                            "', '" + meta.Element("Year").Value + "', '" + meta.Element("Month").Value + "', '" + meta.Element("Day").Value +
                                            "', '" + meta.Element("Writer").Value + "', '" + meta.Element("Penciller").Value + "', '" + meta.Element("Inker").Value +
                                            "', '" + meta.Element("Colorist").Value + "', '" + meta.Element("Letterer").Value + "', '" + meta.Element("CoverArtist").Value +
                                            "', '" + meta.Element("Editor").Value + "', '" + meta.Element("Publisher").Value + "', '" + meta.Element("Imprint").Value +
                                            "', '" + meta.Element("Genre").Value + "', '" + meta.Element("PageCount").Value + "', '" + meta.Element("LanguageISO").Value +
                                            "', '" + meta.Element("Format").Value + "', '" + meta.Element("AgeRating").Value + "', '" + meta.Element("BlackAndWhite").Value + 
                                            "', '" + meta.Element("Manga").Value + "')";
                            command = new SQLiteCommand(sql, conn);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case ".zip":
                        sql = "insert or ignore into R_BOOK (title, file_name, file_path) values ('" + Path.GetFileNameWithoutExtension(file)+ "', '" + Path.GetFileName(file) + "', '" + f_path + "');";
                        command = new SQLiteCommand(sql, conn);
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

            SQLiteConnection connStr = new SQLiteConnection("Data Source="+dbroute+";Version=3;");

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
                item.SubItems.Add(rdr["file_path"].ToString());

                listView1.Items.Add(item);
            }
            rdr.Close();
            connStr.Close();
       
        }

        private void Db_update()
        {
            string isblack;
            if (IsBlackButton.Checked)
                isblack = "Yes";
            else
                isblack = "No";

            SQLiteConnection conn = new SQLiteConnection("Data Source="+dbroute+";Version=3;");

            conn.Open();

            string sql = "update R_BOOK set title = '" + TitleBox.Text + "'," +
                "series = '" + SeriesBox.Text + "'," +
                "number = '" + NumberBox.Text + "'," +
                "book_number = '" + BookNumberBox.Text + "'," +
                "count = '" + CountBox.Text + "'," +
                "volume = '" + VolumeBox.Text + "'," +
                "alternate_series = '" + AlternateSeriesBox.Text + "'," +
                "storyarc = '" + StoryArcBox.Text + "'," +
                "series_group = '" + SeriesGroupBox.Text + "'," +
                "year = '" + YearBox.Text + "'," +
                "month = '" + MonthBox.Text + "'," +
                "day = '" + DayBox.Text + "'," +
                "writer = '" + WriterBox.Text + "'," +
                "penciller = '" + PencillerBox.Text + "'," +
                "inker = '" + InkerBox.Text + "'," +
                "colorist = '" + ColoristBox.Text + "'," +
                "letterer = '" + LettererBox.Text + "'," +
                "cover_artist = '" + CoverArtistBox.Text + "'," +
                "editor = '" + EditorBox.Text + "'," +
                "publisher = '" + PublisherBox.Text + "'," +
                "imprint = '" + ImprintBox.Text + "'," +
                "genre = '" + GenreBox.Text + "'," +
                "page_count = '" + PageCountBox.Text + "'," +
                "language = '" + LanguageBox.Text + "'," +
                "format = '" + SeriesBox.Text + "'," +
                "age_rating = '" + AgeRatingBox.Text + "'," +
                "black_and_white = '" + isblack + "'  where file_name = '" +
                listView1.SelectedItems[0].SubItems[1].Text + "';";
                
            listView1.SelectedItems[0].SubItems[2].Text = TitleBox.Text;
            listView1.SelectedItems[0].SubItems[3].Text = SeriesBox.Text;
            listView1.SelectedItems[0].SubItems[4].Text = NumberBox.Text;
            listView1.SelectedItems[0].SubItems[5].Text = BookNumberBox.Text;
            listView1.SelectedItems[0].SubItems[6].Text = CountBox.Text;
            listView1.SelectedItems[0].SubItems[7].Text = VolumeBox.Text;
            listView1.SelectedItems[0].SubItems[8].Text = AlternateSeriesBox.Text;
            listView1.SelectedItems[0].SubItems[10].Text = StoryArcBox.Text;
            listView1.SelectedItems[0].SubItems[11].Text = SeriesGroupBox.Text;
            listView1.SelectedItems[0].SubItems[13].Text = YearBox.Text;
            listView1.SelectedItems[0].SubItems[14].Text = MonthBox.Text;
            listView1.SelectedItems[0].SubItems[15].Text = DayBox.Text;
            listView1.SelectedItems[0].SubItems[16].Text = WriterBox.Text;
            listView1.SelectedItems[0].SubItems[17].Text = PencillerBox.Text;
            listView1.SelectedItems[0].SubItems[18].Text = InkerBox.Text;
            listView1.SelectedItems[0].SubItems[19].Text = ColoristBox.Text;
            listView1.SelectedItems[0].SubItems[20].Text = LettererBox.Text;
            listView1.SelectedItems[0].SubItems[21].Text = CoverArtistBox.Text;
            listView1.SelectedItems[0].SubItems[22].Text = EditorBox.Text;
            listView1.SelectedItems[0].SubItems[23].Text = PublisherBox.Text;
            listView1.SelectedItems[0].SubItems[24].Text = ImprintBox.Text;
            listView1.SelectedItems[0].SubItems[25].Text = GenreBox.Text;
            listView1.SelectedItems[0].SubItems[26].Text = PageCountBox.Text;
            listView1.SelectedItems[0].SubItems[27].Text = LanguageBox.Text;
            listView1.SelectedItems[0].SubItems[29].Text = AgeRatingBox.Text;
                
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
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

                Db_update();
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
            try
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

                if (listView1.SelectedItems[0].SubItems[30].Text == "Yes")
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
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            string path = listView1.SelectedItems[0].SubItems[33].Text;
            System.Diagnostics.Process.Start(@"C:\Program Files\Honeyview\Honeyview.exe", path);
        }

        private void ExtractAllButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ExtractOneButton_Click(object sender, EventArgs e)
        {
            ExtractToCbz(listView1.SelectedItems[0].SubItems[33].Text);
            refresh();
        }

        private void ExtractToCbz(string startPath)
        {
            if (Path.GetExtension(startPath) == ".zip" || Path.GetExtension(startPath) == ".cbz")
            {
                string zipPath = Directory.GetParent(startPath) + "\\temp";
                ZipFile.ExtractToDirectory(startPath, zipPath);
                CreateCBZ(startPath, zipPath, Convert.ToInt32(listView1.SelectedIndices[0].ToString()));
            }
            else
            {
                CreateCBZ(startPath, Convert.ToInt32(listView1.SelectedIndices[0].ToString()));
            }
        }

        private void CreateCBZ(string startPath, int n)
        {
            CreateXml(startPath, n);
            ZipFile.CreateFromDirectory(startPath, startPath + ".cbz");
            if (OriginDelBox.Checked)
                Directory.Delete(startPath, true);
        }

        private void CreateCBZ(string startPath, string zipPath, int n)
        {
            CreateXml(zipPath, n);
            try
            {
                ZipFile.CreateFromDirectory(zipPath, Path.ChangeExtension(startPath, ".cbz"));
                Directory.Delete(zipPath, true);
                if (OriginDelBox.Checked)
                    File.Delete(startPath);
            }
            catch ( System.IO.IOException )
            {
                ZipFile.CreateFromDirectory(zipPath, Path.ChangeExtension(startPath, "_.cbz"));
                File.Delete(startPath);
                File.Move(Path.ChangeExtension(startPath, "_.cbz"), Path.ChangeExtension(startPath, ".cbz"));
                Directory.Delete(zipPath, true);
            }  
        }

        private void CreateXml(string startPath, int n)
        {
            string url = Directory.GetParent(startPath) + "\\temp" + "\\ComicInfo.xml";

            string[] data = new string[30];

            for(int i = 0; i < 30; i++)
            {
                if (listView1.Items[n].SubItems[i + 2].Text == "")
                    data[i] = "N/A";
                else
                    data[i] = listView1.Items[n].SubItems[i + 2].Text;
            }

            XDocument xdoc = new XDocument(new XDeclaration("1.0", "UTF-8", null));
            XElement xroot = new XElement("ComicInfo",
                new XElement("Title", data[0]),
                new XElement("Series",data[1]),
                new XElement("Number",data[2]),
                new XElement("BookNumber",data[3]),
                new XElement("Count",data[4]),
                new XElement("Volume",data[5]),
                new XElement("AlternateSeries",data[6]),
                new XElement("AlternateNumber",data[7]),
                new XElement("StoryArc",data[8]),
                new XElement("SeriesGroup",data[9]),
                new XElement("AlternateCount",data[10]),
                new XElement("Year",data[11]),
                new XElement("Month",data[12]),
                new XElement("Day",data[13]),
                new XElement("Writer",data[14]),
                new XElement("Penciller",data[15]),
                new XElement("Inker",data[16]),
                new XElement("Colorist",data[17]),
                new XElement("Letterer",data[18]),
                new XElement("CoverArtist",data[19]),
                new XElement("Editor",data[20]),
                new XElement("Publisher",data[21]),
                new XElement("Imprint",data[22]),
                new XElement("Genre",data[23]),
                new XElement("PageCount",data[24]),
                new XElement("LanguageISO",data[25]),
                new XElement("Format",data[26]),
                new XElement("AgeRating",data[27]),
                new XElement("BlackAndWhite",data[28]),
                new XElement("Manga",data[29])                
                );
            xdoc.Add(xroot);
            xdoc.Save(url);
        }

        private void refresh()
        {
            FileInfo fileInfo = new FileInfo(dbroute);
            try
            {
                fileInfo.Delete();
                listView1.Items.Clear();
            }
            catch
            {
                MessageBox.Show("DB가 사용중입니다. 잠시 후 다시 시도해 주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Db_init(); // DB 생성/초기화

            dbroute = Properties.UserConfig.Default.path + "\\db.sqlite";

            Db_regist(Properties.UserConfig.Default.path); // DB에 파일 등록
            Db_view();
        }

        private XDocument readZipFile(String filePath)
        {
            XDocument xdoc = null;
            try
            {
                if (File.Exists(filePath))
                {
                    ZipArchive apcZipFile = ZipFile.Open(filePath, ZipArchiveMode.Read);
                    foreach (ZipArchiveEntry entry in apcZipFile.Entries)
                    {
                        if (entry.Name.ToUpper().EndsWith(".XML"))
                        {
                            ZipArchiveEntry zipEntry = apcZipFile.GetEntry(entry.Name);
                            xdoc = XDocument.Load(zipEntry.Open());
                            return xdoc;
                        }
                    }
                }

                return xdoc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
        }
    } 
}
