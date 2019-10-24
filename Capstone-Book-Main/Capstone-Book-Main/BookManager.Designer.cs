namespace Capstone_Book_Main
{
    partial class BookManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Series = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Writer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Penciller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeriesLable = new System.Windows.Forms.Label();
            this.CanmodiButton = new System.Windows.Forms.Button();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.VolumeBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.SeriesBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImprintBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.PageCountBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.LanguageBox = new System.Windows.Forms.TextBox();
            this.IsColorButton = new System.Windows.Forms.RadioButton();
            this.IsBlackButton = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.AgeRatingBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.EditorBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CoverArtistBox = new System.Windows.Forms.TextBox();
            this.LettererBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ColoristBox = new System.Windows.Forms.TextBox();
            this.InkerBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PencillerBox = new System.Windows.Forms.TextBox();
            this.WriterBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.PublisherBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.SeriesGroupBox = new System.Windows.Forms.TextBox();
            this.StoryArcBox = new System.Windows.Forms.TextBox();
            this.AlternateSeriesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExtractOneButton = new System.Windows.Forms.Button();
            this.ExtractAllButton = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BookNumberBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookNum,
            this.Title,
            this.Series,
            this.Writer,
            this.Penciller,
            this.Genre,
            this.AgeRating});
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 459);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BookNum
            // 
            this.BookNum.Text = "도서번호";
            // 
            // Title
            // 
            this.Title.Text = "도서명";
            // 
            // Series
            // 
            this.Series.Text = "시리즈";
            // 
            // Writer
            // 
            this.Writer.Text = "작가";
            // 
            // Penciller
            // 
            this.Penciller.Text = "작화가";
            // 
            // Genre
            // 
            this.Genre.Text = "장르";
            // 
            // AgeRating
            // 
            this.AgeRating.Text = "심의연령";
            // 
            // SeriesLable
            // 
            this.SeriesLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeriesLable.AutoSize = true;
            this.SeriesLable.Location = new System.Drawing.Point(9, 61);
            this.SeriesLable.Name = "SeriesLable";
            this.SeriesLable.Size = new System.Drawing.Size(41, 12);
            this.SeriesLable.TabIndex = 6;
            this.SeriesLable.Text = "시리즈";
            // 
            // CanmodiButton
            // 
            this.CanmodiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CanmodiButton.Location = new System.Drawing.Point(722, 436);
            this.CanmodiButton.Name = "CanmodiButton";
            this.CanmodiButton.Size = new System.Drawing.Size(75, 23);
            this.CanmodiButton.TabIndex = 1;
            this.CanmodiButton.Text = "수정";
            this.toolTip1.SetToolTip(this.CanmodiButton, "메타데이터를 수정 가능한 상태로 전환합니다.");
            this.CanmodiButton.UseVisualStyleBackColor = true;
            this.CanmodiButton.Click += new System.EventHandler(this.CanmodiButton_Click);
            // 
            // CountBox
            // 
            this.CountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountBox.Location = new System.Drawing.Point(131, 84);
            this.CountBox.MaximumSize = new System.Drawing.Size(36, 21);
            this.CountBox.MinimumSize = new System.Drawing.Size(36, 21);
            this.CountBox.Name = "CountBox";
            this.CountBox.ReadOnly = true;
            this.CountBox.Size = new System.Drawing.Size(36, 21);
            this.CountBox.TabIndex = 4;
            this.CountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TitleLable
            // 
            this.TitleLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(20, 8);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(29, 12);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "제목";
            // 
            // VolumeBox
            // 
            this.VolumeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBox.Location = new System.Drawing.Point(225, 57);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.ReadOnly = true;
            this.VolumeBox.Size = new System.Drawing.Size(24, 21);
            this.VolumeBox.TabIndex = 5;
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBox.Location = new System.Drawing.Point(56, 3);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(193, 21);
            this.TitleBox.TabIndex = 1;
            // 
            // NumberBox
            // 
            this.NumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberBox.Location = new System.Drawing.Point(56, 84);
            this.NumberBox.MaximumSize = new System.Drawing.Size(41, 21);
            this.NumberBox.MinimumSize = new System.Drawing.Size(41, 21);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.ReadOnly = true;
            this.NumberBox.Size = new System.Drawing.Size(41, 21);
            this.NumberBox.TabIndex = 3;
            this.NumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SeriesBox
            // 
            this.SeriesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeriesBox.Location = new System.Drawing.Point(56, 57);
            this.SeriesBox.Name = "SeriesBox";
            this.SeriesBox.ReadOnly = true;
            this.SeriesBox.Size = new System.Drawing.Size(163, 21);
            this.SeriesBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.수정ToolStripMenuItem,
            this.도구ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.수정ToolStripMenuItem.Text = "수정";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.BookNumberBox);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.PageCountBox);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.LanguageBox);
            this.panel1.Controls.Add(this.IsColorButton);
            this.panel1.Controls.Add(this.IsBlackButton);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.AgeRatingBox);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.GenreBox);
            this.panel1.Controls.Add(this.PublisherBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DayBox);
            this.panel1.Controls.Add(this.MonthBox);
            this.panel1.Controls.Add(this.YearBox);
            this.panel1.Controls.Add(this.SeriesGroupBox);
            this.panel1.Controls.Add(this.StoryArcBox);
            this.panel1.Controls.Add(this.AlternateSeriesBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TitleBox);
            this.panel1.Controls.Add(this.SeriesLable);
            this.panel1.Controls.Add(this.NumberBox);
            this.panel1.Controls.Add(this.SeriesBox);
            this.panel1.Controls.Add(this.CountBox);
            this.panel1.Controls.Add(this.VolumeBox);
            this.panel1.Controls.Add(this.TitleLable);
            this.panel1.Location = new System.Drawing.Point(516, 29);
            this.panel1.MinimumSize = new System.Drawing.Size(269, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 401);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImprintBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 60);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "간행정보";
            // 
            // ImprintBox
            // 
            this.ImprintBox.Location = new System.Drawing.Point(3, 17);
            this.ImprintBox.Multiline = true;
            this.ImprintBox.Name = "ImprintBox";
            this.ImprintBox.ReadOnly = true;
            this.ImprintBox.Size = new System.Drawing.Size(256, 40);
            this.ImprintBox.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Location = new System.Drawing.Point(229, 88);
            this.label21.MaximumSize = new System.Drawing.Size(17, 12);
            this.label21.MinimumSize = new System.Drawing.Size(17, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 40;
            this.label21.Text = "쪽";
            // 
            // PageCountBox
            // 
            this.PageCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageCountBox.Location = new System.Drawing.Point(189, 84);
            this.PageCountBox.MaximumSize = new System.Drawing.Size(36, 21);
            this.PageCountBox.MinimumSize = new System.Drawing.Size(36, 21);
            this.PageCountBox.Name = "PageCountBox";
            this.PageCountBox.ReadOnly = true;
            this.PageCountBox.Size = new System.Drawing.Size(36, 21);
            this.PageCountBox.TabIndex = 39;
            this.PageCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 305);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 38;
            this.label20.Text = "언어";
            // 
            // LanguageBox
            // 
            this.LanguageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageBox.Location = new System.Drawing.Point(56, 300);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.ReadOnly = true;
            this.LanguageBox.Size = new System.Drawing.Size(75, 21);
            this.LanguageBox.TabIndex = 37;
            // 
            // IsColorButton
            // 
            this.IsColorButton.AutoSize = true;
            this.IsColorButton.Enabled = false;
            this.IsColorButton.Location = new System.Drawing.Point(200, 302);
            this.IsColorButton.Name = "IsColorButton";
            this.IsColorButton.Size = new System.Drawing.Size(47, 16);
            this.IsColorButton.TabIndex = 36;
            this.IsColorButton.TabStop = true;
            this.IsColorButton.Text = "컬러";
            this.IsColorButton.UseVisualStyleBackColor = true;
            // 
            // IsBlackButton
            // 
            this.IsBlackButton.AutoSize = true;
            this.IsBlackButton.Enabled = false;
            this.IsBlackButton.Location = new System.Drawing.Point(148, 302);
            this.IsBlackButton.Name = "IsBlackButton";
            this.IsBlackButton.Size = new System.Drawing.Size(47, 16);
            this.IsBlackButton.TabIndex = 35;
            this.IsBlackButton.TabStop = true;
            this.IsBlackButton.Text = "흑백";
            this.IsBlackButton.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "심의연령";
            // 
            // AgeRatingBox
            // 
            this.AgeRatingBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeRatingBox.Location = new System.Drawing.Point(67, 273);
            this.AgeRatingBox.Name = "AgeRatingBox";
            this.AgeRatingBox.ReadOnly = true;
            this.AgeRatingBox.Size = new System.Drawing.Size(182, 21);
            this.AgeRatingBox.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "장르";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 31;
            this.label17.Text = "출판사";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "발매일";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 29;
            this.label15.Text = "시리즈그룹";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.EditorBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CoverArtistBox);
            this.groupBox1.Controls.Add(this.LettererBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ColoristBox);
            this.groupBox1.Controls.Add(this.InkerBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PencillerBox);
            this.groupBox1.Controls.Add(this.WriterBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 158);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "저자정보";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 33;
            this.label22.Text = "편집자";
            // 
            // EditorBox
            // 
            this.EditorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorBox.Location = new System.Drawing.Point(51, 128);
            this.EditorBox.Name = "EditorBox";
            this.EditorBox.ReadOnly = true;
            this.EditorBox.Size = new System.Drawing.Size(80, 21);
            this.EditorBox.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "레터러";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "커버 아티스트";
            // 
            // CoverArtistBox
            // 
            this.CoverArtistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoverArtistBox.Location = new System.Drawing.Point(95, 101);
            this.CoverArtistBox.Name = "CoverArtistBox";
            this.CoverArtistBox.ReadOnly = true;
            this.CoverArtistBox.Size = new System.Drawing.Size(80, 21);
            this.CoverArtistBox.TabIndex = 29;
            // 
            // LettererBox
            // 
            this.LettererBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LettererBox.Location = new System.Drawing.Point(179, 48);
            this.LettererBox.Name = "LettererBox";
            this.LettererBox.ReadOnly = true;
            this.LettererBox.Size = new System.Drawing.Size(80, 21);
            this.LettererBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "잉커";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "컬러리스트";
            // 
            // ColoristBox
            // 
            this.ColoristBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColoristBox.Location = new System.Drawing.Point(76, 74);
            this.ColoristBox.Name = "ColoristBox";
            this.ColoristBox.ReadOnly = true;
            this.ColoristBox.Size = new System.Drawing.Size(80, 21);
            this.ColoristBox.TabIndex = 25;
            // 
            // InkerBox
            // 
            this.InkerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InkerBox.Location = new System.Drawing.Point(47, 47);
            this.InkerBox.Name = "InkerBox";
            this.InkerBox.ReadOnly = true;
            this.InkerBox.Size = new System.Drawing.Size(80, 21);
            this.InkerBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "작가";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "펜슬러";
            // 
            // PencillerBox
            // 
            this.PencillerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PencillerBox.Location = new System.Drawing.Point(179, 20);
            this.PencillerBox.Name = "PencillerBox";
            this.PencillerBox.ReadOnly = true;
            this.PencillerBox.Size = new System.Drawing.Size(80, 21);
            this.PencillerBox.TabIndex = 21;
            // 
            // WriterBox
            // 
            this.WriterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WriterBox.Location = new System.Drawing.Point(47, 20);
            this.WriterBox.Name = "WriterBox";
            this.WriterBox.ReadOnly = true;
            this.WriterBox.Size = new System.Drawing.Size(80, 21);
            this.WriterBox.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "원작";
            // 
            // GenreBox
            // 
            this.GenreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreBox.Location = new System.Drawing.Point(56, 246);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.ReadOnly = true;
            this.GenreBox.Size = new System.Drawing.Size(193, 21);
            this.GenreBox.TabIndex = 27;
            // 
            // PublisherBox
            // 
            this.PublisherBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PublisherBox.Location = new System.Drawing.Point(56, 219);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.ReadOnly = true;
            this.PublisherBox.Size = new System.Drawing.Size(193, 21);
            this.PublisherBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 198);
            this.label7.MaximumSize = new System.Drawing.Size(17, 12);
            this.label7.MinimumSize = new System.Drawing.Size(17, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 197);
            this.label6.MaximumSize = new System.Drawing.Size(17, 12);
            this.label6.MinimumSize = new System.Drawing.Size(17, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "년";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 197);
            this.label5.MaximumSize = new System.Drawing.Size(17, 12);
            this.label5.MinimumSize = new System.Drawing.Size(17, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "월";
            // 
            // DayBox
            // 
            this.DayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayBox.Location = new System.Drawing.Point(195, 192);
            this.DayBox.MaximumSize = new System.Drawing.Size(36, 21);
            this.DayBox.MinimumSize = new System.Drawing.Size(36, 21);
            this.DayBox.Name = "DayBox";
            this.DayBox.ReadOnly = true;
            this.DayBox.Size = new System.Drawing.Size(36, 21);
            this.DayBox.TabIndex = 16;
            this.DayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MonthBox
            // 
            this.MonthBox.Location = new System.Drawing.Point(138, 192);
            this.MonthBox.MaximumSize = new System.Drawing.Size(36, 21);
            this.MonthBox.MinimumSize = new System.Drawing.Size(36, 21);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.ReadOnly = true;
            this.MonthBox.Size = new System.Drawing.Size(36, 21);
            this.MonthBox.TabIndex = 15;
            this.MonthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YearBox
            // 
            this.YearBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearBox.Location = new System.Drawing.Point(56, 192);
            this.YearBox.MaximumSize = new System.Drawing.Size(59, 21);
            this.YearBox.MinimumSize = new System.Drawing.Size(59, 21);
            this.YearBox.Name = "YearBox";
            this.YearBox.ReadOnly = true;
            this.YearBox.Size = new System.Drawing.Size(59, 21);
            this.YearBox.TabIndex = 14;
            this.YearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SeriesGroupBox
            // 
            this.SeriesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeriesGroupBox.Location = new System.Drawing.Point(79, 165);
            this.SeriesGroupBox.Name = "SeriesGroupBox";
            this.SeriesGroupBox.ReadOnly = true;
            this.SeriesGroupBox.Size = new System.Drawing.Size(170, 21);
            this.SeriesGroupBox.TabIndex = 13;
            // 
            // StoryArcBox
            // 
            this.StoryArcBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoryArcBox.Location = new System.Drawing.Point(56, 138);
            this.StoryArcBox.Name = "StoryArcBox";
            this.StoryArcBox.ReadOnly = true;
            this.StoryArcBox.Size = new System.Drawing.Size(193, 21);
            this.StoryArcBox.TabIndex = 12;
            // 
            // AlternateSeriesBox
            // 
            this.AlternateSeriesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlternateSeriesBox.Location = new System.Drawing.Point(56, 111);
            this.AlternateSeriesBox.Name = "AlternateSeriesBox";
            this.AlternateSeriesBox.ReadOnly = true;
            this.AlternateSeriesBox.Size = new System.Drawing.Size(193, 21);
            this.AlternateSeriesBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "부제";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(167, 89);
            this.label3.MaximumSize = new System.Drawing.Size(17, 12);
            this.label3.MinimumSize = new System.Drawing.Size(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "권";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 89);
            this.label2.MaximumSize = new System.Drawing.Size(33, 12);
            this.label2.MinimumSize = new System.Drawing.Size(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "권 중";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.MaximumSize = new System.Drawing.Size(29, 12);
            this.label1.MinimumSize = new System.Drawing.Size(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "전체";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(722, 463);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "실행";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // ExtractOneButton
            // 
            this.ExtractOneButton.Location = new System.Drawing.Point(644, 436);
            this.ExtractOneButton.Name = "ExtractOneButton";
            this.ExtractOneButton.Size = new System.Drawing.Size(45, 23);
            this.ExtractOneButton.TabIndex = 9;
            this.ExtractOneButton.Text = "단일";
            this.toolTip1.SetToolTip(this.ExtractOneButton, "선택한 파일만 내보냅니다");
            this.ExtractOneButton.UseVisualStyleBackColor = true;
            this.ExtractOneButton.Visible = false;
            // 
            // ExtractAllButton
            // 
            this.ExtractAllButton.Location = new System.Drawing.Point(597, 436);
            this.ExtractAllButton.Name = "ExtractAllButton";
            this.ExtractAllButton.Size = new System.Drawing.Size(45, 23);
            this.ExtractAllButton.TabIndex = 10;
            this.ExtractAllButton.Text = "일괄";
            this.ExtractAllButton.UseVisualStyleBackColor = true;
            this.ExtractAllButton.Visible = false;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtractButton.AutoSize = true;
            this.ExtractButton.Location = new System.Drawing.Point(519, 436);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 11;
            this.ExtractButton.Text = "내보내기";
            this.toolTip1.SetToolTip(this.ExtractButton, "파일을 메타데이터를 포함한 CBZ 파일로 내보냅니다.");
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // BookNumberBox
            // 
            this.BookNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookNumberBox.Location = new System.Drawing.Point(67, 30);
            this.BookNumberBox.Name = "BookNumberBox";
            this.BookNumberBox.ReadOnly = true;
            this.BookNumberBox.Size = new System.Drawing.Size(182, 21);
            this.BookNumberBox.TabIndex = 41;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 42;
            this.label23.Text = "도서번호";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem,
            this.옵션ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.옵션ToolStripMenuItem.Text = "옵션";
            this.옵션ToolStripMenuItem.Click += new System.EventHandler(this.옵션ToolStripMenuItem_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.ExtractAllButton);
            this.Controls.Add(this.ExtractOneButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CanmodiButton);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 489);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BookNum;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Writer;
        private System.Windows.Forms.ColumnHeader Penciller;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Series;
        private System.Windows.Forms.ColumnHeader AgeRating;
        private System.Windows.Forms.Label SeriesLable;
        private System.Windows.Forms.TextBox VolumeBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox SeriesBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Button CanmodiButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DayBox;
        private System.Windows.Forms.TextBox MonthBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox SeriesGroupBox;
        private System.Windows.Forms.TextBox StoryArcBox;
        private System.Windows.Forms.TextBox AlternateSeriesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox PublisherBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CoverArtistBox;
        private System.Windows.Forms.TextBox LettererBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ColoristBox;
        private System.Windows.Forms.TextBox InkerBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PencillerBox;
        private System.Windows.Forms.TextBox WriterBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox PageCountBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox LanguageBox;
        private System.Windows.Forms.RadioButton IsColorButton;
        private System.Windows.Forms.RadioButton IsBlackButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox AgeRatingBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ImprintBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExtractOneButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox EditorBox;
        private System.Windows.Forms.Button ExtractAllButton;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox BookNumberBox;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
    }
}
