using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab04
{
    public partial class FormMain : Form
    {
        private Client _client;
        private Room _room;
        public FormMain()
        {
            InitializeComponent();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _client = new Client();
            FormClient formClient = new FormClient(_client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _client = formClient.Client;
            }
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient(_client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _client = formClient.Client;
            }
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _room = new Room();
            FormRoom formRoom = new FormRoom(_room);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                _room = formRoom.Room;
            }
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom(_room);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                _room = formRoom.Room;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
