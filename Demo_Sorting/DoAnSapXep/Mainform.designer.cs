using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace DoAnSapXep
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.lbHuy = new System.Windows.Forms.Label();
            this.lbKhoiTao = new System.Windows.Forms.Label();
            this.lbThuatToan = new System.Windows.Forms.Label();
            this.lbSapXep = new System.Windows.Forms.Label();
            this.lbMangChuaSapXep = new System.Windows.Forms.Label();
            this.sapxepPanel = new System.Windows.Forms.Panel();
            this.huypanel = new System.Windows.Forms.Panel();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.xoamangbtn = new System.Windows.Forms.Button();
            this.chuasapxepPanel = new System.Windows.Forms.Panel();
            this.yTuongTextBox = new System.Windows.Forms.TextBox();
            this.daydangxepListbox = new System.Windows.Forms.ListBox();
            this.thuattoanpanel = new System.Windows.Forms.Panel();
            this.selectionrdbtn = new System.Windows.Forms.RadioButton();
            this.insertionrdbtn = new System.Windows.Forms.RadioButton();
            this.mergerdbtn = new System.Windows.Forms.RadioButton();
            this.quickrdbtn = new System.Windows.Forms.RadioButton();
            this.bubblerdbtn = new System.Windows.Forms.RadioButton();
            this.interchangerdbtn = new System.Windows.Forms.RadioButton();
            this.Loaisapxeppanel = new System.Windows.Forms.Panel();
            this.giamrdbtn = new System.Windows.Forms.RadioButton();
            this.tangrdbtn = new System.Windows.Forms.RadioButton();
            this.khoitaopanel = new System.Windows.Forms.Panel();
            this.soluongNodetbx = new System.Windows.Forms.TextBox();
            this.nhaptaybtn = new System.Windows.Forms.Button();
            this.lbSoPhanTu = new System.Windows.Forms.Label();
            this.venutbtn = new System.Windows.Forms.Button();
            this.taongaunhienbtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btndebug = new System.Windows.Forms.Button();
            this.cboxdebug = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HienThiPanel = new System.Windows.Forms.Panel();
            this.tabctlytuong = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbDieuKhien = new System.Windows.Forms.Label();
            this.dungbtn = new System.Windows.Forms.Button();
            this.batdaubtn = new System.Windows.Forms.Button();
            this.huybnt = new System.Windows.Forms.Button();
            this.lbTocDo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dieukhienpanel = new System.Windows.Forms.Panel();
            this.huypanel.SuspendLayout();
            this.chuasapxepPanel.SuspendLayout();
            this.thuattoanpanel.SuspendLayout();
            this.Loaisapxeppanel.SuspendLayout();
            this.khoitaopanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.HienThiPanel.SuspendLayout();
            this.tabctlytuong.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.dieukhienpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHuy
            // 
            this.lbHuy.AutoSize = true;
            this.lbHuy.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHuy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbHuy.Location = new System.Drawing.Point(4, 2);
            this.lbHuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHuy.Name = "lbHuy";
            this.lbHuy.Size = new System.Drawing.Size(45, 21);
            this.lbHuy.TabIndex = 12;
            this.lbHuy.Text = "Hủy";
            // 
            // lbKhoiTao
            // 
            this.lbKhoiTao.AutoSize = true;
            this.lbKhoiTao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoiTao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbKhoiTao.Location = new System.Drawing.Point(18, 7);
            this.lbKhoiTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoiTao.Name = "lbKhoiTao";
            this.lbKhoiTao.Size = new System.Drawing.Size(89, 21);
            this.lbKhoiTao.TabIndex = 13;
            this.lbKhoiTao.Text = "Khởi Tạo";
            // 
            // lbThuatToan
            // 
            this.lbThuatToan.AutoSize = true;
            this.lbThuatToan.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuatToan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbThuatToan.Location = new System.Drawing.Point(4, 0);
            this.lbThuatToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThuatToan.Name = "lbThuatToan";
            this.lbThuatToan.Size = new System.Drawing.Size(111, 21);
            this.lbThuatToan.TabIndex = 15;
            this.lbThuatToan.Text = "Thuật Toán";
            // 
            // lbSapXep
            // 
            this.lbSapXep.AutoSize = true;
            this.lbSapXep.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSapXep.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSapXep.Location = new System.Drawing.Point(5, 7);
            this.lbSapXep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSapXep.Name = "lbSapXep";
            this.lbSapXep.Size = new System.Drawing.Size(83, 21);
            this.lbSapXep.TabIndex = 16;
            this.lbSapXep.Text = "Sắp Xếp";
            // 
            // lbMangChuaSapXep
            // 
            this.lbMangChuaSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMangChuaSapXep.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMangChuaSapXep.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbMangChuaSapXep.Location = new System.Drawing.Point(18, 11);
            this.lbMangChuaSapXep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMangChuaSapXep.Name = "lbMangChuaSapXep";
            this.lbMangChuaSapXep.Size = new System.Drawing.Size(159, 21);
            this.lbMangChuaSapXep.TabIndex = 17;
            this.lbMangChuaSapXep.Text = "Mảng ban đầu\r\n";
            // 
            // sapxepPanel
            // 
            this.sapxepPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sapxepPanel.AutoSize = true;
            this.sapxepPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sapxepPanel.Location = new System.Drawing.Point(13, 178);
            this.sapxepPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sapxepPanel.Name = "sapxepPanel";
            this.sapxepPanel.Size = new System.Drawing.Size(1352, 667);
            this.sapxepPanel.TabIndex = 18;
            this.sapxepPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sapxepPanel_MouseClick);
            // 
            // huypanel
            // 
            this.huypanel.BackColor = System.Drawing.Color.DimGray;
            this.huypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huypanel.Controls.Add(this.thoatbtn);
            this.huypanel.Controls.Add(this.xoamangbtn);
            this.huypanel.Controls.Add(this.lbHuy);
            this.huypanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huypanel.Location = new System.Drawing.Point(813, 61);
            this.huypanel.Margin = new System.Windows.Forms.Padding(4);
            this.huypanel.Name = "huypanel";
            this.huypanel.Size = new System.Drawing.Size(333, 53);
            this.huypanel.TabIndex = 25;
            // 
            // thoatbtn
            // 
            this.thoatbtn.Location = new System.Drawing.Point(189, 13);
            this.thoatbtn.Margin = new System.Windows.Forms.Padding(4);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(101, 26);
            this.thoatbtn.TabIndex = 14;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // xoamangbtn
            // 
            this.xoamangbtn.Location = new System.Drawing.Point(58, 13);
            this.xoamangbtn.Margin = new System.Windows.Forms.Padding(4);
            this.xoamangbtn.Name = "xoamangbtn";
            this.xoamangbtn.Size = new System.Drawing.Size(101, 26);
            this.xoamangbtn.TabIndex = 15;
            this.xoamangbtn.Text = "Xóa mảng";
            this.xoamangbtn.UseVisualStyleBackColor = true;
            this.xoamangbtn.Click += new System.EventHandler(this.xoamangbtn_Click);
            // 
            // chuasapxepPanel
            // 
            this.chuasapxepPanel.BackColor = System.Drawing.Color.DimGray;
            this.chuasapxepPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chuasapxepPanel.Controls.Add(this.lbMangChuaSapXep);
            this.chuasapxepPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuasapxepPanel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.chuasapxepPanel.Location = new System.Drawing.Point(13, 122);
            this.chuasapxepPanel.Margin = new System.Windows.Forms.Padding(4);
            this.chuasapxepPanel.Name = "chuasapxepPanel";
            this.chuasapxepPanel.Size = new System.Drawing.Size(1349, 48);
            this.chuasapxepPanel.TabIndex = 19;
            // 
            // yTuongTextBox
            // 
            this.yTuongTextBox.BackColor = System.Drawing.Color.DimGray;
            this.yTuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yTuongTextBox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yTuongTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yTuongTextBox.Location = new System.Drawing.Point(0, 0);
            this.yTuongTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yTuongTextBox.Multiline = true;
            this.yTuongTextBox.Name = "yTuongTextBox";
            this.yTuongTextBox.ReadOnly = true;
            this.yTuongTextBox.Size = new System.Drawing.Size(372, 161);
            this.yTuongTextBox.TabIndex = 12;
            // 
            // daydangxepListbox
            // 
            this.daydangxepListbox.BackColor = System.Drawing.Color.DimGray;
            this.daydangxepListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daydangxepListbox.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daydangxepListbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.daydangxepListbox.FormattingEnabled = true;
            this.daydangxepListbox.ItemHeight = 17;
            this.daydangxepListbox.Location = new System.Drawing.Point(0, 8);
            this.daydangxepListbox.Margin = new System.Windows.Forms.Padding(4);
            this.daydangxepListbox.Name = "daydangxepListbox";
            this.daydangxepListbox.Size = new System.Drawing.Size(381, 136);
            this.daydangxepListbox.TabIndex = 13;
            // 
            // thuattoanpanel
            // 
            this.thuattoanpanel.BackColor = System.Drawing.Color.DimGray;
            this.thuattoanpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thuattoanpanel.Controls.Add(this.mergerdbtn);
            this.thuattoanpanel.Controls.Add(this.interchangerdbtn);
            this.thuattoanpanel.Controls.Add(this.quickrdbtn);
            this.thuattoanpanel.Controls.Add(this.selectionrdbtn);
            this.thuattoanpanel.Controls.Add(this.insertionrdbtn);
            this.thuattoanpanel.Controls.Add(this.bubblerdbtn);
            this.thuattoanpanel.Controls.Add(this.lbThuatToan);
            this.thuattoanpanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thuattoanpanel.Location = new System.Drawing.Point(1373, 13);
            this.thuattoanpanel.Margin = new System.Windows.Forms.Padding(4);
            this.thuattoanpanel.Name = "thuattoanpanel";
            this.thuattoanpanel.Size = new System.Drawing.Size(412, 157);
            this.thuattoanpanel.TabIndex = 4;
            // 
            // selectionrdbtn
            // 
            this.selectionrdbtn.AutoSize = true;
            this.selectionrdbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionrdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectionrdbtn.Location = new System.Drawing.Point(49, 65);
            this.selectionrdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectionrdbtn.Name = "selectionrdbtn";
            this.selectionrdbtn.Size = new System.Drawing.Size(132, 25);
            this.selectionrdbtn.TabIndex = 17;
            this.selectionrdbtn.Text = "Selection sort";
            this.selectionrdbtn.UseVisualStyleBackColor = true;
            this.selectionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // insertionrdbtn
            // 
            this.insertionrdbtn.AutoSize = true;
            this.insertionrdbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertionrdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.insertionrdbtn.Location = new System.Drawing.Point(244, 26);
            this.insertionrdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.insertionrdbtn.Name = "insertionrdbtn";
            this.insertionrdbtn.Size = new System.Drawing.Size(131, 25);
            this.insertionrdbtn.TabIndex = 12;
            this.insertionrdbtn.Text = "Insertion sort";
            this.insertionrdbtn.UseVisualStyleBackColor = true;
            this.insertionrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // mergerdbtn
            // 
            this.mergerdbtn.AutoSize = true;
            this.mergerdbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergerdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mergerdbtn.Location = new System.Drawing.Point(244, 108);
            this.mergerdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.mergerdbtn.Name = "mergerdbtn";
            this.mergerdbtn.Size = new System.Drawing.Size(111, 25);
            this.mergerdbtn.TabIndex = 21;
            this.mergerdbtn.Text = "Merge sort";
            this.mergerdbtn.UseVisualStyleBackColor = true;
            this.mergerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // quickrdbtn
            // 
            this.quickrdbtn.AutoSize = true;
            this.quickrdbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickrdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.quickrdbtn.Location = new System.Drawing.Point(244, 65);
            this.quickrdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.quickrdbtn.Name = "quickrdbtn";
            this.quickrdbtn.Size = new System.Drawing.Size(106, 25);
            this.quickrdbtn.TabIndex = 19;
            this.quickrdbtn.Text = "Quick sort";
            this.quickrdbtn.UseVisualStyleBackColor = true;
            this.quickrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // bubblerdbtn
            // 
            this.bubblerdbtn.AutoSize = true;
            this.bubblerdbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubblerdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bubblerdbtn.Location = new System.Drawing.Point(49, 108);
            this.bubblerdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.bubblerdbtn.Name = "bubblerdbtn";
            this.bubblerdbtn.Size = new System.Drawing.Size(115, 25);
            this.bubblerdbtn.TabIndex = 16;
            this.bubblerdbtn.Text = "Bubble sort";
            this.bubblerdbtn.UseVisualStyleBackColor = true;
            this.bubblerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // interchangerdbtn
            // 
            this.interchangerdbtn.AutoSize = true;
            this.interchangerdbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interchangerdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.interchangerdbtn.Location = new System.Drawing.Point(49, 26);
            this.interchangerdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.interchangerdbtn.Name = "interchangerdbtn";
            this.interchangerdbtn.Size = new System.Drawing.Size(154, 25);
            this.interchangerdbtn.TabIndex = 12;
            this.interchangerdbtn.Text = "Interchange sort";
            this.interchangerdbtn.UseVisualStyleBackColor = true;
            this.interchangerdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // Loaisapxeppanel
            // 
            this.Loaisapxeppanel.BackColor = System.Drawing.Color.DimGray;
            this.Loaisapxeppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loaisapxeppanel.Controls.Add(this.giamrdbtn);
            this.Loaisapxeppanel.Controls.Add(this.tangrdbtn);
            this.Loaisapxeppanel.Controls.Add(this.lbSapXep);
            this.Loaisapxeppanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loaisapxeppanel.ForeColor = System.Drawing.Color.DarkGray;
            this.Loaisapxeppanel.Location = new System.Drawing.Point(1154, 13);
            this.Loaisapxeppanel.Margin = new System.Windows.Forms.Padding(4);
            this.Loaisapxeppanel.Name = "Loaisapxeppanel";
            this.Loaisapxeppanel.Size = new System.Drawing.Size(208, 101);
            this.Loaisapxeppanel.TabIndex = 21;
            // 
            // giamrdbtn
            // 
            this.giamrdbtn.AutoSize = true;
            this.giamrdbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giamrdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.giamrdbtn.Location = new System.Drawing.Point(42, 68);
            this.giamrdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.giamrdbtn.Name = "giamrdbtn";
            this.giamrdbtn.Size = new System.Drawing.Size(71, 26);
            this.giamrdbtn.TabIndex = 12;
            this.giamrdbtn.TabStop = true;
            this.giamrdbtn.Text = "Giảm";
            this.giamrdbtn.UseVisualStyleBackColor = true;
            this.giamrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // tangrdbtn
            // 
            this.tangrdbtn.AutoSize = true;
            this.tangrdbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangrdbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tangrdbtn.Location = new System.Drawing.Point(42, 33);
            this.tangrdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.tangrdbtn.Name = "tangrdbtn";
            this.tangrdbtn.Size = new System.Drawing.Size(71, 26);
            this.tangrdbtn.TabIndex = 13;
            this.tangrdbtn.TabStop = true;
            this.tangrdbtn.Text = "Tăng";
            this.tangrdbtn.UseVisualStyleBackColor = true;
            this.tangrdbtn.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // khoitaopanel
            // 
            this.khoitaopanel.BackColor = System.Drawing.Color.DimGray;
            this.khoitaopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khoitaopanel.Controls.Add(this.soluongNodetbx);
            this.khoitaopanel.Controls.Add(this.nhaptaybtn);
            this.khoitaopanel.Controls.Add(this.lbSoPhanTu);
            this.khoitaopanel.Controls.Add(this.venutbtn);
            this.khoitaopanel.Controls.Add(this.taongaunhienbtn);
            this.khoitaopanel.Controls.Add(this.lbKhoiTao);
            this.khoitaopanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoitaopanel.Location = new System.Drawing.Point(13, 13);
            this.khoitaopanel.Margin = new System.Windows.Forms.Padding(4);
            this.khoitaopanel.Name = "khoitaopanel";
            this.khoitaopanel.Size = new System.Drawing.Size(353, 101);
            this.khoitaopanel.TabIndex = 24;
            // 
            // soluongNodetbx
            // 
            this.soluongNodetbx.Location = new System.Drawing.Point(287, 7);
            this.soluongNodetbx.Margin = new System.Windows.Forms.Padding(4);
            this.soluongNodetbx.Multiline = true;
            this.soluongNodetbx.Name = "soluongNodetbx";
            this.soluongNodetbx.Size = new System.Drawing.Size(53, 21);
            this.soluongNodetbx.TabIndex = 15;
            this.soluongNodetbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.soluongNodetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nhaptaybtn
            // 
            this.nhaptaybtn.Location = new System.Drawing.Point(129, 61);
            this.nhaptaybtn.Margin = new System.Windows.Forms.Padding(4);
            this.nhaptaybtn.Name = "nhaptaybtn";
            this.nhaptaybtn.Size = new System.Drawing.Size(95, 33);
            this.nhaptaybtn.TabIndex = 6;
            this.nhaptaybtn.Text = "Nhập tay";
            this.nhaptaybtn.UseVisualStyleBackColor = true;
            this.nhaptaybtn.Click += new System.EventHandler(this.nhaptaybtn_Click);
            // 
            // lbSoPhanTu
            // 
            this.lbSoPhanTu.AutoSize = true;
            this.lbSoPhanTu.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhanTu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSoPhanTu.Location = new System.Drawing.Point(176, 7);
            this.lbSoPhanTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoPhanTu.Name = "lbSoPhanTu";
            this.lbSoPhanTu.Size = new System.Drawing.Size(105, 21);
            this.lbSoPhanTu.TabIndex = 14;
            this.lbSoPhanTu.Text = "Số phần tử";
            // 
            // venutbtn
            // 
            this.venutbtn.Location = new System.Drawing.Point(232, 61);
            this.venutbtn.Margin = new System.Windows.Forms.Padding(4);
            this.venutbtn.Name = "venutbtn";
            this.venutbtn.Size = new System.Drawing.Size(100, 33);
            this.venutbtn.TabIndex = 5;
            this.venutbtn.Text = "Đổi số";
            this.venutbtn.UseVisualStyleBackColor = true;
            this.venutbtn.Click += new System.EventHandler(this.venutbtn_Click);
            // 
            // taongaunhienbtn
            // 
            this.taongaunhienbtn.Location = new System.Drawing.Point(22, 61);
            this.taongaunhienbtn.Margin = new System.Windows.Forms.Padding(4);
            this.taongaunhienbtn.Name = "taongaunhienbtn";
            this.taongaunhienbtn.Size = new System.Drawing.Size(99, 34);
            this.taongaunhienbtn.TabIndex = 7;
            this.taongaunhienbtn.Text = "Ngẫu nhiên";
            this.taongaunhienbtn.UseVisualStyleBackColor = true;
            this.taongaunhienbtn.Click += new System.EventHandler(this.taongaunhienbtn_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btndebug);
            this.panel10.Controls.Add(this.cboxdebug);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.ForeColor = System.Drawing.Color.DarkGray;
            this.panel10.Location = new System.Drawing.Point(813, 13);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(333, 47);
            this.panel10.TabIndex = 26;
            // 
            // btndebug
            // 
            this.btndebug.ForeColor = System.Drawing.Color.Black;
            this.btndebug.Location = new System.Drawing.Point(209, 11);
            this.btndebug.Margin = new System.Windows.Forms.Padding(4);
            this.btndebug.Name = "btndebug";
            this.btndebug.Size = new System.Drawing.Size(81, 28);
            this.btndebug.TabIndex = 11;
            this.btndebug.Text = "Debug";
            this.btndebug.UseVisualStyleBackColor = true;
            this.btndebug.Click += new System.EventHandler(this.btndebug_Click);
            // 
            // cboxdebug
            // 
            this.cboxdebug.AutoSize = true;
            this.cboxdebug.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboxdebug.Location = new System.Drawing.Point(130, 18);
            this.cboxdebug.Margin = new System.Windows.Forms.Padding(4);
            this.cboxdebug.Name = "cboxdebug";
            this.cboxdebug.Size = new System.Drawing.Size(71, 21);
            this.cboxdebug.TabIndex = 0;
            this.cboxdebug.Text = "Debug";
            this.cboxdebug.UseVisualStyleBackColor = true;
            this.cboxdebug.CheckedChanged += new System.EventHandler(this.cboxdebug_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Debug mode";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.Color.DimGray;
            this.codeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeListBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeListBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 18;
            this.codeListBox.Location = new System.Drawing.Point(-1, 20);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.ScrollAlwaysVisible = true;
            this.codeListBox.Size = new System.Drawing.Size(433, 306);
            this.codeListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code C++";
            // 
            // HienThiPanel
            // 
            this.HienThiPanel.BackColor = System.Drawing.Color.DimGray;
            this.HienThiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HienThiPanel.Controls.Add(this.label2);
            this.HienThiPanel.Controls.Add(this.codeListBox);
            this.HienThiPanel.Font = new System.Drawing.Font("Centaur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HienThiPanel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HienThiPanel.Location = new System.Drawing.Point(1373, 399);
            this.HienThiPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HienThiPanel.Name = "HienThiPanel";
            this.HienThiPanel.Size = new System.Drawing.Size(412, 446);
            this.HienThiPanel.TabIndex = 22;
            // 
            // tabctlytuong
            // 
            this.tabctlytuong.Controls.Add(this.tabPage1);
            this.tabctlytuong.Controls.Add(this.tabPage2);
            this.tabctlytuong.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctlytuong.Location = new System.Drawing.Point(1373, 178);
            this.tabctlytuong.Margin = new System.Windows.Forms.Padding(4);
            this.tabctlytuong.Name = "tabctlytuong";
            this.tabctlytuong.SelectedIndex = 0;
            this.tabctlytuong.Size = new System.Drawing.Size(412, 213);
            this.tabctlytuong.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.yTuongTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(404, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ý tưởng thuật toán";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.daydangxepListbox);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(404, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dãy đang sắp xếp";
            // 
            // lbDieuKhien
            // 
            this.lbDieuKhien.AutoSize = true;
            this.lbDieuKhien.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDieuKhien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDieuKhien.Location = new System.Drawing.Point(15, 7);
            this.lbDieuKhien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDieuKhien.Name = "lbDieuKhien";
            this.lbDieuKhien.Size = new System.Drawing.Size(109, 21);
            this.lbDieuKhien.TabIndex = 14;
            this.lbDieuKhien.Text = "Điều Khiển";
            // 
            // dungbtn
            // 
            this.dungbtn.Location = new System.Drawing.Point(117, 67);
            this.dungbtn.Margin = new System.Windows.Forms.Padding(4);
            this.dungbtn.Name = "dungbtn";
            this.dungbtn.Size = new System.Drawing.Size(81, 28);
            this.dungbtn.TabIndex = 9;
            this.dungbtn.Text = "Dừng";
            this.dungbtn.UseVisualStyleBackColor = true;
            this.dungbtn.Click += new System.EventHandler(this.dungbtn_Click);
            // 
            // batdaubtn
            // 
            this.batdaubtn.Location = new System.Drawing.Point(19, 67);
            this.batdaubtn.Margin = new System.Windows.Forms.Padding(4);
            this.batdaubtn.Name = "batdaubtn";
            this.batdaubtn.Size = new System.Drawing.Size(81, 28);
            this.batdaubtn.TabIndex = 10;
            this.batdaubtn.Text = "Bắt đầu";
            this.batdaubtn.UseVisualStyleBackColor = true;
            this.batdaubtn.Click += new System.EventHandler(this.batdaubtn_Click);
            // 
            // huybnt
            // 
            this.huybnt.Location = new System.Drawing.Point(206, 67);
            this.huybnt.Margin = new System.Windows.Forms.Padding(4);
            this.huybnt.Name = "huybnt";
            this.huybnt.Size = new System.Drawing.Size(81, 28);
            this.huybnt.TabIndex = 8;
            this.huybnt.Text = "Hủy";
            this.huybnt.UseVisualStyleBackColor = true;
            this.huybnt.Click += new System.EventHandler(this.huybnt_Click);
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTocDo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTocDo.Location = new System.Drawing.Point(133, 25);
            this.lbTocDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(68, 21);
            this.lbTocDo.TabIndex = 4;
            this.lbTocDo.Text = "Tốc độ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(333, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "00:00";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(209, 12);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(180, 39);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(397, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "5\r\n";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // dieukhienpanel
            // 
            this.dieukhienpanel.BackColor = System.Drawing.Color.DimGray;
            this.dieukhienpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dieukhienpanel.Controls.Add(this.label1);
            this.dieukhienpanel.Controls.Add(this.trackBar1);
            this.dieukhienpanel.Controls.Add(this.label11);
            this.dieukhienpanel.Controls.Add(this.lbTocDo);
            this.dieukhienpanel.Controls.Add(this.huybnt);
            this.dieukhienpanel.Controls.Add(this.batdaubtn);
            this.dieukhienpanel.Controls.Add(this.dungbtn);
            this.dieukhienpanel.Controls.Add(this.lbDieuKhien);
            this.dieukhienpanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieukhienpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dieukhienpanel.Location = new System.Drawing.Point(374, 13);
            this.dieukhienpanel.Margin = new System.Windows.Forms.Padding(4);
            this.dieukhienpanel.Name = "dieukhienpanel";
            this.dieukhienpanel.Size = new System.Drawing.Size(431, 101);
            this.dieukhienpanel.TabIndex = 23;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1798, 858);
            this.Controls.Add(this.huypanel);
            this.Controls.Add(this.HienThiPanel);
            this.Controls.Add(this.tabctlytuong);
            this.Controls.Add(this.sapxepPanel);
            this.Controls.Add(this.Loaisapxeppanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.thuattoanpanel);
            this.Controls.Add(this.khoitaopanel);
            this.Controls.Add(this.dieukhienpanel);
            this.Controls.Add(this.chuasapxepPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Sorting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed_1);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.huypanel.ResumeLayout(false);
            this.huypanel.PerformLayout();
            this.chuasapxepPanel.ResumeLayout(false);
            this.thuattoanpanel.ResumeLayout(false);
            this.thuattoanpanel.PerformLayout();
            this.Loaisapxeppanel.ResumeLayout(false);
            this.Loaisapxeppanel.PerformLayout();
            this.khoitaopanel.ResumeLayout(false);
            this.khoitaopanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.HienThiPanel.ResumeLayout(false);
            this.HienThiPanel.PerformLayout();
            this.tabctlytuong.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.dieukhienpanel.ResumeLayout(false);
            this.dieukhienpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHuy;
        private System.Windows.Forms.Label lbKhoiTao;
        private System.Windows.Forms.Label lbThuatToan;
        private System.Windows.Forms.Label lbSapXep;
        private System.Windows.Forms.Label lbMangChuaSapXep;
        private System.Windows.Forms.Panel sapxepPanel;
        private System.Windows.Forms.Panel chuasapxepPanel;
        private System.Windows.Forms.Panel thuattoanpanel;
        private System.Windows.Forms.RadioButton interchangerdbtn;
        private System.Windows.Forms.Panel Loaisapxeppanel;
        private System.Windows.Forms.Panel khoitaopanel;
        private System.Windows.Forms.Panel huypanel;
        private System.Windows.Forms.RadioButton insertionrdbtn;
        private System.Windows.Forms.RadioButton mergerdbtn;
        private System.Windows.Forms.RadioButton quickrdbtn;
        private System.Windows.Forms.RadioButton selectionrdbtn;
        private System.Windows.Forms.RadioButton bubblerdbtn;
        private System.Windows.Forms.RadioButton giamrdbtn;
        private System.Windows.Forms.RadioButton tangrdbtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbSoPhanTu;
        private System.Windows.Forms.Button venutbtn;
        private System.Windows.Forms.Button taongaunhienbtn;
        private System.Windows.Forms.Button thoatbtn;
        private System.Windows.Forms.Button xoamangbtn;
        private System.Windows.Forms.TextBox soluongNodetbx;
        private TextBox yTuongTextBox;
        private Timer timer1;
        private ListBox codeListBox;
        private Label label2;
        private Panel HienThiPanel;
        private ListBox daydangxepListbox;
        private Button nhaptaybtn;
        private Label label3;
        private CheckBox cboxdebug;
        private TabControl tabctlytuong;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btndebug;
        private Label lbDieuKhien;
        private Button dungbtn;
        private Button batdaubtn;
        private Button huybnt;
        private Label lbTocDo;
        private Label label11;
        private TrackBar trackBar1;
        private Label label1;
        private Panel dieukhienpanel;
    }
}

