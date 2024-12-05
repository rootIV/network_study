namespace Mult_Conn_Client_GUI;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        Btn_Connect = new Button();
        Btn_Send = new Button();
        Btn_Close = new Button();
        Txt_Msg = new TextBox();
        SuspendLayout();
        // 
        // Btn_Connect
        // 
        Btn_Connect.Location = new Point(12, 12);
        Btn_Connect.Name = "Btn_Connect";
        Btn_Connect.Size = new Size(140, 23);
        Btn_Connect.TabIndex = 0;
        Btn_Connect.Text = "Connect";
        Btn_Connect.UseVisualStyleBackColor = true;
        Btn_Connect.Click += Btn_Connect_Click;
        // 
        // Btn_Send
        // 
        Btn_Send.Location = new Point(12, 70);
        Btn_Send.Name = "Btn_Send";
        Btn_Send.Size = new Size(140, 23);
        Btn_Send.TabIndex = 1;
        Btn_Send.Text = "Send";
        Btn_Send.UseVisualStyleBackColor = true;
        Btn_Send.Click += Btn_Send_Click;
        // 
        // Btn_Close
        // 
        Btn_Close.Location = new Point(12, 99);
        Btn_Close.Name = "Btn_Close";
        Btn_Close.Size = new Size(140, 23);
        Btn_Close.TabIndex = 2;
        Btn_Close.Text = "Close";
        Btn_Close.UseVisualStyleBackColor = true;
        Btn_Close.Click += Btn_Close_Click;
        // 
        // Txt_Msg
        // 
        Txt_Msg.Location = new Point(12, 41);
        Txt_Msg.Name = "Txt_Msg";
        Txt_Msg.Size = new Size(140, 23);
        Txt_Msg.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(165, 134);
        Controls.Add(Txt_Msg);
        Controls.Add(Btn_Close);
        Controls.Add(Btn_Send);
        Controls.Add(Btn_Connect);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button Btn_Connect;
    private Button Btn_Send;
    private Button Btn_Close;
    private TextBox Txt_Msg;
}
