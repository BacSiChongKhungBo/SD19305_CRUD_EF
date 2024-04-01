namespace PRL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_MaNV = new TextBox();
            txt_HoTen = new TextBox();
            txt_NgSinh = new TextBox();
            rbtn_Nam = new RadioButton();
            rbtn_Nữ = new RadioButton();
            cmbx_DiaChi = new ComboBox();
            btn_Add = new Button();
            btn_Update = new Button();
            button3 = new Button();
            btn_Clear = new Button();
            label6 = new Label();
            txt_Search = new TextBox();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 284);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 4;
            label5.Text = "Địa Chỉ";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(201, 32);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(396, 23);
            txt_MaNV.TabIndex = 5;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(201, 90);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(396, 23);
            txt_HoTen.TabIndex = 6;
            // 
            // txt_NgSinh
            // 
            txt_NgSinh.Location = new Point(201, 155);
            txt_NgSinh.Name = "txt_NgSinh";
            txt_NgSinh.Size = new Size(396, 23);
            txt_NgSinh.TabIndex = 7;
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_Nam.Location = new Point(201, 212);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new Size(92, 41);
            rbtn_Nam.TabIndex = 8;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nữ
            // 
            rbtn_Nữ.AutoSize = true;
            rbtn_Nữ.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_Nữ.Location = new Point(353, 210);
            rbtn_Nữ.Name = "rbtn_Nữ";
            rbtn_Nữ.Size = new Size(71, 41);
            rbtn_Nữ.TabIndex = 9;
            rbtn_Nữ.TabStop = true;
            rbtn_Nữ.Text = "Nữ";
            rbtn_Nữ.UseVisualStyleBackColor = true;
            // 
            // cmbx_DiaChi
            // 
            cmbx_DiaChi.FormattingEnabled = true;
            cmbx_DiaChi.Location = new Point(201, 298);
            cmbx_DiaChi.Name = "cmbx_DiaChi";
            cmbx_DiaChi.Size = new Size(396, 23);
            cmbx_DiaChi.TabIndex = 10;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(603, 32);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(185, 53);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(603, 109);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(185, 51);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(603, 190);
            button3.Name = "button3";
            button3.Size = new Size(185, 49);
            button3.TabIndex = 13;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Clear.Location = new Point(603, 272);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(185, 49);
            btn_Clear.TabIndex = 14;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 348);
            label6.Name = "label6";
            label6.Size = new Size(128, 37);
            label6.TabIndex = 15;
            label6.Text = "Tìm Kiếm";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(146, 362);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(396, 23);
            txt_Search.TabIndex = 16;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(12, 397);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(776, 291);
            dtgView.TabIndex = 17;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 700);
            Controls.Add(dtgView);
            Controls.Add(txt_Search);
            Controls.Add(label6);
            Controls.Add(btn_Clear);
            Controls.Add(button3);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(cmbx_DiaChi);
            Controls.Add(rbtn_Nữ);
            Controls.Add(rbtn_Nam);
            Controls.Add(txt_NgSinh);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_MaNV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_MaNV;
        private TextBox txt_HoTen;
        private TextBox txt_NgSinh;
        private RadioButton rbtn_Nam;
        private RadioButton rbtn_Nữ;
        private ComboBox cmbx_DiaChi;
        private Button btn_Add;
        private Button btn_Update;
        private Button button3;
        private Button btn_Clear;
        private Label label6;
        private TextBox txt_Search;
        private DataGridView dtgView;
    }
}
