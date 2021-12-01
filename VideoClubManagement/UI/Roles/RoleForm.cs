using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Roles
{
    public partial class RoleForm : Form
    {
        ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private readonly IValidator<Role> _validator;

        public RoleForm(Form parent)
        {
            InitializeComponent();
            _validator = new RoleValidator();
            _parent = parent;
        }

        private void refreshData()
        {
            roleDataGridView.DataSource = _applicationDbContext.Roles.ToList();
        }

        private void clearData()
        {
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            createdDateValueLabel.Text = "";
            lastUpadtedValueLabel.Text = "";
            idValueLabel.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var roles = _applicationDbContext.Roles
                .Where(r => r.Id.ToString().Contains(searchTextBox.Text)
                    || r.Name.Contains(searchTextBox.Text)
                    || r.Description.Contains(searchTextBox.Text)
                    || r.CreatedDate.ToString().Contains(searchTextBox.Text)
                    || r.LastUpdatedDate.ToString().Contains(searchTextBox.Text));

            roleDataGridView.DataSource = roles.ToList();
            roleDataGridView.Refresh();
        }

        private void exportToCSVButton_Click(object sender, EventArgs e)
        {
            var roles = _applicationDbContext.Roles.ToList();

            var lines = new List<string>
            {
                "Identificador,Name,Description,Fecha de Creación,Última fecha de actualización,Esta Activo"
            };

            foreach (var role in roles)
            {
                lines.Add($"{ role.Id }," +
                    $"{ role.Name }," +
                    $"{ role.Description }," +
                    $"{ role.CreatedDate }," +
                    $"{ role.LastUpdatedDate }," +
                    $"{ BoolHelper.BoolToYesNoString(role.IsActive) }");
            }

            FileHelper.ExportToCSV("Roles.csv", lines);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
                    "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (save)
                {
                    Role role = new Role
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        IsActive = isActiveCheckBox.Checked
                    };

                    var validationErrors = _validator.GetValidationErrors(role);

                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        _applicationDbContext.Roles.Add(role);
                        _applicationDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con exito");
                        refreshData();
                        clearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var update = MessageBox.Show($"¿Estás seguro que deseas actualizar estos datos?",
                    "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

                Role role = _applicationDbContext.Roles.Find(int.Parse(idValueLabel.Text));
                role.Name = nameTextBox.Text;
                role.Description = descriptionTextBox.Text;
                role.IsActive = isActiveCheckBox.Checked;

                if (update)
                {
                    if (role != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(role);
                        if (validationErrors != null && validationErrors.Count > 0)
                        {
                            string errors = "";
                            foreach (var validationError in validationErrors)
                                errors += $"{ validationError }{ Environment.NewLine }";

                            MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _applicationDbContext.SaveChanges();
                            MessageBox.Show("Registro actualizado con exito.");
                            refreshData();
                            clearData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar " + ex);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = _applicationDbContext.Roles.Find(int.Parse(idValueLabel.Text));
                if (role != null)
                {
                    _applicationDbContext.Roles.Remove(role);
                    _applicationDbContext.SaveChanges();
                }

                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar " + ex);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void RoleForm_Load(object sender, EventArgs e) => refreshData();

        private void roleDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(roleDataGridView.CurrentRow.Cells[2].Value.ToString());
            var role = _applicationDbContext.Roles.Find(id);
            idValueLabel.Text = role.Id.ToString();
            createdDateValueLabel.Text = role.CreatedDate.ToString("dd-MM-yyyy");
            lastUpadtedValueLabel.Text = role.LastUpdatedDate.ToString("dd-MM-yyyy");
            nameTextBox.Text = role.Name;
            descriptionTextBox.Text = role.Description;
            isActiveCheckBox.Checked = role.IsActive;
        }
    }
}
