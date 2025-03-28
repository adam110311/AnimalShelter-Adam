using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            animal = null;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            if (animalTypeComboBox.SelectedIndex == 1)
            {
                animal = new Dog(123456, new SimpleDate(11, 11, 2003), "Doggy", new SimpleDate(11, 11, 2023));
            }
            else if (animalTypeComboBox.SelectedIndex == 0)
            {
                animal = new Cat(123456, new SimpleDate(11, 11, 2003), "Kitty", "test");
            }
            listBox1.Items.Add(animal);
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            this.animal = (Animal)listBox1.SelectedItem;
            ChipTxb.Text = animal.ChipRegistrationNumber.ToString();
            NameTxb.Text = animal.Name;
            DateTxb.Text = animal.DateOfBirth.ToString();
            ResTxb.Text = animal.IsReserved.ToString();

            if (animal is Dog dog)
            {
                VarTxb.Text = dog.LastWalkDate.ToString();
            }
            else if (animal is Cat cat)
            {
                VarTxb.Text = cat.BadHabits;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.animal = (Animal)listBox1.SelectedItem;
            //ChipTxb.Text = animal.ChipRegistrationNumber.ToString();
            //NameTxb.Text = animal.Name;
            //DateTxb.Text = animal.DateOfBirth.ToString();
            //ResTxb.Text = animal.IsReserved.ToString();

            //if (animal is Dog dog)
            //{
            //    VarTxb.Text = dog.LastWalkDate.ToString();
            //}
            //else if (animal is Cat cat)
            //{
            //    VarTxb.Text = cat.BadHabits;
            //}
        }
    }
}
