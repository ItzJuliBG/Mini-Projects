using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Res
{
    public partial class CleanRoomForm : Form
    {
        List<Room> Rooms;
        MethodList methodList;
        public CleanRoomForm()
        {
            InitializeComponent();
            
            Rooms = new List<Room>();

            methodList = new MethodList();

            methodList.LoadingData(Rooms);
        }
        private void CleanRoomForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            methodList.ReturnToHome();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanRoom();
        }

        private void CleanRoom()
        {
            string input = textBox1.Text;
            if (int.TryParse(input, out _))
            {
                int inputNumber = int.Parse(input);
                if (inputNumber < 1 || inputNumber > 30)
                {
                    MessageBox.Show(ExceptionMessages.nonExistantRoomNumber);
                }
                else
                {
                    Room currentRoom = Rooms.FirstOrDefault(x => x.RoomNumber == inputNumber);

                    if (currentRoom.IsCleaned == true)
                    {
                        MessageBox.Show(ExceptionMessages.roomAlreadyCleaned);
                    }
                    else
                    {
                        currentRoom.IsCleaned = true;

                        MessageBox.Show(ExceptionMessages.roomCleanedSuccessfully);
                        var index = Rooms.IndexOf(currentRoom);
                        Rooms.RemoveAt(index);
                        Rooms.Insert(index, currentRoom);
                        string filePath2 = FilePaths.ReservationFileSavePath;
                        using (StreamWriter writer = new StreamWriter(filePath2)) //problem here with true value for append

                            foreach (var room in Rooms)
                            {
                                writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, {room.IsCleaned}, {room.IsOccupated}");
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show(ExceptionMessages.useOnlyNums);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
