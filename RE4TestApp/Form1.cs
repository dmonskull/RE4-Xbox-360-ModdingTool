using JRPC_Client;
using System.Windows.Forms;
using XDevkit;
using MetroFramework;
using MetroFramework.Forms;
using System.Text;

namespace RE4TestApp
{
    public partial class Form1 : MetroForm
    {
        JRPC JRPC = new JRPC();

        public string GameFolder = ReadSpecificLine(AppDomain.CurrentDomain.BaseDirectory + "important.txt", 1);
        public string GameName = ReadSpecificLine(AppDomain.CurrentDomain.BaseDirectory + "important.txt", 2);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDictionaries();
            timer1.Start();
            try
            {
                JRPC.Connect();
                if (JRPC.activeConnection == true)
                {
                    label1.Text = "Connection Active";
                    label1.ForeColor = Color.Green;
                    button4.Text = "Re-Connect";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting to Console", "DMONET");
            }

        }
        private void InitializeDictionaries()
        {
            PopulateComboBox(comboBox1, itemDictionary.Keys);
            PopulateComboBox(comboBox2, itemSlotOffsets.Keys);
            PopulateComboBox(comboBox3, itemAmountOffsets.Keys);
            PopulateComboBox(comboBox4, ammoAndSmallItems.Keys);
            PopulateComboBox(comboBox5, giveItemSlots.Keys);
        }
        private void PopulateComboBox(ComboBox comboBox, IEnumerable<string> items)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(items.ToArray());
        }
        static string ReadSpecificLine(string filePath, int lineNumber)
        {
            string content = null;
            try
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    for (int i = 1; i < lineNumber; i++)
                    {
                        file.ReadLine();

                        if (file.EndOfStream)
                        {
                            Console.WriteLine($"End of file.  The file only contains {i} lines.");
                            break;
                        }
                    }
                    content = file.ReadLine();
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }

            return content;

        }

        Dictionary<string, uint> itemSlotOffsets = new Dictionary<string, uint>
        {
    {"First Item Slot", 3281685323U},
    {"Second Item Slot", 3281685309U},
    {"Third Item Slot", 3281685365U},
    {"Fourth Item Slot", 3281685379U},
    {"Fifth Item Slot", 3281685393U},
    {"Sixth Item Slot", 3281685407U},
    {"Seventh Item Slot", 3281685421U},
    {"Eighth Item Slot", 3281685435U},
    {"Ninth Item Slot", 3281685449U},
    {"Tenth Item Slot", 3281685463U}
        };

        Dictionary<string, List<uint>> itemAmountOffsets = new Dictionary<string, List<uint>>
{
    {"First Item Amount", new List<uint> {3281685325U}},
    {"Second Item Amount", new List<uint> {3281685311U}},
    {"Third Item Amount", new List<uint> {3281685367U}},
    {"Fourth Item Amount", new List<uint> {3281685381U}},
    {"Fifth Item Amount", new List<uint> {3281685395U}},
    {"Sixth Item Amount", new List<uint> {3281685409U}},
    {"Seventh Item Amount", new List<uint> {3281685423U}},
    {"Eighth Item Amount", new List<uint> {3281685437U}},
    {"Ninth Item Amount", new List<uint> {3281685451U, 3281685457U}},
    {"Tenth Item Amount", new List<uint> {3281685465U}}
};

        Dictionary<string, uint> giveItemSlots = new Dictionary<string, uint>
        {
            {"Give Item Slot 1", 3281685393U},
            {"Give Item Slot 2", 3281685421U},
            {"Give Item Slot 3", 3281685449U},
            {"Give Item Slot 4", 3281685491U},
            {"Give Item Slot 5", 3281685547U}
        };

        Dictionary<string, uint> giveItemSlots2 = new Dictionary<string, uint>
        {
    {"Give Item Slot 1", 3281685396U},
    {"Give Item Slot 2", 3281685424U},
    {"Give Item Slot 3", 3281685452U},
    {"Give Item Slot 4", 3281685494U},
    {"Give Item Slot 5", 3281685550U}
        };

        Dictionary<string, byte> itemDictionary = new Dictionary<string, byte>
        {
    {"Matilda", 0x03},
    {"Bow Gun", 0x10},
    {"Chicago Typewriter", 0x34},
    {"Combat Knife", 0x38},
    {"Custom TMP", 0x3E},
    {"Handcannon", 0x37},
    {"Handgun", 0x23},
    {"Handgun w/ Silencer", 0x24},
    {"Infinite Launcher", 0x6D},
    {"Mine Thrower", 0x36},
    {"P.R.L 412", 0x41},
    {"Red9", 0x25},
    {"Red9 with Stock", 0x26},
    {"Rifle (semi auto) with Infrared Scope", 0x51},
    {"Rocket Launcher Special", 0x17},
    {"Shotgun", 0x47},
    {"Killer7", 0x2A},
    {"Killer7 w/ Silencer", 0x2B},
    {"Punisher", 0x40},
    {"Krauser's Bow", 0x52},
    {"Krauser's Knife", 0x0D},
    {"Hand Grenade", 0x01},
    {"Flash Grenade", 0x0E},
    {"Incendiary Grenade", 0x02},
    {"Arrows", 0x72},
    {"Bowgun Bolts", 0x11},
    {"Chicago Typewriter Ammo", 0x6A},
    {"Handgun Ammo", 0x04},
    {"Handcannon Ammo", 0x1A},
    {"Shotgun Ammo", 0x18},
    {"Rifle Ammo", 0x07},
    {"Rifle Ammo (Infrared)", 0xA0},
    {"TMP Ammo", 0x20},
    {"First Aid", 0x05},
    {"Green Herb", 0x06},
    {"Mixed Herbs (G+R)", 0x14},
    {"Mixed Herbs (G+R+Y)", 0x15},
    {"Mixed Herbs (R+Y)", 0xA8},
    {"Activation Key (blue)", 0x31},
    {"Activation Key (red)", 0x33},
    {"Black Bass", 0x95},
    {"Black Bass (L)", 0x97},
    {"Blacktail", 0x27},
    {"Blacktail with Silencer", 0x28},
    {"Bonus Time", 0x73},
    {"Brass Pocket Watch", 0x59},
    {"Camp Key", 0x8C},
    {"Castle Gate Key", 0xA7},
    {"Elegant Headdress", 0x5A},
    {"Emergency Lock Key Card", 0x74},
    {"Emerald", 0xA1},
    {"Freezer Key Card", 0x84},
    {"Gallery Key", 0xA3},
    {"Gold Chicken Egg", 0x0A},
    {"Gold Sword", 0x80},
    {"Green Catseye", 0x5F},
    {"Hexagonal Emblem", 0xA6},
    {"JetSki Key", 0x88},
    {"Key to the Mine", 0x7B},
    {"Lift Activation Key", 0x8E},
    {"Pearl Pendant", 0x58},
    {"Piece of the Holy Beast, Eagle", 0x87},
    {"Piece of the Holy Beast, Panther", 0x85},
    {"Piece of the Holy Beast, Serpent", 0x86},
    {"Plaga Sample", 0x0C},
    {"Platinum Sword", 0xC4},
    {"Prison Key", 0xC3},
    {"Ruby", 0x77},
    {"Serpent Ornament", 0x39},
    {"Waste Disposal Key", 0x92},
    {"Yellow Catseye", 0x61}
        };

        Dictionary<string, byte> ammoAndSmallItems = new Dictionary<string, byte>
{
    {"Hand Grenade", 0x01},
    {"Flash Grenade", 0x0E},
    {"Incendiary Grenade", 0x02},
    {"Arrows", 0x72},
    {"Bowgun Bolts", 0x11},
    {"Chicago Typewriter Ammo", 0x6A},
    {"Handgun Ammo", 0x04},
    {"Handcannon Ammo", 0x1A},
    {"Shotgun Ammo", 0x18},
    {"Rifle Ammo", 0x07},
    {"Rifle Ammo (Infrared)", 0xA0},
    {"TMP Ammo", 0x20},
    {"First Aid", 0x05},
    {"Mixed Herbs (G+R)", 0x14},
    {"Mixed Herbs (G+R+Y)", 0x15},
    {"Mixed Herbs (R+Y)", 0xA8},
    {"Plaga Sample", 0x0C}
};

        private void button1_Click(object sender, EventArgs e)
        {
            if (itemSlotOffsets.ContainsKey(comboBox2.Text) && itemDictionary.ContainsKey(comboBox1.Text))
            {
                uint selectedSlotOffset = itemSlotOffsets[comboBox2.Text];
                byte selectedValue = itemDictionary[comboBox1.Text];
                JRPC.SetMemory(selectedSlotOffset, new byte[] { selectedValue });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var xexPath = @"Hdd:\" + GameFolder + "\\" + GameName + "\\default.xex";
                JRPC.xbConsole.Reboot(xexPath, xexPath.Substring(0, xexPath.LastIndexOf(@"\", StringComparison.Ordinal)), null, XboxRebootFlags.Title);
                JRPC.XNotify("Loaded Resident Evil 4");
            }
            catch (Exception) { MessageBox.Show("please connect to console first"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedSlot = comboBox3.Text;
            byte selectedAmount = (byte)(numericUpDown1.Value);

            if (itemAmountOffsets.ContainsKey(selectedSlot))
            {
                List<uint> selectedAmountOffsets = itemAmountOffsets[selectedSlot];

                foreach (var selectedAmountOffset in selectedAmountOffsets)
                {
                    byte[] amountBytes = new byte[] { selectedAmount };
                    JRPC.SetMemory(selectedAmountOffset, amountBytes);
                }
            }
            else
            {

            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                JRPC.Connect();
                if (JRPC.activeConnection == true)
                {
                    MessageBox.Show("Connection Active", "DMONET");
                    label1.Text = "Connection Active";
                    label1.ForeColor = Color.Green;
                    button4.Text = "Re-Connect";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting to Console", "DMONET");
            }
        }
        private void CheckHeldWeapons()
        {
            StringBuilder heldWeapons = new StringBuilder();
            foreach (var entry in itemSlotOffsets)
            {
                byte[] slotValue = JRPC.GetMemory(entry.Value, 4);

                foreach (var weaponEntry in itemDictionary)
                {
                    if (weaponEntry.Value == slotValue[0])
                    {
                        heldWeapons.AppendLine($"Slot: {entry.Key}, Weapon: {weaponEntry.Key}");
                    }
                }
            }
            MessageBox.Show(heldWeapons.ToString());
        }


        private bool ShrinkEnemies;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ShrinkEnemies)
                {
                    button5.Text = "Shrink Enemies: ON";
                    JRPC.SetMemory(0x82000A08, new byte[] { 0x3F, 0x19, 0x99, 0x9A });
                }
                else
                {
                    button5.Text = "Shrink Enemies: OFF";
                    JRPC.SetMemory(0x82000A08, new byte[] { 0x3F, 0x66, 0x66, 0x66 });
                }
                ShrinkEnemies = !ShrinkEnemies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        private bool HugeEnemies;
        private int hue;

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HugeEnemies)
                {
                    button6.Text = "Huge Enemies: ON";
                    JRPC.SetMemory(0x82000A08, new byte[] { 0x3F, 0x7D, 0x70, 0xA4 });
                }
                else
                {
                    button6.Text = "Huge Enemies: OFF";
                    JRPC.SetMemory(0x82000A08, new byte[] { 0x3F, 0x66, 0x66, 0x66 });
                }
                HugeEnemies = !HugeEnemies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                CheckHeldWeapons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void RandomizeFirstByteAtItemOffsets(Dictionary<string, uint> itemSlotOffsets)
        {
            Random random = new Random();

            foreach (var entry in itemSlotOffsets)
            {
                byte randomByte = (byte)random.Next(256);
                JRPC.SetMemory(entry.Value, new byte[] { randomByte });
            }
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                RandomizeFirstByteAtItemOffsets(itemSlotOffsets);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (giveItemSlots.ContainsKey(comboBox5.Text) && ammoAndSmallItems.ContainsKey(comboBox4.Text))
            {
                uint selectedSlotOffset = giveItemSlots[comboBox5.Text];
                byte selectedValue = itemDictionary[comboBox4.Text];
                JRPC.SetMemory(selectedSlotOffset, new byte[] { selectedValue });
            }
            if (giveItemSlots2.ContainsKey(comboBox5.Text))
            {
                uint selectedSlotOffset = giveItemSlots2[comboBox5.Text];
                JRPC.SetMemory(selectedSlotOffset, new byte[] { 0x01 });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string text = label2.Text;
            label2.Text = text.Substring(1) + text[0];
            Color rainbowColor = ColorFromHSL(hue, 1.0, 0.5);
            label2.ForeColor = rainbowColor;
            hue = (hue + 1) % 360;
        }
        private Color ColorFromHSL(int hue, double saturation, double lightness) =>
            Color.FromArgb(
                (int)Math.Round((hue / 60.0) % 2 == 0
                    ? (1 - Math.Abs(2 * lightness - 1)) * saturation * 255
                    : 0
                ),
                (int)Math.Round((hue / 60.0) % 2 == 0
                    ? 0
                    : (1 - Math.Abs(2 * (hue / 60.0) % 2 - 1)) * saturation * 255
                ),
                (int)Math.Round((hue / 60.0) % 2 == 0
                    ? (1 - Math.Abs(2 * (hue / 60.0) % 2 - 1)) * saturation * 255
                    : (1 - Math.Abs(2 * lightness - 1)) * saturation * 255
                )
            );

        private void button9_Click_1(object sender, EventArgs e)
        {
            string message = "Replace: replaces any gun currently in your inventory in the selected item slot.\n\nGive: gives you any small item listed, puts it in the discarded items inventory, have to move it into inventory from discarded side.\n\nSet: sets the amount you want for the selected item slot (max 255)\n\nPlease use 'Weapon Check' to see what guns are currently in which item slot.";
            MessageBox.Show(message, "RE4 Modding Tool Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text);
            string originalText = label4.Text;
            label4.Text = "Copied!";
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (timerSender, timerArgs) =>
            {
                label4.Text = originalText;
                timer.Stop();
                timer.Dispose();
            };

            timer.Start();
        }

        private int ptasState = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                switch (ptasState)
                {
                    case 0:
                        button11.Text = "PTAS: 99999999";
                        JRPC.SetMemory(3261454408U, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        ptasState = 1;
                        break;
                    case 1:
                        button11.Text = "PTAS: 1000";
                        JRPC.SetMemory(3261454408U, new byte[] { 0x00, 0x00, 0x03, 0xE8 });
                        ptasState = 2;
                        break;
                    case 2:
                        button11.Text = "PTAS: bugged";
                        JRPC.SetMemory(3261454408U, new byte[] { 0xAA, 0xAA, 0xFF, 0xFF });
                        ptasState = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }
    }
}