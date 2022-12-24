
namespace Stock
{
    partial class dashboard
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbitemname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtammount = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.txtitmcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblitmcode = new System.Windows.Forms.Label();
            this.newradio = new System.Windows.Forms.RadioButton();
            this.existingradio = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbalanceissue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbitemsissue = new System.Windows.Forms.ComboBox();
            this.txtamountissue = new System.Windows.Forms.TextBox();
            this.cmbbranchissue = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker1issue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbsearchitem = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 669);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recieved Items";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Stock.Properties.Resources.main_background;
            this.panel1.Controls.Add(this.existingradio);
            this.panel1.Controls.Add(this.newradio);
            this.panel1.Controls.Add(this.lblitmcode);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtitmcode);
            this.panel1.Controls.Add(this.datepicker);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtitemname);
            this.panel1.Controls.Add(this.txtammount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbitemname);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(136, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 524);
            this.panel1.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 37);
            this.button2.TabIndex = 43;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbitemname
            // 
            this.cmbitemname.FormattingEnabled = true;
            this.cmbitemname.Location = new System.Drawing.Point(201, 204);
            this.cmbitemname.Name = "cmbitemname";
            this.cmbitemname.Size = new System.Drawing.Size(149, 21);
            this.cmbitemname.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Amount :";
            // 
            // txtammount
            // 
            this.txtammount.Location = new System.Drawing.Point(200, 260);
            this.txtammount.Name = "txtammount";
            this.txtammount.Size = new System.Drawing.Size(150, 20);
            this.txtammount.TabIndex = 40;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(201, 204);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(150, 20);
            this.txtitemname.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Item Name :";
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(202, 312);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(149, 20);
            this.datepicker.TabIndex = 48;
            // 
            // txtitmcode
            // 
            this.txtitmcode.Location = new System.Drawing.Point(201, 151);
            this.txtitmcode.Name = "txtitmcode";
            this.txtitmcode.Size = new System.Drawing.Size(150, 20);
            this.txtitmcode.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 37);
            this.label10.TabIndex = 38;
            this.label10.Text = "RECIEVED ITEMS";
            // 
            // lblitmcode
            // 
            this.lblitmcode.AutoSize = true;
            this.lblitmcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitmcode.Location = new System.Drawing.Point(103, 154);
            this.lblitmcode.Name = "lblitmcode";
            this.lblitmcode.Size = new System.Drawing.Size(72, 13);
            this.lblitmcode.TabIndex = 50;
            this.lblitmcode.Text = "Item Code :";
            // 
            // newradio
            // 
            this.newradio.AutoSize = true;
            this.newradio.Location = new System.Drawing.Point(101, 114);
            this.newradio.Name = "newradio";
            this.newradio.Size = new System.Drawing.Size(70, 17);
            this.newradio.TabIndex = 45;
            this.newradio.TabStop = true;
            this.newradio.Text = "New Item";
            this.newradio.UseVisualStyleBackColor = true;
            this.newradio.Click += new System.EventHandler(this.newradio_Click);
            // 
            // existingradio
            // 
            this.existingradio.AutoSize = true;
            this.existingradio.Location = new System.Drawing.Point(256, 114);
            this.existingradio.Name = "existingradio";
            this.existingradio.Size = new System.Drawing.Size(84, 17);
            this.existingradio.TabIndex = 46;
            this.existingradio.TabStop = true;
            this.existingradio.Text = "Existing Item";
            this.existingradio.UseVisualStyleBackColor = true;
            this.existingradio.Click += new System.EventHandler(this.newradio_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Search);
            this.tabPage3.Controls.Add(this.cmbsearchitem);
            this.tabPage3.Controls.Add(this.Reset);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.DataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(746, 669);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "All items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(3, 74);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(740, 587);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Selct item:";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(437, 19);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 695);
            this.tabControl1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblbalanceissue);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(480, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 62);
            this.panel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Balance :";
            // 
            // lblbalanceissue
            // 
            this.lblbalanceissue.AutoSize = true;
            this.lblbalanceissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalanceissue.Location = new System.Drawing.Point(148, 24);
            this.lblbalanceissue.Name = "lblbalanceissue";
            this.lblbalanceissue.Size = new System.Drawing.Size(14, 13);
            this.lblbalanceissue.TabIndex = 19;
            this.lblbalanceissue.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(1783, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 476);
            this.panel2.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1735, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 476);
            this.panel4.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(277, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Branch :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Amount:";
            // 
            // cmbitemsissue
            // 
            this.cmbitemsissue.FormattingEnabled = true;
            this.cmbitemsissue.Location = new System.Drawing.Point(124, 146);
            this.cmbitemsissue.Name = "cmbitemsissue";
            this.cmbitemsissue.Size = new System.Drawing.Size(123, 21);
            this.cmbitemsissue.TabIndex = 15;
            this.cmbitemsissue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtamountissue
            // 
            this.txtamountissue.Location = new System.Drawing.Point(124, 243);
            this.txtamountissue.Name = "txtamountissue";
            this.txtamountissue.Size = new System.Drawing.Size(123, 20);
            this.txtamountissue.TabIndex = 9;
            // 
            // cmbbranchissue
            // 
            this.cmbbranchissue.FormattingEnabled = true;
            this.cmbbranchissue.Location = new System.Drawing.Point(338, 247);
            this.cmbbranchissue.Name = "cmbbranchissue";
            this.cmbbranchissue.Size = new System.Drawing.Size(149, 21);
            this.cmbbranchissue.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(55, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Item :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(277, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Date:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // dateTimePicker1issue
            // 
            this.dateTimePicker1issue.Location = new System.Drawing.Point(338, 147);
            this.dateTimePicker1issue.Name = "dateTimePicker1issue";
            this.dateTimePicker1issue.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1issue.TabIndex = 18;
            this.dateTimePicker1issue.ValueChanged += new System.EventHandler(this.dateTimePicker1issue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISSUING";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 669);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item Issuing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Stock.Properties.Resources.main_background;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.dateTimePicker1issue);
            this.panel5.Controls.Add(this.cmbbranchissue);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.cmbitemsissue);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtamountissue);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(117, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 450);
            this.panel5.TabIndex = 22;
            // 
            // cmbsearchitem
            // 
            this.cmbsearchitem.Location = new System.Drawing.Point(81, 22);
            this.cmbsearchitem.Name = "cmbsearchitem";
            this.cmbsearchitem.Size = new System.Drawing.Size(225, 20);
            this.cmbsearchitem.TabIndex = 18;
            this.cmbsearchitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbsearchitem_KeyPress);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(331, 19);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button3_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(Stock.dashboard);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 695);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton existingradio;
        private System.Windows.Forms.RadioButton newradio;
        private System.Windows.Forms.Label lblitmcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtitmcode;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtammount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbitemname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1issue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbbranchissue;
        private System.Windows.Forms.TextBox txtamountissue;
        private System.Windows.Forms.ComboBox cmbitemsissue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblbalanceissue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox cmbsearchitem;
    }
}