using System.Globalization;

namespace KursovaCS;

public partial class vertexFrm : Form
{
    FigureContainer figureContainer = new FigureContainer();
    public vertexFrm()
    {
        InitializeComponent();
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

    private void containerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        throw new System.NotImplementedException();
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

    private void operationBtn_Click(object sender, EventArgs e)
    {
        try
        {
            int figIndex1 = int.Parse(figureIndex1.Text);
            int figIndex2 = int.Parse(figureIndex2.Text);
            int vertIndex1 = int.Parse(vertexIndex1.Text);
            int vertIndex2 = int.Parse(vertexIndex2.Text);
            double scalar = double.Parse(scalarBox.Text, CultureInfo.InvariantCulture);
            
            Figure fig1 = figureContainer.GetFigure(figIndex1);
            Figure fig2 = figureContainer.GetFigure(figIndex2);
            
            var vertices1 = fig1.GetVertices().ToArray();
            var vertices2 = fig2.GetVertices().ToArray();

            if (vertIndex1 < 0 || vertIndex1 >= vertices1.Length ||
                vertIndex2 < 0 || vertIndex2 >= vertices2.Length)
            {
                MessageBox.Show("Невірний індекс вершини.");
                return;
            }

            Vertex v1 = vertices1[vertIndex1];
            Vertex v2 = vertices2[vertIndex2];
            
            Vertex added = v1 + v2;
            Vertex subtracted = v1 - v2;
            Vertex multiplied = v1 * scalar;
            Vertex divided;

            try
            {
                divided = v1 / scalar;
                divisionBox.Text = divided.ToString();
            }
            catch (DivideByZeroException)
            {
                divisionBox.Text = "Ділення на 0";
            }
            
            additionBox.Text = added.ToString();
            subtractionBox.Text = subtracted.ToString();
            multiplicationBox.Text = multiplied.ToString();
        }
        catch (FormatException)
        {
            MessageBox.Show("Усі поля мають бути заповнені коректними числами (індекси та скаляр).");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MessageBox.Show("Помилка: " + ex.Message);
        }
    }
}