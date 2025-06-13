namespace KursovaCS;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        bx1 = new System.Windows.Forms.TextBox();
        by1 = new System.Windows.Forms.TextBox();
        bx2 = new System.Windows.Forms.TextBox();
        by2 = new System.Windows.Forms.TextBox();
        bx3 = new System.Windows.Forms.TextBox();
        by3 = new System.Windows.Forms.TextBox();
        bx4 = new System.Windows.Forms.TextBox();
        by4 = new System.Windows.Forms.TextBox();
        addFigure = new System.Windows.Forms.Button();
        typeChoose = new System.Windows.Forms.ComboBox();
        label6 = new System.Windows.Forms.Label();
        containerView = new System.Windows.Forms.DataGridView();
        clearBtn = new System.Windows.Forms.Button();
        readFileBtn = new System.Windows.Forms.Button();
        writeFileBtn = new System.Windows.Forms.Button();
        areaBtn = new System.Windows.Forms.Button();
        vertOperationsBtn = new System.Windows.Forms.Button();
        moveBtn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)containerView).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(22, 13);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(265, 25);
        label1.TabIndex = 0;
        label1.Text = "ВВЕДЕННЯ ДАНИХ ФІГУРИ";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(23, 55);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(90, 25);
        label2.TabIndex = 1;
        label2.Text = "Тип фігури";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(22, 125);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(90, 25);
        label3.TabIndex = 2;
        label3.Text = "Веришини";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(22, 169);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(24, 25);
        label4.TabIndex = 3;
        label4.Text = "X";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(88, 169);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(24, 25);
        label5.TabIndex = 4;
        label5.Text = "Y";
        // 
        // bx1
        // 
        bx1.Location = new System.Drawing.Point(20, 197);
        bx1.Name = "bx1";
        bx1.Size = new System.Drawing.Size(25, 23);
        bx1.TabIndex = 5;
        // 
        // by1
        // 
        by1.Location = new System.Drawing.Point(87, 197);
        by1.Name = "by1";
        by1.Size = new System.Drawing.Size(25, 23);
        by1.TabIndex = 6;
        // 
        // bx2
        // 
        bx2.Location = new System.Drawing.Point(22, 238);
        bx2.Name = "bx2";
        bx2.Size = new System.Drawing.Size(25, 23);
        bx2.TabIndex = 7;
        // 
        // by2
        // 
        by2.Location = new System.Drawing.Point(88, 238);
        by2.Name = "by2";
        by2.Size = new System.Drawing.Size(25, 23);
        by2.TabIndex = 8;
        // 
        // bx3
        // 
        bx3.Location = new System.Drawing.Point(22, 286);
        bx3.Name = "bx3";
        bx3.Size = new System.Drawing.Size(25, 23);
        bx3.TabIndex = 9;
        // 
        // by3
        // 
        by3.Location = new System.Drawing.Point(88, 286);
        by3.Name = "by3";
        by3.Size = new System.Drawing.Size(25, 23);
        by3.TabIndex = 10;
        // 
        // bx4
        // 
        bx4.Location = new System.Drawing.Point(22, 329);
        bx4.Name = "bx4";
        bx4.Size = new System.Drawing.Size(25, 23);
        bx4.TabIndex = 11;
        // 
        // by4
        // 
        by4.Location = new System.Drawing.Point(88, 329);
        by4.Name = "by4";
        by4.Size = new System.Drawing.Size(25, 23);
        by4.TabIndex = 12;
        // 
        // addFigure
        // 
        addFigure.Location = new System.Drawing.Point(6, 358);
        addFigure.Name = "addFigure";
        addFigure.Size = new System.Drawing.Size(124, 31);
        addFigure.TabIndex = 13;
        addFigure.Text = "Додати фігуру";
        addFigure.UseVisualStyleBackColor = true;
        // 
        // typeChoose
        // 
        typeChoose.FormattingEnabled = true;
        typeChoose.Location = new System.Drawing.Point(22, 83);
        typeChoose.Name = "typeChoose";
        typeChoose.Size = new System.Drawing.Size(176, 23);
        typeChoose.TabIndex = 14;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(480, 13);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(126, 25);
        label6.TabIndex = 15;
        label6.Text = "Контейнер";
        // 
        // containerView
        // 
        containerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        containerView.GridColor = System.Drawing.SystemColors.Info;
        containerView.Location = new System.Drawing.Point(278, 55);
        containerView.Name = "containerView";
        containerView.Size = new System.Drawing.Size(514, 297);
        containerView.TabIndex = 16;
        containerView.Text = "dataGridView1";
        // 
        // clearBtn
        // 
        clearBtn.Location = new System.Drawing.Point(668, 358);
        clearBtn.Name = "clearBtn";
        clearBtn.Size = new System.Drawing.Size(124, 81);
        clearBtn.TabIndex = 17;
        clearBtn.Text = "Очистити";
        clearBtn.UseVisualStyleBackColor = true;
        // 
        // readFileBtn
        // 
        readFileBtn.Location = new System.Drawing.Point(538, 358);
        readFileBtn.Name = "readFileBtn";
        readFileBtn.Size = new System.Drawing.Size(124, 81);
        readFileBtn.TabIndex = 18;
        readFileBtn.Text = "Читання з файлу";
        readFileBtn.UseVisualStyleBackColor = true;
        // 
        // writeFileBtn
        // 
        writeFileBtn.Location = new System.Drawing.Point(408, 358);
        writeFileBtn.Name = "writeFileBtn";
        writeFileBtn.Size = new System.Drawing.Size(124, 81);
        writeFileBtn.TabIndex = 19;
        writeFileBtn.Text = "Запис у файл";
        writeFileBtn.UseVisualStyleBackColor = true;
        // 
        // areaBtn
        // 
        areaBtn.Location = new System.Drawing.Point(278, 358);
        areaBtn.Name = "areaBtn";
        areaBtn.Size = new System.Drawing.Size(124, 81);
        areaBtn.TabIndex = 20;
        areaBtn.Text = "Фігура з найбільшою площею";
        areaBtn.UseVisualStyleBackColor = true;
        // 
        // vertOperationsBtn
        // 
        vertOperationsBtn.Location = new System.Drawing.Point(6, 395);
        vertOperationsBtn.Name = "vertOperationsBtn";
        vertOperationsBtn.Size = new System.Drawing.Size(124, 44);
        vertOperationsBtn.TabIndex = 21;
        vertOperationsBtn.Text = "Операції з веришанми";
        vertOperationsBtn.UseVisualStyleBackColor = true;
        // 
        // moveBtn
        // 
        moveBtn.Location = new System.Drawing.Point(136, 358);
        moveBtn.Name = "moveBtn";
        moveBtn.Size = new System.Drawing.Size(124, 81);
        moveBtn.TabIndex = 22;
        moveBtn.Text = "Переміщення фігур";
        moveBtn.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(moveBtn);
        Controls.Add(vertOperationsBtn);
        Controls.Add(areaBtn);
        Controls.Add(writeFileBtn);
        Controls.Add(readFileBtn);
        Controls.Add(clearBtn);
        Controls.Add(containerView);
        Controls.Add(label6);
        Controls.Add(typeChoose);
        Controls.Add(addFigure);
        Controls.Add(by4);
        Controls.Add(bx4);
        Controls.Add(by3);
        Controls.Add(bx3);
        Controls.Add(by2);
        Controls.Add(bx2);
        Controls.Add(by1);
        Controls.Add(bx1);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)containerView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView containerView;
    private System.Windows.Forms.Button clearBtn;
    private System.Windows.Forms.Button readFileBtn;
    private System.Windows.Forms.Button writeFileBtn;
    private System.Windows.Forms.Button areaBtn;
    private System.Windows.Forms.Button vertOperationsBtn;
    private System.Windows.Forms.Button moveBtn;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.ComboBox typeChoose;

    private System.Windows.Forms.TextBox bx1;
    private System.Windows.Forms.TextBox by1;
    private System.Windows.Forms.TextBox bx2;
    private System.Windows.Forms.TextBox by2;
    private System.Windows.Forms.TextBox bx3;
    private System.Windows.Forms.TextBox by3;
    private System.Windows.Forms.TextBox bx4;
    private System.Windows.Forms.TextBox by4;
    private System.Windows.Forms.Button addFigure;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}