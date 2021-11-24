
namespace Sader_Hotkey_Creator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.browse_button = new System.Windows.Forms.Button();
            this.command_textBox = new System.Windows.Forms.TextBox();
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            this.press_button = new System.Windows.Forms.Button();
            this.hold_button = new System.Windows.Forms.Button();
            this.press_label = new System.Windows.Forms.Label();
            this.hold_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.items_dataGridView = new System.Windows.Forms.DataGridView();
            this.mini_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.startup_checkBox = new System.Windows.Forms.CheckBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.Key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.browse_button);
            this.panel1.Controls.Add(this.command_textBox);
            this.panel1.Controls.Add(this.type_comboBox);
            this.panel1.Controls.Add(this.press_button);
            this.panel1.Controls.Add(this.hold_button);
            this.panel1.Controls.Add(this.press_label);
            this.panel1.Controls.Add(this.hold_label);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "+";
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(344, 92);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(288, 29);
            this.browse_button.TabIndex = 7;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // command_textBox
            // 
            this.command_textBox.Location = new System.Drawing.Point(344, 19);
            this.command_textBox.Multiline = true;
            this.command_textBox.Name = "command_textBox";
            this.command_textBox.Size = new System.Drawing.Size(290, 67);
            this.command_textBox.TabIndex = 6;
            this.command_textBox.Text = "Command Line";
            // 
            // type_comboBox
            // 
            this.type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Location = new System.Drawing.Point(217, 58);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(121, 23);
            this.type_comboBox.TabIndex = 5;
            // 
            // press_button
            // 
            this.press_button.Location = new System.Drawing.Point(139, 19);
            this.press_button.Name = "press_button";
            this.press_button.Size = new System.Drawing.Size(63, 48);
            this.press_button.TabIndex = 4;
            this.press_button.Text = "Press Key";
            this.press_button.UseVisualStyleBackColor = true;
            this.press_button.Click += new System.EventHandler(this.press_button_Click);
            // 
            // hold_button
            // 
            this.hold_button.Location = new System.Drawing.Point(31, 21);
            this.hold_button.Name = "hold_button";
            this.hold_button.Size = new System.Drawing.Size(56, 48);
            this.hold_button.TabIndex = 3;
            this.hold_button.Text = "Hold Key";
            this.hold_button.UseVisualStyleBackColor = true;
            this.hold_button.Click += new System.EventHandler(this.hold_button_Click);
            // 
            // press_label
            // 
            this.press_label.AutoSize = true;
            this.press_label.Location = new System.Drawing.Point(135, 88);
            this.press_label.Name = "press_label";
            this.press_label.Size = new System.Drawing.Size(67, 15);
            this.press_label.TabIndex = 2;
            this.press_label.Text = "NumPad1";
            // 
            // hold_label
            // 
            this.hold_label.AutoSize = true;
            this.hold_label.Location = new System.Drawing.Point(20, 88);
            this.hold_label.Name = "hold_label";
            this.hold_label.Size = new System.Drawing.Size(67, 15);
            this.hold_label.TabIndex = 1;
            this.hold_label.Text = "NumPad1";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(646, 21);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(99, 94);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(670, 193);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 372);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // items_dataGridView
            // 
            this.items_dataGridView.AllowUserToAddRows = false;
            this.items_dataGridView.AllowUserToDeleteRows = false;
            this.items_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key1,
            this.Key2,
            this.Type,
            this.Command});
            this.items_dataGridView.Location = new System.Drawing.Point(32, 193);
            this.items_dataGridView.Name = "items_dataGridView";
            this.items_dataGridView.ReadOnly = true;
            this.items_dataGridView.RowHeadersWidth = 51;
            this.items_dataGridView.RowTemplate.Height = 24;
            this.items_dataGridView.Size = new System.Drawing.Size(614, 372);
            this.items_dataGridView.TabIndex = 3;
            this.items_dataGridView.SelectionChanged += new System.EventHandler(this.items_dataGridView_SelectionChanged);
            // 
            // mini_notifyIcon
            // 
            this.mini_notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mini_notifyIcon.BalloonTipText = "Minmized to Tray";
            this.mini_notifyIcon.BalloonTipTitle = "Sader Hotkey Creator";
            this.mini_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mini_notifyIcon.Icon")));
            this.mini_notifyIcon.Text = "Sader Hotkey Creator";
            this.mini_notifyIcon.Visible = true;
            this.mini_notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // startup_checkBox
            // 
            this.startup_checkBox.AutoSize = true;
            this.startup_checkBox.Location = new System.Drawing.Point(296, 11);
            this.startup_checkBox.Name = "startup_checkBox";
            this.startup_checkBox.Size = new System.Drawing.Size(269, 19);
            this.startup_checkBox.TabIndex = 4;
            this.startup_checkBox.Text = "Run the program On Windows Startup";
            this.startup_checkBox.UseVisualStyleBackColor = true;
            this.startup_checkBox.CheckStateChanged += new System.EventHandler(this.startup_checkBox_CheckStateChanged);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(43, 7);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(150, 24);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Fully Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Key1
            // 
            this.Key1.HeaderText = "Hold";
            this.Key1.MinimumWidth = 6;
            this.Key1.Name = "Key1";
            this.Key1.ReadOnly = true;
            this.Key1.Width = 60;
            // 
            // Key2
            // 
            this.Key2.HeaderText = "Press";
            this.Key2.MinimumWidth = 6;
            this.Key2.Name = "Key2";
            this.Key2.ReadOnly = true;
            this.Key2.Width = 60;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 85;
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.MinimumWidth = 6;
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            this.Command.Width = 252;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.startup_checkBox);
            this.Controls.Add(this.items_dataGridView);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Sader Hotkey Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button press_button;
        private System.Windows.Forms.Button hold_button;
        private System.Windows.Forms.Label press_label;
        private System.Windows.Forms.Label hold_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox command_textBox;
        private System.Windows.Forms.ComboBox type_comboBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.DataGridView items_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon mini_notifyIcon;
        private System.Windows.Forms.CheckBox startup_checkBox;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
    }
}

