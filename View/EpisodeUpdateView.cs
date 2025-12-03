using System.Diagnostics;
using MVC_Update.Controller;
using MVC_Update.Model;

namespace MVC_Update.View
{
    public partial class EpisodeUpdateView : Form
    {
        private readonly EpisodeModel model;
        private readonly EpisodeController controller;
        private readonly AuthorController authorController;

        public EpisodeUpdateView(EpisodeModel model)
        {
            controller = new EpisodeController();
            authorController = new AuthorController();
            this.model = model;

            InitializeComponent();

            Text = model.Title + " - Bijwerken";

            tbTitle.Text = model.Title;
            dtpDate.Value = new DateTime(model.Date, new TimeOnly());

            List<AuthorModel> authors = authorController.ReadAll();
            cboAuteur.DataSource = authors;
            cboAuteur.DisplayMember = "Name";
            cboAuteur.ValueMember = "Id";

            cboAuteur.SelectedValue = model.Author.Id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.Title = tbTitle.Text;
            model.Author = (AuthorModel) cboAuteur.SelectedItem;

            controller.Update(model);

            // Wanneer succesvol
            MessageBox.Show("Aflevering bijgewerkt.");
            Close();
        }
    }
}
