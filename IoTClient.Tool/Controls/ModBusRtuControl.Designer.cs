﻿namespace IoTClient.Tool.Controls
{
    partial class ModBusRtuControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.but_read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.but_write = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_float = new System.Windows.Forms.RadioButton();
            this.rd_double = new System.Windows.Forms.RadioButton();
            this.rd_short = new System.Windows.Forms.RadioButton();
            this.rd_bit = new System.Windows.Forms.RadioButton();
            this.rd_ulong = new System.Windows.Forms.RadioButton();
            this.rd_ushort = new System.Windows.Forms.RadioButton();
            this.rd_long = new System.Windows.Forms.RadioButton();
            this.rd_int = new System.Windows.Forms.RadioButton();
            this.rd_uint = new System.Windows.Forms.RadioButton();
            this.txt_baudRate = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stopBit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dataBit = new System.Windows.Forms.TextBox();
            this.cb_portNameSend = new System.Windows.Forms.ComboBox();
            this.but_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_open = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_read
            // 
            this.but_read.Location = new System.Drawing.Point(183, 14);
            this.but_read.Name = "but_read";
            this.but_read.Size = new System.Drawing.Size(75, 23);
            this.but_read.TabIndex = 7;
            this.but_read.Text = "读取";
            this.but_read.UseVisualStyleBackColor = true;
            this.but_read.Click += new System.EventHandler(this.but_read_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "地址";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(43, 16);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(121, 21);
            this.txt_address.TabIndex = 9;
            // 
            // but_write
            // 
            this.but_write.Location = new System.Drawing.Point(479, 14);
            this.but_write.Name = "but_write";
            this.but_write.Size = new System.Drawing.Size(75, 23);
            this.but_write.TabIndex = 10;
            this.but_write.Text = "写入";
            this.but_write.UseVisualStyleBackColor = true;
            this.but_write.Click += new System.EventHandler(this.butWrite_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(359, 15);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 21);
            this.txt_value.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.but_read);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_address);
            this.groupBox3.Controls.Add(this.but_write);
            this.groupBox3.Controls.Add(this.txt_value);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 47);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(771, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "显示报文";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "值";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(768, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "清空数据";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.rd_float);
            this.groupBox1.Controls.Add(this.rd_double);
            this.groupBox1.Controls.Add(this.rd_short);
            this.groupBox1.Controls.Add(this.rd_bit);
            this.groupBox1.Controls.Add(this.rd_ulong);
            this.groupBox1.Controls.Add(this.rd_ushort);
            this.groupBox1.Controls.Add(this.rd_long);
            this.groupBox1.Controls.Add(this.rd_int);
            this.groupBox1.Controls.Add(this.rd_uint);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 50);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // rd_float
            // 
            this.rd_float.AutoSize = true;
            this.rd_float.Location = new System.Drawing.Point(436, 23);
            this.rd_float.Name = "rd_float";
            this.rd_float.Size = new System.Drawing.Size(53, 16);
            this.rd_float.TabIndex = 22;
            this.rd_float.Text = "float";
            this.rd_float.UseVisualStyleBackColor = true;
            // 
            // rd_double
            // 
            this.rd_double.AutoSize = true;
            this.rd_double.Location = new System.Drawing.Point(495, 23);
            this.rd_double.Name = "rd_double";
            this.rd_double.Size = new System.Drawing.Size(59, 16);
            this.rd_double.TabIndex = 23;
            this.rd_double.Text = "double";
            this.rd_double.UseVisualStyleBackColor = true;
            // 
            // rd_short
            // 
            this.rd_short.AutoSize = true;
            this.rd_short.Checked = true;
            this.rd_short.Location = new System.Drawing.Point(70, 23);
            this.rd_short.Name = "rd_short";
            this.rd_short.Size = new System.Drawing.Size(53, 16);
            this.rd_short.TabIndex = 6;
            this.rd_short.TabStop = true;
            this.rd_short.Text = "short";
            this.rd_short.UseVisualStyleBackColor = true;
            // 
            // rd_bit
            // 
            this.rd_bit.AutoSize = true;
            this.rd_bit.Location = new System.Drawing.Point(11, 23);
            this.rd_bit.Name = "rd_bit";
            this.rd_bit.Size = new System.Drawing.Size(47, 16);
            this.rd_bit.TabIndex = 16;
            this.rd_bit.Text = "线圈";
            this.rd_bit.UseVisualStyleBackColor = true;
            // 
            // rd_ulong
            // 
            this.rd_ulong.AutoSize = true;
            this.rd_ulong.Location = new System.Drawing.Point(374, 23);
            this.rd_ulong.Name = "rd_ulong";
            this.rd_ulong.Size = new System.Drawing.Size(53, 16);
            this.rd_ulong.TabIndex = 21;
            this.rd_ulong.Text = "ulong";
            this.rd_ulong.UseVisualStyleBackColor = true;
            // 
            // rd_ushort
            // 
            this.rd_ushort.AutoSize = true;
            this.rd_ushort.Location = new System.Drawing.Point(129, 23);
            this.rd_ushort.Name = "rd_ushort";
            this.rd_ushort.Size = new System.Drawing.Size(59, 16);
            this.rd_ushort.TabIndex = 17;
            this.rd_ushort.Text = "ushort";
            this.rd_ushort.UseVisualStyleBackColor = true;
            // 
            // rd_long
            // 
            this.rd_long.AutoSize = true;
            this.rd_long.Location = new System.Drawing.Point(315, 23);
            this.rd_long.Name = "rd_long";
            this.rd_long.Size = new System.Drawing.Size(47, 16);
            this.rd_long.TabIndex = 20;
            this.rd_long.Text = "long";
            this.rd_long.UseVisualStyleBackColor = true;
            // 
            // rd_int
            // 
            this.rd_int.AutoSize = true;
            this.rd_int.Location = new System.Drawing.Point(194, 23);
            this.rd_int.Name = "rd_int";
            this.rd_int.Size = new System.Drawing.Size(41, 16);
            this.rd_int.TabIndex = 18;
            this.rd_int.Text = "int";
            this.rd_int.UseVisualStyleBackColor = true;
            // 
            // rd_uint
            // 
            this.rd_uint.AutoSize = true;
            this.rd_uint.Location = new System.Drawing.Point(253, 23);
            this.rd_uint.Name = "rd_uint";
            this.rd_uint.Size = new System.Drawing.Size(47, 16);
            this.rd_uint.TabIndex = 19;
            this.rd_uint.Text = "uint";
            this.rd_uint.UseVisualStyleBackColor = true;
            // 
            // txt_baudRate
            // 
            this.txt_baudRate.Location = new System.Drawing.Point(131, 19);
            this.txt_baudRate.Name = "txt_baudRate";
            this.txt_baudRate.Size = new System.Drawing.Size(42, 21);
            this.txt_baudRate.TabIndex = 5;
            this.txt_baudRate.Text = "9600";
            // 
            // txt_content
            // 
            this.txt_content.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_content.Location = new System.Drawing.Point(13, 168);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_content.Size = new System.Drawing.Size(855, 272);
            this.txt_content.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_stopBit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_dataBit);
            this.groupBox2.Controls.Add(this.cb_portNameSend);
            this.groupBox2.Controls.Add(this.but_close);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.but_open);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_stationNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_baudRate);
            this.groupBox2.Location = new System.Drawing.Point(13, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 50);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "停止位";
            // 
            // txt_stopBit
            // 
            this.txt_stopBit.Location = new System.Drawing.Point(296, 19);
            this.txt_stopBit.Name = "txt_stopBit";
            this.txt_stopBit.Size = new System.Drawing.Size(24, 21);
            this.txt_stopBit.TabIndex = 22;
            this.txt_stopBit.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "数据位";
            // 
            // txt_dataBit
            // 
            this.txt_dataBit.Location = new System.Drawing.Point(219, 20);
            this.txt_dataBit.Name = "txt_dataBit";
            this.txt_dataBit.Size = new System.Drawing.Size(24, 21);
            this.txt_dataBit.TabIndex = 20;
            this.txt_dataBit.Text = "8";
            // 
            // cb_portNameSend
            // 
            this.cb_portNameSend.FormattingEnabled = true;
            this.cb_portNameSend.Location = new System.Drawing.Point(35, 20);
            this.cb_portNameSend.Name = "cb_portNameSend";
            this.cb_portNameSend.Size = new System.Drawing.Size(47, 20);
            this.cb_portNameSend.TabIndex = 18;
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(419, 19);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(75, 23);
            this.but_close.TabIndex = 17;
            this.but_close.Text = "断开";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.butClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "关闭服务";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "本地模拟服务";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // but_open
            // 
            this.but_open.Location = new System.Drawing.Point(338, 18);
            this.but_open.Name = "but_open";
            this.but_open.Size = new System.Drawing.Size(75, 23);
            this.but_open.TabIndex = 1;
            this.but_open.Text = "连接";
            this.but_open.UseVisualStyleBackColor = true;
            this.but_open.Click += new System.EventHandler(this.but_open_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "站号";
            // 
            // txt_stationNumber
            // 
            this.txt_stationNumber.Location = new System.Drawing.Point(563, 19);
            this.txt_stationNumber.Name = "txt_stationNumber";
            this.txt_stationNumber.Size = new System.Drawing.Size(35, 21);
            this.txt_stationNumber.TabIndex = 14;
            this.txt_stationNumber.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "波特率";
            // 
            // ModBusRtuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModBusRtuControl";
            this.Size = new System.Drawing.Size(880, 450);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button but_read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button but_write;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_float;
        private System.Windows.Forms.RadioButton rd_double;
        private System.Windows.Forms.RadioButton rd_short;
        private System.Windows.Forms.RadioButton rd_bit;
        private System.Windows.Forms.RadioButton rd_ulong;
        private System.Windows.Forms.RadioButton rd_ushort;
        private System.Windows.Forms.RadioButton rd_long;
        private System.Windows.Forms.RadioButton rd_int;
        private System.Windows.Forms.RadioButton rd_uint;
        private System.Windows.Forms.TextBox txt_baudRate;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_open;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stationNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_portNameSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stopBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dataBit;
    }
}