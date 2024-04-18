using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Res
{
    public partial class FindingRoomForm : Form
    {
        List<Room> Rooms;
        MethodList methodList;
        public FindingRoomForm()
        {
            InitializeComponent();

            Rooms = new List<Room>();

            methodList = new MethodList();

            methodList.LoadingData(Rooms);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isInputDigit = int.TryParse(textBox1.Text, out int parsedInput);
            if (isInputDigit)
            {
                if (parsedInput < 1 || parsedInput > 30)
                {
                    MessageBox.Show(ExceptionMessages.nonExistantRoomNumber);
                }
                else
                {
                    List<Room> roomToDisplay = new();
                    roomToDisplay.Add(Rooms.FirstOrDefault(r => r.RoomNumber == parsedInput));
                    dataGridView1.DataSource = roomToDisplay;
                }
            }
            else
            {
                MessageBox.Show(ExceptionMessages.useOnlyNums);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            methodList.ReturnToHome();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}