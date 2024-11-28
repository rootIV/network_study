namespace Client_GUI;

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
        Listen_Btn = new Button();
        listBox1 = new ListBox();
        textBox1 = new TextBox();
        Send_Btn = new Button();
        SuspendLayout();
        // 
        // Listen_Btn
        // 
        Listen_Btn.Location = new Point(12, 12);
        Listen_Btn.Name = "Listen_Btn";
        Listen_Btn.Size = new Size(210, 23);
        Listen_Btn.TabIndex = 0;
        Listen_Btn.Text = "Listen";
        Listen_Btn.UseVisualStyleBackColor = true;
        Listen_Btn.Click += Listen_Btn_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(12, 53);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(210, 139);
        listBox1.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 211);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(210, 23);
        textBox1.TabIndex = 2;
        // 
        // Send_Btn
        // 
        Send_Btn.Location = new Point(12, 240);
        Send_Btn.Name = "Send_Btn";
        Send_Btn.Size = new Size(210, 23);
        Send_Btn.TabIndex = 3;
        Send_Btn.Text = "Send";
        Send_Btn.UseVisualStyleBackColor = true;
        Send_Btn.Click += Send_Btn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(234, 274);
        Controls.Add(Send_Btn);
        Controls.Add(textBox1);
        Controls.Add(listBox1);
        Controls.Add(Listen_Btn);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button Listen_Btn;
    private ListBox listBox1;
    private TextBox textBox1;
    private Button Send_Btn;
}
