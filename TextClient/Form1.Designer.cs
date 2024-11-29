namespace TextClient;

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
        TextBox = new RichTextBox();
        Btn_Connect = new Button();
        Btn_Send_Text = new Button();
        SuspendLayout();
        // 
        // TextBox
        // 
        TextBox.Location = new Point(12, 12);
        TextBox.Name = "TextBox";
        TextBox.Size = new Size(293, 192);
        TextBox.TabIndex = 0;
        TextBox.Text = "";
        // 
        // Btn_Connect
        // 
        Btn_Connect.Location = new Point(12, 210);
        Btn_Connect.Name = "Btn_Connect";
        Btn_Connect.Size = new Size(293, 23);
        Btn_Connect.TabIndex = 1;
        Btn_Connect.Text = "Connect";
        Btn_Connect.UseVisualStyleBackColor = true;
        Btn_Connect.Click += Btn_Connect_Click;
        // 
        // Btn_Send_Text
        // 
        Btn_Send_Text.Location = new Point(12, 239);
        Btn_Send_Text.Name = "Btn_Send_Text";
        Btn_Send_Text.Size = new Size(293, 23);
        Btn_Send_Text.TabIndex = 2;
        Btn_Send_Text.Text = "Send Text";
        Btn_Send_Text.UseVisualStyleBackColor = true;
        Btn_Send_Text.Click += Btn_Send_Text_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(317, 272);
        Controls.Add(Btn_Send_Text);
        Controls.Add(Btn_Connect);
        Controls.Add(TextBox);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private RichTextBox TextBox;
    private Button Btn_Connect;
    private Button Btn_Send_Text;
}
