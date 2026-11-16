using System.Linq;
using Npgsql;

namespace AeroBase
{
    public partial class Form1 : Form
    {
        private DroneRepository repository;
        private string connectionString = "Host=localhost;Port=5432;Database=aerobase;" +
            "Username=postgres;Password=2903Lizok.";
        public Form1()
        {
            InitializeComponent();

            repository = new DroneRepository(connectionString);
            RefreshTable();
        }

        private void RefreshTable()
        {
            try
            {
                var drones = repository.GetAll();
                dgvDrones.DataSource = null;
                dgvDrones.DataSource = drones;

                if (dgvDrones.Columns["Id"] != null)
                    dgvDrones.Columns["Id"].Visible = false;

                lblTotalDrones.Text = drones.Count.ToString();
                lblReadyDrones.Text = drones.Count(d => d.Status == "Исправен").ToString();
                lblMaintenanceDrones.Text = drones.Count(d => d.Status == "На ТО").ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDrone_Click(object sender, EventArgs e)
        {
            try
            {
                Drone newDrone = new Drone
                {
                    Name = "Новый дрон " + DateTime.Now.Second,
                    Model = "Модель-Тест",
                    Type = "Квадрокоптер",
                    InventoryNumber = "INV-" + new Random().Next(1000, 9999),
                    Status = "Исправен"
                };

                repository.Add(newDrone);
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message);
            }
        }

        private void btnDeleteDrone_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow == null)
            {
                MessageBox.Show("Выберите БПЛА для удаления!");
                return;
            }

            Drone selectedDrone = dgvDrones.CurrentRow.DataBoundItem as Drone;

            if (selectedDrone == null) return;

            DialogResult answer = MessageBox.Show(
                "Удалить БПЛА «" + selectedDrone.Name + "»?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                try
                {
                    repository.Delete(selectedDrone.Id);
                    RefreshTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void btnEditDrone_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow == null)
            {
                MessageBox.Show("Выберите БПЛА!");
                return;
            }

            Drone selectedDrone = dgvDrones.CurrentRow.DataBoundItem as Drone;
            if (selectedDrone == null) return;

            // 1. Спрашиваем Название
            string newName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название:", "Редактирование", selectedDrone.Name);
            if (string.IsNullOrEmpty(newName)) return;

            // 2. Спрашиваем Модель
            string newModel = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите модель:", "Редактирование", selectedDrone.Model);
            if (string.IsNullOrEmpty(newModel)) return;

            // 3. Спрашиваем Тип
            string newType = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите тип:", "Редактирование", selectedDrone.Type);
            if (string.IsNullOrEmpty(newType)) return;

            // 4. Спрашиваем Инвентарный номер
            string newInv = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите инв. номер:", "Редактирование", selectedDrone.InventoryNumber);
            if (string.IsNullOrEmpty(newInv)) return;

            // 5. Спрашиваем Статус
            string newStatus = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите статус (Исправен / На ТО):", "Редактирование", selectedDrone.Status);
            if (string.IsNullOrEmpty(newStatus)) return;

            selectedDrone.Name = newName.Trim();
            selectedDrone.Model = newModel.Trim();
            selectedDrone.Type = newType.Trim();
            selectedDrone.InventoryNumber = newInv.Trim();
            selectedDrone.Status = newStatus.Trim();

            try
            {
                repository.Update(selectedDrone); 
                RefreshTable();                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
    }
}
