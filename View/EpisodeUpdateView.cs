using MVC_Update.Controller;
using MVC_Update.Model;

namespace MVC_Update.View
{
    public partial class EpisodeUpdateView : Form
    {
        private readonly EpisodeController controller;

        public EpisodeUpdateView(EpisodeModel model)
        {
            controller = new EpisodeController();

            InitializeComponent();

            Text = model.Title + " - Bijwerken";

            tbTitle.Text = model.Title;
            dtpDate.Value = new DateTime(model.Date, new TimeOnly());
            tbAuthor.Text = model.AuthorId.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Implementeer
            controller.Update();

            // Wanneer succesvol
            MessageBox.Show("Aflevering bijgewerkt.");
            Close();
        }
    }
}
