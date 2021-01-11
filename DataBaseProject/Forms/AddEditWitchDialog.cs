using DataBaseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject.Forms
{
    public partial class AddEditWitchDialog : Form
    {

        public AddEditWitchDialog(List<Coven> covens, List<Habitat> habitats)
        {
            InitializeComponent();
            this.Text = "Добавить ведьму";
            Witch = new Witch();
            this.habitats = habitats;
            FillHabitats();
            this.covens = covens;
            FillCovens();
        }

        public Witch Witch { get; private set; }
        private readonly List<Coven> covens;
        private readonly List<Habitat> habitats;

        public AddEditWitchDialog(Witch witch, List<Coven> covens, List<Habitat> habitats) : this(covens, habitats)
        {
            this.Text = "Редактировать ведьму";
            Witch = witch;
            FillWitch();
        }

        private void FillCovens()
        {
            cbCoven.ValueMember = "Id";
            cbCoven.DisplayMember = "Name";
            List<Coven> cbCovensDataSource = new List<Coven>();
            cbCovensDataSource.AddRange(covens);
            cbCovensDataSource.Insert(0, new Coven() { Id = -1, Name = "Без ковена" });
            cbCoven.DataSource = cbCovensDataSource;
        }

        private void FillHabitats()
        {
            cbHabitat.ValueMember = "Id";
            cbHabitat.DisplayMember = "Name";
            List<Habitat> cbHabitatDataSource = new List<Habitat>();
            cbHabitatDataSource.AddRange(habitats);
            cbHabitatDataSource.Insert(0, new Habitat() { Id = -1, Name = "Без места" });
            cbHabitat.DataSource = cbHabitatDataSource;
        }

        private void FillWitch()
        {
            
            tbName.Text = Witch.Name;
            dtpBirth.Value = Witch.Birth;
            if (Witch.DateDeath == DateTime.MinValue)
               dtpDeath.Value = DateTime.Now;
            else dtpDeath.Value = Witch.DateDeath.Date;

            cbHabitat.SelectedItem = (Witch.Habitat != null) ? habitats.Where(t => t.Id == Witch.Habitat.Id).FirstOrDefault() : null;
            cbCoven.SelectedItem = (Witch.Coven != null) ? covens.Where(t => t.Id == Witch.Coven.Id).FirstOrDefault() : null;
        }

        private Coven GetCovenFromComboBox()
        {
            Coven coven = cbCoven.SelectedItem as Coven;
            if (coven.Id == -1)
                return null;
            return coven;
        }

        private Habitat GetHabitatFromComboBox()
        {
            Habitat habitat = cbHabitat.SelectedItem as Habitat;
            if (habitat.Id == -1)
                return null;
            return habitat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //валидация
            
            Witch.Name = tbName.Text;
            Witch.Birth = dtpBirth.Value;
            if (dtpDeath.Value == DateTime.Now)
                Witch.DateDeath =DateTime.MinValue;
            else Witch.DateDeath = dtpDeath.Value;


            Witch.Habitat = GetHabitatFromComboBox();
            Witch.Coven = GetCovenFromComboBox();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
