using System.ComponentModel;

namespace KursovaCS;

partial class MoveFrm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        loadBtn = new System.Windows.Forms.Button();
        writeBtn = new System.Windows.Forms.Button();
        containerView = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        dx = new System.Windows.Forms.TextBox();
        dy = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        moveBtn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)containerView).BeginInit();
        SuspendLayout();
        // 
        // loadBtn
        // 
        loadBtn.Location = new System.Drawing.Point(7, 406);
        loadBtn.Name = "loadBtn";
        loadBtn.Size = new System.Drawing.Size(81, 38);
        loadBtn.TabIndex = 0;
        loadBtn.Text = "Читання з файлу";
        loadBtn.UseVisualStyleBackColor = true;
        loadBtn.Click += loadBtn_Click;
        // 
        // writeBtn
        // 
        writeBtn.Location = new System.Drawing.Point(94, 405);
        writeBtn.Name = "writeBtn";
        writeBtn.Size = new System.Drawing.Size(100, 38);
        writeBtn.TabIndex = 1;
        writeBtn.Text = "Записати у файл";
        writeBtn.UseVisualStyleBackColor = true;
        writeBtn.Click += writeBtn_Click_1;
        // 
        // containerView
        // 
        containerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        containerView.Location = new System.Drawing.Point(200, 45);
        containerView.Name = "containerView";
        containerView.Size = new System.Drawing.Size(596, 398);
        containerView.TabIndex = 2;
        containerView.Text = "dataGridView1";
        containerView.CellContentClick += containerView_CellContentClick;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(436, 6);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(127, 26);
        label1.TabIndex = 3;
        label1.Text = "Контейнер";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(10, 6);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(78, 26);
        label2.TabIndex = 4;
        label2.Text = "Вісь X";
        // 
        // dx
        // 
        dx.Location = new System.Drawing.Point(10, 64);
        dx.Name = "dx";
        dx.Size = new System.Drawing.Size(78, 23);
        dx.TabIndex = 5;
        // 
        // dy
        // 
        dy.Location = new System.Drawing.Point(116, 64);
        dy.Name = "dy";
        dy.Size = new System.Drawing.Size(78, 23);
        dy.TabIndex = 6;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(116, 6);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(78, 26);
        label3.TabIndex = 7;
        label3.Text = "Вісь Y";
        // 
        // moveBtn
        // 
        moveBtn.Location = new System.Drawing.Point(10, 123);
        moveBtn.Name = "moveBtn";
        moveBtn.Size = new System.Drawing.Size(184, 38);
        moveBtn.TabIndex = 8;
        moveBtn.Text = "Перемістити фігуру";
        moveBtn.UseVisualStyleBackColor = true;
        moveBtn.Click += moveBtn_Click;
        // 
        // MoveFrm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(moveBtn);
        Controls.Add(label3);
        Controls.Add(dy);
        Controls.Add(dx);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(containerView);
        Controls.Add(writeBtn);
        Controls.Add(loadBtn);
        Text = "MoveFrm";
        ((System.ComponentModel.ISupportInitialize)containerView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button moveBtn;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox dx;
    private System.Windows.Forms.TextBox dy;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.DataGridView containerView;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button writeBtn;

    private System.Windows.Forms.Button loadBtn;

    #endregion
}