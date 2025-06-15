namespace KursovaCS;

public partial class MoveFrm : Form
{
    private FigureContainer figureContainer = new FigureContainer();

    public MoveFrm()
    {
        InitializeComponent();
    }

    private void loadBtn_Click(object sender, EventArgs e)
    {
        try
        {
            string filename = "Figures.txt";
            figureContainer.Dispose();
            figureContainer = new FigureContainer();
            figureContainer.LoadFromFile(filename);
            UpdateFiguresDisplay();

            MessageBox.Show($"Успішно завантажено {figureContainer.Count} фігур.", "Завантаження завершено",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Сталася помилка під час завантаження файлу: {ex.Message}", "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void containerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void writeBtn_Click_1(object sender, EventArgs e)
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

    private void moveBtn_Click(object sender, EventArgs e)
    {
        if (containerView.SelectedRows.Count == 0)
        {
            MessageBox.Show("Будь ласка, виберіть фігуру зі списку.");
            return;
        }

        if (!containerView.Columns.Contains("ID"))
        {
            MessageBox.Show("Стовпця 'ID' не знайдено.");
            return;
        }

        DataGridViewRow selectedRow = containerView.SelectedRows[0];
        object idValue = selectedRow.Cells["ID"].Value;

        if (idValue == null)
        {
            MessageBox.Show("Індекс фігури не вказаний.");
            return;
        }

        int index;
        if (!int.TryParse(idValue.ToString(), out index))
        {
            MessageBox.Show("Невірний індекс фігури.");
            return;
        }

        int x = 0, y = 0;
        int.TryParse(dx.Text, out x);
        int.TryParse(dy.Text, out y);

        figureContainer.MoveFigureByIndex(index, x, y);
        UpdateFiguresDisplay();
        MessageBox.Show("Фігуру успішно переміщено!");
    }
}