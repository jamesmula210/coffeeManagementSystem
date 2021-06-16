namespace javaShop
{
    partial class DashBoard
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
            this.labelid = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.labelpayment = new System.Windows.Forms.Label();
            this.labelquantity = new System.Windows.Forms.Label();
            this.textid = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbquantity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textpayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(91, 110);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(42, 26);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "ID:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(91, 182);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 26);
            this.name.TabIndex = 1;
            this.name.Text = "Coffee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "JamesCafe Coffee Shop";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(91, 250);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(128, 26);
            this.type.TabIndex = 4;
            this.type.Text = "Coffee Type:";
            // 
            // labelpayment
            // 
            this.labelpayment.AutoSize = true;
            this.labelpayment.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpayment.Location = new System.Drawing.Point(91, 409);
            this.labelpayment.Name = "labelpayment";
            this.labelpayment.Size = new System.Drawing.Size(91, 26);
            this.labelpayment.TabIndex = 8;
            this.labelpayment.Text = "Payment:";
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(91, 325);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(95, 26);
            this.labelquantity.TabIndex = 7;
            this.labelquantity.Text = "Quantity:";
            // 
            // textid
            // 
            this.textid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textid.DefaultText = "";
            this.textid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textid.DisabledState.Parent = this.textid;
            this.textid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textid.FocusedState.Parent = this.textid;
            this.textid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textid.HoverState.Parent = this.textid;
            this.textid.Location = new System.Drawing.Point(244, 100);
            this.textid.Name = "textid";
            this.textid.PasswordChar = '\0';
            this.textid.PlaceholderText = "";
            this.textid.SelectedText = "";
            this.textid.ShadowDecoration.Parent = this.textid;
            this.textid.Size = new System.Drawing.Size(200, 36);
            this.textid.TabIndex = 9;
            this.textid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textid_KeyPress);
            // 
            // cmbname
            // 
            this.cmbname.BackColor = System.Drawing.Color.Transparent;
            this.cmbname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbname.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbname.FocusedState.Parent = this.cmbname;
            this.cmbname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbname.HoverState.Parent = this.cmbname;
            this.cmbname.ItemHeight = 30;
            this.cmbname.Items.AddRange(new object[] {
            "Affogato",
            "Americano",
            "Caffe Latte",
            "Caffe Mocha",
            "Caffe Au Lait",
            "Cappuccino",
            "Cold Drew Coffee",
            "Double Espresso"});
            this.cmbname.ItemsAppearance.Parent = this.cmbname;
            this.cmbname.Location = new System.Drawing.Point(244, 172);
            this.cmbname.Name = "cmbname";
            this.cmbname.ShadowDecoration.Parent = this.cmbname;
            this.cmbname.Size = new System.Drawing.Size(200, 36);
            this.cmbname.TabIndex = 10;
            // 
            // cmbtype
            // 
            this.cmbtype.BackColor = System.Drawing.Color.Transparent;
            this.cmbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtype.FocusedState.Parent = this.cmbtype;
            this.cmbtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbtype.HoverState.Parent = this.cmbtype;
            this.cmbtype.ItemHeight = 30;
            this.cmbtype.Items.AddRange(new object[] {
            "Arabica",
            "Robusta",
            "Black Coffee",
            "Latte",
            "Cappuccino",
            "Americano",
            "Espresso",
            "Doppio"});
            this.cmbtype.ItemsAppearance.Parent = this.cmbtype;
            this.cmbtype.Location = new System.Drawing.Point(244, 240);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.ShadowDecoration.Parent = this.cmbtype;
            this.cmbtype.Size = new System.Drawing.Size(200, 36);
            this.cmbtype.TabIndex = 11;
            // 
            // cmbquantity
            // 
            this.cmbquantity.BackColor = System.Drawing.Color.Transparent;
            this.cmbquantity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbquantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbquantity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbquantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbquantity.FocusedState.Parent = this.cmbquantity;
            this.cmbquantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbquantity.HoverState.Parent = this.cmbquantity;
            this.cmbquantity.ItemHeight = 30;
            this.cmbquantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbquantity.ItemsAppearance.Parent = this.cmbquantity;
            this.cmbquantity.Location = new System.Drawing.Point(244, 315);
            this.cmbquantity.Name = "cmbquantity";
            this.cmbquantity.ShadowDecoration.Parent = this.cmbquantity;
            this.cmbquantity.Size = new System.Drawing.Size(200, 36);
            this.cmbquantity.TabIndex = 12;
            // 
            // textpayment
            // 
            this.textpayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textpayment.DefaultText = "";
            this.textpayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textpayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textpayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textpayment.DisabledState.Parent = this.textpayment;
            this.textpayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textpayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textpayment.FocusedState.Parent = this.textpayment;
            this.textpayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textpayment.HoverState.Parent = this.textpayment;
            this.textpayment.Location = new System.Drawing.Point(244, 399);
            this.textpayment.Name = "textpayment";
            this.textpayment.PasswordChar = '\0';
            this.textpayment.PlaceholderText = "";
            this.textpayment.SelectedText = "";
            this.textpayment.ShadowDecoration.Parent = this.textpayment;
            this.textpayment.Size = new System.Drawing.Size(200, 36);
            this.textpayment.TabIndex = 13;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 60;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.LinkColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(932, 441);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(68, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(12, 12);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(30, 32);
            this.guna2GradientCircleButton1.TabIndex = 16;
            this.guna2GradientCircleButton1.Text = "X";
            this.guna2GradientCircleButton1.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.coffeename,
            this.coffeetype,
            this.quantity,
            this.payment});
            this.dataGridView1.Location = new System.Drawing.Point(477, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 219);
            this.dataGridView1.TabIndex = 17;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // coffeename
            // 
            this.coffeename.HeaderText = "Coffee Name";
            this.coffeename.Name = "coffeename";
            // 
            // coffeetype
            // 
            this.coffeetype.HeaderText = "Coffee Type";
            this.coffeetype.Name = "coffeetype";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            // 
            // btnInsert
            // 
            this.btnInsert.BorderRadius = 30;
            this.btnInsert.CheckedState.Parent = this.btnInsert;
            this.btnInsert.CustomImages.Parent = this.btnInsert;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.HoverState.Parent = this.btnInsert;
            this.btnInsert.Location = new System.Drawing.Point(542, 325);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ShadowDecoration.Parent = this.btnInsert;
            this.btnInsert.Size = new System.Drawing.Size(74, 45);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 30;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(925, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(70, 45);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1034, 473);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.textpayment);
            this.Controls.Add(this.cmbquantity);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.cmbname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.labelpayment);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label labelpayment;
        private System.Windows.Forms.Label labelquantity;
        private Guna.UI2.WinForms.Guna2TextBox textid;
        private Guna.UI2.WinForms.Guna2ComboBox cmbname;
        private Guna.UI2.WinForms.Guna2ComboBox cmbtype;
        private Guna.UI2.WinForms.Guna2ComboBox cmbquantity;
        private Guna.UI2.WinForms.Guna2TextBox textpayment;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.LinkLabel btnLogout;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeename;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
    }
}