
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class DanhSachNhanVienForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.grvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbDateWork = new System.Windows.Forms.Label();
            this.dtpDateWork = new System.Windows.Forms.DateTimePicker();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbThemNhanVien = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.lbCapTaiKhoan = new System.Windows.Forms.Label();
            this.btnCapTaiKhoan = new System.Windows.Forms.Button();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbIdUser = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnRandPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.9F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 522.1F)});
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.panel3);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 358F)});
            this.tablePanel1.Size = new System.Drawing.Size(1488, 814);
            this.tablePanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 1);
            this.panel2.Controls.Add(this.btnThemNhanVien);
            this.panel2.Controls.Add(this.cbRole);
            this.panel2.Controls.Add(this.cbGender);
            this.panel2.Controls.Add(this.dtpDateWork);
            this.panel2.Controls.Add(this.lbRole);
            this.panel2.Controls.Add(this.dtpBirth);
            this.panel2.Controls.Add(this.lbGender);
            this.panel2.Controls.Add(this.lbPhone);
            this.panel2.Controls.Add(this.lbAddress);
            this.panel2.Controls.Add(this.lbSalary);
            this.panel2.Controls.Add(this.lbDateWork);
            this.panel2.Controls.Add(this.lbCMND);
            this.panel2.Controls.Add(this.lbBirth);
            this.panel2.Controls.Add(this.lbThemNhanVien);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtCMND);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(969, 3);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 0);
            this.panel2.Size = new System.Drawing.Size(516, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.gridNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanel1.SetRow(this.panel1, 0);
            this.tablePanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(960, 808);
            this.panel1.TabIndex = 0;
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhanVien.Location = new System.Drawing.Point(5, 5);
            this.gridNhanVien.MainView = this.grvNhanVien;
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.Size = new System.Drawing.Size(950, 798);
            this.gridNhanVien.TabIndex = 0;
            this.gridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhanVien});
            // 
            // grvNhanVien
            // 
            this.grvNhanVien.GridControl = this.gridNhanVien;
            this.grvNhanVien.Name = "grvNhanVien";
            this.grvNhanVien.OptionsFind.AlwaysVisible = true;
            this.grvNhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvNhanVien_RowClick);
            this.grvNhanVien.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvNhanVien_RowUpdated);
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 1);
            this.panel3.Controls.Add(this.btnRandPass);
            this.panel3.Controls.Add(this.btnCapTaiKhoan);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lbCapTaiKhoan);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtAccount);
            this.panel3.Controls.Add(this.txtIdUser);
            this.panel3.Controls.Add(this.lbPassword);
            this.panel3.Controls.Add(this.lbAccount);
            this.panel3.Controls.Add(this.lbIdUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(969, 459);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(516, 352);
            this.panel3.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(16, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(482, 25);
            this.txtName.TabIndex = 0;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(16, 182);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(238, 25);
            this.txtCMND.TabIndex = 0;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(260, 298);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(238, 25);
            this.txtSalary.TabIndex = 0;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(16, 241);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(482, 25);
            this.txtAddress.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 5);
            this.panel4.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 50);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 15);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ tên";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.Location = new System.Drawing.Point(16, 106);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(60, 15);
            this.lbBirth.TabIndex = 1;
            this.lbBirth.Text = "Ngày sinh";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(16, 124);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(312, 25);
            this.dtpBirth.TabIndex = 2;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(331, 106);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(52, 15);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Giới tính";
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(334, 124);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(164, 25);
            this.cbGender.TabIndex = 3;
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(16, 164);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(78, 15);
            this.lbCMND.TabIndex = 1;
            this.lbCMND.Text = "CMND/CCCD";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(260, 182);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(238, 25);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(257, 164);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(77, 15);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(16, 223);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(44, 15);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbDateWork
            // 
            this.lbDateWork.AutoSize = true;
            this.lbDateWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateWork.Location = new System.Drawing.Point(16, 280);
            this.lbDateWork.Name = "lbDateWork";
            this.lbDateWork.Size = new System.Drawing.Size(80, 15);
            this.lbDateWork.TabIndex = 1;
            this.lbDateWork.Text = "Ngày vào làm";
            // 
            // dtpDateWork
            // 
            this.dtpDateWork.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateWork.Location = new System.Drawing.Point(16, 298);
            this.dtpDateWork.Name = "dtpDateWork";
            this.dtpDateWork.Size = new System.Drawing.Size(238, 25);
            this.dtpDateWork.TabIndex = 2;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(257, 280);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(97, 15);
            this.lbSalary.TabIndex = 1;
            this.lbSalary.Text = "Lương khởi điểm";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(13, 339);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(70, 15);
            this.lbRole.TabIndex = 1;
            this.lbRole.Text = "Phân quyền";
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbRole.Location = new System.Drawing.Point(16, 357);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(482, 25);
            this.cbRole.TabIndex = 3;
            // 
            // lbThemNhanVien
            // 
            this.lbThemNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThemNhanVien.AutoSize = true;
            this.lbThemNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lbThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbThemNhanVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbThemNhanVien.Location = new System.Drawing.Point(167, 17);
            this.lbThemNhanVien.Name = "lbThemNhanVien";
            this.lbThemNhanVien.Size = new System.Drawing.Size(177, 30);
            this.lbThemNhanVien.TabIndex = 1;
            this.lbThemNhanVien.Text = "Thêm nhân viên";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNhanVien.FlatAppearance.BorderSize = 3;
            this.btnThemNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.Location = new System.Drawing.Point(0, 404);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(516, 46);
            this.btnThemNhanVien.TabIndex = 6;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // lbCapTaiKhoan
            // 
            this.lbCapTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCapTaiKhoan.AutoSize = true;
            this.lbCapTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbCapTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbCapTaiKhoan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCapTaiKhoan.Location = new System.Drawing.Point(167, 19);
            this.lbCapTaiKhoan.Name = "lbCapTaiKhoan";
            this.lbCapTaiKhoan.Size = new System.Drawing.Size(155, 30);
            this.lbCapTaiKhoan.TabIndex = 1;
            this.lbCapTaiKhoan.Text = "Cấp tài khoản";
            // 
            // btnCapTaiKhoan
            // 
            this.btnCapTaiKhoan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCapTaiKhoan.FlatAppearance.BorderSize = 3;
            this.btnCapTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCapTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnCapTaiKhoan.Location = new System.Drawing.Point(0, 313);
            this.btnCapTaiKhoan.Name = "btnCapTaiKhoan";
            this.btnCapTaiKhoan.Size = new System.Drawing.Size(516, 39);
            this.btnCapTaiKhoan.TabIndex = 7;
            this.btnCapTaiKhoan.Text = "Cấp tài khoản";
            this.btnCapTaiKhoan.UseVisualStyleBackColor = false;
            this.btnCapTaiKhoan.Click += new System.EventHandler(this.btnCapTaiKhoan_Click);
            // 
            // txtIdUser
            // 
            this.txtIdUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUser.Location = new System.Drawing.Point(16, 91);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(482, 29);
            this.txtIdUser.TabIndex = 0;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(16, 149);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(482, 29);
            this.txtAccount.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(16, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(367, 29);
            this.txtPassword.TabIndex = 0;
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdUser.Location = new System.Drawing.Point(13, 73);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(79, 15);
            this.lbIdUser.TabIndex = 1;
            this.lbIdUser.Text = "Mã nhân viên";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.Location = new System.Drawing.Point(13, 131);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(58, 15);
            this.lbAccount.TabIndex = 1;
            this.lbAccount.Text = "Tài khoản";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(13, 185);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // btnRandPass
            // 
            this.btnRandPass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRandPass.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRandPass.FlatAppearance.BorderSize = 3;
            this.btnRandPass.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRandPass.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRandPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandPass.ForeColor = System.Drawing.Color.White;
            this.btnRandPass.Location = new System.Drawing.Point(389, 203);
            this.btnRandPass.Name = "btnRandPass";
            this.btnRandPass.Size = new System.Drawing.Size(109, 29);
            this.btnRandPass.TabIndex = 7;
            this.btnRandPass.Text = "Tạo mật khẩu";
            this.btnRandPass.UseVisualStyleBackColor = false;
            this.btnRandPass.Click += new System.EventHandler(this.btnRandPass_Click);
            // 
            // DanhSachNhanVienForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "DanhSachNhanVienForm";
            this.Size = new System.Drawing.Size(1488, 814);
            this.Load += new System.EventHandler(this.DanhSachNhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDateWork;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDateWork;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbThemNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnCapTaiKhoan;
        private System.Windows.Forms.Label lbCapTaiKhoan;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbIdUser;
        private System.Windows.Forms.Button btnRandPass;
    }
}
