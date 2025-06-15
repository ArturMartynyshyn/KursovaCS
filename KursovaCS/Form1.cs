
namespace KursovaCS;

using System.Globalization;
public partial class Form1 : Form

{
    private string selectedFigureType;
    private FigureContainer figureContainer = new FigureContainer();
    
    public Form1()

    {
        InitializeComponent();
        SetupTypeComboBox();
    }
    private void SetupTypeComboBox()
    {
        typeChoose.Items.Add("Rectangle");
        typeChoose.Items.Add("Square");
        typeChoose.SelectedIndex = 0;
    }
    private void typeChoose_SelectedIndexChanged(object sender, EventArgs e)

    {
        if (typeChoose.SelectedItem == null)
        {
            return;
        }
        this.selectedFigureType = typeChoose.SelectedItem.ToString();
    }
    

    private void readFileBtn_Click(object sender, EventArgs e)
    {
        try
        {
            string filename = "Figures.txt";
            figureContainer.Dispose();
            figureContainer = new FigureContainer();
            figureContainer.LoadFromFile(filename);
            UpdateFiguresDisplay();

            MessageBox.Show($"Успішно завантажено {figureContainer.Count} фігур.", "Завантаження завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Сталася помилка під час завантаження файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void addFigure_Click(object sender, EventArgs e)
    {
        try
        {
            var vertices = new Vertex[4];

            vertices[0] = new Vertex(double.Parse(bx1.Text, CultureInfo.InvariantCulture), double.Parse(by1.Text, CultureInfo.InvariantCulture));
            vertices[1] = new Vertex(double.Parse(bx2.Text, CultureInfo.InvariantCulture), double.Parse(by2.Text, CultureInfo.InvariantCulture));
            vertices[2] = new Vertex(double.Parse(bx3.Text, CultureInfo.InvariantCulture), double.Parse(by3.Text, CultureInfo.InvariantCulture));
            vertices[3] = new Vertex(double.Parse(bx4.Text, CultureInfo.InvariantCulture), double.Parse(by4.Text, CultureInfo.InvariantCulture));

            Figure newFigure = null;

            switch (this.selectedFigureType)

            {
                case "Rectangle":
                    newFigure = new MyRectangle(vertices);
                    break;

                case "Square":
                    newFigure = new Square(vertices);
                    break;

                default:
                    MessageBox.Show("Будь ласка, оберіть тип фігури.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
            }
            this.figureContainer.AddFigure(newFigure);
            UpdateFiguresDisplay();
        }

        catch (FormatException)
        {
            MessageBox.Show("Будь ласка, введіть коректні числові значення у всі поля для координат.", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (ArgumentException ex)
        {
            MessageBox.Show($"Помилка валідації фігури: {ex.Message}", "Неправильні координати", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        catch (Exception ex)
        {
            MessageBox.Show($"Сталася невідома помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
    private void UpdateFiguresDisplay()

    {
        var displayList = new List<object>();
        for (int i = 0; i < figureContainer.Count; i++)
        {
            var fig = figureContainer[i];
            displayList.Add(new
            {
                ID = i,
                Type = fig.FigureType,
                Area = fig.CalculateArea(),
                Description = fig.ToString()
            });
        }

        containerView.DataSource = displayList;

        if (containerView.Columns.Count > 0)
        {
            containerView.Columns["ID"].HeaderText = "№";
            containerView.Columns["Type"].HeaderText = "Тип фігури";
            containerView.Columns["Area"].HeaderText = "Площа";
            containerView.Columns["Description"].HeaderText = "Координати вершин";
            containerView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
        figureContainer.Dispose();
        figureContainer = new FigureContainer();
        UpdateFiguresDisplay();
    }

    private void writeFileBtn_Click(object sender, EventArgs e)
    {
        try
        {
            string filename = "Figures.txt";
            figureContainer.SaveToFile(filename);
            MessageBox.Show("Фігури успішно записані у файл!", "Запис завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Сталася помилка під час запису у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        if (containerView.SelectedRows.Count > 0)
        {
            try
            {
                int selectedIndex = (int)containerView.SelectedRows[0].Cells["ID"].Value;
                
                figureContainer.RemoveById(selectedIndex);
                UpdateFiguresDisplay();

                MessageBox.Show("Фігуру успішно видалено!", "Видалення завершено", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася невідома помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void moveBtn_Click(object sender, EventArgs e)
    {
        MoveFrm frm = new MoveFrm();
        frm.ShowDialog();
    }

    private void label6_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void vertOperationsBtn_Click(object sender, EventArgs e)
    {
        vertexFrm frm = new vertexFrm();
        frm.ShowDialog();
    }

    private void areaBtn_Click(object sender, EventArgs e)
    {
        if (figureContainer.Count == 0)
        {
            MessageBox.Show("У контейнері немає фігур.");
            return;
        }

        Figure maxFigure = figureContainer.GetMaxAreaFigure();

        if (maxFigure != null)
        {
            double area = maxFigure.CalculateArea();
            MessageBox.Show($"Фігура з найбільшою площею: {maxFigure.FigureType}\nПлоща: {area}");
        }
        else
        {
            MessageBox.Show("Не вдалося знайти фігуру з найбільшою площею.");
        }
    }
}