using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldenRingArmorOptimizer {
    public partial class ItemForm : Form {

        public MainWindow main;
        public int editIndex = -1;

        public ItemForm() {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            var equipment = new MainWindow.Equipment() {
                name = textBoxName.Text,
                type = (MainWindow.equipType)comboBoxType.SelectedIndex,
                weight = numericUpDownWeight.Value,
                physical = numericUpDownPhys.Value,
                vsPierce = numericUpDownPierce.Value,
                vsSlash = numericUpDownSlash.Value,
                vsStrike = numericUpDownStrike.Value,
                fire = numericUpDownFire.Value,
                focus = numericUpDownFocus.Value,
                holy = numericUpDownHoly.Value,
                immunity = numericUpDownImmun.Value,
                lightning = numericUpDownLightn.Value,
                magic = numericUpDownMagic.Value,
                poise = numericUpDownPoise.Value,
                robustness = numericUpDownRobust.Value,
                vitality = numericUpDownVital.Value
            };
            if (editIndex > -1) { //Editing an item
                main.equipment[editIndex] = equipment;
            } else { //Adding an item
                main.equipment.Add(equipment);
            }
            main.lastEquip = equipment.type;
            main.refreshList();
            Close();
        }

        /*private void button1_Click(object sender, EventArgs e) {
            Random random = new Random();
            MainWindow.equipType type = (MainWindow.equipType)random.Next(0, 4);
            main.equipment.Add(new MainWindow.Equipment() {
                name = "Randomized Item!",
                type = type,
                weight = (decimal)random.NextDouble() * 10,
                physical = (decimal)random.NextDouble() * 10,
                vsPierce = (decimal)random.NextDouble() * 10,
                vsSlash = (decimal)random.NextDouble() * 10,
                vsStrike = (decimal)random.NextDouble() * 10,
                fire = (decimal)random.NextDouble() * 10,
                focus = (decimal)random.NextDouble() * 10,
                holy = (decimal)random.NextDouble() * 10,
                immunity = (decimal)random.NextDouble() * 10,
                lightning = (decimal)random.NextDouble() * 10,
                magic = (decimal)random.NextDouble() * 10,
                poise = (decimal)random.NextDouble() * 10,
                robustness = (decimal)random.NextDouble() * 10,
                vitality = (decimal)random.NextDouble() * 10
            });
            main.refreshList();
            Close();
        }*/
    }
}
