namespace sample
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.ultraComboEditor1 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraComboEditor2 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "환자번호";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "주민번호";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(108, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "[환자번호]";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.Patnum);
            this.textBox1.Leave += new System.EventHandler(this.Patleave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(108, 100);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "주민번호앞자리";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.num1);
            this.textBox2.Leave += new System.EventHandler(this.num2);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(233, 67);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 31);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "[환자성명]";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Enter += new System.EventHandler(this.Patname);
            this.textBox3.Leave += new System.EventHandler(this.Patnleave);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(233, 100);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 31);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "주민번호뒷자리";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.backnum);
            this.textBox4.Leave += new System.EventHandler(this.backnum2);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(358, 67);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 31);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "[영문성명]";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Enter += new System.EventHandler(this.Engname);
            this.textBox5.Leave += new System.EventHandler(this.Engname2);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(358, 100);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(41, 31);
            this.textBox6.TabIndex = 7;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(403, 100);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(41, 31);
            this.textBox7.TabIndex = 8;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(109)))), ((int)(((byte)(191)))));
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(535, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "인적사항 수정";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label3.Location = new System.Drawing.Point(464, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "잠복결핵";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 21;
            this.comboBox1.Items.AddRange(new object[] {
            "잠복결핵 검진",
            "잠복결핵 치료",
            "잠복결핵 해당없음",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(535, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 29);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.s);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label4.Location = new System.Drawing.Point(37, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "주     소";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(108, 152);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 31);
            this.textBox8.TabIndex = 13;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label5.Location = new System.Drawing.Point(159, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Location = new System.Drawing.Point(180, 152);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(47, 31);
            this.textBox9.TabIndex = 15;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.checkBox1.Location = new System.Drawing.Point(32, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 23);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "웹검색";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.Location = new System.Drawing.Point(108, 189);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(119, 31);
            this.textBox10.TabIndex = 17;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox11.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.Location = new System.Drawing.Point(233, 152);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(430, 68);
            this.textBox11.TabIndex = 18;
            this.textBox11.Text = "\r\n[주    소]";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.textBox11.Enter += new System.EventHandler(this.address);
            this.textBox11.Leave += new System.EventHandler(this.address1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label6.Location = new System.Drawing.Point(37, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "전화번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label7.Location = new System.Drawing.Point(37, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "직장정보";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox12.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox12.Location = new System.Drawing.Point(108, 226);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(119, 31);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "[휴대전화번호]";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.textBox12.Enter += new System.EventHandler(this.Phone);
            this.textBox12.Leave += new System.EventHandler(this.Phone1);
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox13.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox13.Location = new System.Drawing.Point(108, 263);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(119, 31);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "[직장명]";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox14.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox14.Location = new System.Drawing.Point(233, 226);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(119, 31);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "[전화번호]";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            this.textBox14.Enter += new System.EventHandler(this.homenum);
            this.textBox14.Leave += new System.EventHandler(this.homenum1);
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox15.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox15.Location = new System.Drawing.Point(233, 263);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(119, 31);
            this.textBox15.TabIndex = 24;
            this.textBox15.Text = "[직장전화번호]";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label8.Location = new System.Drawing.Point(37, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "생년월일";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox16.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox16.Location = new System.Drawing.Point(108, 300);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(119, 31);
            this.textBox16.TabIndex = 26;
            this.textBox16.Text = "[생년월일]";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            this.textBox16.Enter += new System.EventHandler(this.Birth);
            this.textBox16.Leave += new System.EventHandler(this.Birth1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label9.Location = new System.Drawing.Point(37, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "E-mail";
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox17.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox17.Location = new System.Drawing.Point(108, 339);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(119, 31);
            this.textBox17.TabIndex = 29;
            this.textBox17.Text = "[E-Mail]";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.textBox17.Enter += new System.EventHandler(this.Email);
            this.textBox17.Leave += new System.EventHandler(this.Email1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label10.Location = new System.Drawing.Point(37, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "여권번호";
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox18.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox18.Location = new System.Drawing.Point(108, 377);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(244, 31);
            this.textBox18.TabIndex = 32;
            this.textBox18.Text = "[여권번호]";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.checkBox2.Location = new System.Drawing.Point(388, 226);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 23);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "환자번호미사용";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox3.ForeColor = System.Drawing.Color.Red;
            this.checkBox3.Location = new System.Drawing.Point(388, 254);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 24);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "VIP 환자";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.checkBox4.Location = new System.Drawing.Point(388, 279);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(140, 23);
            this.checkBox4.TabIndex = 35;
            this.checkBox4.Text = "개인정보활용동의";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.checkBox5.Location = new System.Drawing.Point(388, 308);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(112, 23);
            this.checkBox5.TabIndex = 36;
            this.checkBox5.Text = "문자발송거부";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox6.Location = new System.Drawing.Point(388, 333);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(153, 24);
            this.checkBox6.TabIndex = 37;
            this.checkBox6.Text = "국제수가 적용여부";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox7.ForeColor = System.Drawing.Color.Red;
            this.checkBox7.Location = new System.Drawing.Point(551, 224);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(88, 24);
            this.checkBox7.TabIndex = 38;
            this.checkBox7.Text = "정보보호";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox8.ForeColor = System.Drawing.Color.Red;
            this.checkBox8.Location = new System.Drawing.Point(551, 251);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(103, 24);
            this.checkBox8.TabIndex = 39;
            this.checkBox8.Text = "사생활보호";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.checkBox9.Location = new System.Drawing.Point(551, 279);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(98, 23);
            this.checkBox9.TabIndex = 40;
            this.checkBox9.Text = "급여제한자";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.checkBox10.Location = new System.Drawing.Point(551, 307);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(106, 23);
            this.checkBox10.TabIndex = 41;
            this.checkBox10.Text = "보훈상이7급";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox11.Location = new System.Drawing.Point(551, 333);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(108, 24);
            this.checkBox11.TabIndex = 42;
            this.checkBox11.Text = "외국인 여부";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label11.Location = new System.Drawing.Point(384, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "국     적";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownHeight = 200;
            this.comboBox4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.ItemHeight = 21;
            this.comboBox4.Items.AddRange(new object[] {
            "South Korea",
            "America",
            "Japan",
            "China"});
            this.comboBox4.Location = new System.Drawing.Point(452, 359);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(211, 29);
            this.comboBox4.TabIndex = 44;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.textBox19.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox19.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox19.Location = new System.Drawing.Point(-1, 0);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(807, 29);
            this.textBox19.TabIndex = 45;
            this.textBox19.Text = "환자정보";
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // ultraButton3
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BackColor2 = System.Drawing.Color.White;
            appearance1.BackColorDisabled = System.Drawing.Color.White;
            appearance1.BackColorDisabled2 = System.Drawing.Color.White;
            this.ultraButton3.Appearance = appearance1;
            this.ultraButton3.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat;
            this.ultraButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ultraButton3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            appearance2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.ultraButton3.HotTrackAppearance = appearance2;
            this.ultraButton3.Location = new System.Drawing.Point(589, 3);
            this.ultraButton3.Name = "ultraButton3";
            this.ultraButton3.Size = new System.Drawing.Size(116, 26);
            this.ultraButton3.TabIndex = 82;
            this.ultraButton3.Text = "내원내역상세";
            this.ultraButton3.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // ultraComboEditor1
            // 
            this.ultraComboEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013;
            this.ultraComboEditor1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.ultraComboEditor1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            valueListItem5.DataValue = "ValueListItem0";
            valueListItem5.DisplayText = " 양력";
            valueListItem6.DataValue = "ValueListItem1";
            valueListItem6.DisplayText = "음력";
            this.ultraComboEditor1.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem5,
            valueListItem6});
            this.ultraComboEditor1.Location = new System.Drawing.Point(233, 301);
            this.ultraComboEditor1.Name = "ultraComboEditor1";
            this.ultraComboEditor1.Size = new System.Drawing.Size(119, 31);
            this.ultraComboEditor1.TabIndex = 91;
            // 
            // ultraComboEditor2
            // 
            this.ultraComboEditor2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013;
            this.ultraComboEditor2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.ultraComboEditor2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            valueListItem1.DataValue = "ValueListItem0";
            valueListItem1.DisplayText = "hanmail.net";
            valueListItem2.DataValue = "ValueListItem1";
            valueListItem2.DisplayText = "naver.com";
            valueListItem3.DataValue = "ValueListItem2";
            valueListItem3.DisplayText = "daum.com";
            valueListItem4.DataValue = "ValueListItem3";
            valueListItem4.DisplayText = "gmail.com";
            this.ultraComboEditor2.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2,
            valueListItem3,
            valueListItem4});
            this.ultraComboEditor2.Location = new System.Drawing.Point(233, 340);
            this.ultraComboEditor2.Name = "ultraComboEditor2";
            this.ultraComboEditor2.Size = new System.Drawing.Size(119, 31);
            this.ultraComboEditor2.TabIndex = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.ultraComboEditor2);
            this.Controls.Add(this.ultraComboEditor1);
            this.Controls.Add(this.ultraButton3);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox19;
        public Infragistics.Win.Misc.UltraButton ultraButton3;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor2;

    }
}

