using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EldenRingArmorOptimizer {
    public partial class MainWindow : Form {

        ItemForm itemForm = new ItemForm();
        BinaryFormatter formatter = new BinaryFormatter();
        string saveFolder;
        string saveFile;
        string prefFile;

        public enum equipType {
            Helmet,
            Chestpiece,
            Gloves,
            Leggings
        }
        public equipType lastEquip;

        [Serializable]
        public class SaveData {
            public int priority;
            public decimal weightLimit;
            public int maxLoad;
            public decimal extraWeight;
            public decimal maxDifference;
        };

        [Serializable]
        public class Equipment {
            public uint id;
            public bool enabled = true;
            public string name;
            public equipType type;
            public decimal weight;
            public decimal physical;
            public decimal vsStrike;
            public decimal vsSlash;
            public decimal vsPierce;
            public decimal magic;
            public decimal fire;
            public decimal lightning;
            public decimal holy;
            public decimal immunity;
            public decimal robustness;
            public decimal focus;
            public decimal vitality;
            public decimal poise;
        }
        public class Loadout {
            public uint id;
            public string helm;
            public string chest;
            public string gloves;
            public string legs;
            public decimal score;
            public decimal weight;
            public decimal physical;
            public decimal vsStrike;
            public decimal vsSlash;
            public decimal vsPierce;
            public decimal magic;
            public decimal fire;
            public decimal lightning;
            public decimal holy;
            public decimal immunity;
            public decimal robustness;
            public decimal focus;
            public decimal vitality;
            public decimal poise;
        }

        public List<Equipment> equipment;

        public MainWindow() {
            InitializeComponent();
            comboBoxDesiredLd.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 0;
            listViewResults.Items.Clear();
            listViewEquipment.Items.Clear();
            equipment = new List<Equipment>(0);
            saveFolder = AppDomain.CurrentDomain.BaseDirectory;
            saveFile = saveFolder + "\\equipment.dat";
            prefFile = saveFolder + "\\prefs.dat";
            loadData();
            refreshList(true);
        }

        private void saveData(bool isPrefs = false) {
            FileStream file;
            if (!Directory.Exists(saveFolder)) Directory.CreateDirectory(saveFolder);
            if (isPrefs) {
                if (File.Exists(prefFile)) file = File.OpenWrite(prefFile);
                else file = File.Create(prefFile);
                var data = new SaveData() {
                    extraWeight = numericUpDownExWeight.Value,
                    maxDifference = numericUpDownMaxDiff.Value,
                    weightLimit = numericUpDownWgtLimit.Value,
                    maxLoad = comboBoxDesiredLd.SelectedIndex,
                    priority = comboBoxPriority.SelectedIndex
                };
                formatter.Serialize(file, data);
            } else {
                if (File.Exists(saveFile)) file = File.OpenWrite(saveFile);
                else file = File.Create(saveFile);
                formatter.Serialize(file, equipment);
            }
            file.Close();
        }

        private void loadData() {
            FileStream file;
            if (File.Exists(saveFile)) file = File.OpenRead(saveFile);
            else return;
            equipment = (List<Equipment>)formatter.Deserialize(file);
            file.Close();
            if (File.Exists(prefFile)) file = File.OpenRead(prefFile);
            else return;
            var data = (SaveData)formatter.Deserialize(file);
            file.Close();
            numericUpDownExWeight.Value = data.extraWeight;
            numericUpDownMaxDiff.Value = data.maxDifference;
            numericUpDownWgtLimit.Value = data.weightLimit;
            comboBoxDesiredLd.SelectedIndex = data.maxLoad;
            comboBoxPriority.SelectedIndex = data.priority;
        }

        public void refreshList(bool bypassSave = false) {
            listViewEquipment.Items.Clear();
            for (int i = 0; i < equipment.Count; i++) {
                var item = equipment[i];
                item.id = (uint)i;
                var list = listViewEquipment.Items.Add(item.id.ToString());
                list.Checked = item.enabled;
                list.SubItems.Add(item.name);
                list.SubItems.Add(item.type.ToString());
                list.SubItems.Add(item.weight.ToString("0.0"));
                list.SubItems.Add((item.physical + item.vsPierce + item.vsSlash + item.vsStrike).ToString("0.0"));
                list.SubItems.Add((item.magic + item.fire + item.holy + item.lightning).ToString("0.0"));
                list.SubItems.Add((item.vitality + item.focus + item.immunity + item.robustness).ToString("0"));
                list.SubItems.Add(item.poise.ToString("0"));
            }
            if (!bypassSave) saveData();
        }

        private void initializeItemPopup() {
            itemForm = new ItemForm {
                main = this
            };
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            initializeItemPopup();
            itemForm.comboBoxType.SelectedIndex = 0;
            itemForm.comboBoxType.SelectedIndex = (int)lastEquip;
            itemForm.ShowDialog();
        }

        private void listView_Item_Click(object sender, EventArgs e) {
            initializeItemPopup();
            int i = listViewEquipment.FocusedItem.Index;
            itemForm.editIndex = i;
            var item = equipment[i];
            itemForm.comboBoxType.SelectedIndex = (int)item.type;
            itemForm.numericUpDownFire.Value = item.fire;
            itemForm.numericUpDownFocus.Value = item.focus;
            itemForm.numericUpDownHoly.Value = item.holy;
            itemForm.numericUpDownImmun.Value = item.immunity;
            itemForm.numericUpDownLightn.Value = item.lightning;
            itemForm.numericUpDownMagic.Value = item.magic;
            itemForm.numericUpDownPhys.Value = item.physical;
            itemForm.numericUpDownPierce.Value = item.vsPierce;
            itemForm.numericUpDownPoise.Value = item.poise;
            itemForm.numericUpDownRobust.Value = item.robustness;
            itemForm.numericUpDownSlash.Value = item.vsSlash;
            itemForm.numericUpDownStrike.Value = item.vsStrike;
            itemForm.numericUpDownVital.Value = item.vitality;
            itemForm.numericUpDownWeight.Value = item.weight;
            itemForm.textBoxName.Text = item.name;
            itemForm.buttonAdd.Text = "Edit Item";
            itemForm.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e) {
            equipment.RemoveAt(listViewEquipment.FocusedItem.Index);
            refreshList();
        }

        private void settingsChanged(object sender, EventArgs e) {
            saveData(true);
        }

        private async void buttonStart_Click(object sender, EventArgs e) {
            buttonStart.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            int dL = comboBoxDesiredLd.SelectedIndex; // These might not be necessary
            decimal wL = numericUpDownWgtLimit.Value; // But I put them in
            decimal xW = numericUpDownExWeight.Value; // And then fixed other stuff
            decimal mD = numericUpDownMaxDiff.Value;  // And I'm too scared to change it back
            string pI = (string)comboBoxPriority.SelectedItem;
            var l = await Task.Run(() => searchStart(dL, wL, xW, mD, pI));
            listViewResults.Items.Clear();
            foreach (var item in l) {
                var list = listViewResults.Items.Add(item.id.ToString());
                list.SubItems.Add(item.helm);
                list.SubItems.Add(item.chest);
                list.SubItems.Add(item.gloves);
                list.SubItems.Add(item.legs);
                list.SubItems.Add(item.score.ToString("0.0"));
                list.SubItems.Add(item.weight.ToString("0.0"));
                list.SubItems.Add((item.physical + item.vsPierce + item.vsSlash + item.vsStrike).ToString("0.0"));
                list.SubItems.Add((item.magic + item.fire + item.holy + item.lightning).ToString("0.0"));
                list.SubItems.Add((item.vitality + item.focus + item.immunity + item.robustness).ToString("0"));
                list.SubItems.Add(item.poise.ToString("0"));
            }
            progressBar1.Style = ProgressBarStyle.Blocks;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            buttonStart.Enabled = true;
        }

        private List<Loadout> searchStart(int desiredLoadIndex, decimal weightLimit, decimal extWeight, decimal maxDiff, string priority) {
            List<Equipment> helms = new List<Equipment>(0);
            List<Equipment> chests = new List<Equipment>(0);
            List<Equipment> gloves = new List<Equipment>(0);
            List<Equipment> legs = new List<Equipment>(0);
            Equipment blank = new Equipment {
                name = "(NONE)",
                physical = 0,
                vsPierce = 0,
                vsSlash = 0,
                vsStrike = 0,
                fire = 0,
                focus = 0,
                holy = 0,
                immunity = 0,
                lightning = 0,
                magic = 0,
                poise = 0,
                robustness = 0,
                vitality = 0
            };
            helms.Add(blank);
            chests.Add(blank);
            gloves.Add(blank);
            legs.Add(blank);
            //Console.WriteLine($"[{DateTime.Now:HH:mm:ss:fff}] Sorting all items...");
            foreach (var item in equipment) {
                switch (item.type) {
                    case equipType.Chestpiece:
                        chests.Add(item);
                        continue;
                    case equipType.Gloves:
                        gloves.Add(item);
                        continue;
                    case equipType.Helmet:
                        helms.Add(item);
                        continue;
                    case equipType.Leggings:
                        legs.Add(item);
                        continue;
                }
            }
            //Console.WriteLine($"[{DateTime.Now:HH:mm:ss:fff}] Finished sorting, starting search.");
            decimal loadMult = -1;
            switch (desiredLoadIndex) {
                case 0:
                    loadMult = 0.3m;
                    break;
                case 1:
                    loadMult = 0.7m;
                    break;
                case 2:
                    loadMult = 1;
                    break;
            }
            decimal totWeightLimit = weightLimit * loadMult;
            List<Loadout> finalEquipment = new List<Loadout>(0);
            // Madness ahead...
            foreach (var helm in helms) {
                if (!helm.enabled) continue;
                decimal currWeight = helm.weight + extWeight;
                if (loadMult > 0) {
                    if (currWeight > totWeightLimit) continue;
                }
                foreach (var chest in chests) {
                    if (!chest.enabled) continue;
                    if (loadMult > 0) {
                        currWeight = helm.weight + chest.weight + extWeight;
                        if (currWeight > totWeightLimit) continue;
                    }
                    foreach (var glove in gloves) {
                        if (!glove.enabled) continue;
                        if (loadMult > 0) {
                            currWeight = glove.weight + helm.weight + chest.weight + extWeight;
                            if (currWeight > totWeightLimit) continue;
                        }
                        foreach (var leg in legs) {
                            if (!leg.enabled) continue;
                            if (loadMult > 0) {
                                currWeight = leg.weight + glove.weight + helm.weight + chest.weight + extWeight;
                                if (currWeight > totWeightLimit) continue;
                            }
                            finalEquipment.Add(new Loadout() {
                                helm = helm.name,
                                chest = chest.name,
                                gloves = glove.name,
                                legs = leg.name,
                                weight = helm.weight + chest.weight + glove.weight + leg.weight,
                                physical = helm.physical + chest.physical + glove.physical + leg.physical,
                                vsPierce = helm.vsPierce + chest.vsPierce + glove.vsPierce + leg.vsPierce,
                                vsSlash = helm.vsSlash + chest.vsSlash + glove.vsSlash + leg.vsSlash,
                                vsStrike = helm.vsStrike + chest.vsStrike + glove.vsStrike + leg.vsStrike,
                                fire = helm.fire + chest.fire + glove.fire + leg.fire,
                                focus = helm.focus + chest.focus + glove.focus + leg.focus,
                                holy = helm.holy + chest.holy + glove.holy + leg.holy,
                                immunity = helm.immunity + chest.immunity + glove.immunity + leg.immunity,
                                lightning = helm.lightning + chest.lightning + glove.lightning + leg.lightning,
                                magic = helm.magic + chest.magic + glove.magic + leg.magic,
                                poise = helm.poise + chest.poise + glove.poise + leg.poise,
                                robustness = helm.robustness + chest.robustness + glove.robustness + leg.robustness,
                                vitality = helm.vitality + chest.vitality + glove.vitality + leg.vitality
                            });
                        }
                    }
                }
            }
            decimal targetValue = 0;
            decimal currentValue;
            //Console.WriteLine($"[{DateTime.Now:HH:mm:ss:fff}] Collated all valid item combinations, now searching for optimal entries...");
            loopStart:
            foreach (var item in finalEquipment) {
                switch (priority) {
                    case "Total Combined":
                        currentValue = item.fire + (item.focus / 10) + item.holy + (item.immunity / 10) + item.lightning + item.magic + item.physical + item.poise + (item.robustness / 10) + (item.vitality / 10) + item.vsPierce + item.vsSlash + item.vsStrike;
                        break;
                    case "Total Phys+Mag":
                        currentValue = item.fire + item.holy + item.lightning + item.magic + item.physical + item.vsPierce + item.vsSlash + item.vsStrike;
                        break;
                    case "Total Physical":
                        currentValue = item.physical + item.vsStrike + item.vsSlash + item.vsPierce;
                        break;
                    case "Total Magic":
                        currentValue = item.fire + item.holy + item.lightning + item.magic;
                        break;
                    case "Phys+Mag+Poise":
                        currentValue = item.fire + item.holy + item.lightning + item.magic + item.physical + item.vsPierce + item.vsSlash + item.vsStrike + item.poise;
                        break;
                    case "Total Resistances":
                        currentValue = item.focus + item.vitality + item.immunity + item.robustness;
                        break;
                    case "Strike":
                        currentValue = item.vsStrike;
                        break;
                    case "Slash":
                        currentValue = item.vsSlash;
                        break;
                    case "Pierce":
                        currentValue = item.vsPierce;
                        break;
                    case "Magic":
                        currentValue = item.magic;
                        break;
                    case "Fire":
                        currentValue = item.fire;
                        break;
                    case "Lightning":
                        currentValue = item.lightning;
                        break;
                    case "Holy":
                        currentValue = item.holy;
                        break;
                    case "Poise":
                        currentValue = item.poise;
                        break;
                    case "Immunity":
                        currentValue = item.immunity;
                        break;
                    case "Robustness":
                        currentValue = item.robustness;
                        break;
                    case "Focus":
                        currentValue = item.focus;
                        break;
                    case "Vitality":
                        currentValue = item.vitality;
                        break;
                    default:
                        throw new Exception("Typo in final large case block!");
                }
                item.score = currentValue;
                if (currentValue > targetValue) targetValue = currentValue;
                else if (currentValue < targetValue - maxDiff) {
                    finalEquipment.Remove(item);
                    goto loopStart;
                }
            }
            List<Loadout> sortedFinal = finalEquipment.OrderByDescending(o => o.score).ToList();
            for (int i = 0; i < sortedFinal.Count; i++) {
                sortedFinal[i].id = (uint)i;
            }
            //Console.WriteLine($"[{DateTime.Now:HH:mm:ss:fff}] Done.");
            return sortedFinal;
        }

        private void listViewEquipment_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if (listViewEquipment.Items.Count == 0) return;
            var i = int.Parse(e.Item.Text);
            equipment[i].enabled = e.Item.Checked;
            //saveData();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < listViewEquipment.Items.Count; i++) listViewEquipment.Items[i].Checked = true;
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < listViewEquipment.Items.Count; i++) listViewEquipment.Items[i].Checked = false;
        }
    }
}
