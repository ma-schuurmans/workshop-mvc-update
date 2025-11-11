using MVC_Update.Controller;
using MVC_Update.Model;
using MVC_Update.View;

namespace MVC_Update
{
    public partial class Afleveringen : Form
    {
        private readonly EpisodeController controller;

        public Afleveringen()
        {
            controller = new EpisodeController();

            InitializeComponent();

            lvEpisodes.Columns.Add("Title", 200);
            lvEpisodes.Columns.Add("Date", 100);
            lvEpisodes.Columns.Add("AuthorId", 100);

            refreshListview();
        }

        private void refreshListview()
        {
            List<EpisodeModel> episodes = controller.ReadAll();

            foreach (EpisodeModel episode in episodes)
            {
                ListViewItem lvItem = new ListViewItem([
                    episode.Title,
                    episode.Date.ToString(),
                    episode.AuthorId.ToString()]
                );

                lvItem.Tag = episode;

                lvEpisodes.Items.Add(lvItem);
            }
        }

        private void lvEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Visible = lvEpisodes.SelectedItems.Count != 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var items = lvEpisodes.SelectedItems;

            if (items.Count == 0) return;

            EpisodeUpdateView view = new EpisodeUpdateView((EpisodeModel)items[0].Tag);
            view.ShowDialog();
        }
    }
}
