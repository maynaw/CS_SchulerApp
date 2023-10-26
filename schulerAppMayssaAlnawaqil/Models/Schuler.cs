using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace schulerAppMayssaAlnawaqil.Models
{
    internal class Schuler : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChange(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public Schuler() { }

        private int schulerId;

        public int SchulerId
        {
            get { return schulerId; }
            set { schulerId = value;
                RaisePropertyChange("SchulerId");
            }
        }

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value;
                RaisePropertyChange("Firstname");
            }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value;
                RaisePropertyChange("Lastname");
            }
        }

        private int classNo;

        public int ClassNo
        {
            get { return classNo; }
            set
            {
                if (value <= 10)
                {
                    if (value < 0)
                    {
                        RaisePropertyChange("ErrorMessage");
                    }
                    classNo = value;
                    RaisePropertyChange("ClassNo");
                }
                else
                {
                    MessageBox.Show("pleas enter class number under or equals to 10!");
                }
            }
        }




    }
}
