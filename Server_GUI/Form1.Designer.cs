namespace Server_GUI;

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
        textBox1 = new TextBox();
        Connect_Btn = new Button();
        listBox1 = new ListBox();
        Send_Btn = new Button();
        textBox2 = new TextBox();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 12);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(242, 23);
        textBox1.TabIndex = 0;
        // 
        // Connect_Btn
        // 
        Connect_Btn.Location = new Point(260, 12);
        Connect_Btn.Name = "Connect_Btn";
        Connect_Btn.Size = new Size(98, 23);
        Connect_Btn.TabIndex = 1;
        Connect_Btn.Text = "Connect";
        Connect_Btn.UseVisualStyleBackColor = true;
        Connect_Btn.Click += Connect_Btn_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(12, 41);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(346, 94);
        listBox1.TabIndex = 2;
        // 
        // Send_Btn
        // 
        Send_Btn.Location = new Point(260, 141);
        Send_Btn.Name = "Send_Btn";
        Send_Btn.Size = new Size(98, 23);
        Send_Btn.TabIndex = 4;
        Send_Btn.Text = "Send";
        Send_Btn.UseVisualStyleBackColor = true;
        Send_Btn.Click += Send_Btn_Click;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(12, 141);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(242, 23);
        textBox2.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(370, 176);
        Controls.Add(Send_Btn);
        Controls.Add(textBox2);
        Controls.Add(listBox1);
        Controls.Add(Connect_Btn);
        Controls.Add(textBox1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Button Connect_Btn;
    private ListBox listBox1;
    private Button Send_Btn;
    private TextBox textBox2;
}
